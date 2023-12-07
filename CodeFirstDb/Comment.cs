using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb;

public class Comment
{
    [Key]
    [Required]
    public int CommentID { get; set; }

    public string CommentText { get; set; } 

}