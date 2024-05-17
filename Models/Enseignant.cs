using System.ComponentModel.DataAnnotations;

namespace GestionEnseignants.Models
{
    public class Enseignant
    {
        //Attributs :
        public int Id { get; set; }
        [Required]          //Obligatoire
        [StringLength(15, MinimumLength = 3)]
        [Display(Name = "Donner le nom :")]
        public string nom { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3)]
        [Display(Name = "Donner le prenom :")]
        public string prenom { get; set; }
        [DataType(DataType.Date)] //Fomat de date valide
        [Display(Name ="Donner la date de naissance de l'enseignant :")]
        public DateTime dateNais { get; set; }
        [Range(1, 5)] //Entre 1..5
        [Display(Name = "Donner le grade de l'enseignant :")]
        public string grd {  get; set; }
        [Display(Name = "Donner le departement ID de l'enseignant :")]
        public int departementId { get; set; }
        public Departement Departement { get; set; } 
    }
}
