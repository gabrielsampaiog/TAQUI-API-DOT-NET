﻿namespace Taqui.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int? id);

        void Add(T entity);

        void Update(T existingEntity, T entity);

        void Delete(int id);
    }
}
