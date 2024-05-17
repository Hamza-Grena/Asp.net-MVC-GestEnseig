namespace GestionEnseignants.Models.Repositories
{
    public interface IDepartementRepository <Departement>
    {
        //Methodes Abstrait :
        IList<Departement> GetAll();
        Departement GetById(int id);
        void Add(Departement e);
        void Edit(Departement e);
        void Delete(Departement e);
        double EnseignantAgeAverage(int departementId);
        int EnseignantCount(int departementId);
    }
}
