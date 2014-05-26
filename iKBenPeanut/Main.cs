using System;
using Sulakore;
using System.Drawing;
using System.Windows.Forms;

namespace iKBenPeanut
{
    public partial class Main : Form
    {
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
            SKore.ClearCache();
            LoaderReady = false;
            string Source = Account[HPages.Client];
            Loader.Document.MouseDown -= Document_MouseDown;
            Text = string.Format("iKBenPeanut ~ {0}[{1}]", Source.GetChild("var habboName = \"", '\"', 0), Source.GetChild("var habboId = ", ';', 0));
            Loader.DocumentText = Source;
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
    }
}