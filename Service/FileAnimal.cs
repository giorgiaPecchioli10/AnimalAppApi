using AnimalAppApi.Models;
using System.Text.Json;

namespace AnimalAppApi.Service
{
    public class FileAnimal
    {
        public void WriteAndSerialize(string path, List<Animal> animals)
        {            
            string json = JsonSerializer.Serialize(animals);
            File.WriteAllText(path,json);
        }

        public List<Animal> ReadAndDeserialize(string path)
        {
            string json = File.ReadAllText(path);

            if (json == string.Empty)
            {
                return new List<Animal>();
            }
            else
            {
                List<Animal> animals = JsonSerializer.Deserialize<List<Animal>>(json);
                return animals;
            }
        }

        //public static string Read(string path)
        //{
        //    return File.ReadAllText(path);
        //}



        //private string Serializer(List<Animal> animalsList)
        //{
        //    return JsonSerializer.Serialize(animalsList);
        //}
        //private static List<Animal> Deserialize(string json)
        //{
        //    return JsonSerializer.Deserialize<List<Animal>>(json);
        //}




    }
}
