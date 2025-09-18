using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zajecia
{
	public class Euklides : IDistance
	{
		public double Policz(double[] wektor1, double[] wektor2)
		{
			double odl = 0;
			for (int i = 0; i < wektor1.GetLength(0); i++)
			{
				odl += Math.Pow(wektor1[i] - wektor2[i], 2);
			}
			return Math.Sqrt(odl);
		}
	}
}
