using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

// do providera
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Data;


namespace zajecia
{
	public class Data
	{
		// ? oznacza ze zmienna moze byc nullem
		double[,]? dane;
		string[]? etykiety;
		double[]? srednie;
		double[]? odchylenia;
		int[]? indexy;

		public void WczytajDane(string sciezka)
		{
			StreamReader plik = new StreamReader(sciezka);

			if (plik == null)
			{
				Console.WriteLine("nie udalo sie otworzyc pliku");
				return;
			}

			// ustawienie odpowiedniego separatora dal danych
			NumberFormatInfo provider = new NumberFormatInfo();
			provider.NumberDecimalSeparator = ".";
			provider.NumberGroupSeparator = ",";

			// biore pierwsza linijke do sprawdzenia ile kolumn i wierszy
			var line = plik.ReadLine();
			if (line == null)
			{
				Console.WriteLine("plik pusty");
				return;
			}

			var aux = line.Split(",");
			int wiersz = 1; // na pewno jest jedna linijka bo zostala juz wczytana
			int kolumna = aux.GetLength(0) - 1; // -1 bo to dal liczb tlyko ostatni el to string
			int index_etykieta = kolumna; // index ostatniego elementu to to samo co ilosc kolumn

			// sprawdzam ile jest wierszy jak sa puste to nie licze
			// isnullorwhitespace zwraca true jesli string jest pusty
			while ((line = plik.ReadLine()) != null)
			{
				if (!string.IsNullOrWhiteSpace(line))
				{
					wiersz += 1;
				}
			}

			// wracam na poczatek pliku
			plik.DiscardBufferedData();
			plik.BaseStream.Seek(0, SeekOrigin.Begin);

			// Console.WriteLine("rozmiar tylko tabela danych (liczb) bez stringa wiersz " + wiersz + ", kolumna " + kolumna + "\n"); // dla irysow jest 150, 4

			dane = new double[wiersz, kolumna]; // rozmiar tabeli wiersze x kolumny
			etykiety = new string[wiersz]; // rozmiar tabeli etykiety wiersze x 1


			for (int i = 0; i < dane.GetLength(0); i++)
			{
				// czytaj linie az nie bedzie pusta
				do
				{
					line = plik.ReadLine();
				} while (string.IsNullOrWhiteSpace(line));


				aux = line.Split(",");

				for (int j = 0; j < dane.GetLength(1); j++)
				{
					dane[i, j] = Convert.ToDouble(aux[j], provider);
				}

				etykiety[i] = Convert.ToString(aux[index_etykieta]);
			}

			plik.Close();

			StworzTabIndexow();
		}

		public void Wypisz()
		{
			if (dane == null || etykiety == null)
			{
				Console.WriteLine("nie ma jeszcze danych");
				return;
			}


			for (int i = 0; i < dane.GetLength(0); i++)
			{
				for (int j = 0; j < dane.GetLength(1); j++)
				{
					Console.Write($"{dane[i, j]} ");
				}
				Console.Write(etykiety[i]);
				Console.WriteLine("\n");
			}

		}

		public double[,] Standaryzacja()
		{
			// zabezpieczenie bo wyswietla non stop ostrzezenie ze dane moga byc null
			if (dane == null) return new double[0, 0];

			srednie = new double[dane.GetLength(1)];
			odchylenia = new double[dane.GetLength(1)];

			// srednia

			for (int j = 0; j < dane.GetLength(1); j++)
			{
				double suma = 0;
				for (int i = 0; i < dane.GetLength(0); i++)
				{
					suma += dane[i, j];
				}
				srednie[j] = suma / dane.GetLength(0);
			}

			// odchylenie

			for (int j = 0; j < dane.GetLength(1); j++)
			{
				double suma_roznic_kwa = 0;
				for (int i = 0; i < dane.GetLength(0); i++)
				{
					suma_roznic_kwa += Math.Pow(dane[i, j] - srednie[j], 2);
				}
				odchylenia[j] = Math.Sqrt(suma_roznic_kwa / dane.GetLength(0));
			}

			double[,] gotowe_dane = new double[dane.GetLength(0), dane.GetLength(1)];

			for (int i = 0; i < dane.GetLength(0); i++)
			{
				for (int j = 0; j < dane.GetLength(1); j++)
				{
					gotowe_dane[i, j] = (dane[i, j] - srednie[j]) / odchylenia[j];
				}
			}

			return gotowe_dane;

		}

		public void NadpiszStandaryzacja()
		{
			dane = Standaryzacja();
		}
		public void WypiszSredniaOdchylenie()
		{
			if (srednie == null || odchylenia == null) return;

			Console.Write("\nsrednie\n");
			for (int i = 0; i < srednie.GetLength(0); i++)
			{
				Console.Write(srednie[i] + " ");
			}
			Console.Write("\n\n");

			Console.Write("\nodchyleenia\n");
			for (int i = 0; i < odchylenia.GetLength(0); i++)
			{
				Console.Write(odchylenia[i] + " ");
			}
			Console.Write("\n\n");
		}

		public void StworzTabIndexow()
		{
			if (dane == null) return;

			int ilosc_wierszy = dane.GetLength(0);

			indexy = new int[ilosc_wierszy];

			// uzupelniam tablice indexami po kolei
			for (int i = 0; i < ilosc_wierszy; i++)
			{
				indexy[i] = i;
			}
		}

		public void Pomieaszaj()
		{
			if (indexy == null) return;

			Random r = new Random();
			// losuje index i zamineiam go z ostatnim
			for (int i = dane.GetLength(0) - 1; i > 0; i--)
			{
				int losowa = r.Next(0, i);

				int temp = indexy[i];
				indexy[i] = indexy[losowa];
				indexy[losowa] = temp;
			}
		}

		public void WypiszPomieszane()
		{
			if (indexy == null) return;

			for (int i = 0; i < indexy.GetLength(0); i++)
			{
				Console.Write(indexy[i] + " ");
			}
		}

		public int IloscWierszy()
		{
			if (dane == null) return 0;

			return dane.GetLength(0);
		}
		public int IloscKolumn()
		{
			if (dane == null) return 0;

			return dane.GetLength(1);
		}

		// przeciazenie operatora do odczytu danych z tablicy
		public (double[], string) this[int i]
		{
			get
			{
				int kolumna = dane.GetLength(1);

				double[] linijka = new double[kolumna];

				for (int j = 0; j < kolumna; j++)
				{
					linijka[j] = dane[indexy[i], j];
				}

				return (linijka, etykiety[indexy[i]]);
			}
		}

		public int[] Indexy
		{
			get { return indexy; }
			set { indexy = value; }
		}

	}
}