using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darts
{
    public class Dart
    {
        public int score{get;set;}
        public bool IsDouble{get;set;}
        public bool IsTriple { get; set; }
        private Random random = new Random ();
        
        public Dart(Random rand)
        {
            random = rand;
        }

        public void Throw()
        {

            score=random.Next (0, 21);
            int multiplier = random.Next (1, 101);
            if(multiplier > 95) IsTriple=true;
            else if(multiplier > 90 && multiplier <= 95) IsDouble=true;


        }

    }
}
