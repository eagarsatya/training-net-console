using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingNET.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public int SubjectId { get; set; }

        public Student()
        {

        }

        public string ConcanateIdName()
        {
            var concanatedString = $"{Id} - {Name}";
            return concanatedString;
        }
    }
}
