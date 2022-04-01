using System;

namespace Generic_Collections.Models
{
    class Student
    {
        private int _id;
        public int Id { get; }
       
        public string Name { get; set; }
    
        public string Surname { get; set; }
        
        public int Age { get; set; }

        public double Point { get; set; }

        public Student(string name, string surname, double point)
        {
            Name = name;
            Surname = surname;
            Point = point;
        }

        public Student()
        {
        }

        public void ShowInfo()
        {
            Console.WriteLine($"student id{Id}\n"+
                $"name: {Name}\n"+
                $"surname: {Surname}\n"+
                $"age: {Age}\n"+
                $"point: {Point}") ;
        }
        public static bool operator>(Student A, Student B)
        {
            return A.Point > B.Point;
        }
        
        public static bool operator<(Student A, Student B)
        {
            return A.Point < B.Point;
        }




    }
}
    
