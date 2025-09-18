
using System.Windows.Forms;
using zajecia; // zeby wykrywalo mi te pliki z klasmi

namespace uczenie_maszynowe
{
	public partial class Machine_Learning : Form
	{
		Data dane;
		string sciezka, nazwa;
		bool plik, stand, mieszane;


		public Machine_Learning()
		{
			dane = new Data();
			plik = false;
			stand = false;
			mieszane = false;
            nazwa = "BRAK";
			sciezka = "";

            InitializeComponent();
		}

		void WypiszWGridView()
		{
			// jak nie ma danych to nic nie robi
			if (dane == null) return;

			// czysci 
			dataGridView.Rows.Clear();
			dataGridView.Columns.Clear();
			
			// dodaje nazwe i to co sie wyswietla dla odpwoiedniej liczby kolumn
			dataGridView.Columns.Add($"Index", $"Index");

			for (int i = 0; i < dane.IloscKolumn(); i++)
			{
				dataGridView.Columns.Add($"Col{i}", $"Kolumna {i + 1}");
			}
			dataGridView.Columns.Add("Etykieta", "Etykieta");


			for (int i = 0; i < dane.IloscWierszy(); i++)
			{
				var (liczby, nazwa) = dane[i];

				// tworze tablice obiektow ktora reprezentuje jeden wiersz
				// dlugosc wektora + index + etykieta = dlugosc + 2
				object[] wiersz = new object[liczby.GetLength(0) + 2];

				wiersz[0] = i + 1;

				for (int j = 0; j < liczby.GetLength(0); j++)
				{
					wiersz[j + 1] = liczby[j];
				}

				// na ostatnim miejscu etykieta
				wiersz[liczby.GetLength(0) + 1] = nazwa;

				// dodaje caly wiersz
				dataGridView.Rows.Add(wiersz);
			}
		}
		
		void AktualizujOgraniczenia()
		{
			// ustawiam ograniczenia dla wybory najblizszych i podzialow
			if (dane != null && dane.IloscWierszy() > 0)
			{
				// ustawiam maximum i minimum
				numericUpDown_podzialy.Maximum = dane.IloscWierszy();
				numericUpDown_podzialy.Minimum = 2;

				numericUpDown_najblizszych.Maximum = dane.IloscWierszy();
				numericUpDown_najblizszych.Minimum = 1;
			}
		}
		
		private void button_otworz_Click(object sender, EventArgs e)
		{
			// otwarcie okienka dialogowego
			OpenFileDialog open_file_dialog = new OpenFileDialog();
			DialogResult r = open_file_dialog.ShowDialog();

			if (r == DialogResult.OK)
			{
				//otiweramy plik
				sciezka = open_file_dialog.FileName;

				// wczytujemy go
				dane.WczytajDane(sciezka);
				// aktualizacja ilosci podzialow i najblizsych
				AktualizujOgraniczenia();

				plik = true;
				// wypisujemy dane o pliku
				// i wypisujemy dane w tabeli
				WypiszInfo();
				WypiszWGridView();
				richTextBox_wyniki.Text += "\nOtwarto plik.\n";
			}
		}
		
		void WypiszInfo()
		{
			// wypisuje info o pliku
			// zaleznie od wybranych opcji
			var stand_info = stand ? "TAK" : "NIE";
			var mieszanie_info = mieszane ? "TAK" : "NIE";
			if (plik)
			{
				var nazwa_tab = sciezka.Split('\\').ToArray();
				nazwa = nazwa_tab[nazwa_tab.GetLength(0) - 1];
			}

			richTextBox_info_plik.Text = $"Plik: {nazwa}\n" +
							$"Wierszy: {dane.IloscWierszy()}\n" +
							$"Kolumn: {dane.IloscKolumn()}\n" +
							$"Pomieszane: {mieszanie_info}\n" +
							$"Standaryzacja: {stand_info}";
		}
		
		private void button_standaryzacja_Click(object sender, EventArgs e)
		{
			// odpowiednie komunikaty
			if (!stand)
			{
				stand = true;
				button_standaryzacja.Text = "Nie standaryzuj";
				richTextBox_wyniki.Text += "\nW³¹czono standaryzacje danych.\n";
			}
			else
			{
				stand = false;
                button_standaryzacja.Text = "Standaryzacja";
				richTextBox_wyniki.Text += "\nWy³¹czono standaryzacje danych.\n";
			}
			WypiszInfo();
		}
		
		private void button_mieszaj_Click(object sender, EventArgs e)
		{
			// odpowiednie komunikaty
			if (!mieszane)
			{
				mieszane = true;
				button_mieszaj.Text = "Nie mieszaj danych";
				richTextBox_wyniki.Text += "\nW³¹czono mieszanie danych.\n";
			}
			else
			{
				mieszane = false;
				button_mieszaj.Text = "Mieszaj dane";
				richTextBox_wyniki.Text += "\nWy³¹czono mieszanie danych.\n";
			}
			WypiszInfo();
		}
		
		private void radio_button_euklides_CheckedChanged(object sender, EventArgs e)
		{
			// odpowiedni komunikat
			if (radio_button_euklides.Checked)
			{
				richTextBox_wyniki.Text += ("\nWybrano obliczenia za pomoca odleglosci euklidesowej.\n");
			}
		}

		private void radio_button_cosinus_CheckedChanged(object sender, EventArgs e)
		{
            // odpowiedni komunikat
            if (radio_button_cosinus.Checked)
			{
				richTextBox_wyniki.Text += ("\nWybrano obliczenia za pomoca odleglosci cosinusowej.\n");
			}
		}

		private void radio_button_knn_CheckedChanged(object sender, EventArgs e)
		{
            // odpowiedni komunikat
            if (radio_button_knn.Checked)
			{
				richTextBox_wyniki.Text += ("\nWybrano metode knn.\n");
			}
		}

		private void button_testuj_Click(object sender, EventArgs e)
		{
			// sprawdzam czy wszystko jest wybrane
			if (!CzyGotowe())
			{
				return;
			}

			Podsumowanie();

			// gdybym kilka razy klinknal testuj dla jednego ustawinia
			// to jeszcze raz laduje plik
			dane.WczytajDane(sciezka);

			if (stand)
			{
				dane.NadpiszStandaryzacja();
			}

			if (mieszane)
			{
				dane.Pomieaszaj();
			}

            // biore jako domyslna euklidesa
			// potem zmieniam jak jest taka potrzeba
            IDistance obliczenia = new Euklides(); 

            //if (radio_button_euklides.Checked)
            //{
            //	obliczenia = new Euklides();
            //}

            if (radio_button_cosinus.Checked)
			{
				obliczenia = new Cosinus();
			}

            // tutaj tak samo 
            // ustaiwam ze knn jest domyslna
            IMachine metoda = new zajecia.Knn(dane, obliczenia, (int)numericUpDown_najblizszych.Value); 

			// gdyby bylo wiecej do wyboru to tu by byly ify
			//if (radio_button_knn.Checked)
			//{
			//	metoda = new Knn(dane, obliczenia, (int)numericUpDown_najblizszych.Value);
			//}

			CV cv = new CV(dane, (int)numericUpDown_podzialy.Value, metoda);

			// zamieniam wynik na % i zaokraglame do 2 po przecinku
			var wynik = Math.Round(cv.Testuj() * 100, 2);

            richTextBox_wyniki.Text += $"Poprawnosc wynosi {wynik}%";
			MessageBox.Show($"Poprawnosc wynosi {wynik}%");
		}

		void Podsumowanie()
		{
			// wypisanie danych
			var ustawienia = $"Plik: {nazwa}\n" + 
							$"Metoda: {(radio_button_knn.Checked ? "KNN" : "Nie wybrano")}\n" +
							$"Obliczanie odleglosci: {(radio_button_euklides.Checked ? "Euklides" :
							radio_button_cosinus.Checked ? "Cosinus" : "Nie wybrano")}\n" +
							$"Standaryzacja: {(stand ? "TAK" : "NIE")}\n" +
							$"Mieszanie: {(mieszane ? "TAK" : "NIE")}";

			richTextBox_wyniki.Text = ("\n=== Aktualne ustawienia ===\n" + ustawienia + "\n");
		}

		bool CzyGotowe()
		{
			// sprawdzam czy wszystko jest wybrane
			if (nazwa == "BRAK")
			{
				richTextBox_wyniki.Text = "\nNie mozna uruchomic testowania.\n\nBrak wybranego pliku.\n";
				return false;
			}

			if (!radio_button_knn.Checked)
			{
                richTextBox_wyniki.Text = "\nNie mozna uruchomic testowania.\n\nBrak wybranej metody obliczen.\n";
                return false;
            }

			if (!radio_button_cosinus.Checked && !radio_button_euklides.Checked)
			{
                richTextBox_wyniki.Text = "\nNie mozna uruchomic testowania.\n\nBrak wybranego typu obliczen odleglosci.\n";
                return false;
            }

			return true;
		}

		private void richTextBox_wyniki_TextChanged(object sender, EventArgs e)
		{
            // ustawia pozycje kursora na sam koniec tekstu w okienku richtextbox
            richTextBox_wyniki.SelectionStart = richTextBox_wyniki.Text.Length;
			// automatycznie przewija aby kursor byl widoczny
			richTextBox_wyniki.ScrollToCaret();
		}

        private void button_wyczysc_Click(object sender, EventArgs e)
        {
            // reset pol
            dane = new Data();
            sciezka = "";
            nazwa = "BRAK";
            plik = false;
            stand = false;
            mieszane = false;

            // czyszczenie tabelki
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

			// czyszczenie informacji
            richTextBox_wyniki.Clear();
            richTextBox_wyniki.Text = "Wszystkie akcje programu:\n";

            richTextBox_info_plik.Clear();
            richTextBox_info_plik.Text = "Dane pliku.";

			// reset min max
			numericUpDown_najblizszych.Maximum = 100;
			numericUpDown_najblizszych.Minimum = 0;
			numericUpDown_najblizszych.Value = 0;

			numericUpDown_podzialy.Maximum = 100;
			numericUpDown_podzialy.Minimum = 0;
			numericUpDown_podzialy.Value = 0;

            // reset guzikow
            button_standaryzacja.Text = "Standaryzacja";
            button_mieszaj.Text = "Mieszaj dane";

            // reset obliczen i metody
            radio_button_euklides.Checked = false;
			radio_button_cosinus.Checked = false;
            radio_button_knn.Checked = false;

			richTextBox_wyniki.Text = ("Zresetowano wszystkie ustawienia programu.\n");
        }
    }
}