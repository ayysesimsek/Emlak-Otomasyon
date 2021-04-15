using EmlakClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonuClassLibrary
{
    class FileWriteOrFileReadClasses
    {
        #region Property Members
        public static Home[] home = new Home[1000];
        public static int recordCount = 0;
        public static string ProvinceAndCounty_TextFile = @"../../ProvinceAndCounty.txt";
        public static string users_TextFile = @"../../users.txt";
        public static string Rent_TextFile = @"../../Rent.txt";
        public static string Sale_TextFile = @"../../Sale.txt";
        public List<Home> homeList = new List<Home>();
        #endregion

        /// <summary>
        /// Şehir ve Semtin comboboxlara yüklenme ve sayfa açılışında doldurulması işlemleri yapılmaktadır .. 
        /// </summary>
        /// <param name="indis"></param>
        /// <param name="combo_il"></param>
        /// <param name="combo_semt"></param>
        public static void ProvinceAndCountyLoad(int indis, ComboBox combo_il, ComboBox combo_semt)
        {
            FileStream fs = new FileStream(ProvinceAndCounty_TextFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string okunan = sr.ReadLine();

            while (okunan != null)
            {
                string[] word = okunan.Split('*');
                if (indis == 1)
                {
                    string province = combo_il.Text;
                    if (province == word[0])
                    {
                        combo_semt.Items.Add(word[indis]);
                    }
                }
                else if (!combo_il.Items.Contains(word[indis]))
                {
                    combo_il.Items.Add(word[indis]);
                }
                okunan = sr.ReadLine();
            }
        }

        /// <summary>
        /// Login ekranına girerken kullanıcı adı ve şifre kontrolü dosyadan okunuyor .. 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool LoginReadFile(TextBox username, TextBox password)
        {
            bool IsBool = false;
            if (File.Exists(users_TextFile))
            {
                FileStream fs = new FileStream(users_TextFile, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string row = sr.ReadLine();
                while (row != null)
                {
                    string[] user = row.Split('-');
                    if (user[0].Equals(username.Text) &&
                        user[1].Equals(password.Text))
                    {
                        IsBool = true;
                        break;
                    }
                    else
                    {
                        IsBool = false;
                        break;
                    }
                }
                sr.Close();
                fs.Close();
            }

            return IsBool;
        }

        /// <summary>
        /// Satılık ev bilgileri .txt dosyasına kaydediliyor .. 
        /// </summary>
        /// <param name="homeList"></param>
        public static void SaleHouseWriteToFile(List<Home> homeList)
        {
            if (File.Exists(Sale_TextFile))
            {
                FileStream fs = new FileStream(Sale_TextFile, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < homeList.Count; i++)
                {
                    sw.WriteLine(homeList[i].HomeInformation());
                }
                fs.Flush();
                sw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show(".txt dosyanız bulunamadı.!!",
                                "BİLGİLENDİRME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Kiralık ev bilgileri .txt dosyasına kaydediliyor .. 
        /// </summary>
        /// <param name="listHome"></param>
        public static void RentHouseWriteToFile(List<Home> listHome)
        {
            List<Home> homeInfo = new List<Home>();
            if (File.Exists(Rent_TextFile))
            {
                FileStream fs = new FileStream(Rent_TextFile, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < listHome.Count; i++)
                {
                    sw.WriteLine(listHome[i].HomeInformation());
                }
                fs.Flush();
                sw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show(".txt dosyanız bulunamadı.!!",
                                "BİLGİLENDİRME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Sorgulama ekranında kiralık ev bilgileri .txt dosyasından okunup kiralık sınıfına aktarılıyor .. Bir listede tüm bilgiler tutuluyor ... 
        /// </summary>
        public void HouseRentTextFileListReader()
        {
            HouseForRent kiralikEv = new HouseForRent();
            FileStream fs = new FileStream(Rent_TextFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string read = sr.ReadLine();
            string readerValue = "";

            while (read != null)
            {
                readerValue = read;
                string[] split = readerValue.Split(',');

                kiralikEv.NumberOfRooms = Convert.ToInt32(split[0]);
                kiralikEv.NumberOfFloors = Convert.ToInt32(split[1]);
                kiralikEv.District = split[2];
                kiralikEv.Area = Convert.ToInt32(split[3]);
                kiralikEv.DateOfConstructor = DateTime.Parse(split[4]);
                kiralikEv.Active = bool.Parse(split[5]);
                kiralikEv.HomeNumber = Convert.ToInt32(split[6]);

                if (TypeHome.Bahceli.ToString() == split[7])
                {
                    kiralikEv.IsType = TypeHome.Bahceli;
                }
                else if (TypeHome.Daire.ToString() == split[7])
                {
                    kiralikEv.IsType = TypeHome.Daire;
                }
                else if (TypeHome.Dubleks.ToString() == split[7])
                {
                    kiralikEv.IsType = TypeHome.Dubleks;
                }
                else if (TypeHome.Mustakil.ToString() == split[7])
                {
                    kiralikEv.IsType = TypeHome.Mustakil;
                }
                kiralikEv.Deposito = Convert.ToDecimal(split[8]);
                kiralikEv.Rent = Convert.ToDecimal(split[9]);
                kiralikEv.EvTipi = split[10];
                homeList.Add(kiralikEv);

                read = sr.ReadLine();
            }
            fs.Close();
            sr.Close();
        }

        /// <summary>
        /// Sorgulama ekranında satılık ev bilgileri .txt dosyasından okunup satılık sınıfına aktarılıyor .. Bir listede tüm bilgiler tutuluyor ... 
        /// </summary>
        public void HouseSaleTextFileReader()
        {
            FileStream fs = new FileStream(Sale_TextFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string read = sr.ReadLine();
            string readerValue = "";
            HouseForSale satilikEv = null;
            while (read != null)
            {
                satilikEv = new HouseForSale();
                readerValue = read;
                string[] split = readerValue.Split(',');

                satilikEv.NumberOfRooms = Convert.ToInt32(split[0]);
                satilikEv.NumberOfFloors = Convert.ToInt32(split[1]);
                satilikEv.District = split[2];
                satilikEv.Area = Convert.ToInt32(split[3]);
                satilikEv.DateOfConstructor = DateTime.Parse(split[4]);
                satilikEv.Active = bool.Parse(split[5]);
                satilikEv.HomeNumber = Convert.ToInt32(split[6]);

                if (TypeHome.Bahceli.ToString() == split[7])
                {
                    satilikEv.IsType = TypeHome.Bahceli;
                }
                else if (TypeHome.Daire.ToString() == split[7])
                {
                    satilikEv.IsType = TypeHome.Daire;
                }
                else if (TypeHome.Dubleks.ToString() == split[7])
                {
                    satilikEv.IsType = TypeHome.Dubleks;
                }
                else if (TypeHome.Mustakil.ToString() == split[7])
                {
                    satilikEv.IsType = TypeHome.Mustakil;
                }
                satilikEv.Price = Convert.ToDecimal(split[8]);
                satilikEv.EvTipi = split[9];
                homeList.Add(satilikEv);

                read = sr.ReadLine();
            }
            fs.Close();
            sr.Close();
        }

    }
}
