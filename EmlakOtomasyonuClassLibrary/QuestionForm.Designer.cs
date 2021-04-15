namespace EmlakOtomasyonuClassLibrary
{
    partial class QuestionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdKiralık = new System.Windows.Forms.RadioButton();
            this.rdSatilik = new System.Windows.Forms.RadioButton();
            this.nmOdaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSemt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.rdAktif = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nmKatNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmlakNo = new System.Windows.Forms.TextBox();
            this.dtYapimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDepozito = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cmTur = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmOdaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKatNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepozito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORGULAMA EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rdKiralık);
            this.panel1.Controls.Add(this.rdSatilik);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(409, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 51);
            this.panel1.TabIndex = 2;
            // 
            // rdKiralık
            // 
            this.rdKiralık.AutoSize = true;
            this.rdKiralık.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKiralık.ForeColor = System.Drawing.Color.Orange;
            this.rdKiralık.Location = new System.Drawing.Point(129, 15);
            this.rdKiralık.Name = "rdKiralık";
            this.rdKiralık.Size = new System.Drawing.Size(75, 21);
            this.rdKiralık.TabIndex = 2;
            this.rdKiralık.TabStop = true;
            this.rdKiralık.Text = "Kiralık";
            this.rdKiralık.UseVisualStyleBackColor = true;
            this.rdKiralık.CheckedChanged += new System.EventHandler(this.rdSatilik_CheckedChanged_1);
            // 
            // rdSatilik
            // 
            this.rdSatilik.AutoSize = true;
            this.rdSatilik.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdSatilik.ForeColor = System.Drawing.Color.Orange;
            this.rdSatilik.Location = new System.Drawing.Point(17, 15);
            this.rdSatilik.Name = "rdSatilik";
            this.rdSatilik.Size = new System.Drawing.Size(71, 21);
            this.rdSatilik.TabIndex = 1;
            this.rdSatilik.TabStop = true;
            this.rdSatilik.Text = "Satılık";
            this.rdSatilik.UseVisualStyleBackColor = true;
            this.rdSatilik.CheckedChanged += new System.EventHandler(this.rdSatilik_CheckedChanged_1);
            // 
            // nmOdaSayisi
            // 
            this.nmOdaSayisi.Location = new System.Drawing.Point(144, 71);
            this.nmOdaSayisi.Name = "nmOdaSayisi";
            this.nmOdaSayisi.Size = new System.Drawing.Size(162, 20);
            this.nmOdaSayisi.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Oda Sayısı : ";
            // 
            // cmbSemt
            // 
            this.cmbSemt.FormattingEnabled = true;
            this.cmbSemt.Location = new System.Drawing.Point(144, 159);
            this.cmbSemt.Name = "cmbSemt";
            this.cmbSemt.Size = new System.Drawing.Size(162, 21);
            this.cmbSemt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Semt : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şehir : ";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(144, 130);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(162, 21);
            this.cmbSehir.TabIndex = 16;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(693, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Alan (m2) : ";
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(826, 101);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(162, 20);
            this.txtAlan.TabIndex = 18;
            this.txtAlan.Text = "1";
            this.txtAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlan_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(693, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fiyat : ";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(826, 42);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(162, 20);
            this.txtFiyat.TabIndex = 20;
            this.txtFiyat.Text = "0";
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // rdAktif
            // 
            this.rdAktif.AutoSize = true;
            this.rdAktif.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktif.ForeColor = System.Drawing.Color.White;
            this.rdAktif.Location = new System.Drawing.Point(844, 200);
            this.rdAktif.Name = "rdAktif";
            this.rdAktif.Size = new System.Drawing.Size(60, 21);
            this.rdAktif.TabIndex = 1;
            this.rdAktif.Text = "Aktif";
            this.rdAktif.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(342, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 65);
            this.button1.TabIndex = 21;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kat No : ";
            // 
            // nmKatNo
            // 
            this.nmKatNo.Location = new System.Drawing.Point(144, 101);
            this.nmKatNo.Name = "nmKatNo";
            this.nmKatNo.Size = new System.Drawing.Size(162, 20);
            this.nmKatNo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Emlak Numarası : ";
            // 
            // txtEmlakNo
            // 
            this.txtEmlakNo.Location = new System.Drawing.Point(144, 42);
            this.txtEmlakNo.Name = "txtEmlakNo";
            this.txtEmlakNo.Size = new System.Drawing.Size(162, 20);
            this.txtEmlakNo.TabIndex = 27;
            this.txtEmlakNo.Text = "1";
            this.txtEmlakNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmlakNo_KeyPress);
            // 
            // dtYapimTarihi
            // 
            this.dtYapimTarihi.Location = new System.Drawing.Point(826, 131);
            this.dtYapimTarihi.Name = "dtYapimTarihi";
            this.dtYapimTarihi.Size = new System.Drawing.Size(162, 20);
            this.dtYapimTarihi.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(693, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Yapım Tarihi : ";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(826, 71);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(162, 20);
            this.txtRent.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(693, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Kira : ";
            // 
            // txtDepozito
            // 
            this.txtDepozito.Location = new System.Drawing.Point(826, 159);
            this.txtDepozito.Name = "txtDepozito";
            this.txtDepozito.Size = new System.Drawing.Size(162, 20);
            this.txtDepozito.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(693, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Depozito : ";
            // 
            // cmTur
            // 
            this.cmTur.FormattingEnabled = true;
            this.cmTur.ItemHeight = 13;
            this.cmTur.Location = new System.Drawing.Point(144, 190);
            this.cmTur.Margin = new System.Windows.Forms.Padding(2);
            this.cmTur.Name = "cmTur";
            this.cmTur.Size = new System.Drawing.Size(162, 21);
            this.cmTur.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Türü : ";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(966, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "₺";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(966, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "₺";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(966, 42);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "₺";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(452, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 65);
            this.button2.TabIndex = 39;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(562, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 65);
            this.button3.TabIndex = 40;
            this.button3.Text = "İNCELE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1010, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmTur);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDepozito);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtYapimTarihi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmlakNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmKatNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdAktif);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.cmbSemt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmOdaSayisi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestionForm_FormClosed);
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmOdaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKatNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepozito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdKiralık;
        private System.Windows.Forms.RadioButton rdSatilik;
        private System.Windows.Forms.NumericUpDown nmOdaSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSemt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.RadioButton rdAktif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmKatNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmlakNo;
        private System.Windows.Forms.DateTimePicker dtYapimTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtRent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtDepozito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmTur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}