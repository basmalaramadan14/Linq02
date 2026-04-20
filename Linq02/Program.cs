using Linq02.DataSources;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //        var result = Source.ProductList
            //.OrderByDescending(p => p.UnitPrice)
            //.Take(3);

            //        foreach (var p in result)
            //        {
            //            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //        }
            #endregion


            #region Q02
            //int pageSize = 5;
            //int pageNumber = 2;

            //var result = Source.ProductList
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName}");
            //}
            #endregion

            #region Q03
            //        var result = Source.ProductList
            //.OrderBy(p => p.UnitPrice)
            //.TakeWhile(p => p.UnitPrice < 25);

            //        foreach (var p in result)
            //        {
            //            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //        }
            #endregion

            #region Q04
            //        bool allInStock = Source.ProductList
            //.Where(p => p.Category == "Seafood")
            //.All(p => p.UnitsInStock > 0);

            //        Console.WriteLine(allInStock);
            #endregion

            #region Q05
            //int[] ids = { 3, 9, 13, 18 };

            //bool contains9 = ids.Contains(9);

            //Console.WriteLine(contains9);
            #endregion
            #region Q06
            //        var result = Source.ProductList
            //.GroupBy(p => p.Category);

            //        foreach (var group in result)
            //        {
            //            Console.WriteLine($"{group.Key} - {group.Count()}");
            //        }
            #endregion
            #region Q07 
            //        var result = Source.ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    Products = g.Select(p => p.ProductName)
            //});

            //        foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.Products)
            //    {
            //        Console.WriteLine($"{name}");
            //    }
            //}
            #endregion
            #region Q08
            //        var result = Source.ProductList
            //.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);

            //        foreach (var category in result)
            //        {
            //    Console.WriteLine(category);
            //}
            #endregion
            #region Q09
            //        var result =
            //from c in Source.CustomerList
            //group c by c.Country into g
            //select new
            //{
            //    Country = g.Key,
            //    Count = g.Count(),
            //    TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
            //};

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Country} - {item.Count} - {item.TotalOrderValue}");
            //}
            #endregion
            #region Q10
            //int totalUnits = Source.ProductList
            //.Sum(p => p.UnitsInStock);
            //Console.WriteLine(totalUnits);
            #endregion
            #region Q11
            var cheapest = Source.ProductList.Min(p => p.UnitPrice);
            var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);

            Console.WriteLine($"Cheapest: {cheapest}");
            Console.WriteLine($"Most Expensive: {mostExpensive}");
            #endregion
            #region Q12
            //        var categories = Source.ProductList
            //.Select(p => p.Category)
            //.Distinct();

            //        foreach (var c in categories)
            //        {
            //            Console.WriteLine(c);
            //        }
            #endregion
            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1
            //    .Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}
            #endregion
            #region Q15
            // var dict = Source.ProductList
            //.ToDictionary(p => p.ProductID);

            // var product = dict[18];

            // Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            #endregion
            #region Q16
            //var product = Source.ProductList
            //.First(p => p.UnitPrice > 50);

            //Console.WriteLine(product.ProductName);
            #endregion
            #region Q17
            //        var product = Source.ProductList
            //.FirstOrDefault(p => p.UnitPrice > 500);

            //        if (product != null)
            //        {
            //            Console.WriteLine(product.ProductName);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No product found");
            //        }
            #endregion
            #region Q18
            //var result = Enumerable.Range(1, 10)
            //.Select(n => 7 * n);

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q19
            //var evens = Enumerable.Range(1, 30)
            //   .Where(n => n % 2 == 0);

            //foreach (var n in evens)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region Q20
            var products = Source.ProductList
              .Select(p => p.ProductName)
          .Take(3);

            var customers = Source.CustomerList
                .Select(c => c.CompanyName)
            .Take(3);

            var result = products.Concat(customers);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Q21

            #endregion
        }
    }
}
