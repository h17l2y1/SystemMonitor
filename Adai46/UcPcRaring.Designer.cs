namespace Adai46
{
    partial class UcPcRaring
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCpuRatingName = new System.Windows.Forms.Label();
            this.lbGpuRatingName = new System.Windows.Forms.Label();
            this.lbRamRatingName = new System.Windows.Forms.Label();
            this.lbRamRating = new System.Windows.Forms.Label();
            this.lbGpuRating = new System.Windows.Forms.Label();
            this.lbCpuRating = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbRamRating);
            this.panel1.Controls.Add(this.lbGpuRating);
            this.panel1.Controls.Add(this.lbCpuRating);
            this.panel1.Controls.Add(this.lbRamRatingName);
            this.panel1.Controls.Add(this.lbGpuRatingName);
            this.panel1.Controls.Add(this.lbCpuRatingName);
            this.panel1.Location = new System.Drawing.Point(95, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 250);
            this.panel1.TabIndex = 2;
            // 
            // lbCpuRatingName
            // 
            this.lbCpuRatingName.AutoSize = true;
            this.lbCpuRatingName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpuRatingName.Location = new System.Drawing.Point(48, 52);
            this.lbCpuRatingName.Name = "lbCpuRatingName";
            this.lbCpuRatingName.Size = new System.Drawing.Size(51, 21);
            this.lbCpuRatingName.TabIndex = 0;
            this.lbCpuRatingName.Text = "CPU: ";
            // 
            // lbGpuRatingName
            // 
            this.lbGpuRatingName.AutoSize = true;
            this.lbGpuRatingName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGpuRatingName.Location = new System.Drawing.Point(47, 95);
            this.lbGpuRatingName.Name = "lbGpuRatingName";
            this.lbGpuRatingName.Size = new System.Drawing.Size(52, 21);
            this.lbGpuRatingName.TabIndex = 1;
            this.lbGpuRatingName.Text = "GPU: ";
            // 
            // lbRamRatingName
            // 
            this.lbRamRatingName.AutoSize = true;
            this.lbRamRatingName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRamRatingName.Location = new System.Drawing.Point(43, 136);
            this.lbRamRatingName.Name = "lbRamRatingName";
            this.lbRamRatingName.Size = new System.Drawing.Size(56, 21);
            this.lbRamRatingName.TabIndex = 2;
            this.lbRamRatingName.Text = "RAM: ";
            // 
            // lbRamRating
            // 
            this.lbRamRating.AutoSize = true;
            this.lbRamRating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRamRating.Location = new System.Drawing.Point(140, 136);
            this.lbRamRating.Name = "lbRamRating";
            this.lbRamRating.Size = new System.Drawing.Size(48, 21);
            this.lbRamRating.TabIndex = 5;
            this.lbRamRating.Text = "RAM";
            // 
            // lbGpuRating
            // 
            this.lbGpuRating.AutoSize = true;
            this.lbGpuRating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGpuRating.Location = new System.Drawing.Point(140, 95);
            this.lbGpuRating.Name = "lbGpuRating";
            this.lbGpuRating.Size = new System.Drawing.Size(44, 21);
            this.lbGpuRating.TabIndex = 4;
            this.lbGpuRating.Text = "GPU";
            // 
            // lbCpuRating
            // 
            this.lbCpuRating.AutoSize = true;
            this.lbCpuRating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpuRating.Location = new System.Drawing.Point(140, 52);
            this.lbCpuRating.Name = "lbCpuRating";
            this.lbCpuRating.Size = new System.Drawing.Size(43, 21);
            this.lbCpuRating.TabIndex = 3;
            this.lbCpuRating.Text = "CPU";
            // 
            // UcPcRaring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel1);
            this.Name = "UcPcRaring";
            this.Size = new System.Drawing.Size(711, 460);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRamRating;
        private System.Windows.Forms.Label lbGpuRating;
        private System.Windows.Forms.Label lbCpuRating;
        private System.Windows.Forms.Label lbRamRatingName;
        private System.Windows.Forms.Label lbGpuRatingName;
        private System.Windows.Forms.Label lbCpuRatingName;
    }
}
