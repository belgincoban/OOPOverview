using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.AddStudent(new Student { Id = 1, Age = 18, Name = "Belgin Çoban" });
            classRoom.AddStudent(new Student { Id = 2, Age = 28, Name = "Türkay Ürkmez" });
            classRoom.AddStudent(new Student { Id = 6, Age = 8, Name = "Şeyda Nur " });

            classRoom.SortStudents();
            

            foreach (var student in classRoom)
            {
                Console.WriteLine($"{student.Name} {student.Age}");
            }
            Console.ReadLine();
        }
    }
}
