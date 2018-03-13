using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    
{
    class Gradebook
    {
        public Gradebook()
        {

        }
        
        public void AddGrade(float grade)
        {
            grades.Add(grade);

        }
        List<float> grades = new List<float>(); 
    }
}
