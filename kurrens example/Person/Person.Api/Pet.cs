namespace Person.Api
{
    public class Pet
    {
        public Pet(int id, string name, string species)
        {
            // regex validate name here, throw exception if it's invalid
            // same with species
            // in this case, leave the id to be validated by the code that is making the pet
            // ...

            Id = id;
            Name = name;
            Species = species;
        }

        public int Id { get; }
        public string Name { get; }
        public string Species { get; }
    }
}
