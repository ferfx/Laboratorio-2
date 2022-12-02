using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Ovelar_Primer_Parcial
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            
            

            Application.Run(new FormLogin());

            /*var admines = AdminDao.TraerAdmines();
            foreach (var persona in admines)
            {

                MessageBox.Show(persona.Apellido);
            }*/


        }
    }
}