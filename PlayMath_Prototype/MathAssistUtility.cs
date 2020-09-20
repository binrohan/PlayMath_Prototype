
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMath_Prototype
{
    public class MathAssistUtility
    {
        public MathAssistUtility()
        {

        }
        /// <summary>
        /// Taka a number and it's propertise like co-efficient and constant as booleans.
        /// Do: Generate plus sign for positive number.
        /// Do: Doesn't generate plus when it's position at first of a expression or term
        /// Do: if number is 1 as a co-efficient then omit 1.
        /// </summary>
        /// <param name="isFirstNumber">True: The number is at first position in a expreesion or term Flase: Other position</param>
        /// <param name="isConstant">True: Number is a constant False: Number is a Co-efficient</param>
        /// <param name="number">Number that is handling can be a constant or a Co-efficient</param>
        /// <returns>A string of number form that shows in console Like: X, 2X, +5X, -2X +15, 15</returns>
        public string PlusGenerator(bool isFirstNumber, bool isConstant, int number)
        {
            if (isFirstNumber == true && number > 0 && number != 1)
                return "" + number;
            if (isFirstNumber == true && number < 0 && number != 1)
                return "" + number;
            else if (isFirstNumber == false && number > 0 && number != 1)
                return "+" + number;
            else if (isFirstNumber == true && number == 1 && isConstant == true)
                return "" + number;
            else if (isFirstNumber == false && number == 1 && isConstant == false)
                return "+" + number;
            else if (isFirstNumber == false && number == 1 && isConstant == true)
                return "+" + number;
            else if (isFirstNumber == false && number == -1 && isConstant == true)
                return "+" + number;
            else if (isFirstNumber == true && number == 1)
                return "";
            else if (isFirstNumber == false && number == 1)
                return "+";
            else if (number < 0 && number != -1)
                return number.ToString();
            else if (number == -1)
                return "-";
            else if (number == 0)
                return "+"+number;
            else
                return "[PlayMath_Prototype/MathAssistUtility/PlusGenerator]";
        }
        /// <summary>
        /// Find two numbers from fators of two different number as they multiplies is last number and sum is mid number
        /// </summary>
        /// <param name="multiplier">A integer type list contains factor of number</param>
        /// <param name="midNum">Number is a co-efficient of middle term of trinomial expression</param>
        /// <param name="lastNum">constant number of trinomial expreesion</param>
        /// <returns>A array of two numbers. Default: Send 0 and 0 is conditions aren't meet</returns>
        public int[] FactorValueFinder(List<int> multiplier,int midNum, int lastNum)
        {
            int[] factorValue = new int[2];
            for(int i = 0; i < multiplier.Count; i++)
            {
                for(int j = 0; j < multiplier.Count; ++j)
                {
                    if (multiplier[i] + multiplier[j] == midNum && multiplier[i] * multiplier[j] == lastNum)
                    {
                        factorValue[0] = multiplier[i];
                        factorValue[1] = multiplier[j];
                    }
                    else if (multiplier[i] - multiplier[j] == midNum && multiplier[i] * -multiplier[j] == lastNum)
                    {
                        factorValue[0] = multiplier[i];
                        factorValue[1] = -multiplier[j];
                    }
                    else if (-multiplier[i] + multiplier[j] == midNum && -multiplier[i] * multiplier[j] == lastNum)
                    {
                        factorValue[0] = -multiplier[i];
                        factorValue[1] = multiplier[j];
                    }
                    else if (-multiplier[i] - multiplier[j] == midNum && -multiplier[i] * -multiplier[j] == lastNum)
                    {
                        factorValue[0] = -multiplier[i];
                        factorValue[1] = -multiplier[j];
                    }
                }
            }
            return factorValue;
        }
    }
}
