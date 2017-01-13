using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class SimpleInheritanceDemo
    {
        public void ShowDemo()
        {
            Marine m = new Marine();
            m.Display();
            m.DisplayA();
            Unit u = m;
            u.Display();
            u.DisplayA();
        }

        public abstract class Unit
        {
            public abstract void Display();
            public virtual void DisplayA()
            {
                Console.WriteLine("from unit");
            }
        }

        public class Marine : Unit
        {
            public override void Display()
            {
                Console.WriteLine("Hello");
            }

            public override void DisplayA()
            {
                base.DisplayA();
                Console.WriteLine("from child");
            }
        }
    }
}
