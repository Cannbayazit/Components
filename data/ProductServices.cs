using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.data
{
    public class ProductServices
    {

        List<Product> products = new List<Product>()
        {

            new Product(){ProductId=1,ProductName="Computer",Price=5000,PurchaseDate=Convert.ToDateTime("01-Mar-2019"),Photo=photoString},
            new Product(){ProductId=2,ProductName="Leptop",Price=6000,PurchaseDate=Convert.ToDateTime("02-Mar-2019"),Photo=photoString},
            new Product(){ProductId=3,ProductName="Watch",Price=500,PurchaseDate=Convert.ToDateTime("03-May-2019"),Photo=photoString},
            new Product(){ProductId=4,ProductName="Gun",Price=15000,PurchaseDate=Convert.ToDateTime("04-Apr-2019"),Photo=photoString},
            new Product(){ProductId=5,ProductName="Desk",Price=2000,PurchaseDate=Convert.ToDateTime("05-Mar-2019"),Photo=photoString},
            new Product(){ProductId=6,ProductName="Computer",Price=5000,PurchaseDate=Convert.ToDateTime("01-Mar-2019"),Photo=photoString},
            new Product(){ProductId=7,ProductName="Leptop",Price=6000,PurchaseDate=Convert.ToDateTime("02-Mar-2019"),Photo=photoString},
            new Product(){ProductId=8,ProductName="Watch",Price=500,PurchaseDate=Convert.ToDateTime("03-May-2019"),Photo=photoString},
            new Product(){ProductId=9,ProductName="Gun",Price=15000,PurchaseDate=Convert.ToDateTime("04-Apr-2019"),Photo=photoString},
            new Product(){ProductId=10,ProductName="Desk",Price=2000,PurchaseDate=Convert.ToDateTime("05-Mar-2019"),Photo=photoString},
            new Product(){ProductId=11,ProductName="Computer",Price=5000,PurchaseDate=Convert.ToDateTime("01-Mar-2019"),Photo=photoString},
            new Product(){ProductId=12,ProductName="Leptop",Price=6000,PurchaseDate=Convert.ToDateTime("02-Mar-2019"),Photo=photoString},
            new Product(){ProductId=13,ProductName="Watch",Price=500,PurchaseDate=Convert.ToDateTime("03-May-2019"),Photo=photoString},
            new Product(){ProductId=14,ProductName="Gun",Price=15000,PurchaseDate=Convert.ToDateTime("04-Apr-2019"),Photo=photoString},
            new Product(){ProductId=15,ProductName="Desk",Price=2000,PurchaseDate=Convert.ToDateTime("05-Mar-2019"),Photo=photoString}

        };


        public static string photoString = "data:image/jpeg;base64,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";

        public async Task<List<Product>> ProductList()
        {

            return await Task.FromResult(products);


        }

    }
}