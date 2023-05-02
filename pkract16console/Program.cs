using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace pkract16console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива с использованием \"/\": ");
            string[] arr = Console.ReadLine().Split('/');
            int digCount = 0;
            foreach (string s in arr) {
                foreach (char c in s) {
                    if (char.IsDigit(c)) { digCount++; }
                }

            }
            Console.WriteLine($"Кол-во цифр в массиве: {digCount}");
            Console.WriteLine($"Элементы массива до символа \"/\": ");
            foreach (string s in arr) {
                if (s == "/")
                {
                    break;
                }
                if (s != "") { Console.WriteLine(s); }
               
            }
            Console.WriteLine($"Элементы массива после символа \"/\" в верхнем и нижнем регистрах:");
            foreach (string s in arr) {
                if (s == "/") { continue; }
                if (s == "") { break; }
                string news = "";
                foreach (char c in s)
                {
                    if (Char.IsUpper(c))
                    {
                        news += Char.ToLower(c);
                    }
                    else if (Char.IsLower(c))
                    {
                        news += Char.ToUpper(c);
                    }
                    else { news += c; }
                }
                Console.WriteLine(news);
                Console.WriteLine("Измененный массив записан в файл");
                StreamWriter st = new StreamWriter("mass.txt", true);
                st.WriteLine(news);
                st.Close();
            }
           
            
            Console.ReadKey();
        }
    }
}
