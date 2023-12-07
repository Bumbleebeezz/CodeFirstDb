using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb;

public class Author
{
    [Key]
    public int AuthorID { get; set; }

    [Required]
    [MaxLength(50)]
    public string AuthorName { get; set; }

    public List<Blog> Blogs { get; set; } 
}