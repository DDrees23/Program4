using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //each 5 prodcuts get values using constructors from product class.  
            Product product1 = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4);
            Product product2 = new Product("Monster Beverage", "Monster Energy", 901643, "Beverage", 10.75, 5);
            Product product3 = new Product("PepsiCo", "Mtn Dew", 854221, "Beverage", 2.50, 5);
            Product product4 = new Product("The Coca-Cola Comapny", "Sprite", 862112, "Beverage", 2.50, 5);
            Product product5 = new Product("General Mills", "Cinnamon Toast Crunch", 521203, "Cereal", 4.99, 1);

            Console.WriteLine("List of products we sell:");
            Console.WriteLine("-------------------------------------------------------------");


            //throw products into array so we can just list and edit a specific arrray instead of having to keep on listing the five products. 
            Product[] productArray = { product1, product2, product3, product4, product5 };

            //Displays array
            DisplayProducts(productArray);

            
            Console.WriteLine("---------------------After Changes-------------------");
            
            //Changes are made to each specific product in the array. 
            productArray[0].ProductPrice = 3.00;
            productArray[1].InStock();
            productArray[2].ProductName = "Mountain Dew";
            productArray[3].SupplierName = "The Coca-Cola Company";
            productArray[4].InStock();


            //Displays array
            DisplayProducts(productArray);
        }


        //pre: a valid array of products are passed in
        //post: prodcuts are displayed via the string method. 
        public static void DisplayProducts(Product[] toDisplay)
        {
            foreach(Product product in toDisplay)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }

}
