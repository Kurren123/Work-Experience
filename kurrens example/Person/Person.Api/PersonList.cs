namespace Person.Api
{
    public class PersonList
    {
        private readonly List<Person> people = [];

        public List<Person> GetAllPeople()
        {
            // return a copy of the list, otherwise the calling code can amend the list
            return [.. people];
        }

        public void AddPerson(string name, int age)
        {
            // Notice here that we are only asking for name and age.
            // We are giving the PersonList the responsibility of making the Person,
            // otherwise the calling code can give us a person with pets that have a non
            // unique ID
            people.Add(new Person(name, age, []));
        }

        public void AddPet(int personIndex, Pet pet)
        {
            // the following is wrong, as it's adding the pet to
            // a copy of the person's pets. If you call .Pets on that person afterwards,
            // you won't find the new pet there
            //
            // people[personIndex].Pets.Add(pet);

            // we remove the old person and create a new one at the same index
            Person oldPerson = people[personIndex];
            List<Pet> personsPets = oldPerson.Pets;
            personsPets.Add(pet);
            Person newPerson = new(oldPerson.Name, oldPerson.Age, personsPets);

            people[personIndex] = newPerson;
        }

        public void Save()
        {
            // serialise them to json, save to file
        }

        public void Load()
        {
            //load from file
        }
    }
}
