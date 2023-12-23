using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAmeliyatService
    {
        List<Ameliyat> GetAll();
        void Add(Ameliyat ameliyat);
        void DeleteById(int id);
        void Delete(Ameliyat ameliyat);
        void Update(Ameliyat ameliyat);
        Ameliyat GetById(int id);
    }
}
