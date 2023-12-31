using DarAlArqamForm.Forms;
using DarAlArqamForm.Models;
using DarAlarqamProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new UserLogin());
         // Application.Run(new studentdata());
        //  Application.Run(new Teachersalary());
       //    Application.Run(new DarAlArqam());
      //  Application.Run(new AddStudent());
          

        }
    }
}
