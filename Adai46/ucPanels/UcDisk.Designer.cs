namespace Adai46
{
    partial class UcDisk
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
            this.pnBot = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnBot
            // 
            this.pnBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBot.Location = new System.Drawing.Point(0, 0);
            this.pnBot.Name = "pnBot";
            this.pnBot.Size = new System.Drawing.Size(711, 460);
            this.pnBot.TabIndex = 1;
            // 
            // UcDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnBot);
            this.Name = "UcDisk";
            this.Size = new System.Drawing.Size(711, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBot;
    }
}
