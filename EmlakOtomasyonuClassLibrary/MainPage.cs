using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmlakClassLibrary;

namespace EmlakOtomasyonuClassLibrary
{
    public partial class MainPage : Form
    {
        public static bool IsAddHome = false;
        public static bool IsQuestionHome = false;

        #region CONSTRUCTOR
        public MainPage()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// İlan ekleme ekranı açılıyor .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEkle_Click(object sender, EventArgs e)
        {
            if (IsAddHome == false)
            {
                AddForm add = new AddForm();
                add.Show();
                IsAddHome = true;
            }
            else if (IsAddHome == true)
            {
                MessageBox.Show("Ekleme formu zaten açılmıştır. Açılan bir ekranı tekrar tekrar açamazsınız !! ",
                                "UYARI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// İlan listeleme ekranı açılıyor .. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxListele_Click(object sender, EventArgs e)
        {
            if (IsQuestionHome == false)
            {
                QuestionForm question = new QuestionForm();
                question.Show();
                IsQuestionHome = true;
            }
            else if (IsQuestionHome == true)
            {
                MessageBox.Show("Sorgulama formu zaten açılmıştır. Açılan bir ekranı tekrar tekrar açamazsınız !! ",
                                "UYARI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
        
    }
}
