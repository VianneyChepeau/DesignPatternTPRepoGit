using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRP
{
    public static class StudentDAO
    {
        public static void insert(StudentModel model)
        {
            Console.WriteLine("insertion de " + model.FirstName + " dans la BDD");
        }

        public static void update(StudentModel model)
        {
            Console.WriteLine("modification de " + model.FirstName + " dans la BDD");
        }
    }
}