using EmlakClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonuClassLibrary
{
    public partial class AddForm : Form
    {
        #region Public Members
        public string Rent_TextFile = @"../../Rent.txt";
        public string Sale_TextFile = @"../../Sale.txt";
        public TypeHome selectType;
        public Home selectHome;
        public bool activeStatus = false;
        public RadioButton rb;
        List<Home> homeListInfo = new List<Home>();
        #endregion

        /// <summary>
        /// CCONSTRUCTOR
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
        }

        #region EVENT

        #region AnaForm Load bugünün tarh ayarlaması yapılmaktadır. 
        private void AddForm_Load(object sender, EventArgs e)
        {
            txtEmlakNumarasi.Text = "1";
            dtYapimTarihi.Value = DateTime.Now.Date;
            FileWriteOrFileReadClasses.ProvinceAndCountyLoad(0, cmbSehir, cmbSemt);

           
        }
        #endregion

        /// <summary>
        ///  Ekle butonuna basıldığında gerçekleşecek olaylar tanımlanıyor. 
        ///  RadioButton dan sender eventi ile alınan bilgi üzerinden kiralık ya da satılık ev olarak seçildiğinde gerçekleşecek işlemler yapılmaktadır ..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rb == null)
            {
                MessageBox.Show("Eklenecek evi eklemeden önce satılık / kiralık olduğu bilgisinin seçilmesi gerekiyor. Aksi taktirde ev eklemesi işleminiz gerçekleşmeyecektir. ",
                                "BİLGİLENDİRME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                if (rdAktif.Checked)
                {
                    activeStatus = true;
                }
                switch (rb.Text)
                {
                    #region Kiralık eve tıklanıldığında dosyaya kayıt işlemi atanıyor ... 
                    case "Kiralık":
                        RentHouseAddTextFile();
                        break;
                    #endregion

                    #region Satılık eve tıklanıldığında dosyaya kayıt işlemi atanıyor .. 
                    case "Satılık":
                        SaleHouseAddTextFile();
                        break;
                }
                #endregion
            }
        }

        #region Kiralık / Satılık RadioButtonların sender olayı ayarlanmaktadır .. 
        private void rdSatilik_CheckedChanged_1(object sender, EventArgs e)
        {
            rb = (RadioButton)sender;
            if (rb.Text == "Kiralık")
            {
                nmOdaSayisi.ResetText();
                nmOdaSayisi.Focus();
                txtDepozito.Enabled = true;
                txtRent.Enabled = true;
                txtFiyat.Enabled = false;
                
            }
            else if (rb.Text == "Satılık")
            {
                nmOdaSayisi.ResetText();
                nmOdaSayisi.Focus();
                txtFiyat.Enabled = true;
                txtDepozito.Enabled = false;
                txtRent.Enabled = false;
            }
        }
        #endregion

        #region Kiralık ev için metot tanımlamsı yapılmıştır. .txt  dosyasına kayıt işlemi gerçekleşmektedir .. 
        public void RentHouseAddTextFile()
        {
            if (String.IsNullOrEmpty(txtRent.Text) ||
                          String.IsNullOrEmpty(txtDepozito.Text))
            {
                MessageBox.Show("Deposito ya da kira alanını lütfen doldurunuz");
                return;
            }
            else
            {
                if (EmptyControl() == false)
                {
                    HouseForRent rentHouse = new HouseForRent();
                    rentHouse.NumberOfRooms = Convert.ToInt32(nmOdaSayisi.Value);
                    rentHouse.NumberOfFloors = Convert.ToInt32(nmKatNumarasi.Text);
                    rentHouse.District = cmbSemt.SelectedItem.ToString();
                    rentHouse.Area = Convert.ToDouble(txtAlan.Text);
                    rentHouse.DateOfConstructor = DateTime.Parse(dtYapimTarihi.Text);
                    rentHouse.Active = activeStatus;
                    rentHouse.HomeNumber = Convert.ToInt32(txtEmlakNumarasi.Text);
                    if (rdDaire.Checked)
                    {
                        rentHouse.IsType = TypeHome.Daire;
                    }
                    else if (rdBahceli.Checked)
                    {
                        rentHouse.IsType = TypeHome.Bahceli;
                    }
                    else if (rdMüstakil.Checked)
                    {
                        rentHouse.IsType = TypeHome.Mustakil;
                    }
                    else if (rdDubleks.Checked)
                    {
                        rentHouse.IsType = TypeHome.Dubleks;
                    }
                    rentHouse.Deposito = Convert.ToDecimal(txtDepozito.Text);
                    rentHouse.Rent = Convert.ToDecimal(txtRent.Text);
                    rentHouse.EvTipi = "Kiralık";
                    homeListInfo.Add(rentHouse);
                    FileWriteOrFileReadClasses.RentHouseWriteToFile(homeListInfo); // Dosyaya yazma işlemi
                    MessageBox.Show("Kiralık ev kaydınız başarıyla tamamlanmıştır .. ",
                                    "Bilgilendirme",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }


            }
        }
        #endregion

        #region Satılık ev için metot tanımlaması yapılmıştır. .txt dosyasına kayıt işlemi gerçekleşmektedir ..
        public void SaleHouseAddTextFile()
        {
            if (String.IsNullOrEmpty(lblDepo.Text))
            {
                MessageBox.Show("Lütfen fiyat alanını doldurunuz !!");
                return;
            }
            else
            {
                if (EmptyControl() == false)
                {
                    HouseForSale saleHouse = new HouseForSale();
                    saleHouse.NumberOfRooms = Convert.ToInt32(nmOdaSayisi.Value);
                    saleHouse.NumberOfFloors = Convert.ToInt32(nmKatNumarasi.Text);
                    saleHouse.District = cmbSemt.SelectedItem.ToString();
                    saleHouse.Area = Convert.ToDouble(txtAlan.Text);
                    saleHouse.DateOfConstructor = DateTime.Parse(dtYapimTarihi.Text);
                    saleHouse.Active = activeStatus;
                    saleHouse.HomeNumber = Convert.ToInt32(txtEmlakNumarasi.Text);
                    if (rdDaire.Checked)
                    {
                        saleHouse.IsType = TypeHome.Daire;
                    }
                    else if (rdBahceli.Checked)
                    {
                        saleHouse.IsType = TypeHome.Bahceli;
                    }
                    else if (rdMüstakil.Checked)
                    {
                        saleHouse.IsType = TypeHome.Mustakil;
                    }
                    else if (rdDubleks.Checked)
                    {
                        saleHouse.IsType = TypeHome.Dubleks;
                    }
                    saleHouse.Price = Convert.ToDecimal(txtFiyat.Text);
                    saleHouse.EvTipi = "Satılık";
                    homeListInfo.Add(saleHouse);
                    FileWriteOrFileReadClasses.SaleHouseWriteToFile(homeListInfo);  // Dosyaya yazma işlemi
                    MessageBox.Show("Satılık ev kaydınız başarıyla tamamlanmıştır .. ",
                                    "Bilgilendirme",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
            }
        }
        #endregion

        #region Form kapatıldığında tekrardan formun açılabilmesi için boolen ifade ile kontrol edilmiştir .. 
        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage.IsAddHome = false;
        }
        #endregion

        #region Şehir combosuna tıkladığımızda ona ait olan semtlerin dosyadan okunması işleniyor .. 
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSemt.Items.Clear();
            cmbSemt.Text = "";
            FileWriteOrFileReadClasses.ProvinceAndCountyLoad(1, cmbSehir, cmbSemt);
        }
        #endregion

        /// <summary>
        /// Girilen fiyat değeri kontrolü yapılmaktdır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (String.IsNullOrEmpty(lblDepo.Text))
                {
                    lblFiyatBilgi.Visible = true;
                    lblFiyatBilgi.Text = "Fiyat değeri girmelisiniz.";
                }
                else if (int.Parse(lblDepo.Text) <= 0)
                {
                    lblFiyatBilgi.Visible = true;
                    lblFiyatBilgi.Text = "Fiyat değeri 0'dan büyük olmalıdır..";
                }
                else
                {
                    lblFiyatBilgi.Text = "";
                    lblFiyatBilgi.Visible = false;
                    btnEkle.Focus();
                }
            }
        }

        /// <summary>
        /// Girilen depozito kontrolü yapılmaktadır ... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDepozito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtDepozito.Text == "")
                    lblDepo.Text = "Depozito değeri girmelisiniz.";
                else if (int.Parse(txtDepozito.Text) <= 0)
                    lblDepo.Text = "Depozito değeri 0 dan büyük olmalı.";
                else
                {
                    lblDepo.Text = "";
                    btnEkle.Focus();
                }
            }
        }

        /// <summary>
        /// Girilen alan kontrolü yapılmaktadır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((txtAlan.Text) == "")
                    lblAlanBilgi.Text = "Alan değeri girmelisiniz.";
                else if (int.Parse(txtAlan.Text) <= 0)
                    lblAlanBilgi.Text = "Alan değeri 0 dan büyük olmalı.";
                else
                {
                    lblAlanBilgi.Text = "";
                    dtYapimTarihi.Focus();
                }
            }
        }

        #endregion
        /// <summary>
        /// Boş kontrolü yapılmaktadır . 
        /// </summary>
        /// <returns></returns>
        public bool EmptyControl()
        {
            bool returnObject = false;
            if (String.IsNullOrEmpty(txtEmlakNumarasi.Text) ||
                String.IsNullOrEmpty(nmOdaSayisi.Text) ||
                String.IsNullOrEmpty(nmKatNumarasi.Text) ||
                String.IsNullOrEmpty(cmbSehir.Text) ||
                String.IsNullOrEmpty(cmbSemt.Text) ||
                String.IsNullOrEmpty(txtAlan.Text) ||
                String.IsNullOrEmpty(dtYapimTarihi.Text) ||
                (!rdAktif.Checked &&
                !rdPasif.Checked) ||
                (!rdDaire.Checked &&
                !rdBahceli.Checked &&
                !rdDubleks.Checked &&
                !rdMüstakil.Checked))
            {
                MessageBox.Show("Tüm alanlar doldurulmak zorundadır !!! ",
                                "BİLGİLENDİRME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                returnObject = true;
            }
            return returnObject;
        }
    }
}
