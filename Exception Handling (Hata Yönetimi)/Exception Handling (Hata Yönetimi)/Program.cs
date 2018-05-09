using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exception_Handling__Hata_Yönetimi_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 0;
            try
            {
                int[] dizi = new int[2];
                dizi[2] = 10;

                Console.WriteLine(a / b);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Hata(IndexOutOfRangeException : " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Hata(DivideByZeroException : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Selçuk");
            }

            Console.ReadKey();
        }
    }
}

