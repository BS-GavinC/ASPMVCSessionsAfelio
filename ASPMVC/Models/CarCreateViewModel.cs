using System.ComponentModel.DataAnnotations;

namespace ASPMVC.Models;

public class CarCreateViewModel
{
    [Display(Name = "Marque de la voiture")]
    [Required(ErrorMessage = "Champ requis")]
    public string? Brand { get; set; }
    
    [Display(Name = "Modele de la voiture")]
    [Required(ErrorMessage = "Champ requis")]
    public string? Model { get; set; }
}