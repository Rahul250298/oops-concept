using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Abstraction
{
    abstract class Country
    {
        public abstract void special();
        public void topR()
        {
            Console.WriteLine("Top Rankers");
        }
    }

        class India : Country
        {
            public override void special()
            {
                Console.WriteLine("India:population");
            }
        }
        class Us : Country
        {
            public override void special()
            {
                Console.WriteLine("Us:Tech Giants");
            }
        }
        class China : Country
        {
            public override void special()
            {
                Console.WriteLine("China: Super Power");
            }
        }
        class Newzealand : Country
        {
            public override void special()
            {
                Console.WriteLine("Newzealand:Womens Safety");

            }
        }
    }

    
    

