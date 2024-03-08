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
            //Changes
            //Ini udah benar
            //Ini gua unsure

            //Belajar merging
            //Tolong jangan di merge
            //Tolong jangan di merge
        }

        public string ConcanateIdName()
        {
            var concanatedString = $"{Id} - {Name}";
            return concanatedString;
        }
    }
}
