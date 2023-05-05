using ErdincHocaCozumAss15.Context;
using ErdincHocaCozumAss15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincHocaCozumAss15.Repositories
{
    internal class NoteRepository
    {
        public NoteRepository()
        {
            dbContext = new AppDbContext();
        }
        AppDbContext dbContext;

        public Note GetById(int id)
        {
            return dbContext.Notes.Find(id);
        }

        public List<Note> GetNotesByUserId(int userId)
        {
            return dbContext.Notes.Where(a=> a.UserId == userId).ToList();  
        }

        public bool Add(Note note)
        {
            dbContext.Notes.Add(note);
            return dbContext.SaveChanges()> 0;
        }

        public bool Update(Note note) 
        {
            dbContext.Notes.Update(note);
            return dbContext.SaveChanges()> 0;
        }

        public bool Delete(int id)
        {
            Note note = GetById(id);
            dbContext.Notes.Remove(note);
            return dbContext.SaveChanges()> 0;
        }

    }
}
