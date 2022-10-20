using OOP_9_IEnumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9_IEnumerators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<Product>()
            {
                new Product() { ProductId = 1 , ProductName = " Buzdolabı", Price = 8500},
                new Product() { ProductId = 2 , ProductName =  " Ocak", Price =  5800 },
                new Product() { ProductId = 3 , ProductName = " Kahve Makinesi ", Price =  3000 },
                new Product() { ProductId = 4 , ProductName = " Bulaşık Makinesi ", Price =  4000 },
                new Product() { ProductId = 5 , ProductName =" Fırın ", Price = 8250},
            };
            foreach (var product in collection)
            {
                Console.WriteLine($"{product.ProductId}" +
                    $"{product.ProductName}" +
                    $"{product.Price}");
            }
            Console.WriteLine("\n");
            //IEnumerator generic bir ifadedir bu yüzden <> arasına bir type yazmak gerekir.
            // GetEnumerator Generic bir list return eder. Yani list of prodcut döner.
            IEnumerator<Product> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Current.ProductId}" +
                    $"{enumerator.Current.ProductName}" +
                    $"{enumerator.Current.Price}");
            }
            Console.ReadLine();
        }
    }
}
/* MoveNext () = Eğer mevcut örnekten sonra bir tane daha örnek varsa true döner(while döngüsü devam eder)
                 Ne zaman ki örnek yoksa o zaman false döner ve while döngüsü sonlanır.
                 Bu mantıkla her defasında bir örnek alacak şekilde ilerlemiş oluruz.

IEnumerator ifademizde üzerinde bulunduğumuz örneği  Current ifadesi ile temsil ederiz.(Döngüyü Current ifadesiyle dolaşmış oluruz)
Kısaca IEnumerator ile foreeach döngüsü yerine kullanmış oluruz. (Listeyi IEnumerator ile yazdırdık)
*/
