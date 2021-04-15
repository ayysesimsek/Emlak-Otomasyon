namespace EmlakOtomasyonuClassLibrary
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxListele = new System.Windows.Forms.PictureBox();
            this.pictureBoxEkle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "İLAN LİSTELE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "İLAN EKLE";
            // 
            // pictureBoxListele
            // 
            this.pictureBoxListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxListele.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxListele.Image")));
            this.pictureBoxListele.Location = new System.Drawing.Point(11, 178);
            this.pictureBoxListele.Name = "pictureBoxListele";
            this.pictureBoxListele.Size = new System.Drawing.Size(121, 128);
            this.pictureBoxListele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxListele.TabIndex = 5;
            this.pictureBoxListele.TabStop = false;
            this.pictureBoxListele.Click += new System.EventHandler(this.pictureBoxListele_Click);
            // 
            // pictureBoxEkle
            // 
            this.pictureBoxEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEkle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEkle.Image")));
            this.pictureBoxEkle.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEkle.Name = "pictureBoxEkle";
            this.pictureBoxEkle.Size = new System.Drawing.Size(121, 128);
            this.pictureBoxEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEkle.TabIndex = 4;
            this.pictureBoxEkle.TabStop = false;
            this.pictureBoxEkle.Click += new System.EventHandler(this.pictureBoxEkle_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(150, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxListele);
            this.Controls.Add(this.pictureBoxEkle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxListele;
        private System.Windows.Forms.PictureBox pictureBoxEkle;
    }
}