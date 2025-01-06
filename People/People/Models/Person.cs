namespace People.Models;
using SQLite;

[Table("People")]
public class Person
{
    [PrimaryKey]
    public int Id { get; set; }
    [MaxLength(250), Unique]
    public string Name { get; set; }

}
