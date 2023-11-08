using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//K7151
//CIS-199-01
//Program1
//9/29/2022
//This class handles the back end for building and maintaining products
namespace Program4
{
    class Product
    {
        private string _supplierName;
        private string _productName;
        private int _productID;
        private string _productType;
        private double _productPrice;
        private int _aisle;
        private bool _inStock;

        //built a contructor to be called upon in program class to call upong the following 
        //Pre: A supplier name, a product name, a product ID within the range of 100,000 and 999,999, a product type, a product type,
        //  a product price that is greater than zero, and a aisle in between numbers 1 through 20 is provided.
        //Post: A product is created.
        public Product (string supplierName, string productName, int productID, string productType, double productPrice, int aisle)
        {
            SupplierName = supplierName;
            ProductName = productName;
            ProductID = productID;
            ProductType = productType;
            ProductPrice = productPrice;
            Aisle = aisle;
            OutOfStock();
        }
        

        //gets and returns suppliername
        public string SupplierName
        {
            get; set;

        }

        //gets and returns product name
        public string ProductName
        {
            get; set;

        }

        //gets a value and returns a value that is inputed between 100,000 and 999,999, if not between these numbers, value of number is zero. 
        public int ProductID
        {
            //pre: N/A
            //post: Product ID is returned
            get
            {
                return _productID;
            }

            //pre: a product ID value higher than 100,000 and less than 999,999 is provided. 
            //post: product ID is updated to new value
            set
            {
                if(value > 100000 && value < 999999)
                {
                    _productID = value;
                }
                else
                {
                    _productID = 0;
                }
            }
        }
        
        //gets and returns product Type. (cereal or beverage)

        public string ProductType
        {
            get; set;

        }


        public double ProductPrice
        {

            //pre: N/A
            //post: Product Price is returned
            get
            {
                return _productPrice;
            }

            //pre: a value of price that is higher than zero is provided
            //post: Product price is updated to new value.
            set
            {
                if (value > 0)
                {
                    _productPrice = value;
                }
                else
                {
                    _productPrice = 0;
                }
            }
        }


        public int Aisle
        {
            //pre: N/A
            //post: Aisle is returned
            get
            {
                return _aisle;
            }
            set
            {
                //pre: a aisle value that is equal to or more than one, or equal to or less than twenty is provided
                //post: aisle is updated to new value.
                if (value >= 1 && value <= 20)
                {
                    _aisle = value;
                }
                else
                {
                    _aisle = 0;
                }
            }
        }
        
        //pre: N/A
        //post: The products inventory status is set to Instock
        public void InStock()
        {
            _inStock = true;
        }

        //Pre: N/A
        //post: The products inventory status is set to OutOfStock
        public void OutOfStock()
        {
            _inStock = false;
        }


        //Pre: N/A
        //Post: The products InStock status is returned
        public bool IsOutofStock()
        {
            return _inStock;
        }


        //Pre: N/A
        //Post: Product information is returned as a string
        public override string ToString()
        {
            return $"Supplier: {SupplierName}  {Environment.NewLine} " +
                    $"Product: {ProductName}  {Environment.NewLine} " +
                    $"ID: { ProductID}  {Environment.NewLine} " +
                    $"Category: {ProductType}  {Environment.NewLine} " +
                    $"Price: {ProductPrice}  {Environment.NewLine} " +
                    $"Aisle: {Aisle}  {Environment.NewLine} " +
                    $"In Stock: {IsOutofStock()}";
        }
    }//the override string to string fills in this string above with the input from the program class constructor.
}
