using System.ComponentModel.DataAnnotations;

namespace GestionEnseignants.Models
{
    public class Departement
    {
        public int Id { get; set; }
        [Required]          //Obligatoire
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Nom de departement :")]
        public string depName { get; set; }
        [Required]          //Obligatoire
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Nom de responsable de departement :")]
        public string responsable { get; set; }
        public ICollection<Enseignant> enseignants { get; set;}
    }
}
