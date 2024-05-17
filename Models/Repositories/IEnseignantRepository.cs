namespace GestionEnseignants.Models.Repositories
{
    public interface IEnseignantRepository <Enseignant>
    {
        //Methodes Abstrait :
        IList<Enseignant> GetAll();
        Enseignant GetById(int id);
        void Add(Enseignant e);
        void Edit(Enseignant e);
        void Delete(Enseignant e);
        // double EnseignantAgeAverage(int departementId);
        //int EnseignantCount(int departementId);
        IList<Enseignant> getEnseignantByDeplId(int? depId);
        IList<Enseignant> findByName(string nom);

        
    }
}
