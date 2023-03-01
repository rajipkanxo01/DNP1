// See https://aka.ms/new-console-template for more information

using JSONIntro;

Person p1 = new Person("Rajib", "Paudyal", 20, 172, false, 'M', new[] { "Playing Games", "Sleeping" });
Person p2 = new Person("Pramesh", "Shrestha", 17, 172, true, 'M', new[] { "Teaching", "Singing" });
Person p3 = new Person("Suhani", "Pandey", 20, 152, false, 'F', new[] { "Beating Rajib" });

List<Person> persons = new List<Person>
{
    p1,
    p2,
    p3
};

PersonPersistence pp = new PersonPersistence();
pp.StoreObjects(persons);
pp.ReadObjects();

// Console.WriteLine(personAsJson);