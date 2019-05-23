using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meflix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Idea para no terminar el programa una vez que se cierra el forms principal, sacada de:
            // {https://es.stackoverflow.com/questions/38427/c%C3%B3mo-cerrar-un-form-en-c-y-que-se-habra-otro}

            InicioSesión main = new InicioSesión();
            main.FormClosed += MainForm_Closed; 
            main.Show();
            Application.Run();
        }


        //Idea para terminar el programa una vez que ya no hay ventanas abiertas, sacada de:
        // {https://stackoverflow.com/a/10769349/4955425}

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }

        }
    }
}
