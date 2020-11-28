using System.Collections.Generic;

namespace Kartuves.BL.Interfaces
{
    public interface ICRUDRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity Get(int key);
        void Update(TEntity entity);
        int Add(TEntity entity);
        void Delete(int key);

    }
}
