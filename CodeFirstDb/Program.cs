using CodeFirstDb;

Console.WriteLine("Hello Db!");

using var db = new AppDbContext();

db.Blogs.Add
(
    new ()
    {
        BlogTitle = "Five Nights of Coding",
        BlogContent = "30 hours of C# in VisualStudios2022"
    }
);
db.Blogs.Add
(
    new ()
    {
        BlogTitle = "5 most popular ice-creams",
        BlogContent = "A list of the top-rated ice-creams of 2022 according to ITHS-students"
    }
);
db.Blogs.Add
(
    new ()
    {
        BlogTitle = "Upcomming upgrades",
        BlogContent = "Upcomming upgrades for Mac and Android devices"
    }
);

db.SaveChanges();
