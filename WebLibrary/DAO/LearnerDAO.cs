using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Models;

namespace WebLibrary.DAO
{
    public class LearnerDAO
    {
        private static LearnerDAO instance = null;
        private static readonly object instanceLock = new object();
        public static LearnerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new LearnerDAO();

                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Learner> GetLearnerlist()
        {
            var learners = new List<Learner>();
            try
            {
                using var context = new DBContext();
                learners = context.Learners.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

                throw;
            }
            return learners;
        }

        public Learner GetLearnerByID(int learnerID)
        {
            Learner learner = null;
            try
            {
                using var context = new DBContext();
                learner = context.Learners.SingleOrDefault(c => c.LearnerId.Equals(learnerID));

            }
            catch (System.Exception)
            {

                throw;
            }
            return learner;
        }

        public void AddNew(Learner learner)
        {
            try
            {
                Learner existingLearner = GetLearnerByID(learner.LearnerId);
                if (existingLearner == null)
                {
                    using (var context = new DBContext())
                    {
                        context.Learners.Add(learner);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The learner already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Learner learner)
        {
            try
            {
                Learner existingLearner = GetLearnerByID(learner.LearnerId);
                if (existingLearner != null)
                {
                    using (var context = new DBContext())
                    {
                        context.Learners.Update(learner);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The learner does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int learnerID)
        {
            try
            {
                Learner learner = GetLearnerByID(learnerID);
                if (learner != null)
                {
                    using (var context = new DBContext())
                    {
                        context.Learners.Remove(learner);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The learner does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}