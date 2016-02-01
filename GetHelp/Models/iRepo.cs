
using System;
using System.Collections;
using System.Collections.Generic;
using GetHelp.Models;
using System.Data.Entity;

interface IRepository<T> where T : class
    {
    IEnumerable<T> GetAll();
    void Create(T item);
    void Update(T item);
    void Delete(int id);
    }

public class QueriesRepository : IRepository<QUERIES>
{
    private DataBase db;

    public QueriesRepository(DataBase context)
    {
        this.db = context;
    }

    public IEnumerable<QUERIES> GetAll()
    {
        return db.QUERIES;
    }

    public QUERIES Get(int id)
    {
        return db.QUERIES.Find(id);
    }

    public void Create(QUERIES quaries)
    {
        db.QUERIES.Add(quaries);
    }

    public void Update(QUERIES quaries)
    {
        db.Entry(quaries).State = EntityState.Modified;
    }

    public void Delete(int id)
    {

        QUERIES queries = db.QUERIES.Find(id);
        if (queries != null) db.QUERIES.Remove(queries);
    }
}

