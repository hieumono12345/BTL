using BTL.DTO;
using DevExpress.Skins;
using DevExpress.UserSkins;
using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BTL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TTNguoiDung a = new TTNguoiDung(91,2,2);
            //TTNguoiDung x = new TTNguoiDung();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmThongBaoCV(a));
           Application.Run(new Login());
            //Application.Run(new frmCatGac(7,true));
        }
    }
}
