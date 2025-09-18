using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia
{
	public class Cosinus : IDistance
	{
		public double Policz(double[] wektor1, double[] wektor2)
		{
			double odl = 0;
			double A = 0;
			double B = 0;

			for (int i = 0; i < wektor1.GetLength(0); i++)
			{
				odl += wektor1[i] * wektor2[i];
				A += Math.Pow(wektor1[i], 2);
				B += Math.Pow(wektor2[i], 2);
			}

			A = Math.Sqrt(A);
			B = Math.Sqrt(B);

			//return 1 - (odl / (A * B));
			return Math.Sqrt(2 * (1 - (odl / (A * B))));
		}
	}
}
