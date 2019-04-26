using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRP
{
    public class StudentBusiness
    {
        private StudentModel model;

        public StudentBusiness(StudentModel model)
        {
            this.model = model;
        }

        public StudentModel StudentModel
        {
            get => default(StudentModel);
            set
            {
            }
        }

        public float CalculateAverage()
        {
            float avg = 0;
            return avg;
        }

        public bool IsGraduated()
        {
            bool isGraduated = false;
            return isGraduated;
        }
    }
}