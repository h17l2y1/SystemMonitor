namespace Adai46
{
    partial class FormDisks
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
            this.pnBot = new System.Windows.Forms.Panel();
            this.elipseButtonOpen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // pnBot
            // 
            this.pnBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnBot.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBot.Location = new System.Drawing.Point(0, 0);
            this.pnBot.Name = "pnBot";
            this.pnBot.Size = new System.Drawing.Size(711, 380);
            this.pnBot.TabIndex = 0;
            // 
            // elipseButtonOpen
            // 
            this.elipseButtonOpen.ElipseRadius = 40;
            this.elipseButtonOpen.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormDisks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(711, 461);
            this.Controls.Add(this.pnBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDisks";
            this.Text = "FormDisks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBot;
        private Bunifu.Framework.UI.BunifuElipse elipseButtonOpen;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}