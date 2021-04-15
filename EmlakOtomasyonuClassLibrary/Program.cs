using EmlakClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonuClassLibrary
{
    static class Program
    {
        #region Değişkenler
        public static bool kapali = true;
        public static Form acilacakForm;
        #endregion
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            while (!kapali)
            {
                kapali = true;
                Application.Run(acilacakForm);
            }
        }
    }
}
