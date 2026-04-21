using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Actividad_Singleton
{
    internal class SM_05_CV
    {
        private static SM_05_CV instance;

        private SM_05_CV() { }

        public static SM_05_CV Instance()
        {
            if (instance == null)
            {
                instance = new SM_05_CV();
            }
            return instance;
        }

    }
}
