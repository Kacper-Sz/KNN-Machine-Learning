using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zajecia
{
	public class CV
	{
		// k mowi na ile zbiorow mam podzielic dane
		int k;
		Data dane;
		IMachine machine;

		public int K
		{
			get { return k; }
			// set { k = value > 0 ? value: 1; }
			set { k = (value > 0 && value < dane.IloscWierszy()) ? value : 2; }

		}
		public CV(Data x, IMachine obiekt)
		{
			dane = x;
			machine = obiekt;
		}

		public CV(Data x, int czesci, IMachine obiekt)
		{
			dane = x;
			K = czesci;
			machine = obiekt;
		}

		public List<(int[], int[])> PodzielDaneNaKCzesci()
		{
			var wynik = new List<(int[], int[])>();

			var ilosc_wierszy = dane.IloscWierszy();
			int podstawowe = ilosc_wierszy / k;
			int reszta = ilosc_wierszy % k;

			int obecna_pozycja = 0;

			for (int i = 0; i < k; i++)
			{
				int rozmiar_zbioru = podstawowe;

				// trzeba porozdziealc resze po rowno
				// reszta bedzei zawsze mniejsza niz k
				if (reszta > i)
				{
					rozmiar_zbioru += 1;
				}

				// tworze ciag liczb od wartosci obecnej pozycji do rozmiaru zbioru i zamieniam nan tablice
				int[] testowy = Enumerable.Range(obecna_pozycja, rozmiar_zbioru).ToArray();
				
				// przenosze sie na kolejny zbior gdzei sie ma zaczynac
				obecna_pozycja += rozmiar_zbioru;

				// tworze ciag wszystkich indexow poza tymi co sa juz w testowym i zamienam na tablce
				int[] treningowy = Enumerable.Range(0, ilosc_wierszy).Except(testowy).ToArray();

				wynik.Add((testowy, treningowy));

			}

			return wynik;
		}

		public void WypiszZbiory()
		{
			var zbiory = PodzielDaneNaKCzesci();

			Console.WriteLine("\n");
			foreach (var el in zbiory)
			{
				Console.WriteLine($"zbior testowy ma dlugosc {el.Item1.GetLength(0)} i elementy: ");

				for (int i = 0; i < el.Item1.GetLength(0); i++)
				{
					Console.Write($"{el.Item1[i]}, ");
				}

				Console.WriteLine("\n");

				Console.WriteLine($"zbior treningowy ma dlugosc {el.Item2.GetLength(0)} i elemnty: ");

				for (int i = 0; i < el.Item2.GetLength(0); i++)
				{
					Console.Write($"{el.Item2[i]}, ");
				}
				Console.WriteLine("\n\n");
			}
			Console.WriteLine("\n");
		}

		public double Testuj()
		{
			double suma_dokladnosci = 0;
			var tablice = PodzielDaneNaKCzesci();

			for (int i = 0; i < tablice.Count(); i++)
			{
				machine.NadpiszIndexy(tablice[i].Item2.ToArray());

				double poprawne = 0.0;

				foreach (var el in tablice[i].Item1)
				{
					// item jeden to wektor item dwa to etykieta
					string dobra_etykieta = dane[el].Item2;
					var test_wektor = dane[el].Item1;
					var przewidywana_etykieta = machine.Klasyfikuj(test_wektor);

					if (dobra_etykieta == przewidywana_etykieta)
					{
						poprawne++;
					}
				}

				double dokladnosc = poprawne / tablice[i].Item1.GetLength(0);
				suma_dokladnosci += dokladnosc;

			}

			return suma_dokladnosci / tablice.Count();
		}
	}
}


/*
dokladnosc = liczba poprawnych / wszystkie

k = 3 mamy 3 dokladnosci zwracamy srednia


imachine interfejs i ma byc metoda testuj 

przekopiowuje jakies dane indexow

menu k cv plik start -> wynik cv

mamy 2 tygodnie

 */
