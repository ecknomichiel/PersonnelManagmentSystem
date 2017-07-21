using PersonnelManagmentSystemV1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonnelManagmentSystemV1.Repositories
{
    public class JobsRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Job> Jobs()
        {
            return db.Jobs;
        }

        public Job Job(int? id)
        {
            return db.Jobs.Where(j => j.ID == id).First();
        }

        public void Add(Job job)
        {
            db.Jobs.Add(job);
            db.SaveChanges();
        }

        public void Edit(Job job)
        {
            db.Entry(job).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Remove(Job job)
        {
            db.Jobs.Remove(job);
            db.SaveChanges();
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}