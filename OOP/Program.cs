using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoLiskovSubstitutionPrinciple();
        }

        static void DemoLiskovSubstitutionPrinciple()
        {
            LiskovSubstitutionPrinciple problem = new LiskovSubstitutionPrinciple();
            problem.ShowDemo();

            LiskovSubstitutionPrincipleSolution solution = new LiskovSubstitutionPrincipleSolution();
            solution.ShowDemo();
        }
    }
}
