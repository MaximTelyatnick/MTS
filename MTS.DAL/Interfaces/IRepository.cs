﻿using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Linq;

namespace MTS.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T Create(T item);
        void CreateRange(IEnumerable<T> entity);
        void Update(T item);
        void Delete(T item);
        void DeleteAll(IEnumerable<T> item);

        /// <summary>SQLExecuteProc для вызова хранимых процедур или SQL запросов
        /// 
        /// </summary>
        IEnumerable<T> SQLExecuteProc(string executeProcString, params FbParameter[] paramArr);

    }
}
