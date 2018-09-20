using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st
            //a
            Int16 theFirst = -30_000;
            Int32 theSecond = 100_000+theFirst;
            long theThird = 9_999_999;
            byte theForth = 200; 
            ushort theFifth = 60_000;
            char theSixth = 'N';
            bool theSeventh = false;
            float theEighth = 14.6989786786f;
            double theNinth = 0.3758932758927D;
            decimal theTenth = 4.99944563463M;
            string theEleventh = "Nastya";
            object theTwelfth = "Sakun";
            Console.WriteLine("Work 1 (a): "+theFirst+"; "+theSecond+"; "+theThird+"; "+theForth+"; "+theFifth+"; "+theSixth+"; "+ theSeventh+"; "+ theEighth+"; "+theNinth+"; "+theTenth+"; "+theEleventh+"; "+theTwelfth);

            //b
            
            Int32 one=theFirst+10_000;
            decimal two = theForth+100;
            long three = theFirst*100;
            object foure = theSixth+"astya";
            object five=theForth-201;
            Console.WriteLine("b1: " + one + "; " + two + "; " + three + "; " + foure + "; " + five);

            Int16 one1 = (Int16)theSecond;
            float two1 = (float)theTenth;
            Int16 three1 =(Int16)theThird ;
            float foure1 = (float)theNinth;
            double five1 =(double)theTenth;
            Console.WriteLine("b2: " + one1 + "; " + two1 + "; " + three1 + "; " + foure1 + "; " + five1);

            //c

            object one2 = theFirst;
            object two2 = theSecond;

            short three2 = (short)one2;
            //d

            var oneD = "Nastya";
            Console.WriteLine(oneD. GetType());
            
            //e
            int ?theFirstE = null;
            int theSecondE = theFirstE ?? 9;
            Console.WriteLine("e: "+ (theFirstE??theSecondE));
        }
    }
}
