using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Actividad_Singleton
{
    internal class SessionManager_05CV
    {
        private static SessionManager_05CV instance;

        private SessionManager_05CV() { }

        public static SessionManager_05CV Instance()
        {
            if (instance == null)
            {
                instance = new SessionManager_05CV();
            }
            return instance;
        }
    }
}
