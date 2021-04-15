namespace EmlakOtomasyonuClassLibrary
{
    partial class AddForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdKiralık = new System.Windows.Forms.RadioButton();
            this.rdSatilik = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nmOdaSayisi = new System.Windows.Forms.NumericUpDown();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.cmbSemt = new System.Windows.Forms.ComboBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.nmKatNumarasi = new System.Windows.Forms.TextBox();
            this.dtYapimTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdDubleks = new System.Windows.Forms.RadioButton();
            this.rdBahceli = new System.Windows.Forms.RadioButton();
            this.rdMüstakil = new System.Windows.Forms.RadioButton();
            this.rdDaire = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmlakNumarasi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdPasif = new System.Windows.Forms.RadioButton();
            this.rdAktif = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlanBilgi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRent = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtDepozito = new System.Windows.Forms.NumericUpDown();
            this.lblDepo = new System.Windows.Forms.Label();
            this.lblFiyatBilgi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmOdaSayisi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepozito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rdKiralık);
            this.panel1.Controls.Add(this.rdSatilik);
            this.panel1.ForeColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(1053, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 87);
            this.panel1.TabIndex = 0;
            // 
            // rdKiralık
            // 
            this.rdKiralık.AutoSize = true;
            this.rdKiralık.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKiralık.ForeColor = System.Drawing.Color.Orange;
            this.rdKiralık.Location = new System.Drawing.Point(129, 30);
            this.rdKiralık.Name = "rdKiralık";
            this.rdKiralık.Size = new System.Drawing.Size(97, 29);
            this.rdKiralık.TabIndex = 2;
            this.rdKiralık.TabStop = true;
            this.rdKiralık.Text = "Kiralık";
            this.rdKiralık.UseVisualStyleBackColor = true;
            this.rdKiralık.CheckedChanged += new System.EventHandler(this.rdSatilik_CheckedChanged_1);
            // 
            // rdSatilik
            // 
            this.rdSatilik.AutoSize = true;
            this.rdSatilik.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdSatilik.ForeColor = System.Drawing.Color.Orange;
            this.rdSatilik.Location = new System.Drawing.Point(17, 30);
            this.rdSatilik.Name = "rdSatilik";
            this.rdSatilik.Size = new System.Drawing.Size(92, 29);
            this.rdSatilik.TabIndex = 1;
            this.rdSatilik.TabStop = true;
            this.rdSatilik.Text = "Satılık";
            this.rdSatilik.UseVisualStyleBackColor = true;
            this.rdSatilik.CheckedChanged += new System.EventHandler(this.rdSatilik_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Sayısı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kat Numarası : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şehir : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Semt : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alan (m2) : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yapım Tarihi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(118, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tür ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fiyat : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Depozito : ";
            // 
            // nmOdaSayisi
            // 
            this.nmOdaSayisi.Location = new System.Drawing.Point(144, 44);
            this.nmOdaSayisi.Name = "nmOdaSayisi";
            this.nmOdaSayisi.Size = new System.Drawing.Size(162, 20);
            this.nmOdaSayisi.TabIndex = 10;
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(144, 118);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(162, 21);
            this.cmbSehir.TabIndex = 11;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // cmbSemt
            // 
            this.cmbSemt.FormattingEnabled = true;
            this.cmbSemt.Location = new System.Drawing.Point(144, 160);
            this.cmbSemt.Name = "cmbSemt";
            this.cmbSemt.Size = new System.Drawing.Size(162, 21);
            this.cmbSemt.TabIndex = 11;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(144, 201);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(162, 20);
            this.txtAlan.TabIndex = 12;
            this.txtAlan.Text = "1";
            this.txtAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlan_KeyPress);
            // 
            // nmKatNumarasi
            // 
            this.nmKatNumarasi.Location = new System.Drawing.Point(144, 82);
            this.nmKatNumarasi.Name = "nmKatNumarasi";
            this.nmKatNumarasi.Size = new System.Drawing.Size(162, 20);
            this.nmKatNumarasi.TabIndex = 12;
            this.nmKatNumarasi.Text = "1";
            // 
            // dtYapimTarihi
            // 
            this.dtYapimTarihi.Location = new System.Drawing.Point(104, 39);
            this.dtYapimTarihi.Name = "dtYapimTarihi";
            this.dtYapimTarihi.Size = new System.Drawing.Size(162, 20);
            this.dtYapimTarihi.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdDubleks);
            this.panel2.Controls.Add(this.rdBahceli);
            this.panel2.Controls.Add(this.rdMüstakil);
            this.panel2.Controls.Add(this.rdDaire);
            this.panel2.Location = new System.Drawing.Point(28, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 107);
            this.panel2.TabIndex = 3;
            // 
            // rdDubleks
            // 
            this.rdDubleks.AutoSize = true;
            this.rdDubleks.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdDubleks.ForeColor = System.Drawing.Color.White;
            this.rdDubleks.Location = new System.Drawing.Point(129, 77);
            this.rdDubleks.Name = "rdDubleks";
            this.rdDubleks.Size = new System.Drawing.Size(84, 21);
            this.rdDubleks.TabIndex = 2;
            this.rdDubleks.TabStop = true;
            this.rdDubleks.Text = "Dubleks";
            this.rdDubleks.UseVisualStyleBackColor = true;
            // 
            // rdBahceli
            // 
            this.rdBahceli.AutoSize = true;
            this.rdBahceli.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBahceli.ForeColor = System.Drawing.Color.White;
            this.rdBahceli.Location = new System.Drawing.Point(129, 11);
            this.rdBahceli.Name = "rdBahceli";
            this.rdBahceli.Size = new System.Drawing.Size(78, 21);
            this.rdBahceli.TabIndex = 2;
            this.rdBahceli.TabStop = true;
            this.rdBahceli.Text = "Bahçeli";
            this.rdBahceli.UseVisualStyleBackColor = true;
            // 
            // rdMüstakil
            // 
            this.rdMüstakil.AutoSize = true;
            this.rdMüstakil.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdMüstakil.ForeColor = System.Drawing.Color.White;
            this.rdMüstakil.Location = new System.Drawing.Point(13, 77);
            this.rdMüstakil.Name = "rdMüstakil";
            this.rdMüstakil.Size = new System.Drawing.Size(87, 21);
            this.rdMüstakil.TabIndex = 1;
            this.rdMüstakil.TabStop = true;
            this.rdMüstakil.Text = "Müstakil";
            this.rdMüstakil.UseVisualStyleBackColor = true;
            // 
            // rdDaire
            // 
            this.rdDaire.AutoSize = true;
            this.rdDaire.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdDaire.ForeColor = System.Drawing.Color.White;
            this.rdDaire.Location = new System.Drawing.Point(13, 11);
            this.rdDaire.Name = "rdDaire";
            this.rdDaire.Size = new System.Drawing.Size(65, 21);
            this.rdDaire.TabIndex = 1;
            this.rdDaire.TabStop = true;
            this.rdDaire.Text = "Daire";
            this.rdDaire.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEkle.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Orange;
            this.btnEkle.Location = new System.Drawing.Point(0, 402);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(1334, 73);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(22, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Emlak Numarası : ";
            // 
            // txtEmlakNumarasi
            // 
            this.txtEmlakNumarasi.Location = new System.Drawing.Point(144, 244);
            this.txtEmlakNumarasi.Name = "txtEmlakNumarasi";
            this.txtEmlakNumarasi.Size = new System.Drawing.Size(162, 20);
            this.txtEmlakNumarasi.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Kira : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(85, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Aktiflik Durumu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdPasif);
            this.panel3.Controls.Add(this.rdAktif);
            this.panel3.Location = new System.Drawing.Point(41, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 61);
            this.panel3.TabIndex = 3;
            // 
            // rdPasif
            // 
            this.rdPasif.AutoSize = true;
            this.rdPasif.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdPasif.ForeColor = System.Drawing.Color.White;
            this.rdPasif.Location = new System.Drawing.Point(105, 22);
            this.rdPasif.Name = "rdPasif";
            this.rdPasif.Size = new System.Drawing.Size(60, 21);
            this.rdPasif.TabIndex = 2;
            this.rdPasif.Text = "Pasif";
            this.rdPasif.UseVisualStyleBackColor = true;
            // 
            // rdAktif
            // 
            this.rdAktif.AutoSize = true;
            this.rdAktif.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktif.ForeColor = System.Drawing.Color.White;
            this.rdAktif.Location = new System.Drawing.Point(20, 22);
            this.rdAktif.Name = "rdAktif";
            this.rdAktif.Size = new System.Drawing.Size(60, 21);
            this.rdAktif.TabIndex = 1;
            this.rdAktif.Text = "Aktif";
            this.rdAktif.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlanBilgi);
            this.groupBox1.Controls.Add(this.cmbSemt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nmOdaSayisi);
            this.groupBox1.Controls.Add(this.cmbSehir);
            this.groupBox1.Controls.Add(this.txtAlan);
            this.groupBox1.Controls.Add(this.txtEmlakNumarasi);
            this.groupBox1.Controls.Add(this.nmKatNumarasi);
            this.groupBox1.Location = new System.Drawing.Point(25, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 292);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // lblAlanBilgi
            // 
            this.lblAlanBilgi.AutoSize = true;
            this.lblAlanBilgi.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlanBilgi.ForeColor = System.Drawing.Color.White;
            this.lblAlanBilgi.Location = new System.Drawing.Point(22, 229);
            this.lblAlanBilgi.Name = "lblAlanBilgi";
            this.lblAlanBilgi.Size = new System.Drawing.Size(22, 15);
            this.lblAlanBilgi.TabIndex = 18;
            this.lblAlanBilgi.Text = "___";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtYapimTarihi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(386, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 183);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRent);
            this.groupBox3.Controls.Add(this.txtFiyat);
            this.groupBox3.Controls.Add(this.txtDepozito);
            this.groupBox3.Controls.Add(this.lblDepo);
            this.groupBox3.Controls.Add(this.lblFiyatBilgi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(688, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 286);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(96, 243);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(162, 20);
            this.txtRent.TabIndex = 23;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(96, 166);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(162, 20);
            this.txtFiyat.TabIndex = 19;
            // 
            // txtDepozito
            // 
            this.txtDepozito.Location = new System.Drawing.Point(96, 202);
            this.txtDepozito.Name = "txtDepozito";
            this.txtDepozito.Size = new System.Drawing.Size(162, 20);
            this.txtDepozito.TabIndex = 22;
            // 
            // lblDepo
            // 
            this.lblDepo.AutoSize = true;
            this.lblDepo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepo.ForeColor = System.Drawing.Color.White;
            this.lblDepo.Location = new System.Drawing.Point(25, 226);
            this.lblDepo.Name = "lblDepo";
            this.lblDepo.Size = new System.Drawing.Size(22, 15);
            this.lblDepo.TabIndex = 17;
            this.lblDepo.Text = "___";
            // 
            // lblFiyatBilgi
            // 
            this.lblFiyatBilgi.AutoSize = true;
            this.lblFiyatBilgi.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatBilgi.ForeColor = System.Drawing.Color.White;
            this.lblFiyatBilgi.Location = new System.Drawing.Point(25, 185);
            this.lblFiyatBilgi.Name = "lblFiyatBilgi";
            this.lblFiyatBilgi.Size = new System.Drawing.Size(22, 15);
            this.lblFiyatBilgi.TabIndex = 16;
            this.lblFiyatBilgi.Text = "___";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(368, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(430, 28);
            this.label13.TabIndex = 14;
            this.label13.Text = "KİRALIK - SATILIK EV EKLEME EKRANI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmlakOtomasyonuClassLibrary.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(1004, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1334, 475);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmOdaSayisi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepozito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdKiralık;
        private System.Windows.Forms.RadioButton rdSatilik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmOdaSayisi;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.ComboBox cmbSemt;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.TextBox nmKatNumarasi;
        private System.Windows.Forms.DateTimePicker dtYapimTarihi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdDubleks;
        private System.Windows.Forms.RadioButton rdBahceli;
        private System.Windows.Forms.RadioButton rdMüstakil;
        private System.Windows.Forms.RadioButton rdDaire;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmlakNumarasi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdPasif;
        private System.Windows.Forms.RadioButton rdAktif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFiyatBilgi;
        private System.Windows.Forms.Label lblDepo;
        private System.Windows.Forms.Label lblAlanBilgi;
        private System.Windows.Forms.NumericUpDown txtFiyat;
        private System.Windows.Forms.NumericUpDown txtRent;
        private System.Windows.Forms.NumericUpDown txtDepozito;
    }
}