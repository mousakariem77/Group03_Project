using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.DAO;
using WebLibrary.Models;

namespace WebLibrary.Repository
{
    public class LearnerRepository : ILearnerRepository
    {
        public Learner GetLearnerByID(int learnerId) => LearnerDAO.Instance.GetLearnerByID(learnerId);
        public IEnumerable<Learner> GetLearners() => LearnerDAO.Instance.GetLearnerlist();
        public void InsertLearner(Learner learner) => LearnerDAO.Instance.AddNew(learner);
        public void DeleteLearner(int learnerId) => LearnerDAO.Instance.Remove(learnerId);
        public void UpdateLearner(Learner learner) => LearnerDAO.Instance.Update(learner); 
    }
}