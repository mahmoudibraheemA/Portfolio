namespace Core.Interfaces
{
    public interface IUnitofwork <T> where T : class
    {
        IGenericRepo<T> entity { get; }
        void Save();
    }
}
