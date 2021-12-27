
namespace NewsFeed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlBar_Panel = new System.Windows.Forms.Panel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BugReportButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Newshowerpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ControlBar_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBar_Panel
            // 
            this.ControlBar_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ControlBar_Panel.Controls.Add(this.MinimizePictureBox);
            this.ControlBar_Panel.Controls.Add(this.ExitPictureBox);
            this.ControlBar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBar_Panel.Location = new System.Drawing.Point(4, 4);
            this.ControlBar_Panel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ControlBar_Panel.Name = "ControlBar_Panel";
            this.ControlBar_Panel.Size = new System.Drawing.Size(1185, 32);
            this.ControlBar_Panel.TabIndex = 0;
            this.ControlBar_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_Panel_MouseDown);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePictureBox.Image = global::NewsFeed.Properties.Resources._;
            this.MinimizePictureBox.Location = new System.Drawing.Point(1121, 0);
            this.MinimizePictureBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(32, 32);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizePictureBox.TabIndex = 4;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.MinimizePictureBox_MouseLeave);
            this.MinimizePictureBox.MouseHover += new System.EventHandler(this.MinimizePictureBox_MouseHover);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPictureBox.Image = global::NewsFeed.Properties.Resources.x;
            this.ExitPictureBox.Location = new System.Drawing.Point(1153, 0);
            this.ExitPictureBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(32, 32);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitPictureBox.TabIndex = 5;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            this.ExitPictureBox.MouseHover += new System.EventHandler(this.ExitPictureBox_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.BugReportButton);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 605);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 49);
            this.panel1.TabIndex = 1;
            // 
            // BugReportButton
            // 
            this.BugReportButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BugReportButton.Font = new System.Drawing.Font("BankGothic Lt BT", 12F);
            this.BugReportButton.Location = new System.Drawing.Point(15, 7);
            this.BugReportButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BugReportButton.Name = "BugReportButton";
            this.BugReportButton.Size = new System.Drawing.Size(138, 30);
            this.BugReportButton.TabIndex = 0;
            this.BugReportButton.Text = "Report Bug";
            this.BugReportButton.UseVisualStyleBackColor = true;
            this.BugReportButton.Click += new System.EventHandler(this.BugReportButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RefreshButton.Font = new System.Drawing.Font("BankGothic Lt BT", 12F);
            this.RefreshButton.Location = new System.Drawing.Point(525, 7);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(138, 30);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Newshowerpanel
            // 
            this.Newshowerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Newshowerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Newshowerpanel.Location = new System.Drawing.Point(4, 36);
            this.Newshowerpanel.Name = "Newshowerpanel";
            this.Newshowerpanel.Size = new System.Drawing.Size(1185, 569);
            this.Newshowerpanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1193, 658);
            this.Controls.Add(this.Newshowerpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControlBar_Panel);
            this.Font = new System.Drawing.Font("BankGothic Lt BT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlBar_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlBar_Panel;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BugReportButton;
        private System.Windows.Forms.FlowLayoutPanel Newshowerpanel;
    }
}

