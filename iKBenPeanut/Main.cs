using System;
using Sulakore;
using System.Drawing;
using Sulakore.NovoFatum;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace iKBenPeanut
{
    public partial class Main : Form
    {
        public ProfileSettings PSettings;
        private bool LoaderReady = false;
        private HSession Account
        {
            get { return Program.Account; }
            set { Program.Account = value; }
        }

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SKore.ClearCache();
            string Source = Account[HPages.Client];
            Text = string.Format("iKBenPeanut ~ {0}[{1}]", Source.GetChild("var habboName = \"", '\"', 0), Source.GetChild("var habboId = ", ';', 0));
            Loader.DocumentText = Source;
        }

        private void ReloadClientBtn_Click(object sender, EventArgs e)
        {
            LoaderReady = false;
            Loader.DocumentText = string.Empty;
            Account.BeginLogin(new AsyncCallback((iAr) =>
            {
                if (Account.EndLogin(iAr))
                {
                    SKore.ClearCache();
                    string Source = Account[HPages.Client];
                    Invoke(new Action(() =>
                    {
                        Loader.Document.MouseDown -= Document_MouseDown;
                        Text = string.Format("iKBenPeanut ~ {0}[{1}]", Source.GetChild("var habboName = \"", '\"', 0), Source.GetChild("var habboId = ", ';', 0));
                        Loader.DocumentText = Source;
                    }));
                }
            }), null);
        }
        private void Document_MouseDown(object sender, HtmlElementEventArgs e)
        {
            if (e.MouseButtonsPressed == MouseButtons.Right)
                CMStrip.Show(PointToScreen(new Point(e.MousePosition.X, e.MousePosition.Y)));
        }
        private void Loader_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!LoaderReady)
            {
                Loader.Document.MouseDown += Document_MouseDown;
                LoaderReady = true;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SKore.ClearCache();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            if (PSettings == null)
                (PSettings = new ProfileSettings(this)).Show();
            else
                PSettings.BringToFront();
        }
    }
}