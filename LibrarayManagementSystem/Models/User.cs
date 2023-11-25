namespace LibrarayManagementSystem.Models;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int RoleId { get; set; }
    public int IsActive { get; set; }
    public DateTime TimeStamps { get; set; }
}
