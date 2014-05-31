using System;
using Sulakore;
using System.Drawing;
using System.Windows.Forms;

namespace iKBenPeanut
{
    public partial class ProfileSettings : Form
    {
        private Main MainF;
        public ProfileSettings(Main MainF)
        {
            this.MainF = MainF;
            InitializeComponent();
        }
        private void ProfileSettings_Load(object sender, System.EventArgs e)
        {
            SKore.BeginGetPlayerAvatar(Program.Account.PlayerName, Program.Account.Hotel, new AsyncCallback((iAr) =>
            {
                Image PA = SKore.EndGetPlayerAvatar(iAr);
                Invoke(new Action(() => { AvatarPctbx.Image = PA; }));
            }), null);
            SKore.BeginGetPlayerMotto(Program.Account.PlayerName, Program.Account.Hotel, new AsyncCallback((iAr) =>
            {
                string PM = SKore.EndGetPlayerMotto(iAr);
                Invoke(new Action(() => { MottoTxt.Text = PM; }));
            }), null);
            SKore.BeginGetPlayerClothes(Program.Account.PlayerName, Program.Account.Hotel, new AsyncCallback((iAr) =>
            {
                string PC = SKore.EndGetPlayerClothes(iAr);
                Invoke(new Action(() => { ClothesTxt.Text = PC; }));
            }), null);
        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            string CI = ClothesTxt.Text;
            UpdateProfileBtn.Enabled = false;
            Program.Account.BeginSaveOutfit(CI, IsMaleChckbx.Checked ? HGenders.Male : HGenders.Female, new AsyncCallback((iAr) =>
            {
                Program.Account.EndSaveOutfit(iAr);
                object[] o = (iAr.AsyncState as object[]);
                Program.Account.BeginUpdateProfile((string)o[0], (bool)o[1], (bool)o[2], (bool)o[3], (bool)o[4], (bool)o[5], new AsyncCallback((ar) =>
                {
                    Program.Account.EndUpdateProfile(ar);
                    SKore.BeginGetPlayerAvatar(CI, new AsyncCallback((iar) =>
                    {
                        Image I = SKore.EndGetPlayerAvatar(iar);
                        Invoke(new Action(() => { AvatarPctbx.Image = I; })); 
                    }), null);
                    Invoke(new Action(() => { UpdateProfileBtn.Enabled = true; }));
                }), null);
            }), new object[6] { MottoTxt.Text, HPEveryoneRdio.Checked, AllowFRChckbx.Checked, OSEveryoneRdio.Checked, OfflineMessagingChckbx.Checked, WCFMMyFriendsRdio.Checked });
        }

        private void ProfileSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainF.PSettings = null;
        }
    }
}