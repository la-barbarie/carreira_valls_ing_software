using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Actividad_Singleton
{
    internal class SessionManager
    {
        private static SessionManager instance;

        private SessionManager() { }

        public static SessionManager Instance()
        {
            if (instance == null)
            {
                instance = new SessionManager();
            }
            return instance;
        }

    }
}
