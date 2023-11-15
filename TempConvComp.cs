using System.Collections.Generic;

namespace TempConvComp
{
    public class TempConvComp
    {
        public double cToR(double c)
        {
            return (double)(c * 4.0 / 5.0);
        }

        public double cToF(double c)
        {
            return (double)(c * 9.0 / 5.0 + 32);
        }

        public double cToK(double c)
        {
            return (double)(c + 273.15);
        }

        public double rToC(double r)
        {
            return (double)(r * 5.0 / 4.0);
        }

        public double rToF(double r)
        {
            return (double)(r * 9.0 / 4.0 + 32);
        }

        public double rToK(double r)
        {
            return (double)(r * 5.0 / 4.0 + 273.15);
        }

        public double fToC(double f)
        {
            return (double)((f - 32) * 5.0 / 9.0);
        }

        public double fToR(double f)
        {
            return (double)((f - 32) * 4.0 / 9.0);
        }

        public double fToK(double f)
        {
            return (double)((f + 459.67) * 5.0 / 9.0);

        }

        public double kToC(double k)
        {
            return (double)(k - 273.15);
        }

        public double kToR(double k)
        {
            return (double)((k - 273.15) * 4.0 / 5.0);
        }

        public double kToF(double k)
        {
            return (double)(k * 9.0 / 5.0 - 459.67);
        }
    }
}