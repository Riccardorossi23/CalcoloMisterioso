using System;

namespace CalcoloMisterioso
{
    public class CalcoloMisterioso
    {
        public static double CalcoloMisterioso1(double[] v)
        {
            double s = 0;
            if (v.Length == 0)
                s = double.NaN;
            else
            {
                for (int i = 0; i < v.Length; i++)
                    s = s + v[i];
            }
            return s;
        }
    }
}
