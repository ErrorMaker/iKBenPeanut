using System;
using Sulakore;
using System.Windows.Forms;
using iKBenPeanut.Properties;

namespace iKBenPeanut
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            EmailTxt.Text = Settings.Default.Email;
            PasswordTxt.Text = Settings.Default.Password;
            HotelTxt.SelectedIndex = HotelTxt.Items.IndexOf(Settings.Default.Hotel);
            LoginCB = OnLoginCallback;
        }

        private AsyncCallback LoginCB;
        public void OnLoginCallback(IAsyncResult iAr)
        {
            LoginAnimation.Stop();
            HSession HS = (HSession)iAr.AsyncState;
            if (HS.EndLogin(iAr))
            {
                Invoke(new Action(() =>
                {
                    LoginBtn.Text = "Login Successful!";
                    foreach (Control C in Controls)
                        C.Enabled = true;
                    Cursor = Cursors.Default;
                    Program.Account = HS;
                    Close();
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    LoginBtn.Text = "Login Failed!";
                    foreach (Control C in Controls)
                        C.Enabled = true;
                    Cursor = Cursors.Default;
                    MessageBox.Show("Unable to authenticate the account, please try again.", "iKBenPeanut ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginBtn.Text = "Login/Connect";
                }));
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            HSession HS = new HSession(EmailTxt.Text, PasswordTxt.Text, HotelTxt.Text.ToHotel());
            HS.BeginLogin(LoginCB, HS);

            Cursor = Cursors.WaitCursor;
            LoginAnimation.Start();
            foreach (Control C in Controls)
                C.Enabled = false;
        }

        private int FrameIndex = 0;
        private string[] Frames = new string[3] { ".", "..", "..." };
        private void LoginAnimation_Tick(object sender, EventArgs e)
        {
            LoginBtn.Text = "Logging In" + Frames[FrameIndex];
            FrameIndex += FrameIndex == 2 ? -2 : 1;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Email = EmailTxt.Text;
            Settings.Default.Password = PasswordTxt.Text;
            Settings.Default.Hotel = HotelTxt.Text;
            Settings.Default.Save();
            if (Program.Account == null) Environment.Exit(0);
        }
    }
}