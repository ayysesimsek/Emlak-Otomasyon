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
    public partial class Login : Form
    {
        public string users_TextFile = @"../../users.txt";

        #region CONSTRUCTOR
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT
        /// <summary>
        /// Giriş yap butonu ve gerçekleşecek olaylar tanımlanmaktadır .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!LoginEmptyControl())
            {
                if (FileWriteOrFileReadClasses.LoginReadFile(txtUsernama, txtPassword) == true)
                {
                    MainPage go = new MainPage();
                    this.Hide();
                    go.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifreniz hatalı !! \nLütfen giriş bilgilerinizi kontrol edip tekrar giriş yapınız . ",
                                    "BİLDİRİ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk);
                }
            }
        }

        /// <summary>
        /// Login ekranına girerken kullanıcı adı ve şifre kısmı boş geçilemez kontrolü yapılıyor ... 
        /// </summary>
        /// <returns></returns>
        public bool LoginEmptyControl()
        {
            bool returnObject = false;
            if (String.IsNullOrEmpty(txtUsernama.Text) ||
              String.IsNullOrEmpty(txtUsernama.Text))
            {
                MessageBox.Show("Sisteme girebilmek için kullanıcı adı ve şifrenizi tam olarak girmiş olmalısınız .. \nAksi taktirde sisteme giriş yapamazsınız !",
                                "UYARI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                returnObject = true;
            }
            return returnObject;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
