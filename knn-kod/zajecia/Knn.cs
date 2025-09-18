using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace zajecia
{
	// tutaj k mowi ilu najblizsyzch sasiadow mam brac
	public class Knn : IMachine
	{
		Data dane;
		double[]? odleglosci;
		int[]? index_miejsce;

		IDistance obliczenia;
		int k; // najblizszych
		int[]? indexy;


		public Knn(Data el, IDistance obl, int najblizszych)
		{
			dane = el;
			obliczenia = obl;
            //k = najblizszych;
            k = (najblizszych > 0 && najblizszych <= dane.IloscWierszy()) ? najblizszych : 1;
            indexy = dane.Indexy;
		}

        //public string Klasyfikuj(double[] wektor, int k, IDistance obliczenia)

        public string Klasyfikuj(double[] wektor)
		{
			// tworzenie tablicy indexow i odleglosci
			var ile_wierszy = indexy.GetLength(0);
            odleglosci = new double[ile_wierszy];
			index_miejsce = new int[odleglosci.GetLength(0)];


			// dane item 1 to tablica (wektr) a item2 to etykieta 
			for (int i = 0; i < ile_wierszy; i++)
			{
				// licze odleglosc dla kazdego wektora
				odleglosci[i] = obliczenia.Policz(wektor, dane[indexy[i]].Item1);

				// zapisuje indexy wektorow odpowiednio do ich odleglosci
				index_miejsce[i] = indexy[i];
			}

			var wynik = WybierzEtykiete();

			return wynik;
		}

		string WybierzEtykiete()
		{
			if (odleglosci == null || index_miejsce == null)
			{
				return "blad";
			}

			// sortuje po odleglosciach rosnaco i zachowuje powiazanie z indexami
			Array.Sort(odleglosci, index_miejsce);
			

			// key, value
			Dictionary<string, int> slownik_etykier = new Dictionary<string, int>();

            // wybieram k najblizszych danych
            for (int i = 0; i < k; i++)
			{
				// wybieram najblizsze etykiety (item2 to etykiety)
				string etykieta = dane[index_miejsce[i]].Item2;

				// jak slownik juz zawiera to zwiekszam
				if (slownik_etykier.ContainsKey(etykieta))
				{
					slownik_etykier[etykieta]++;
				}
				else
				{
					slownik_etykier[etykieta] = 1;
				}
			}

			// zwraca max wartosc sposrod wystapien jaka jest w slowniku
			int max_wystapienia = slownik_etykier.Values.Max();

			// robi tablice z etykietami tych ktore maja value takie jak wartosc maksymalnej maxymalne wystapenie
			var max_etykiety = slownik_etykier.Where(x => x.Value == max_wystapienia).Select(x => x.Key).ToArray();  

			// jak jest tylko jeden wynik to go zwracam
			if (max_etykiety.GetLength(0) == 1)
			{
				return max_etykiety[0];
			}

			// czyli jest kilka
			return "nieokreslone";
		}

		public void WypiszOdleglosci()
		{
			for (int i = 0; i < odleglosci.GetLength(0); i++)
			{
				Console.Write($" {odleglosci[i]} ");
			}
		}

		public void NadpiszIndexy(int[] tablica_indexow)
		{
			indexy = tablica_indexow;
		}
	}
}

/*
 obiekt ma być tworzony poza metoda!!! 
i wtedy chyba przekazywany prezz argument
*/



/*
 
dowolna odleglosc niz eukildesowa


tworzyc klase mozna by bylo kalse euklides i w tej klasie mam y policz odleglosc i wektor x y (double doble 


lcczy odleglosc pomiedzy 2 wektorami i w knn zrobic euklides = new ...
.policz odleglosc 


zrobic interfejs zamiast asy euklides to ma byc nterfejs o nazwie DYSTANS i wtedy klass euklides : DYSTANS

DYSTANS w = new Euklides lub cos innebo i w dowolny spoosb zmieniam 



i odprocz euklidesowej odlegosc kosiunusowa 

2 odlegloscci w moim programie i tego uzyc w knn 

interfejs w innym pliku WSZYSTKO OSOBNO
 */
