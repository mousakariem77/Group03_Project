using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Models;

namespace WebLibrary.DAO
{
    public class LessonProgressDAO
    {
        private static LessonProgressDAO instance = null;
        private static readonly object instanceLock = new object();
        public static LessonProgressDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new LessonProgressDAO();

                    }
                    return instance;
                }
            }
        }
        public IEnumerable<LessonProgress> GetLessonProgresslist()
        {
            var LessonProgress = new List<LessonProgress>();
            try
            {
                using var context = new DBContext();
                LessonProgress = context.LessonProgresses.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

                throw;
            }
            return LessonProgress;
        }

        public LessonProgress GetLessonProgressByID(int LessonProgressID)
        {
            LessonProgress LessonProgress = null;
            try
            { 
                using var context = new DBContext();
                LessonProgress = context.LessonProgresses.SingleOrDefault(c => c.LessonProgressId.Equals(LessonProgressID));

            }
            catch (System.Exception)
            {

                throw;
            }
            return LessonProgress;
        }

        public void AddNew(LessonProgress LessonProgress)
        {
            try
            {
                LessonProgress existingLessonProgress = GetLessonProgressByID(LessonProgress.LessonProgressId);
                if (existingLessonProgress == null)
                {
                    using (var context = new DBContext())
                    {
                        context.LessonProgresses.Add(LessonProgress);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The LessonProgress already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(LessonProgress LessonProgress)
        {
            try
            {
                LessonProgress existingLessonProgress = GetLessonProgressByID(LessonProgress.LessonProgressId);
                if (existingLessonProgress != null)
                {
                    using (var context = new DBContext())
                    {
                        context.LessonProgresses.Update(LessonProgress);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The LessonProgress does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int LessonProgressID)
        {
            try
            {
                LessonProgress LessonProgress = GetLessonProgressByID(LessonProgressID);
                if (LessonProgress != null)
                {
                    using (var context = new DBContext())
                    {
                        context.LessonProgresses.Remove(LessonProgress);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The LessonProgress does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}