namespace Adai46
{
    partial class UcDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDashboard));
            this.lbGpu = new System.Windows.Forms.Label();
            this.progressBarCircleGpu = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnCompInfo = new System.Windows.Forms.Panel();
            this.lbResolution = new System.Windows.Forms.Label();
            this.lbResolTextStatic = new System.Windows.Forms.Label();
            this.lbmatherboardName = new System.Windows.Forms.Label();
            this.lbCpuName = new System.Windows.Forms.Label();
            this.lbMatherboardTextStatic = new System.Windows.Forms.Label();
            this.lbCpuText2Static = new System.Windows.Forms.Label();
            this.lbGpuName = new System.Windows.Forms.Label();
            this.lbGpuTextStatic = new System.Windows.Forms.Label();
            this.btRomText = new System.Windows.Forms.Label();
            this.progressBarCircleRom = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnNetwork = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCheckNetConnStatic = new System.Windows.Forms.Label();
            this.lbCheckNetConn = new System.Windows.Forms.Label();
            this.lbIpAdressStatic = new System.Windows.Forms.Label();
            this.lbIpAdress = new System.Windows.Forms.Label();
            this.pnRam = new System.Windows.Forms.Panel();
            this.lbPersentUsedRam = new System.Windows.Forms.Label();
            this.progressBarLineRam = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbRamUsed = new System.Windows.Forms.Label();
            this.pnSpacerTop = new System.Windows.Forms.Panel();
            this.pnSpacerBot = new System.Windows.Forms.Panel();
            this.lbCpuText = new System.Windows.Forms.Label();
            this.progressBarCircleCpu = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lbRamText = new System.Windows.Forms.Label();
            this.progressBarCircleRam = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnUser = new System.Windows.Forms.Panel();
            this.pbUserAvatar = new System.Windows.Forms.PictureBox();
            this.lbOsVersion = new System.Windows.Forms.Label();
            this.lbOsVersionStatic = new System.Windows.Forms.Label();
            this.lbPcName = new System.Windows.Forms.Label();
            this.lbPcNameStatic = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserNameStatic = new System.Windows.Forms.Label();
            this.elipsePanelRam = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipsePanelNetwork = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipsePanelCompInfo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipsePanelUser = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pcCpu = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pcRam = new System.Diagnostics.PerformanceCounter();
            this.timerForStaticPersent = new System.Windows.Forms.Timer(this.components);
            this.pnCompInfo.SuspendLayout();
            this.pnNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnRam.SuspendLayout();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRam)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGpu
            // 
            this.lbGpu.AutoSize = true;
            this.lbGpu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGpu.Location = new System.Drawing.Point(557, 312);
            this.lbGpu.Name = "lbGpu";
            this.lbGpu.Size = new System.Drawing.Size(44, 21);
            this.lbGpu.TabIndex = 40;
            this.lbGpu.Text = "GPU";
            // 
            // progressBarCircleGpu
            // 
            this.progressBarCircleGpu.animated = false;
            this.progressBarCircleGpu.animationIterval = 5;
            this.progressBarCircleGpu.animationSpeed = 300;
            this.progressBarCircleGpu.BackColor = System.Drawing.Color.LightGray;
            this.progressBarCircleGpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarCircleGpu.BackgroundImage")));
            this.progressBarCircleGpu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCircleGpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.progressBarCircleGpu.LabelVisible = true;
            this.progressBarCircleGpu.LineProgressThickness = 5;
            this.progressBarCircleGpu.LineThickness = 5;
            this.progressBarCircleGpu.Location = new System.Drawing.Point(520, 334);
            this.progressBarCircleGpu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBarCircleGpu.MaxValue = 100;
            this.progressBarCircleGpu.Name = "progressBarCircleGpu";
            this.progressBarCircleGpu.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBarCircleGpu.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.progressBarCircleGpu.Size = new System.Drawing.Size(120, 120);
            this.progressBarCircleGpu.TabIndex = 39;
            this.progressBarCircleGpu.Value = 99;
            // 
            // pnCompInfo
            // 
            this.pnCompInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.pnCompInfo.Controls.Add(this.lbResolution);
            this.pnCompInfo.Controls.Add(this.lbResolTextStatic);
            this.pnCompInfo.Controls.Add(this.lbmatherboardName);
            this.pnCompInfo.Controls.Add(this.lbCpuName);
            this.pnCompInfo.Controls.Add(this.lbMatherboardTextStatic);
            this.pnCompInfo.Controls.Add(this.lbCpuText2Static);
            this.pnCompInfo.Controls.Add(this.lbGpuName);
            this.pnCompInfo.Controls.Add(this.lbGpuTextStatic);
            this.pnCompInfo.Location = new System.Drawing.Point(306, 164);
            this.pnCompInfo.Name = "pnCompInfo";
            this.pnCompInfo.Size = new System.Drawing.Size(380, 120);
            this.pnCompInfo.TabIndex = 38;
            // 
            // lbResolution
            // 
            this.lbResolution.AutoSize = true;
            this.lbResolution.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResolution.ForeColor = System.Drawing.Color.White;
            this.lbResolution.Location = new System.Drawing.Point(92, 93);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(70, 17);
            this.lbResolution.TabIndex = 14;
            this.lbResolution.Text = "9999x9999";
            // 
            // lbResolTextStatic
            // 
            this.lbResolTextStatic.AutoSize = true;
            this.lbResolTextStatic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResolTextStatic.ForeColor = System.Drawing.Color.White;
            this.lbResolTextStatic.Location = new System.Drawing.Point(37, 93);
            this.lbResolTextStatic.Name = "lbResolTextStatic";
            this.lbResolTextStatic.Size = new System.Drawing.Size(49, 17);
            this.lbResolTextStatic.TabIndex = 13;
            this.lbResolTextStatic.Text = "Resol :";
            // 
            // lbmatherboardName
            // 
            this.lbmatherboardName.AutoSize = true;
            this.lbmatherboardName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatherboardName.ForeColor = System.Drawing.Color.White;
            this.lbmatherboardName.Location = new System.Drawing.Point(92, 69);
            this.lbmatherboardName.Name = "lbmatherboardName";
            this.lbmatherboardName.Size = new System.Drawing.Size(53, 17);
            this.lbmatherboardName.TabIndex = 12;
            this.lbmatherboardName.Text = "Mather";
            // 
            // lbCpuName
            // 
            this.lbCpuName.AutoSize = true;
            this.lbCpuName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpuName.ForeColor = System.Drawing.Color.White;
            this.lbCpuName.Location = new System.Drawing.Point(92, 12);
            this.lbCpuName.Name = "lbCpuName";
            this.lbCpuName.Size = new System.Drawing.Size(76, 17);
            this.lbCpuName.TabIndex = 8;
            this.lbCpuName.Text = "CpuName";
            // 
            // lbMatherboardTextStatic
            // 
            this.lbMatherboardTextStatic.AutoSize = true;
            this.lbMatherboardTextStatic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatherboardTextStatic.ForeColor = System.Drawing.Color.White;
            this.lbMatherboardTextStatic.Location = new System.Drawing.Point(12, 69);
            this.lbMatherboardTextStatic.Name = "lbMatherboardTextStatic";
            this.lbMatherboardTextStatic.Size = new System.Drawing.Size(74, 17);
            this.lbMatherboardTextStatic.TabIndex = 11;
            this.lbMatherboardTextStatic.Text = "MaBoard :";
            // 
            // lbCpuText2Static
            // 
            this.lbCpuText2Static.AutoSize = true;
            this.lbCpuText2Static.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpuText2Static.ForeColor = System.Drawing.Color.White;
            this.lbCpuText2Static.Location = new System.Drawing.Point(43, 12);
            this.lbCpuText2Static.Name = "lbCpuText2Static";
            this.lbCpuText2Static.Size = new System.Drawing.Size(43, 17);
            this.lbCpuText2Static.TabIndex = 7;
            this.lbCpuText2Static.Text = "CPU :";
            // 
            // lbGpuName
            // 
            this.lbGpuName.AutoSize = true;
            this.lbGpuName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGpuName.ForeColor = System.Drawing.Color.White;
            this.lbGpuName.Location = new System.Drawing.Point(92, 41);
            this.lbGpuName.Name = "lbGpuName";
            this.lbGpuName.Size = new System.Drawing.Size(76, 17);
            this.lbGpuName.TabIndex = 10;
            this.lbGpuName.Text = "GpuName";
            // 
            // lbGpuTextStatic
            // 
            this.lbGpuTextStatic.AutoSize = true;
            this.lbGpuTextStatic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGpuTextStatic.ForeColor = System.Drawing.Color.White;
            this.lbGpuTextStatic.Location = new System.Drawing.Point(43, 41);
            this.lbGpuTextStatic.Name = "lbGpuTextStatic";
            this.lbGpuTextStatic.Size = new System.Drawing.Size(43, 17);
            this.lbGpuTextStatic.TabIndex = 9;
            this.lbGpuTextStatic.Text = "GPU :";
            // 
            // btRomText
            // 
            this.btRomText.AutoSize = true;
            this.btRomText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRomText.Location = new System.Drawing.Point(409, 312);
            this.btRomText.Name = "btRomText";
            this.btRomText.Size = new System.Drawing.Size(49, 21);
            this.btRomText.TabIndex = 37;
            this.btRomText.Text = "ROM";
            // 
            // progressBarCircleRom
            // 
            this.progressBarCircleRom.animated = false;
            this.progressBarCircleRom.animationIterval = 5;
            this.progressBarCircleRom.animationSpeed = 300;
            this.progressBarCircleRom.BackColor = System.Drawing.Color.LightGray;
            this.progressBarCircleRom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarCircleRom.BackgroundImage")));
            this.progressBarCircleRom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCircleRom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(12)))));
            this.progressBarCircleRom.LabelVisible = true;
            this.progressBarCircleRom.LineProgressThickness = 5;
            this.progressBarCircleRom.LineThickness = 5;
            this.progressBarCircleRom.Location = new System.Drawing.Point(372, 334);
            this.progressBarCircleRom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBarCircleRom.MaxValue = 100;
            this.progressBarCircleRom.Name = "progressBarCircleRom";
            this.progressBarCircleRom.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBarCircleRom.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(12)))));
            this.progressBarCircleRom.Size = new System.Drawing.Size(120, 120);
            this.progressBarCircleRom.TabIndex = 36;
            this.progressBarCircleRom.Value = 99;
            // 
            // pnNetwork
            // 
            this.pnNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.pnNetwork.Controls.Add(this.pictureBox1);
            this.pnNetwork.Controls.Add(this.lbCheckNetConnStatic);
            this.pnNetwork.Controls.Add(this.lbCheckNetConn);
            this.pnNetwork.Controls.Add(this.lbIpAdressStatic);
            this.pnNetwork.Controls.Add(this.lbIpAdress);
            this.pnNetwork.Location = new System.Drawing.Point(22, 164);
            this.pnNetwork.Name = "pnNetwork";
            this.pnNetwork.Size = new System.Drawing.Size(271, 120);
            this.pnNetwork.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbCheckNetConnStatic
            // 
            this.lbCheckNetConnStatic.AutoSize = true;
            this.lbCheckNetConnStatic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckNetConnStatic.ForeColor = System.Drawing.Color.White;
            this.lbCheckNetConnStatic.Location = new System.Drawing.Point(75, 68);
            this.lbCheckNetConnStatic.Name = "lbCheckNetConnStatic";
            this.lbCheckNetConnStatic.Size = new System.Drawing.Size(84, 21);
            this.lbCheckNetConnStatic.TabIndex = 3;
            this.lbCheckNetConnStatic.Text = "Network :";
            // 
            // lbCheckNetConn
            // 
            this.lbCheckNetConn.AutoSize = true;
            this.lbCheckNetConn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckNetConn.ForeColor = System.Drawing.Color.White;
            this.lbCheckNetConn.Location = new System.Drawing.Point(161, 69);
            this.lbCheckNetConn.Name = "lbCheckNetConn";
            this.lbCheckNetConn.Size = new System.Drawing.Size(102, 19);
            this.lbCheckNetConn.TabIndex = 2;
            this.lbCheckNetConn.Text = "CheckConn";
            // 
            // lbIpAdressStatic
            // 
            this.lbIpAdressStatic.AutoSize = true;
            this.lbIpAdressStatic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpAdressStatic.ForeColor = System.Drawing.Color.White;
            this.lbIpAdressStatic.Location = new System.Drawing.Point(70, 24);
            this.lbIpAdressStatic.Name = "lbIpAdressStatic";
            this.lbIpAdressStatic.Size = new System.Drawing.Size(89, 21);
            this.lbIpAdressStatic.TabIndex = 1;
            this.lbIpAdressStatic.Text = "Ip Adress :";
            // 
            // lbIpAdress
            // 
            this.lbIpAdress.AutoSize = true;
            this.lbIpAdress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpAdress.ForeColor = System.Drawing.Color.White;
            this.lbIpAdress.Location = new System.Drawing.Point(161, 24);
            this.lbIpAdress.Name = "lbIpAdress";
            this.lbIpAdress.Size = new System.Drawing.Size(79, 21);
            this.lbIpAdress.TabIndex = 0;
            this.lbIpAdress.Text = "Ip adress";
            // 
            // pnRam
            // 
            this.pnRam.BackColor = System.Drawing.Color.White;
            this.pnRam.Controls.Add(this.lbPersentUsedRam);
            this.pnRam.Controls.Add(this.progressBarLineRam);
            this.pnRam.Controls.Add(this.lbRamUsed);
            this.pnRam.Location = new System.Drawing.Point(488, 23);
            this.pnRam.Name = "pnRam";
            this.pnRam.Size = new System.Drawing.Size(198, 100);
            this.pnRam.TabIndex = 34;
            // 
            // lbPersentUsedRam
            // 
            this.lbPersentUsedRam.AutoSize = true;
            this.lbPersentUsedRam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersentUsedRam.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbPersentUsedRam.Location = new System.Drawing.Point(20, 16);
            this.lbPersentUsedRam.Name = "lbPersentUsedRam";
            this.lbPersentUsedRam.Size = new System.Drawing.Size(63, 18);
            this.lbPersentUsedRam.TabIndex = 2;
            this.lbPersentUsedRam.Text = "RAM  %";
            // 
            // progressBarLineRam
            // 
            this.progressBarLineRam.BackColor = System.Drawing.Color.Silver;
            this.progressBarLineRam.BorderRadius = 5;
            this.progressBarLineRam.Location = new System.Drawing.Point(23, 73);
            this.progressBarLineRam.MaximumValue = 100;
            this.progressBarLineRam.Name = "progressBarLineRam";
            this.progressBarLineRam.ProgressColor = System.Drawing.Color.Teal;
            this.progressBarLineRam.Size = new System.Drawing.Size(157, 7);
            this.progressBarLineRam.TabIndex = 1;
            this.progressBarLineRam.Value = 90;
            // 
            // lbRamUsed
            // 
            this.lbRamUsed.AutoSize = true;
            this.lbRamUsed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRamUsed.Location = new System.Drawing.Point(20, 44);
            this.lbRamUsed.Name = "lbRamUsed";
            this.lbRamUsed.Size = new System.Drawing.Size(117, 17);
            this.lbRamUsed.TabIndex = 0;
            this.lbRamUsed.Text = "Ram Used / Total";
            // 
            // pnSpacerTop
            // 
            this.pnSpacerTop.BackColor = System.Drawing.Color.DarkGray;
            this.pnSpacerTop.Location = new System.Drawing.Point(22, 145);
            this.pnSpacerTop.Name = "pnSpacerTop";
            this.pnSpacerTop.Size = new System.Drawing.Size(664, 2);
            this.pnSpacerTop.TabIndex = 33;
            // 
            // pnSpacerBot
            // 
            this.pnSpacerBot.BackColor = System.Drawing.Color.DarkGray;
            this.pnSpacerBot.Location = new System.Drawing.Point(22, 300);
            this.pnSpacerBot.Name = "pnSpacerBot";
            this.pnSpacerBot.Size = new System.Drawing.Size(664, 2);
            this.pnSpacerBot.TabIndex = 32;
            // 
            // lbCpuText
            // 
            this.lbCpuText.AutoSize = true;
            this.lbCpuText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpuText.Location = new System.Drawing.Point(254, 312);
            this.lbCpuText.Name = "lbCpuText";
            this.lbCpuText.Size = new System.Drawing.Size(43, 21);
            this.lbCpuText.TabIndex = 31;
            this.lbCpuText.Text = "CPU";
            // 
            // progressBarCircleCpu
            // 
            this.progressBarCircleCpu.animated = false;
            this.progressBarCircleCpu.animationIterval = 1;
            this.progressBarCircleCpu.animationSpeed = 1;
            this.progressBarCircleCpu.BackColor = System.Drawing.Color.LightGray;
            this.progressBarCircleCpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarCircleCpu.BackgroundImage")));
            this.progressBarCircleCpu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCircleCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(125)))), ((int)(((byte)(187)))));
            this.progressBarCircleCpu.LabelVisible = true;
            this.progressBarCircleCpu.LineProgressThickness = 5;
            this.progressBarCircleCpu.LineThickness = 5;
            this.progressBarCircleCpu.Location = new System.Drawing.Point(217, 334);
            this.progressBarCircleCpu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBarCircleCpu.MaxValue = 100;
            this.progressBarCircleCpu.Name = "progressBarCircleCpu";
            this.progressBarCircleCpu.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBarCircleCpu.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(125)))), ((int)(((byte)(187)))));
            this.progressBarCircleCpu.Size = new System.Drawing.Size(120, 120);
            this.progressBarCircleCpu.TabIndex = 30;
            this.progressBarCircleCpu.Value = 99;
            // 
            // lbRamText
            // 
            this.lbRamText.AutoSize = true;
            this.lbRamText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRamText.Location = new System.Drawing.Point(91, 312);
            this.lbRamText.Name = "lbRamText";
            this.lbRamText.Size = new System.Drawing.Size(48, 21);
            this.lbRamText.TabIndex = 29;
            this.lbRamText.Text = "RAM";
            // 
            // progressBarCircleRam
            // 
            this.progressBarCircleRam.animated = false;
            this.progressBarCircleRam.animationIterval = 1;
            this.progressBarCircleRam.animationSpeed = 1;
            this.progressBarCircleRam.BackColor = System.Drawing.Color.LightGray;
            this.progressBarCircleRam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarCircleRam.BackgroundImage")));
            this.progressBarCircleRam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCircleRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(18)))), ((int)(((byte)(174)))));
            this.progressBarCircleRam.LabelVisible = true;
            this.progressBarCircleRam.LineProgressThickness = 5;
            this.progressBarCircleRam.LineThickness = 5;
            this.progressBarCircleRam.Location = new System.Drawing.Point(54, 334);
            this.progressBarCircleRam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBarCircleRam.MaxValue = 100;
            this.progressBarCircleRam.Name = "progressBarCircleRam";
            this.progressBarCircleRam.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBarCircleRam.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(18)))), ((int)(((byte)(174)))));
            this.progressBarCircleRam.Size = new System.Drawing.Size(120, 120);
            this.progressBarCircleRam.TabIndex = 28;
            this.progressBarCircleRam.Value = 99;
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(171)))), ((int)(((byte)(65)))));
            this.pnUser.Controls.Add(this.pbUserAvatar);
            this.pnUser.Controls.Add(this.lbOsVersion);
            this.pnUser.Controls.Add(this.lbOsVersionStatic);
            this.pnUser.Controls.Add(this.lbPcName);
            this.pnUser.Controls.Add(this.lbPcNameStatic);
            this.pnUser.Controls.Add(this.lbUserName);
            this.pnUser.Controls.Add(this.lbUserNameStatic);
            this.pnUser.Location = new System.Drawing.Point(22, 23);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(436, 100);
            this.pnUser.TabIndex = 27;
            // 
            // pbUserAvatar
            // 
            this.pbUserAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbUserAvatar.Image")));
            this.pbUserAvatar.Location = new System.Drawing.Point(12, 12);
            this.pbUserAvatar.Name = "pbUserAvatar";
            this.pbUserAvatar.Size = new System.Drawing.Size(74, 74);
            this.pbUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserAvatar.TabIndex = 6;
            this.pbUserAvatar.TabStop = false;
            // 
            // lbOsVersion
            // 
            this.lbOsVersion.AutoSize = true;
            this.lbOsVersion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOsVersion.ForeColor = System.Drawing.Color.White;
            this.lbOsVersion.Location = new System.Drawing.Point(178, 69);
            this.lbOsVersion.Name = "lbOsVersion";
            this.lbOsVersion.Size = new System.Drawing.Size(75, 17);
            this.lbOsVersion.TabIndex = 5;
            this.lbOsVersion.Text = "OS Version";
            // 
            // lbOsVersionStatic
            // 
            this.lbOsVersionStatic.AutoSize = true;
            this.lbOsVersionStatic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOsVersionStatic.ForeColor = System.Drawing.Color.White;
            this.lbOsVersionStatic.Location = new System.Drawing.Point(135, 69);
            this.lbOsVersionStatic.Name = "lbOsVersionStatic";
            this.lbOsVersionStatic.Size = new System.Drawing.Size(33, 17);
            this.lbOsVersionStatic.TabIndex = 4;
            this.lbOsVersionStatic.Text = "OS :";
            // 
            // lbPcName
            // 
            this.lbPcName.AutoSize = true;
            this.lbPcName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPcName.ForeColor = System.Drawing.Color.White;
            this.lbPcName.Location = new System.Drawing.Point(178, 41);
            this.lbPcName.Name = "lbPcName";
            this.lbPcName.Size = new System.Drawing.Size(64, 17);
            this.lbPcName.TabIndex = 3;
            this.lbPcName.Text = "PcName";
            // 
            // lbPcNameStatic
            // 
            this.lbPcNameStatic.AutoSize = true;
            this.lbPcNameStatic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPcNameStatic.ForeColor = System.Drawing.Color.White;
            this.lbPcNameStatic.Location = new System.Drawing.Point(92, 41);
            this.lbPcNameStatic.Name = "lbPcNameStatic";
            this.lbPcNameStatic.Size = new System.Drawing.Size(76, 17);
            this.lbPcNameStatic.TabIndex = 2;
            this.lbPcNameStatic.Text = "Pc Name :";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(178, 12);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 17);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "UserName";
            // 
            // lbUserNameStatic
            // 
            this.lbUserNameStatic.AutoSize = true;
            this.lbUserNameStatic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNameStatic.ForeColor = System.Drawing.Color.White;
            this.lbUserNameStatic.Location = new System.Drawing.Point(127, 12);
            this.lbUserNameStatic.Name = "lbUserNameStatic";
            this.lbUserNameStatic.Size = new System.Drawing.Size(41, 17);
            this.lbUserNameStatic.TabIndex = 0;
            this.lbUserNameStatic.Text = "User :";
            // 
            // elipsePanelRam
            // 
            this.elipsePanelRam.ElipseRadius = 40;
            this.elipsePanelRam.TargetControl = this.pnRam;
            // 
            // elipsePanelNetwork
            // 
            this.elipsePanelNetwork.ElipseRadius = 40;
            this.elipsePanelNetwork.TargetControl = this.pnNetwork;
            // 
            // elipsePanelCompInfo
            // 
            this.elipsePanelCompInfo.ElipseRadius = 40;
            this.elipsePanelCompInfo.TargetControl = this.pnCompInfo;
            // 
            // elipsePanelUser
            // 
            this.elipsePanelUser.ElipseRadius = 40;
            this.elipsePanelUser.TargetControl = this.pnUser;
            // 
            // pcCpu
            // 
            this.pcCpu.CategoryName = "Processor";
            this.pcCpu.CounterName = "% Processor Time";
            this.pcCpu.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pcRam
            // 
            this.pcRam.CategoryName = "Memory";
            this.pcRam.CounterName = "% Committed Bytes In Use";
            // 
            // timerForStaticPersent
            // 
            this.timerForStaticPersent.Enabled = true;
            this.timerForStaticPersent.Interval = 50;
            this.timerForStaticPersent.Tick += new System.EventHandler(this.timerForStaticPersent_Tick);
            // 
            // UcDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbGpu);
            this.Controls.Add(this.progressBarCircleGpu);
            this.Controls.Add(this.pnCompInfo);
            this.Controls.Add(this.btRomText);
            this.Controls.Add(this.progressBarCircleRom);
            this.Controls.Add(this.pnNetwork);
            this.Controls.Add(this.pnRam);
            this.Controls.Add(this.pnSpacerTop);
            this.Controls.Add(this.pnSpacerBot);
            this.Controls.Add(this.lbCpuText);
            this.Controls.Add(this.progressBarCircleCpu);
            this.Controls.Add(this.lbRamText);
            this.Controls.Add(this.progressBarCircleRam);
            this.Controls.Add(this.pnUser);
            this.Name = "UcDashboard";
            this.Size = new System.Drawing.Size(711, 493);
            this.pnCompInfo.ResumeLayout(false);
            this.pnCompInfo.PerformLayout();
            this.pnNetwork.ResumeLayout(false);
            this.pnNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnRam.ResumeLayout(false);
            this.pnRam.PerformLayout();
            this.pnUser.ResumeLayout(false);
            this.pnUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGpu;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBarCircleGpu;
        private System.Windows.Forms.Panel pnCompInfo;
        private System.Windows.Forms.Label lbResolution;
        private System.Windows.Forms.Label lbResolTextStatic;
        private System.Windows.Forms.Label lbmatherboardName;
        private System.Windows.Forms.Label lbCpuName;
        private System.Windows.Forms.Label lbMatherboardTextStatic;
        private System.Windows.Forms.Label lbCpuText2Static;
        private System.Windows.Forms.Label lbGpuName;
        private System.Windows.Forms.Label lbGpuTextStatic;
        private System.Windows.Forms.Label btRomText;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBarCircleRom;
        private System.Windows.Forms.Panel pnNetwork;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCheckNetConnStatic;
        private System.Windows.Forms.Label lbCheckNetConn;
        private System.Windows.Forms.Label lbIpAdressStatic;
        private System.Windows.Forms.Label lbIpAdress;
        private System.Windows.Forms.Panel pnRam;
        private System.Windows.Forms.Label lbPersentUsedRam;
        private Bunifu.Framework.UI.BunifuProgressBar progressBarLineRam;
        private System.Windows.Forms.Label lbRamUsed;
        private System.Windows.Forms.Panel pnSpacerTop;
        private System.Windows.Forms.Panel pnSpacerBot;
        private System.Windows.Forms.Label lbCpuText;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBarCircleCpu;
        private System.Windows.Forms.Label lbRamText;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBarCircleRam;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.PictureBox pbUserAvatar;
        private System.Windows.Forms.Label lbOsVersion;
        private System.Windows.Forms.Label lbOsVersionStatic;
        private System.Windows.Forms.Label lbPcName;
        private System.Windows.Forms.Label lbPcNameStatic;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserNameStatic;
        private Bunifu.Framework.UI.BunifuElipse elipsePanelRam;
        private Bunifu.Framework.UI.BunifuElipse elipsePanelNetwork;
        private Bunifu.Framework.UI.BunifuElipse elipsePanelCompInfo;
        private Bunifu.Framework.UI.BunifuElipse elipsePanelUser;
        private System.Diagnostics.PerformanceCounter pcCpu;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pcRam;
        private System.Windows.Forms.Timer timerForStaticPersent;
    }
}
