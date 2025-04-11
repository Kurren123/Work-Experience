namespace Person.Api
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        private List<Pet> pets = [];

        // return a new list of pets, populated with the private list.
        // this is to stop anyone else from changing this person's list of pets
        public List<Pet> Pets => [.. pets];

        public Person(string name, int age, List<Pet> pets)
        {
            // validation logic here
            if (age <= 0)
            {
                throw new ArgumentOutOfRangeException("age", "Age must be greater than 0");
            }

            // validate the name with a regex here
            // ...

            this.Name = name;
            this.Age = age;
        }
    }
}
