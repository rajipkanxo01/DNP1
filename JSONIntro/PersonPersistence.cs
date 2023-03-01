using System.Text.Json;

namespace JSONIntro;

public class PersonPersistence
{
    public void StoreObjects(List<Person> persons)
    {
        string personAsJson = JsonSerializer.Serialize(persons, new JsonSerializerOptions()
        {
            WriteIndented = true
        });
        File.WriteAllText("Persons.txt", personAsJson);
    }

    public void ReadObjects()
    {
        string allText = File.ReadAllText("Persons.txt");
        List<Person>? person = JsonSerializer.Deserialize<List<Person>>(allText);
        foreach (var person1 in person)
        {
            Console.WriteLine(person);
        }        
    }
}