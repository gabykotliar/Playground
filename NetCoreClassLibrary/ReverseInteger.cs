using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class ReverseInteger
    {
        public int ReverseUsingDecimalPart(int x)
        {
            try
            {
                decimal res = 0;
                int sign = x > 0 ? 1 : -1;
                decimal v = Math.Abs(x);

                while (v >= 1)
                {
                    v = v / 10;
                    var parteEntera = Math.Truncate(v);
                    var parteDecimal = Math.Abs(parteEntera - v);
                    res = (res + parteDecimal) * 10;
                    v = parteEntera;
                }

                res = Math.Round(res) * sign;

                return Convert.ToInt32(res);
            }
            catch
            {
                return 0;
            }
        }

        public int ReverseWithString(int x) 
        {
            var arr = Math.Abs(x).ToString().ToCharArray();
            
            Array.Reverse(arr);
         
            try
            {
                return Convert.ToInt32(string.Join(string.Empty, arr)) * (x > 0 ? 1 : -1);
            }
            catch
            {
                return 0;
            }
        }

        public int ReverseWithModAndReduction(int x)
        {
            try
            {
                int sign = x > 0 ? 1 : -1;

                int source = Math.Abs(x);
                Int32 target = 0;
                
                while (source >= 1) //321
                {
                    int swap = source % 10;
                    source = source / 10;

                    target = checked((target * 10) + swap); // The checked keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.

                    // By default, these non-constant expressions are not checked for overflow 
                    // at run time either, and they do not raise overflow exceptions.  
                }

                return target * sign;
            }
            catch
            {
                return 0;
            }
        }

    }
}
