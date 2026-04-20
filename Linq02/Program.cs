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
            bool allInStock = Source.ProductList
    .Where(p => p.Category == "Seafood")
    .All(p => p.UnitsInStock > 0);

            Console.WriteLine(allInStock);
            #endregion

            #region Q05
            #endregion
            #region Q06
            #endregion
            #region Q07
            #endregion
            #region Q08
            #endregion
            #region Q09
            #endregion
            #region Q10
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
