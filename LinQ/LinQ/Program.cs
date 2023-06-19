//LINQ – Where Clause

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Creating List
            IList<string> productList = new List<string>()
            {
                "pincel",
                "canves book",
                "color",
                "paint",
                "paint palet",
                "paint palet",
                "sckitch book"


            };

            Filtering Data
            var result = from s in productList
                         where s.Contains("book")
                         select s;

            Printing Result
            foreach (string str in result)
            {
                Console.WriteLine(str.ToString());
            }
            Console.ReadKey();

        }
    }
}

//SELECT OPERATOR


using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "Milk", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "sweet", productPrice = 1400 });
            productList.Add(new ProductStore { productName = "chips", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "vegtable", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "sweet candy", productPrice = 7680 });


            //LINQ Query Syntax
            var result = from p in productList
                         where p.productPrice > 2000 && p.productPrice < 5000
                         select p;

            //LINQ Method Syntax. Uncomment it to see the result.
            //var result = productList.Select(p => p);

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}

//SELECTMANY OPERATOR 

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
        public List<string> Size { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result = from p in GetProductDetails()
                         select new { p.productName, p.productPrice, p.Size };
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }

        //Creating List of Product
        static List<ProductStore> GetProductDetails()
        {
            List<ProductStore> product = new List<ProductStore>
            {
            new ProductStore
                {
                productName = "Iphone 13",
                productPrice = 550,
                Size = new List<string>{"240GB","500GB","1TB"}
                },
            new ProductStore
                {
                productName = "samsung sr",
                productPrice = 230,
                Size = new List<string>{"4GB","8GB","16GB"}
                },
            new ProductStore
                {
                productName = "Hawawi",
                productPrice = 150,
                Size = new List<string>{"150GB","16GB","64GB"}
                }
            };
            return product;
        }
    }
}
//OrderBy

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
        public List<string> Size { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result = from p in GetProductDetails()
                         select p;
            foreach (var r in result.SelectMany(ProductStore => ProductStore.Size))
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }

        //Creating List of Product
        static List<ProductStore> GetProductDetails()
        {
            List<ProductStore> product = new List<ProductStore>
            {
            new ProductStore
                {
               productName = "Iphone 13",
                productPrice = 550,
               Size = new List<string>{"240GB","500GB","1TB"}
                },
            new ProductStore
                {
                productName = "samsung sr",
                productPrice = 230,
                Size = new List<string>{"4GB","8GB","16GB"}
                },
            new ProductStore
                {
                productName = "Hawawi",
                productPrice = 150,
                Size = new List<string>{"150GB","16GB","64GB"}
                }
            };
            return product;
        }
    }
}
//ORDERBYDESCENDING


using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "iphone 12", productPrice = 550 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 12 });
            productList.Add(new ProductStore { productName = "charger", productPrice = 20 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 45 });


            //LINQ Query Syntax
            var result = from p in productList
                         orderby p.productPrice
                         select p;

            //LINQ Method Syntax. Uncomment it to see the result.
            //var result = productList.OrderBy(p => p.productPrice);

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}

//THENBY PROGRAMMING

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "iphone 12", productPrice = 550 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 12 });
            productList.Add(new ProductStore { productName = "charger", productPrice = 20 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 45 });


            //LINQ Query Syntax
            var result = from p in productList
                         orderby p.productPrice descending
                         select p;

            //LINQ Method Syntax. Uncomment it to see the result.
            //var result = productList.OrderByDescending(p => p.productPrice);

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}

//REVERSE 


using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "iphone 12", productPrice = 550 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 120 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 235 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 12 });
            productList.Add(new ProductStore { productName = "charger", productPrice = 20 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 45 });

            var result = productList.OrderBy(p => p.productName).ThenBy(p => p.productPrice);

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}

//GroupBy
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "iphone 12", productPrice = 550 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 120 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 235 });
            productList.Add(new ProductStore { productName = "screen protecter", productPrice = 12 });
            productList.Add(new ProductStore { productName = "charger", productPrice = 20 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 45 });
            productList.Add(new ProductStore { productName = "RAM 42", productPrice = 48 });

            var result = productList.OrderBy(p => p.productPrice).Reverse();

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}
//MULTI KEY


using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public int category { get; set; }
        public string productName { get; set; }

        public string type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { category = 1, productName = "iphone 12", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "screen protecter", type = "Accessories" });
            productList.Add(new ProductStore { category = 1, productName = "screen protecter", type = "Acces" });
            productList.Add(new ProductStore { category = 1, productName = "screen protecter", type = "Acc" });
            productList.Add(new ProductStore { category = 2, productName = "charger", type = "tupse" });
            productList.Add(new ProductStore { category = 1, productName = "RAM", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "RAM 42", type = "MEMORY" });

            Query Syntax
            var result = from product in productList
                         group product by product.category;

            Method Syntax. Uncomment it to see the output
            var result = productList.GroupBy(p => p.category);

            foreach (var group in result)
            {
                Console.WriteLine(string.Format("Category: {0}", group.Key));
                foreach (var name in group)
                {
                    Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.productName, name.type));
                }
            }

            Console.ReadKey();
        }
    }
}

//GROUPING WITH SORTING

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public int category { get; set; }
        public string productName { get; set; }

        public string type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { category = 1, productName = "Hard Disk", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "Monitor", type = "DISPLAY" });
            productList.Add(new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" });
            productList.Add(new ProductStore { category = 1, productName = "RAM", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "Processor", type = "CPU" });
            productList.Add(new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" });
            productList.Add(new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" });

            Query Syntax
            var result = from product in productList
                         group product by new { product.category, product.type };

            Method Syntax. Uncomment it to see the output
            var result = productList.GroupBy(p => new { p.category, p.type });

            foreach (var group in result)
            {
                Console.WriteLine(string.Format("Category: {0} | Type: {1}", group.Key.category, group.Key.type));
                foreach (var name in group)
                {
                    Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.productName, name.type));
                }
            }

            Console.ReadKey();
        }
    }
}

//ToLookup Operator


using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public int category { get; set; }
        public string productName { get; set; }

        public string type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { category = 1, productName = "Hard Disk", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "Monitor", type = "DISPLAY" });
            productList.Add(new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" });
            productList.Add(new ProductStore { category = 1, productName = "RAM", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "Processor", type = "CPU" });
            productList.Add(new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" });
            productList.Add(new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" });

            //Query Syntax
            var result = from product in productList
                         group product by new { product.category, product.type } into pgroup
                         orderby pgroup.Key.category
                         select pgroup;


            //Method Syntax. Uncomment it to see the output 
            //var result = productList.GroupBy(p => new { p.category, p.type }).OrderBy(p => p.Key.category);

            foreach (var group in result)
            {
                Console.WriteLine(string.Format("Category: {0} | Type: {1}", group.Key.category, group.Key.type));
                foreach (var name in group)
                {
                    Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.productName, name.type));
                }
            }

            Console.ReadKey();
        }
    }
}

// Average, Count, Max, Sum,
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public int category { get; set; }
        public string productName { get; set; }

        public string type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { category = 1, productName = "RAM ", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "screen ", type = "DISPLAY" });
            productList.Add(new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" });
            productList.Add(new ProductStore { category = 1, productName = "RAM", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "Processor", type = "CPU" });
            productList.Add(new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" });
            productList.Add(new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" });

            var result = productList.ToLookup(p => p.category);

            foreach (var group in result)
            {
                Console.WriteLine(string.Format("Category: {0}", group.Key));
                foreach (var name in group)
                {
                    Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.productName, name.type));
                }
            }

            Console.ReadKey();
        }
    }
}
////}
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "Hard Disk", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "Monitor", productPrice = 3000 });
            productList.Add(new ProductStore { productName = "SSD Disk", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "Processor", productPrice = 7680 });
            productList.Add(new ProductStore { productName = "Bluetooth", productPrice = 540 });
            productList.Add(new ProductStore { productName = "Keyboard & Mouse", productPrice = 1130 });

            //LINQ Query Syntax
            var result = from p in productList
                         select p.productPrice;

            Console.WriteLine("Average: " + result.Average());
            Console.WriteLine("Count: " + result.Count());
            Console.WriteLine("Max: " + result.Max());
            Console.WriteLine("Min: " + result.Min());
            Console.WriteLine("Sum: " + result.Sum());
            Console.WriteLine("First Value: " + result.First());
            Console.WriteLine("Last Value: " + result.Last());
            Console.WriteLine("Is 3500 Available? " + result.Contains(3500));
            Console.WriteLine("Element at 4th Position: " + result.ElementAt(3));

            var distinctPrice = result.Distinct();
            Console.WriteLine("\n\n------- Distinct Result --------\n");
            foreach (var price in distinctPrice)
            {
                Console.WriteLine("Distinct Value: " + price.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
