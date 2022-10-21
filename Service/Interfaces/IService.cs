using AnimalAppApi.Models;

namespace AnimalAppApi.Service.Interfaces
{
    public interface IService
    {
        public Animal Create(PostAnimalModel animal);
        public IList<Animal> GetAllAnimal();
        public Animal GetDetail(int animalId);
        public Animal Put(int animalId);
        public IList<Animal> Delete(int animalId);

    }
}
