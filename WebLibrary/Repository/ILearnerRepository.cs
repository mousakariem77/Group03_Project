using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Models;

namespace WebLibrary.Repository
{
    public interface ILearnerRepository
    {
        IEnumerable<Learner> GetLearners();
        Learner GetLearnerByID(int learnerId);
        void InsertLearner(Learner learner);
        void DeleteLearner(int learnerId);
        void UpdateLearner(Learner learner);
    }
}