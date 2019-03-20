using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System.Globalization_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calender
            DateTime dt1 = DateTime.Now;

            DateTime dt = new DateTime(2012, 1, 1, new JapaneseCalendar());
            dt.AddHours(3);

            DateTime dt2 = DateTime.Now;

            TimeSpan ts = dt2.Subtract(dt1);
            #endregion

            #region CultureInfo
            CultureInfo ci = new CultureInfo("pt-BR");
            string dia;
            for (int i = 0; i < ci.DateTimeFormat.DayNames.Length; i++)
            {
                dia = ci.DateTimeFormat.DayNames[i].ToUpper();
                Console.WriteLine(dia);
            }
            Console.Write("");
            string mes;
            for (int i = 0; i < ci.DateTimeFormat.MonthNames.Length; i++)
            {

                mes = ci.DateTimeFormat.MonthNames[i].ToUpper();
                Console.WriteLine(mes);
            }
          
            Console.ReadKey();
            #endregion

        }
    }
}
