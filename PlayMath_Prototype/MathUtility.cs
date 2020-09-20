using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMath_Prototype
{
    public class MathUtility
    {
        public MathUtility()
        {

        }
        public List<int> Multiplier(int a)
        {
            List<int> multiplier = new List<int>();
            for (int i = 1;i <= a; ++i)
            {
                if (a % i == 0)
                    multiplier.Add(i);
            }
            return multiplier;
        }

        public int MaxCommonDivisor(int n1, int n2)
        {
                if (n2 == 0)
                {
                    return n1;
                }
                else
                {
                    return MaxCommonDivisor(n2, n1 % n2);
                }            
        }

        //Must review later to make it better
        double _x;
        public double X {
            get
            {
                return _x;
            }
        }
        public double[] Quadratic(int a, int b, int c)
        {
            _x = Math.Pow(b, 2) - (4 * a * c);
            double[] result = new double[2];
            if(Math.Pow(b, 2) - (4 * a * c) < 0)
            {
                result[0] = 0;
                result[1] = 0;
            }
            else
            {
                result[0] = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                result[1] = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            }
            return result;
        }

        //PrivateMethods
        private int[] Exchange(int num0, int num1)
        {
            int[] sender = new int[2];
            int temp = num0;
            num0 = num1;
            num1 = temp;

            sender[0] = num0;
            sender[1] = num1;

            return sender;
        }
    }
}
