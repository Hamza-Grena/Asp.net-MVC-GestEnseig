using Microsoft.EntityFrameworkCore;
using System.Linq;
using GestionEnseignants.Models;

namespace GestionEnseignants.Models.Repositories
{
    public class EnseignantRepository : IEnseignantRepository <Enseignant>
    {
        private readonly EnseignantContext context;

        //Constructor :
        public EnseignantRepository(EnseignantContext context)
        {
            this.context = context;
        }
        //Methodes Implements :
        //Return Deps ordered by Name
        public  IList<Enseignant> GetAll()
        {
            return context.Enseignants.OrderBy(e => e.nom).Include(e => e.Departement).ToList();
        }
        //Return Enseignant by id 
        public Enseignant GetById(int id)
        {
            return context.Enseignants.Where(e => e.Id == id).Include(e => e.Departement).SingleOrDefault();
        }
        //Add a new Enseignant 
        public void Add(Enseignant e)
        {
            context.Enseignants.Add(e);
            context.SaveChanges();
        }
        //Return an Enseignant by idEns
        public void Edit(Enseignant e)
        {
            Enseignant e1 = context.Enseignants.Find(e.Id);
            if(e1 != null) 
            {
                e1.nom = e.nom;
                e1.prenom = e.prenom;
                e1.dateNais = e.dateNais;
                e1.grd = e.grd;
                e1.Id =e.Id;
                context.SaveChanges();
            }
        }
        //Delete an Ens by his idEns
        public void Delete (Enseignant e)
        {
            Enseignant e1 = context.Enseignants.Find(e.Id);
            if(e1 != null)
            {
                context.Enseignants.Remove(e1);
                context.SaveChanges();
            }
        }
        //Methode to return list of Enseignant to a specifique Departement
        public IList<Enseignant> getEnseignantByDeplId(int? depId)
        {
            return context.Enseignants.Where(e 
                => e.Id.Equals(depId))
                .OrderBy(e => e.nom)
                .Include(ens => ens.Departement).ToList();

        }
        //Methode to return an Enseignant by Name 
        public IList<Enseignant> findByName(string name)
        {
            return context.Enseignants.Where(s => s.nom.Contains(name)).Include(ens => ens.Departement).ToList();
        }

    }
}
