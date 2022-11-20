// See https://aka.ms/new-console-template for more information



//Scaffold-DbContext "Data Source=DESKTOP-P4GSONA;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer

using EFcore;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Result");

var dbContext = new NorthwindContext();

 

Console.WriteLine("Result");

//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--
//var lst = (new List<string>() { "x", "y" });
//var res = from order in dbContext.Orders
//          let lst2 = lst
//          where lst2.Any(l => order.ShipName.Contains(l))
//          select order.ShipName;

//The LINQ expression 'l => EntityShaperExpression: 
//    EFcore.Order
//    ValueBufferExpression: 
//        ProjectionBindingExpression: EmptyProjectionMember
//    IsNullable: False
//.ShipName.Contains(l)' could not be translated. Either rewrite the query in a form that 
//    can be translated, or switch to client evaluation explicitly by inserting a call 
//    to 'AsEnumerable ', 'AsAsyncEnumerable ', 'ToList ', or 'ToListAsync '.



//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--
//var lst = (new List<string>() { "x", "y" }).AsQueryable();
//var res = from order in dbContext.Orders
//          let lst2 = lst
//          where lst2.Any(l => order.ShipName.Contains(l))
//          select order.ShipName;

//The query contains a projection 'order => EnumerableQuery<string> { "x", "y" }' 
//    of type 'EnumerableQuery<string>'. Collections in the final projection must be an 'IEnumerable<T>' type such as 'List<T>'. 
//    Consider using 'ToList' or some other mechanism to convert the 'IQueryable<T>' or 'IOrderedEnumerable<T>' into an 'IEnumerable<T>'.



//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--
//var lst = (new List<string>() { "x", "y" }).AsQueryable();
//var res = from order in dbContext.Orders
//          let lst2 = lst.AsQueryable()
//          where lst2.Any(l => order.ShipName.Contains(l))
//          select order.ShipName;

//The query contains a projection 'order => EnumerableQuery<string> { "x", "y" }' 
//    of type 'EnumerableQuery<string>'. 
//    Collections in the final projection must be an 'IEnumerable<T>' type such as 'List<T>'. 
//    Consider using 'ToList' or some other mechanism to convert the 'IQueryable<T>' 
//    or 'IOrderedEnumerable<T>' into an 'IEnumerable<T>'



//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--
//var lst = (new List<string>() { "x", "y" }).AsQueryable();
//var res = from order in dbContext.Orders
//          where lst.Any(l => order.ShipName.Contains(l))
//          select order.ShipName;

//The LINQ expression 'EnumerableQuery<string> { "x", "y" }
//    .Any(l => NavigationTreeExpression
//        Value: EntityReference: Order
//        Expression: o.ShipName.Contains(l))' could not be translated. 
//    Either rewrite the query in a form that can be translated, 
//    or switch to client evaluation explicitly by inserting a call 
//    to 'AsEnumerable ', 'AsAsyncEnumerable ', 'ToList ', or 'ToListAsync '.



//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--
//var lst = new List<string>() { "x", "y" };
//var res = from order in dbContext.Orders
//          where lst.AsQueryable().Any(l => order.ShipName.Contains(l))
//          select order.ShipName;

//The LINQ expression 'EnumerableQuery<string> { "x", "y" }
//    .Any(l => NavigationTreeExpression
//        Value: EntityReference: Order
//        Expression: o.ShipName.Contains(l))' could not be translated. 
//    Either rewrite the query in a form that can be translated, 
//    or switch to client evaluation explicitly by inserting a call 
//    to 'AsEnumerable ', 'AsAsyncEnumerable ', 'ToList ', or 'ToListAsync '.



//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--
//var lst = new List<string>() { "x", "y" };
//var res = from order in dbContext.Orders
//          where lst.Any(x => order.ShipName.Contains("x"))
//          select order.ShipName;

//The LINQ expression 'x => EntityShaperExpression: 
//    EFcore.Order
//    ValueBufferExpression: 
//        ProjectionBindingExpression: EmptyProjectionMember
//    IsNullable: False
//.ShipName.Contains("x")' could not be translated. Either rewrite the query in a form that can be translated, 
//    or switch to client evaluation explicitly by inserting a call to 'AsEnumerable ', 
//    'AsAsyncEnumerable ', 'ToList ', or 'ToListAsync '.

//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--

//var lst = new List<string>() { "x", "y" };
//var res = from order in dbContext.Orders
//          where lst.Any(x=>true)
//          select order.ShipName;

//The LINQ expression 'x => True' could not be translated. Either rewrite the query in a form that can be translated,
//    or switch to client evaluation explicitly by inserting a call to 'AsEnumerable', 'AsAsyncEnumerable', 'ToList', or 'ToListAsync'.

//----------------------------------------------------------------------------------------------------------------------------------
//---------DON'T WORK--

//var lst = new List<string>() { "x", "y"};
//var res = from order in dbContext.Orders
//          where lst.Any(l=>order.ShipName.Contains(l))
//          select order.ShipName;


//The LINQ expression 'l => EntityShaperExpression: 
//    EFcore.Order
//    ValueBufferExpression: 
//        ProjectionBindingExpression: EmptyProjectionMember
//    IsNullable: False
//.ShipName.Contains(l)' could not be translated. Either rewrite the query in a form that can be translated, 
//    or switch to client evaluation explicitly by inserting a call to 'AsEnumerable ', 'AsAsyncEnumerable ', 
//    'ToList ', or 'ToListAsync '. See https://go.microsoft.com/fwlink/?linkid=2101038 for more information.

//----------------------------------------------------------------------------------------------------------------------------------
//  WORK
//var res = from order in dbContext.Orders
//          where order.ShipName.Contains("x")
//          select order.ShipName;

//----------------------------------------------------------------------------------------------------------------------------------
//var tmp = dbContext.Orders.FromSql($"select * from Orders"); 

//----------------------------------------------------------------------------------------------------------------------------------
// asnotracking() почти не дал результат на огромной выборке, хотя мог бы
