using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Models;

namespace Project_Group3.DAO
{
    public class InstructorDAO
    {
        private static InstructorDAO instance = null;
        private static readonly object instanceLock = new object();
        public static InstructorDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new InstructorDAO();

                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Instructor> GetInstructorlist()
        {
            var instructors = new List<Instructor>();
            try
            {
                using var context = new DBContext();
                instructors = context.Instructors.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

                throw;
            }
            return instructors;
        }
        public Instructor GetInstructorByID(int instructorID)
        {
            Instructor instructor = null;
            try
            {
                using var context = new DBContext();
                instructor = context.Instructors.SingleOrDefault(p => p.InstructorId == instructorID);

            }
            catch (System.Exception)
            {

                throw;
            }
            return instructor;
        }
        public void AddNew(Instructor instructor)
        {
            try
            {
                Instructor existingInstructor = GetInstructorByID(instructor.InstructorId);
                if (existingInstructor == null)
                {
                    using (var context = new DBContext())
                    {
                        context.Instructors.Add(instructor);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The instructor already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Instructor instructor)
        {
            try
            {
                Instructor existingInstructor = GetInstructorByID(instructor.InstructorId);
                if (existingInstructor != null)
                {
                    using (var context = new DBContext())
                    {
                        context.Instructors.Update(instructor);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The instructor does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int instructorID)
        {
            try
            {
                Instructor instructor = GetInstructorByID(instructorID);
                if (instructor != null)
                {
                    using (var context = new DBContext())
                    {
                        context.Instructors.Remove(instructor);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The instructor does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}