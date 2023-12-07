using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb;

public class Blog
{
    [Key]
    [Required]
    public int BlogID { get; set; }

    [MaxLength(50)]
    public string BlogTitle { get; set; }

    public string BlogContent { get; set;}

    public List<Comment> Comments { get; set; }

}