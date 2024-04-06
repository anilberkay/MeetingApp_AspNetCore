using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class UserInfo
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please enter your name!")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Please enter your phone number!")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "Please enter valid phone number.")]
    public string? Phone { get; set; }
    
    [Required(ErrorMessage = "Please enter your email!")]
    [EmailAddress(ErrorMessage = "Please enter valid email!")]
    public string? Email { get; set; }
    
    [Required(ErrorMessage = "Please choose one!")]
    public bool WillAttend { get; set; }
}