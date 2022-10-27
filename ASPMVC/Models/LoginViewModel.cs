using System.ComponentModel.DataAnnotations;

namespace ASPMVC.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "Champ requis")]
    [EmailAddress(ErrorMessage = "Format invalide")]
    [Display(Name = "Adresse mail")]
    public string? Email { get; set; }
    
    [Required(ErrorMessage = "Champ requis")]
    [DataType(DataType.Password)]
    [Display(Name = "Mot de passe")]
    public string? Password { get; set; }
}