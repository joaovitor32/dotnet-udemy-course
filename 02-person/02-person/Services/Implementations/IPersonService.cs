using _02_person.Model;

namespace _02_person.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        Person Delete(long id);
    }
}
