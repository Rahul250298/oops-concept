using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.polymorphism
{
    public class Program
    { 
        static void Main(string[] args)
        {
            //create a favbillionaire object
            // Indian myIndian = new Indian();
            //call the Billionaires company () method on fav billioaire
            // myIndian.company();
            //name of billionaires and name of indian billionaires
            // Console.WriteLine( myIndian.name + "  " + myIndian.age,myIndian.product );
            Country myCountry = new Country();
            Country myIndia = new India();
            Country myUs = new Us();
            Country myChina = new China();
            Country myNewzealand = new Newzealand();

            myCountry.special();
            myIndia.special();
            myChina.special();
            myNewzealand.special();
            myUs.special();

        }
    }
}