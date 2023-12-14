using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2v2
{
    public class Player
    {
        public string Name { get; set; }
        public string ResultRecord { get; set; }

        

        public int Calculate()
        {
            int total = 0;

            for (int i = 0; i < ResultRecord.Length; i++)
                switch (ResultRecord[i])
                {
                    case 'W' :
                        total += 3;
                        break;
                    case 'D':
                        total += 1;
                        break;
                    case 'L':
                        total += 0;
                        break;


                }

           

            return total;
        }



        public override string ToString()
        {
            int Calculation = Calculate();
            return $"{Name} - {ResultRecord} - {Calculation}";
        }
    }
}
