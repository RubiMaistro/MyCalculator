using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyCalculator
    {
        public float Result { get; set; }
        public float Number { get; set; }
        public string Statement { get; set; }
        public string Operator { get; set; }

        public MyCalculator()
        {
            this.Number = 0;
            this.Result = 0;
            this.Statement = null;
            this.Operator = null;
        }
    }
}
