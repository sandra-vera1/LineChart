using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Graphs
{
    public class Student
    {
        public string Student_Name { get; set; }
        public decimal Term1 { get; set; }
        public decimal Term2 { get; set; }
        public decimal Term3 { get; set; }
        public decimal Term4 { get; set; }

        public object this[string propertyName] 
        { 
           get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
           set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
