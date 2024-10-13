using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20233007_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SwitchCase
            //SwitchCase mekanizması if-else mekanizmasında olduğu gibi karşılaştırma işlemi yapmamızı sağlayan bir mekanizmadır
            //Yalnız mekanizma içerisinde sadece eşitlik sorgulaması yapılır.if-else mekanızmasındaki olduğu gibi komplike sorgular yapılamaz

            //Syntax
            //Switch(değer)   //Switch içerisinde karşılaştıralacak değer girilir
            //{
            //case <karşılaştıralacak değer>: /switch içerisindeki değer bu değere eşit ise içerisindeki komut satırları işleme alınır
            //Komut Satırları
            //Komut Satırları
            //break; //Mekanizmayı sonlandırmak içi kullanılır.Bu durumda bu case sonlanır
            //case <karşılaştıralacak değer>:
            //Komut Satırları
            //Komut Satırları
            //break;
            //default: //Yazılması zorunlu değildir.Case içerisindeki karşılaştırmaların doğruluğu sağlanmadığında default içerisinde komut satırlarını işleme alır.if mekanizmasındaki else mantığında çalışır
            //Komut Satırları
            //Komut Satırları
            //Komut Satırları
            //break;

            //Kullanıcıdan 1-12 arası bir değer girmesini talep edelim
            //Girilen değere göre ay bilgisini dönelim

            Console.WriteLine("1-12 arasında bir sayı giriniz : ");
            int ay =int.Parse(Console.ReadLine());

            switch (ay)
            {
                case 1:
                    Console.WriteLine("OCAK");
                    break;

                    case 2:
                    Console.WriteLine("ŞUBAT");
                    break;

                case 3:
                    Console.WriteLine("MART");
                    break;

                    case 4:
                    Console.WriteLine("NİSAN");
                    break;

                case 5:
                    Console.WriteLine("MAYIS");
                    break;

                    case 6:
                    Console.WriteLine("HAZİRAN");
                    break;

                    case 7:
                    Console.WriteLine("TEMMUZ");
                    break;

                    case 8:
                    Console.WriteLine("AĞUSTOS");
                    break;

                    case 9:
                    Console.WriteLine("EYLÜL");
                    break;

                    case 10:
                    Console.WriteLine("EKİM");
                    break;

                    case 11:
                    Console.WriteLine("KASIM");
                    break;

                    case 12:
                    Console.WriteLine("ARALIK");
                    break;

                default:
                    Console.WriteLine("1-12 arası bir sayı girmelisiniz");
                    break;


            }
            Console.ReadKey();
        }
    }
}
