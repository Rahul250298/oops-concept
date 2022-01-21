using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.polymorphism
{
    public class Country
    {
        public virtual void special()
        {
            Console.WriteLine("Humans look beauty in their way");
        }
    }
    class India : Country
    {
         public override void special()
        {
            Console.WriteLine("population");
        }
    }
    class Us: Country
    {
        public override void special()
        {
            Console.WriteLine("Tech Giants");
        }
    }
    class  China : Country
    {
        public override void special()
        {
            Console.WriteLine("Super Power");
        }
    }
    class Newzealand:Country
    {
        public override void special()
        {
            Console.WriteLine("Womens Safety");

        }
    }
}
