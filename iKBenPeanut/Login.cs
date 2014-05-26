using System;
using Sulakore;
using System.Threading;
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            HSession HS = new HSession(EmailTxt.Text, PasswordTxt.Text, HotelTxt.Text.ToHotel());
            HS.BeginLogin(LoginCB, HS);

            LoginBtn.Text = "Logging In...";
            foreach (Control C in Controls)
                C.Enabled = false;
            Cursor = Cursors.WaitCursor;
        }

        private AsyncCallback LoginCB;
        public void OnLoginCallback(IAsyncResult iAr)
        {
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