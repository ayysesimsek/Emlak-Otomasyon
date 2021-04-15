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
    public partial class QuestionForm : Form
    {
        #region Property Members
        public string Rent_TextFile = @"../../Rent.txt";
        public string Sale_TextFile = @"../../Sale.txt";
        public List<Home> homeClass = new List<Home>();
        FileWriteOrFileReadClasses read = new FileWriteOrFileReadClasses();
        public RadioButton rb;
        #endregion

        #region CONSTRUCTOR
        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(string statusType)
        {
            InitializeComponent();
            if (statusType == "İnceleme")
            {
                for (int i = 0; i < read.homeList.Count; i++)
                {
                    read.HouseRentTextFileListReader();
                    RentHouseDataGrid();
                    string search = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    read.HouseRentTextFileListReader();
                    nmOdaSayisi.Enabled = false;
                    nmKatNo.Enabled = false;
                    cmbSehir.Enabled = false;
                    cmbSemt.Enabled = false;
                    cmTur.Enabled = false;
                    rdKiralık.Enabled = false;
                    rdSatilik.Enabled = false;
                    txtFiyat.Enabled = false;
                    txtRent.Enabled = false;
                    txtAlan.Enabled = false;
                    dtYapimTarihi.Enabled = false;
                    txtDepozito.Enabled = false;
                    rdAktif.Enabled = false;
                }
            }
            else if (statusType == "silme")
            {

            }
            else
            {

            }
        }
        #endregion

        #region EVENT
        /// <summary>
        /// Ara butonuna basıldığında gerçekleşecek olaylar ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!SearchEmptyControl())
            {
                switch (rb.Text)
                {
                    case "Satılık":
                        SaleHouseDataGrid();
                        break;
                    case "Kiralık":
                        RentHouseDataGrid();
                        break;
                }
            }
        }

        /// <summary>
        /// Ara butonuna basıldığında kiralık/satılık seçilmemişse uyarı vermesi gerçekleşiyor. Boş geçilemez uyarısı yapılmaktadır...
        /// </summary>
        /// <returns></returns>
        public bool SearchEmptyControl()
        {
            bool returnObject = false; ;
            if (rb == null)
            {
                MessageBox.Show("Eklenecek evi eklemeden önce satılık / kiralık olduğu bilgisinin seçilmesi gerekiyor. Aksi taktirde ev eklemesi işleminiz gerçekleşmeyecektir. ",
                                "BİLGİLENDİRME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                returnObject = true;
            }
            return returnObject;
        }

        /// <summary>
        /// Sil butonuna basıldığında kiralık/satılık seçilmemişse uyarı vermesi gerçekleşiyor. Boş geçilemez uyarısı yapılmaktadır...
        /// </summary>
        /// <returns></returns>
        public bool DeletedEmptyControl()
        {
            bool returnObject = false; ;
            if (rb == null)
            {
                MessageBox.Show("Silinecek evi silmeden önce satılık / kiralık olduğu bilgisinin seçilmesi gerekiyor. Aksi taktirde ev eklemesi işleminiz gerçekleşmeyecektir. ",
                                "BİLGİLENDİRME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                returnObject = true;
            }
            return returnObject;
        }

        /// <summary>
        /// Satılık seçilip ARA butonuna tıklanıldığında DataGrid de sütun ve satırlar seçilen kiralık bilgilerine göre listelenecektir ... 
        /// </summary>
        public void SaleHouseDataGrid()
        {

            FileWriteOrFileReadClasses readSale = new FileWriteOrFileReadClasses();
            readSale.HouseSaleTextFileReader();

            for (int i = 0; i < readSale.homeList.Count; i++)
            {
                if (readSale.homeList[i].EvTipi == "Satılık")
                {
                    dataGridView1.Columns.Clear();
                    DataTable dataTable = new DataTable();

                    dataTable.Columns.Add("Oda Sayısı");
                    dataTable.Columns.Add("Kat No");
                    dataTable.Columns.Add("Semt");
                    dataTable.Columns.Add("Alan");
                    dataTable.Columns.Add("Yapım Tarihi");
                    dataTable.Columns.Add("Aktif");
                    dataTable.Columns.Add("Emlak Numarası");
                    dataTable.Columns.Add("Tür");
                    dataTable.Columns.Add("Fiyat");

                    dataTable.Rows.Add(readSale.homeList[i].NumberOfRooms,
                                       readSale.homeList[i].NumberOfFloors,
                                       readSale.homeList[i].District,
                                       readSale.homeList[i].Area,
                                       readSale.homeList[i].DateOfConstructor,
                                       readSale.homeList[i].Active,
                                       readSale.homeList[i].HomeNumber,
                                       readSale.homeList[i].IsType,
                                       ((HouseForSale)readSale.homeList[i]).Price);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        /// <summary>
        /// Kiralık seçilip ARA butonuna tıklanıldığında DataGrid de sütun ve satırlar seçilen kiralık bilgilerine göre listelenecektir ... 
        /// </summary>
        public void RentHouseDataGrid()
        {
            FileWriteOrFileReadClasses read = new FileWriteOrFileReadClasses();
            read.HouseRentTextFileListReader();
            dataGridView1.Columns.Clear();

            for (int i = 0; i < read.homeList.Count; i++)
            {
                if (read.homeList[i].EvTipi == "Kiralık")
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Columns.Add("Oda Sayısı");
                    dataTable.Columns.Add("Kat No");
                    dataTable.Columns.Add("Semt");
                    dataTable.Columns.Add("Alan");
                    dataTable.Columns.Add("Yapım Tarihi");
                    dataTable.Columns.Add("Aktif");
                    dataTable.Columns.Add("Emlak Numarası");
                    dataTable.Columns.Add("Tür");
                    dataTable.Columns.Add("Kira");
                    dataTable.Columns.Add("Depozito");

                    dataTable.Rows.Add(read.homeList[i].NumberOfRooms,
                                       read.homeList[i].NumberOfFloors,
                                       read.homeList[i].District,
                                       read.homeList[i].Area,
                                       read.homeList[i].DateOfConstructor,
                                       read.homeList[i].Active,
                                       read.homeList[i].HomeNumber,
                                       read.homeList[i].IsType,
                                       ((HouseForRent)read.homeList[i]).Rent,
                                       ((HouseForRent)read.homeList[i]).Deposito);
                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        /// <summary>
        /// Form kapatılırken tekrar açılabilmesi kontrolü yapılıyor .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage.IsQuestionHome = false;
        }

        /// <summary>
        /// Satılık / Kiralık seçildiğinde duruma göre gözükecek alanların enabled kontrolü yapılmaktadır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdSatilik_CheckedChanged_1(object sender, EventArgs e)
        {
            rb = (RadioButton)sender;
            if (rb.Text == "Kiralık")
            {
                txtFiyat.Enabled = false;
                txtDepozito.Enabled = true;
                txtRent.Enabled = true;
            }
            if (rb.Text == "Satılık")
            {
                txtFiyat.Enabled = true;
                txtDepozito.Enabled = false;
                txtRent.Enabled = false;
            }
        }

        /// <summary>
        /// emlak numarası alanına sadece sayı girişi yapılması sağlandı.
        /// </summary>
        private void txtEmlakNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// fiyat textBoxuna sayı ve nokta('.') dışında veri girişi engellendi.
        /// </summary>
        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// alan textBoxuna sayı ve nokta('.') dışında veri girişi engellendi.
        /// </summary>
        private void txtAlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Sorgulama Ekranı Load 'da şehir ve semt alanları dolduruluyor ... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuestionForm_Load(object sender, EventArgs e)
        {
            FileWriteOrFileReadClasses.ProvinceAndCountyLoad(0, cmbSehir, cmbSemt);
            LoadType();
        }

        /// <summary>
        /// Şehirin bağlı olduğu semtler comboboxa dolduruluyor ..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileWriteOrFileReadClasses.ProvinceAndCountyLoad(1, cmbSehir, cmbSemt);
        }

        /// <summary>
        /// Türler comboboxı dolduruluyor .. 
        /// </summary>
        public void LoadType()
        {
            cmTur.Items.Add(TypeHome.Bahceli);
            cmTur.Items.Add(TypeHome.Daire);
            cmTur.Items.Add(TypeHome.Dubleks);
            cmTur.Items.Add(TypeHome.Mustakil);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FileWriteOrFileReadClasses file = new FileWriteOrFileReadClasses();
        }
        #endregion

        /// <summary>
        /// Silme işlemi gerçekleşmektedir...
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!DeletedEmptyControl())
            {
                try
                {
                    read.HouseRentTextFileListReader();
                    if (read != null)
                    {
                        #region Kiralık ev seçili ise
                        if (rdKiralık.Checked)
                        {
                            string homeNumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                            for (int i = 0; i < read.homeList.Count; i++)
                            {
                                if (read.homeList[i].HomeNumber == Convert.ToInt32(homeNumber))
                                {
                                    read.homeList.RemoveAt(i);
                                    Directory.Delete(Rent_TextFile + homeNumber, true);
                                    break;
                                }
                            }
                            RentHouseDataGrid();
                        }
                        #endregion
                        #region Satılık ev seçili ise
                        if (rdSatilik.Checked)
                        {
                            string homeNumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                            for (int i = 0; i < read.homeList.Count; i++)
                            {
                                if (read.homeList[i].HomeNumber == Convert.ToInt32(homeNumber))
                                {
                                    read.homeList.RemoveAt(i);
                                    Directory.Delete(Sale_TextFile + homeNumber, true);
                                    break;
                                }
                            }
                            SaleHouseDataGrid();
                        }
                        #endregion
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// İnceleme butonu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            QuestionForm searchGo = new QuestionForm("İnceleme");
            this.Hide();
            searchGo.Show();            
        }
    }
}
