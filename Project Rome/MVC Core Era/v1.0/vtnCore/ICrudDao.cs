namespace vtnCore
{
    public interface ICrudDao<T>
    {
        void Create(T Entidade);
        void Update(T Entidade);
        void Delete(T Entidade);
        T RetornarID(int id);
    }
}
