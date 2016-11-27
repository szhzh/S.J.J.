using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriImena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter your whole name: ");
            string name = Console.ReadLine();
            //string name = "Светослав Живков Живков";
            for (int i = 0; i < name.Length; i++)
            {
                int code = (int)name[i];
                if (code >= 65 && code <= 90)
                {
                    if (name.Substring(i, name.Length - i).Contains(' ') == true)
                    {
                        Console.Write("{0}. ", name[i]);
                    }
                    if (name.Substring(i, name.Length - i).Contains(' ') == false)
                    {
                        Console.WriteLine(name.Substring(i, name.Length - i));
                    }
                }
            }
            //Console.Write("Моля, въведете цялото си име: ");
            //string name = Console.ReadLine();
            ////string name = "Светослав Живков Живков";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    int code = (int)name[i];
            //    if (code >= 1040 && code <= 1071)
            //    {
            //        if (name.Substring(i, name.Length - i).Contains(' ') == true)
            //        {
            //            Console.Write("{0}. ", name[i]);
            //        }
            //        if (name.Substring(i, name.Length - i).Contains(' ') == false)
            //        {
            //            Console.WriteLine(name.Substring(i, name.Length - i));
            //        }
            //    }
            //}



        }
    }
}
