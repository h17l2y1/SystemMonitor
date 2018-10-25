namespace Adai46
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.elipseFormMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.pbBotInfo = new System.Windows.Forms.Panel();
            this.lbBy = new System.Windows.Forms.Label();
            this.btAbout2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btAbout1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btDisks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lbLogoVersion = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbExit = new System.Windows.Forms.Label();
            this.lbMaximaze = new System.Windows.Forms.Label();
            this.lbMinimaize = new System.Windows.Forms.Label();
            this.lbPanelName = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.UcPanelDisk = new Adai46.UcDisk();
            this.UcPanelDashboard = new Adai46.UcDashboard();
            this.UcPanelPcRaring = new Adai46.UcPcRaring();
            this.pnSideBar.SuspendLayout();
            this.pbBotInfo.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseFormMain
            // 
            this.elipseFormMain.ElipseRadius = 40;
            this.elipseFormMain.TargetControl = this;
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnSideBar.Controls.Add(this.pbBotInfo);
            this.pnSideBar.Controls.Add(this.btAbout2);
            this.pnSideBar.Controls.Add(this.btAbout1);
            this.pnSideBar.Controls.Add(this.btDisks);
            this.pnSideBar.Controls.Add(this.btDashboard);
            this.pnSideBar.Controls.Add(this.pnLogo);
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(161, 540);
            this.pnSideBar.TabIndex = 0;
            // 
            // pbBotInfo
            // 
            this.pbBotInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pbBotInfo.Controls.Add(this.lbBy);
            this.pbBotInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBotInfo.Location = new System.Drawing.Point(0, 471);
            this.pbBotInfo.Name = "pbBotInfo";
            this.pbBotInfo.Size = new System.Drawing.Size(161, 69);
            this.pbBotInfo.TabIndex = 7;
            // 
            // lbBy
            // 
            this.lbBy.AutoSize = true;
            this.lbBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBy.ForeColor = System.Drawing.Color.LightGray;
            this.lbBy.Location = new System.Drawing.Point(12, 43);
            this.lbBy.Name = "lbBy";
            this.lbBy.Size = new System.Drawing.Size(130, 17);
            this.lbBy.TabIndex = 0;
            this.lbBy.Text = "© Vlad Sharmanov";
            // 
            // btAbout2
            // 
            this.btAbout2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btAbout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btAbout2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbout2.BorderRadius = 0;
            this.btAbout2.ButtonText = "          Button 4";
            this.btAbout2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAbout2.DisabledColor = System.Drawing.Color.Gray;
            this.btAbout2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAbout2.Iconcolor = System.Drawing.Color.Transparent;
            this.btAbout2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btAbout2.Iconimage")));
            this.btAbout2.Iconimage_right = null;
            this.btAbout2.Iconimage_right_Selected = null;
            this.btAbout2.Iconimage_Selected = null;
            this.btAbout2.IconMarginLeft = 0;
            this.btAbout2.IconMarginRight = 0;
            this.btAbout2.IconRightVisible = true;
            this.btAbout2.IconRightZoom = 0D;
            this.btAbout2.IconVisible = false;
            this.btAbout2.IconZoom = 90D;
            this.btAbout2.IsTab = false;
            this.btAbout2.Location = new System.Drawing.Point(0, 196);
            this.btAbout2.Name = "btAbout2";
            this.btAbout2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btAbout2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btAbout2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btAbout2.selected = false;
            this.btAbout2.Size = new System.Drawing.Size(161, 48);
            this.btAbout2.TabIndex = 6;
            this.btAbout2.Text = "          Button 4";
            this.btAbout2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAbout2.Textcolor = System.Drawing.Color.White;
            this.btAbout2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btAbout1
            // 
            this.btAbout1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btAbout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btAbout1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbout1.BorderRadius = 0;
            this.btAbout1.ButtonText = "          PC Rating";
            this.btAbout1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAbout1.DisabledColor = System.Drawing.Color.Gray;
            this.btAbout1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAbout1.Iconcolor = System.Drawing.Color.Transparent;
            this.btAbout1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btAbout1.Iconimage")));
            this.btAbout1.Iconimage_right = null;
            this.btAbout1.Iconimage_right_Selected = null;
            this.btAbout1.Iconimage_Selected = null;
            this.btAbout1.IconMarginLeft = 0;
            this.btAbout1.IconMarginRight = 0;
            this.btAbout1.IconRightVisible = true;
            this.btAbout1.IconRightZoom = 0D;
            this.btAbout1.IconVisible = false;
            this.btAbout1.IconZoom = 90D;
            this.btAbout1.IsTab = false;
            this.btAbout1.Location = new System.Drawing.Point(0, 148);
            this.btAbout1.Name = "btAbout1";
            this.btAbout1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btAbout1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btAbout1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btAbout1.selected = false;
            this.btAbout1.Size = new System.Drawing.Size(161, 48);
            this.btAbout1.TabIndex = 5;
            this.btAbout1.Text = "          PC Rating";
            this.btAbout1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAbout1.Textcolor = System.Drawing.Color.White;
            this.btAbout1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbout1.Click += new System.EventHandler(this.btPcRating_Click);
            // 
            // btDisks
            // 
            this.btDisks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btDisks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btDisks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDisks.BorderRadius = 0;
            this.btDisks.ButtonText = "          Disks";
            this.btDisks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDisks.DisabledColor = System.Drawing.Color.Gray;
            this.btDisks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDisks.Iconcolor = System.Drawing.Color.Transparent;
            this.btDisks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btDisks.Iconimage")));
            this.btDisks.Iconimage_right = null;
            this.btDisks.Iconimage_right_Selected = null;
            this.btDisks.Iconimage_Selected = null;
            this.btDisks.IconMarginLeft = 0;
            this.btDisks.IconMarginRight = 0;
            this.btDisks.IconRightVisible = true;
            this.btDisks.IconRightZoom = 0D;
            this.btDisks.IconVisible = false;
            this.btDisks.IconZoom = 90D;
            this.btDisks.IsTab = false;
            this.btDisks.Location = new System.Drawing.Point(0, 100);
            this.btDisks.Name = "btDisks";
            this.btDisks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btDisks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btDisks.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btDisks.selected = false;
            this.btDisks.Size = new System.Drawing.Size(161, 48);
            this.btDisks.TabIndex = 4;
            this.btDisks.Text = "          Disks";
            this.btDisks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDisks.Textcolor = System.Drawing.Color.White;
            this.btDisks.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisks.Click += new System.EventHandler(this.btDisk_Click);
            // 
            // btDashboard
            // 
            this.btDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDashboard.BorderRadius = 0;
            this.btDashboard.ButtonText = "          Dashboard";
            this.btDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btDashboard.Iconimage")));
            this.btDashboard.Iconimage_right = null;
            this.btDashboard.Iconimage_right_Selected = null;
            this.btDashboard.Iconimage_Selected = null;
            this.btDashboard.IconMarginLeft = 0;
            this.btDashboard.IconMarginRight = 0;
            this.btDashboard.IconRightVisible = true;
            this.btDashboard.IconRightZoom = 0D;
            this.btDashboard.IconVisible = false;
            this.btDashboard.IconZoom = 90D;
            this.btDashboard.IsTab = false;
            this.btDashboard.Location = new System.Drawing.Point(0, 52);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btDashboard.selected = false;
            this.btDashboard.Size = new System.Drawing.Size(161, 48);
            this.btDashboard.TabIndex = 3;
            this.btDashboard.Text = "          Dashboard";
            this.btDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDashboard.Textcolor = System.Drawing.Color.White;
            this.btDashboard.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnLogo.Controls.Add(this.lbLogoVersion);
            this.pnLogo.Controls.Add(this.lbLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(161, 52);
            this.pnLogo.TabIndex = 2;
            // 
            // lbLogoVersion
            // 
            this.lbLogoVersion.AutoSize = true;
            this.lbLogoVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogoVersion.ForeColor = System.Drawing.Color.White;
            this.lbLogoVersion.Location = new System.Drawing.Point(34, 27);
            this.lbLogoVersion.Name = "lbLogoVersion";
            this.lbLogoVersion.Size = new System.Drawing.Size(105, 21);
            this.lbLogoVersion.TabIndex = 2;
            this.lbLogoVersion.Text = "Gold Edition";
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.White;
            this.lbLogo.Location = new System.Drawing.Point(39, 1);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(95, 30);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "Adai46";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.White;
            this.pnHeader.Controls.Add(this.lbExit);
            this.pnHeader.Controls.Add(this.lbMaximaze);
            this.pnHeader.Controls.Add(this.lbMinimaize);
            this.pnHeader.Controls.Add(this.lbPanelName);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(161, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(731, 52);
            this.pnHeader.TabIndex = 0;
            // 
            // lbExit
            // 
            this.lbExit.AutoEllipsis = true;
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Red;
            this.lbExit.Location = new System.Drawing.Point(668, 0);
            this.lbExit.Margin = new System.Windows.Forms.Padding(0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(41, 39);
            this.lbExit.TabIndex = 6;
            this.lbExit.Text = "⚫";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // lbMaximaze
            // 
            this.lbMaximaze.AutoEllipsis = true;
            this.lbMaximaze.AutoSize = true;
            this.lbMaximaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaximaze.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbMaximaze.Location = new System.Drawing.Point(594, 0);
            this.lbMaximaze.Margin = new System.Windows.Forms.Padding(0);
            this.lbMaximaze.Name = "lbMaximaze";
            this.lbMaximaze.Size = new System.Drawing.Size(41, 39);
            this.lbMaximaze.TabIndex = 5;
            this.lbMaximaze.Text = "⚫";
            // 
            // lbMinimaize
            // 
            this.lbMinimaize.AutoEllipsis = true;
            this.lbMinimaize.AutoSize = true;
            this.lbMinimaize.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinimaize.ForeColor = System.Drawing.Color.Gold;
            this.lbMinimaize.Location = new System.Drawing.Point(631, 0);
            this.lbMinimaize.Margin = new System.Windows.Forms.Padding(0);
            this.lbMinimaize.Name = "lbMinimaize";
            this.lbMinimaize.Size = new System.Drawing.Size(41, 39);
            this.lbMinimaize.TabIndex = 4;
            this.lbMinimaize.Text = "⚫";
            this.lbMinimaize.Click += new System.EventHandler(this.lbMinimaize_Click);
            // 
            // lbPanelName
            // 
            this.lbPanelName.AutoSize = true;
            this.lbPanelName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanelName.Location = new System.Drawing.Point(87, 12);
            this.lbPanelName.Name = "lbPanelName";
            this.lbPanelName.Size = new System.Drawing.Size(183, 24);
            this.lbPanelName.TabIndex = 1;
            this.lbPanelName.Text = "          Dashboard";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // UcPanelDisk
            // 
            this.UcPanelDisk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UcPanelDisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcPanelDisk.Location = new System.Drawing.Point(161, 52);
            this.UcPanelDisk.Name = "UcPanelDisk";
            this.UcPanelDisk.Size = new System.Drawing.Size(731, 488);
            this.UcPanelDisk.TabIndex = 3;
            // 
            // UcPanelDashboard
            // 
            this.UcPanelDashboard.BackColor = System.Drawing.Color.LightGray;
            this.UcPanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcPanelDashboard.Location = new System.Drawing.Point(161, 52);
            this.UcPanelDashboard.Name = "UcPanelDashboard";
            this.UcPanelDashboard.Size = new System.Drawing.Size(731, 488);
            this.UcPanelDashboard.TabIndex = 2;
            // 
            // UcPanelPcRaring
            // 
            this.UcPanelPcRaring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.UcPanelPcRaring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcPanelPcRaring.Location = new System.Drawing.Point(161, 52);
            this.UcPanelPcRaring.Name = "UcPanelPcRaring";
            this.UcPanelPcRaring.Size = new System.Drawing.Size(731, 488);
            this.UcPanelPcRaring.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(892, 540);
            this.Controls.Add(this.UcPanelPcRaring);
            this.Controls.Add(this.UcPanelDisk);
            this.Controls.Add(this.UcPanelDashboard);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnSideBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.pnSideBar.ResumeLayout(false);
            this.pbBotInfo.ResumeLayout(false);
            this.pbBotInfo.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseFormMain;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbPanelName;
        private System.Windows.Forms.Panel pnSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton btDashboard;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label lbLogo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btDisks;
        private Bunifu.Framework.UI.BunifuFlatButton btAbout2;
        private Bunifu.Framework.UI.BunifuFlatButton btAbout1;
        private System.Windows.Forms.Label lbLogoVersion;
        private System.Windows.Forms.Panel pbBotInfo;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbMaximaze;
        private System.Windows.Forms.Label lbMinimaize;
        private UcDashboard UcPanelDashboard;
        private UcDisk UcPanelDisk;
        private System.Windows.Forms.Label lbBy;
        private UcPcRaring UcPanelPcRaring;
    }
}