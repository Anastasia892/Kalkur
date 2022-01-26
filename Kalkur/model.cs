using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kalkur
{
   static class model
    {
        static int one = 0;
        static float two = 0;
        static int id = 0;
        static float itog;
        public static List<string> datalist = new List<string> { "Сложение", "Умножение", "Вычитание", "Деление" };
       
        public static TextBox tbItog;

        public static int oneSV
        {
            set
            {
                one = value;
            }
        }
        public static float twoSV
        {
            set
            {
                two = value;
            }
        }
        public static int  idSV
        {
            set
            {
                id = value;
            }
        }
        public static string Rezultat
        {
            get
            {
                switch(id)
                {
                    case 0:
                        itog = one + two;
                        return tbItog.Text=(itog).ToString();
                    case 1:
                        itog = one * two;
                        return tbItog.Text = (itog).ToString();
                    case 2:
                        itog = one - two;
                        return tbItog.Text = (itog).ToString();
                    case 3:
                        itog = one / two;
                        return tbItog.Text = (itog).ToString();
                    default:
                        
                        return "Введите снова";


                }


            }
        }

        public static string Combo
        {
           

            get
            {
                switch (id)
                {
                    case 0:

                        return "+";
                    case 1:

                        return "*";
                    case 2:

                        return "-";
                    case 3:

                        return "/";
                    default:

                        return "Введите снова";

                }

            }
        }
    }
}
