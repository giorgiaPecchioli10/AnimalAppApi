namespace AnimalAppApi.Service.Interfaces
{
    public interface IService
    {
        public T Create<T>(T ojb);
        public IEnumerable<T> GetAll<T>();
        public T GetDetail<T>(int id);
        public T Put<T>(int id);
        public IEnumerable<T> Delete<T>(int id);

    }
}
