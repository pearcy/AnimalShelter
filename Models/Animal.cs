using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    private static List<Animal> _instances = new List<Animal> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<Type> Types { get; set; }

    public Animal(string animalName)
    {
      Name = animalName;
      _instances.Add(this);
      Id = _instances.Count;
      Types = new List<Type> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Animal> GetAll()
    {
      return _instances;
    }

    public static Animal Find(int searchId)
    {
      return _instances[searchId - 1];
    }


    public void AddType(Type type)
    {
      Types.Add(type);
    }
  }
}