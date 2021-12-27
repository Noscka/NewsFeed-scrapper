using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.Collections.Generic;
///using System.Windows.Controls;

namespace NewsFeed
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ControlBar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ExitPictureBox_MouseHover(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(50, 53, 56);
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Newshowerpanel.Controls.Clear();
            Newshowerpanel.AutoScroll = true;
            using (var client = new WebClient())
            {
                string html = client.DownloadString("https://www.bbc.co.uk/");

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                List<string> Titles = new List<string>();
                List<string> URLS = new List<string>();
                List<string> Href = new List<string>();

                foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//p[contains(@class, 'PromoHeadline')]"))
                {
                    Titles.Add(node.InnerText);
                }
                foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//img/@src"))
                {
                    URLS.Add(node.GetAttributeValue("src", "nothing"));
                }
                foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    Href.Add(node.GetAttributeValue("href", string.Empty));
                }

                int i = 0;
                foreach (string b in Titles)
                {
                    ///Panel
                    Panel panel = new Panel();
                    panel.BackColor = Color.FromArgb(82, 82, 82);
                    panel.Size = new Size(340, 305);
                    int y = panel.Location.Y;
                    int x = panel.Location.X;

                    ///Image Box
                    byte[] imageData = client.DownloadData(URLS[i]);
                    MemoryStream stream = new MemoryStream(imageData);
                    var URLimage = new PictureBox();
                    URLimage.Image = Image.FromStream(stream);
                    URLimage.SizeMode = PictureBoxSizeMode.StretchImage;
                    URLimage.Size = new Size(340, 191);
                    stream.Close();

                    ///Label Title
                    var titlelabel = new Label();
                    titlelabel.Text = b.Replace("#x27;", "'");
                    titlelabel.Size = new Size(337, 111);
                    titlelabel.Location = new Point(3, 194);

                    ///Adding to Control
                    panel.Controls.Add(URLimage);
                    panel.Controls.Add(titlelabel);
                    panel.MouseHover += new EventHandler(Panel_MouseHover);
                    panel.MouseLeave += new EventHandler(Panel_MouseLeave);
                    panel.Click += new EventHandler(Panel_MouseClick);
                    panel.Name = i.ToString();
                    Newshowerpanel.Controls.Add(panel);
                    i += 1;
                }

            }
        }

        private void Panel_MouseClick(object sender, EventArgs e)
        {
            Panel senderpanel = (sender as Panel);
            int idnumber = Int32.Parse(senderpanel.Name.ToString());
            senderpanel.BackColor = Color.FromArgb(10, 100, 100);
            ///System.Diagnostics.Process.Start(Href[i]);
        }

        private void Panel_MouseHover(object sender, EventArgs e)
        {
            Panel senderpanel = (sender as Panel);
            ///senderpanel.BackColor = Color.FromArgb(200, 100, 100);
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel senderpanel = (sender as Panel);
            ///senderpanel.BackColor = Color.FromArgb(82, 82, 82);
        }

        private void BugReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doesn't Work Yet");
        }
    }
}
