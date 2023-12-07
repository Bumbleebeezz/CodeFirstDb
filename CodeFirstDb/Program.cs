using CodeFirstDb;

Console.WriteLine("Hello Db!");

using var db = new AppDbContext();


Console.Write("Enter Author name: ");
string name = Console.ReadLine();
db.Authors.Add
(
    new Author
    {
        AuthorID = 1,
        AuthorName = name,
        Blogs = null
    }
);

//db.SaveChanges();
