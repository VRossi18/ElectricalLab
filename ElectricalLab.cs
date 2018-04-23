using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalLab
{
    public class ElectricalLabCalc
    {
        /// <summary>
        /// Calculated all basic circuits variables
        /// </summary>
        /// <param name="Resistence">Resistência</param>
        /// <param name="Current">Corrente</param>
        /// <param name="Tension">Tensão</param>
        public Tuple<string, double> CalcMono(double Resistence, double Current, double Tension)
        {
            try
            {
                if (Resistence == 0)
                {
                    Resistence = Tension / Current;
                    return new Tuple<string, double>("Resistence", Resistence);
                }
                else if (Current == 0)
                {
                    Current = Tension / Resistence;
                    return new Tuple<string, double>("Current", Current);
                }
                else if (Tension == 0)
                {
                    Tension = Current * Resistence;
                    return new Tuple<string, double>("Tension", Tension);
                }
                else
                {
                    throw new ArgumentException("None of the variables is equal to 0 (input the value 0 in the variable to be calculated)");
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                Console.WriteLine("", ex);
                throw ex;
            }
        }

        // Complex numbers conversion (polar to rectangle)
        public string CalcToRec(double Real, double Angle)
        {
            double Z;
            double Y;
            string Result;
            Z = Real * Math.Cos(Angle);
            Y = Real * Math.Sin(Angle);

            Result = ($"The result is { Real} and the imaginary part is {Angle} ");
            return Result;
        }

        // Complex numbers conversion (rectangle to polar)
        public string CalcToPolar(double Real, double Imaginary)
        {
            string Result;
            double Z;
            double Y;
            Z = Math.Atan(Real / Imaginary);
            Y = Math.Sqrt((Real * Real) + (Imaginary * Imaginary));

            Result = ($"The result is {Real} and the angle is {Imaginary}");
            return Result;
        }
    }
}
