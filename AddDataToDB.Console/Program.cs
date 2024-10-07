using AddDataToDB.DAL;
using AddDataToDB.DAL.Entity;
using System.Xml.Linq;


XDocument xDoc = XDocument.Load("C:\\Users\\golub\\source\\repos\\AddDataToDB\\XMLFile1.xml");
var orders = xDoc.Descendants("order")
        .Select(order => new
        {

            OrderDate = (DateTime)order.Element("reg_date"),
            Sum = (decimal)order.Element("sum"),
            Users = order.Elements("user").Select(u => new User
            {
                FIO = u.Element("fio").Value,
                Email = u.Element("email").Value
            }).First()
           ,
            Products = order.Elements("product")
                .Select(p => new Product
                {
                    Count = Convert.ToInt32(p.Element("quantity").Value),
                    Name = (string)p.Element("name").Value,
                    Price = (decimal)p.Element("price")

                })
                .ToList()
        })
        .ToList();

using (ApplicationDbContext db = new())
{
    try
    {

        List<Product> products = new List<Product>();
        List<Order> order_prod = new List<Order>();

        for (int i = 0; i < orders.Count; i++)
        {
            db.Users.Add(orders[i].Users);
            db.SaveChanges();

            for (int j = 0; j < orders[i].Products.Count; j++)
            {
                if (!db.Products.Any(p => p.Name == orders[i].Products[j].Name))
                {
                    products.Add(new Product
                    {
                        Name = orders[i].Products[j].Name,
                        Price = orders[i].Products[j].Price
                    });
                }
            }

            foreach (var prod in products)
            {
                db.Products.Add(prod);
                db.SaveChanges();
            }

            order_prod.Add(new Order
            {
                UserId = orders[i].Users.Id,
                Date = DateOnly.FromDateTime(orders[i].OrderDate),
                Price = orders[i].Sum
            });
            db.Orders.Add(order_prod[i]);
            db.SaveChanges();

            for (int j = 0; j < orders[i].Products.Count; j++)
            {
                db.OrderedProducts.Add(new OrderedProducts
                {
                    OrderId = order_prod[i].Id,
                    ProductId = db.Products.Where(x => x.Name == orders[i].Products[j].Name).Select(x => x.Id).First(),
                    Count = (int)orders[i].Products[j].Count

                });
                db.SaveChanges();
            }

        }
        Console.WriteLine("Объекты успешно добавлены");
        Console.ReadKey();
    }
    catch (Exception ex) { Console.WriteLine(ex.Message); }
}





