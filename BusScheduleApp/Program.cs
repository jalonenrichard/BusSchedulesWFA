﻿using System;
using System.Windows.Forms;

namespace BusScheduleApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*BusRepository busRepository = new BusRepository();
            busRepository.DeleteAll();*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}