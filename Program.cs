using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3_Actividad_Singleton
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // No compila, pues el constructor es privado
            //SessionManager_05CV sessionManager = new SessionManager_05CV(); 

            SessionManager_05CV instance = SessionManager_05CV.Instance();
            
            if (instance == null)
            {
                Console.WriteLine("Instancia null, ERROR");
            } else
            {
                SessionManager_05CV instance2 = SessionManager_05CV.Instance();
                
                if (instance != instance2)
                {
                    throw new Exception("Singleton no funciona!");
                } else
                {
                    Console.WriteLine("Ambas instancias son la misma instancia");
                }
            }
        }
    }
}
