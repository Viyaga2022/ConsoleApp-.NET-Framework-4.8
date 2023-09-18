using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Datatypes
{
    internal class TypeCasting
    {

        /* 
         *  Type Casting =========================================================
         *  1. Implicit Casting
         *  2. Explicit Casting
         *  3. Number To String
         *  4. string To Number
         */

        //1. Implicit Casting:  char -> int -> long -> float -> double
        public long IntToLong(int a)
        {
            long b = a;
            return b;
        }

        public float IntToFloat(int a)
        {
            float b = a;
            return b;
        }

        public double IntToDouble(int a)
        {
            double b = a;
            return b;
        }

        //================================

        public float LongToFloat(long a)
        {
            float b = a;
            return b;
        }

        public double LongToDouble(long a)
        {
            double b = a;
            return b;
        }

        //=================================

        public double FloatToDouble(float a)
        {
            return a;
        }

        /* 2. Explicit Casting: double -> float -> long -> int -> char */

        public int DoubleToInt(double x)
        {
            int y = (int)x;
            return y;
        }

        public long DoubleToLong(double x)
        {
            long y = (long)x;
            return y;
        }

        public float DoubleToFloat(double x)
        {
            float y = (float)x;
            return y;
        }

        //===================================

        public int FloatToInt(float x)
        {
            int y = (int)x;
            return y;
        }

        public long FloatToLong(float x)
        {
            long y = (long)x;
            return y;
        }

        //================================

        public int LongToInt(long x)
        {
            return (int)x;
        }

        /*********************************************************************
         *                       3. Number to String
         * ******************************************************************/

        public string NumToString(int num)
        {
            string s = num.ToString();
            return s;
        }

        public string NumToString(long num)
        {
            string s = Convert.ToString(num); // Type Conversion Method
            return s;
        }

        public string NumToString(float num)
        {
            return Convert.ToString(num);
        }

        public string NumToString(double num)
        {
            return num.ToString();
        }

        /*********************************************************************
         *                          4. String To Number
         ********************************************************************/

        public int StrToNum(string str)
        {
            int.TryParse(str, out int num);

            return num;
        }
    }
}
