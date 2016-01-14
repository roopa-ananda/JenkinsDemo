using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorVersion1
{
    //public class BusiLog
    public class BusinessLogic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="op"></param>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        public string FetchResult(string op, double op1, double op2)
        {
            string result = string.Empty;
            //string Output = string.Empty;

            if (op == "+")
            {
                result = (op1 + op2).ToString();
            }
            else if (op == "-")
            {
                result = (op1 - op2).ToString();
            }
            else if (op == "*")
            {
                result = (op1 * op2).ToString();
            }
            else
            {
                result = (op1 / op2).ToString();
            }

            return result;
        }

    }
}
