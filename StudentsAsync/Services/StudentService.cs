using System.Collections.Generic;
using System.Linq;
using StudentsAsync.Brokers;
using StudentsAsync.Models;

namespace StudentsAsync.Data
{
    public class StudentService
    {
        public IAsyncEnumerable<Student> GetStudentsAsync()
        {
            var storageBroker = new StorageBroker();

            return storageBroker.Students.AsAsyncEnumerable();
        }

        public List<Student> GetStudents()
        {
            var storageBroker = new StorageBroker();

            return storageBroker.Students.ToList();
        }
    }
}
