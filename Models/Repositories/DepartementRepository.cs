
namespace GestionEnseignants.Models.Repositories
{
    public class DepartementRepository : IDepartementRepository <Departement>
    {
        private readonly EnseignantContext context;

        //Constructor :
        public DepartementRepository(EnseignantContext context)
        {
            this.context = context;
        }

        //Add Departement methode  
        public void Add(Departement e)
        {
            context.Departements.Add(e);
            context.SaveChanges();
        }
        //Delete Departement methode 
        public void Delete(Departement e)
        {
            Departement d1 = context.Departements.Find(e.Id);
            if (d1 != null)
            {
                context.Remove(d1);
                context.SaveChanges();
            }
        }
        //Edit methode 
        public void Edit(Departement e)
        {
            Departement d1 = context.Departements.Find(e.Id);
            if(d1 != null)
            {
                d1.depName=e.depName;
                d1.responsable=e.responsable;
                context.SaveChanges(); 
            }
        }
        //Methode to return AVG age of the Enseignant in a specific Departement
        public double EnseignantAgeAverage(int departementId)
        {
            throw new NotImplementedException();
        }
        //Methode to return the number of enseignant for a dep
        public int EnseignantCount(int departementId)
        {
            return context.Enseignants.Where(e => e.Id == departementId).Count();  
        }
        //Methode to get all the Departement
        public IList<Departement> GetAll()
        {
            return context.Departements.OrderBy( d => d.depName).ToList();
        }
        //Methode to get a specific Departement by idDep
        public Departement GetById(int id)
        {
            return context.Departements.Find(id);
        }
    }
}
