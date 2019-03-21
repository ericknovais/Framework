using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Resource_Exemple
{
    class ResorceHelper
    {
        public static string getResorce(string key)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(typeof(System.Resource_Exemple.Main));
            return rm.GetString(key);
        }      
    }
}
