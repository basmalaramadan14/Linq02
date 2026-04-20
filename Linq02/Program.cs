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
            int totalUnits = Source.ProductList
            .Sum(p => p.UnitsInStock);
            Console.WriteLine(totalUnits);
            #endregion
            #region Q11
            #endregion
            #region Q12
            #endregion
            #region Q13
            #endregion
        }
    }
}
