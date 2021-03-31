using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contohoverloading
{
    class numbers
    {
        public int findminimum (int numb1 , int numb2)
        {
            int min;
            min = numb2;
            if( min > numb1)
            {
                min = numb1;
            }
            return min;
        }
        public float findminimum(int numb1, int numb2, float numb3)
        {
            float min;
            min = numb2;
            if (min > numb1)
            {
                min = numb1;
            }
            if(min > numb3)
            {
                min = numb3;
            }
            return min;
        }
        public int findmaximum(int numb1 , int numb2)
        {
            int max;
            max = numb1;
            if(numb2 > max)
            {
                max = numb2;
            }
            return max;
        }
        public float findmaximum(int numb1, int numb2, float numb3)
        {
            float max;
            max = numb1;
            if (numb2 > max)
            {
                max = numb2;
            }
            if (numb3 > max)
            {
                max = numb3;
            }
            return max;
        }
    }
}
