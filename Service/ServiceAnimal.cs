using AnimalAppApi.Models;
using AnimalAppApi.Service.Interfaces;
using System.Text;

namespace AnimalAppApi.Service
{
    public class ServiceAnimal : IService
    {
        private static readonly string _animalPath = "Animals.txt";

        private IList<Animal> _animalList = new List<Animal>();

        private FileAnimal _fileAnimal = new FileAnimal();

        public Animal Create(PostAnimalModel postAnimalModel)
        {
            var animalWithId = new Animal();
            animalWithId.AnimalId = GetId();
            animalWithId.Weight = postAnimalModel.Weight;
            animalWithId.Height = postAnimalModel.Height;
            animalWithId.Species = postAnimalModel.Species;

            var animals = _fileAnimal.ReadAndDeserialize(_animalPath);
            animals.Add(animalWithId);
            _fileAnimal.WriteAndSerialize(_animalPath,animals);
            return animalWithId;
        }

        public IList<Animal> Delete(int animalId)
        {
            throw new NotImplementedException();
        }

        public IList<Animal> GetAll()
        {
            throw new NotImplementedException();
        }

        public Animal GetDetail(int animalId)
        {
            throw new NotImplementedException();
        }

        public Animal Put(int animalId)
        {
            throw new NotImplementedException();
        }

        //public ServiceAnimal(IList<Animal> animalList)
        //{
        //    _animalList = animalList;
        //}



        private int GetId()
        {
            if (_animalList.Count == 0)
                return 1;

            return _animalList.Max(animal => animal.AnimalId) + 1;
        }

    }
}
