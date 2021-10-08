using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    // yetenek kazandıran interfaceler
    public class ClassRoom:IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;
            }
        }

        public void SortStudents()
        {
            students.Sort();
           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

       
    }
}
