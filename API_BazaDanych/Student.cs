using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BazaDanych
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }

        public bool IsDeleted { get; set; }

        public override string ToString()
        {
            return $"ID: {Id},\tName: {Name},\tAverage: {Average:00},\tDeleted: {IsDeleted}" + Environment.NewLine;
        }
    }
}
