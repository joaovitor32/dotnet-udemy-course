using _02_person.Model;

namespace _02_person.Services.Implementations
{
    public class PersonServiceImplemantation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public Person Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i=0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                id = IncrementAndGet(),
                FirstName = "João Vitor" + i,
                LastName = "Muniz Lopes" + i,
                Address = "Endereco",
                Gender = "Male"
            };
        }

        public Person FindById(long id)
        {
            return new Person
            {
                id = IncrementAndGet(),
                FirstName = "João Vitor",
                LastName = "Muniz Lopes",
                Address = "Endereco",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return new Person
            {
                id = IncrementAndGet(),
                FirstName = "João Vitor",
                LastName = "Muniz Lopes",
                Address = "Endereco",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
