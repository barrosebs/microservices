using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }
        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "d41d8cd98f00b204e9800998ecf8427e",
                    Name = "IPhone X",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure " +
                                    "dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident," +
                                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "d6e9c56d7f078d298ed4695d899effbe",
                    Name = "Samsung 10",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure " +
                                    "dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident," +
                                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-2.png",
                    Price = 1500.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "b6d767d2f8ed5d21a44b0e5886680cb9",
                    Name = "LG G7 ThinQ",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure " +
                                    "dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident," +
                                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-3.png",
                    Price = 3500.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "6c8349cc7260ae62e3b1396831a8398f",
                    Name = "iPhone 12 128GB",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure " +
                                    "dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident," +
                                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-4.png",
                    Price = 4400.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "886029c4aaf8c0d38cb80dc8ae0390db",
                    Name = "IPhone 11 128GB",
                    Description = "Lacus laoreet non curabitur gravida arcu ac tortor dignissim.Lacus laoreet non curabitur gravida arcu ac tortor dignissim. " +
                                    "Urna cursus eget nunc scelerisque. Vel eros donec ac odio tempor. Malesuada fames ac turpis egestas integer eget aliquet. " +
                                    "dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident," +
                                    " sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-5.png",
                    Price = 3800.00M,
                    Category = "Smart Phone"
                },
            };
        }
    }
}
