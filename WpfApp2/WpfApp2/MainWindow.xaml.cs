
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Ankieta
{
    public partial class MainWindow : Window
    {
        private class Osoba
        {
            public string Plec { get; set; } = "";
            public int Wiek { get; set; }
            public string Kolor { get; set; } = "";
            public bool Zgoda { get; set; }
        }

        private readonly List<Osoba> osoby = new List<Osoba>();

        public MainWindow()
        {
            InitializeComponent();
            AktualizujWyniki();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            // Sprawdzenie wieku
            if (!int.TryParse(txtWiek.Text, out int wiek)
                || wiek < 0 || wiek > 120)
            {
                MessageBox.Show(
                    "Podaj prawidłowy wiek (0–120).",
                    "Błąd",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            // Sprawdzenie koloru
            if (cmbKolor.SelectedItem is not ComboBoxItem wybranyKolor)
            {
                MessageBox.Show(
                    "Wybierz kolor.",
                    "Błąd",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            // Odczyt płci
            string plec;

            if (rbMezczyzna.IsChecked == true)
                plec = "mężczyzna";
            else if (rbKobieta.IsChecked == true)
                plec = "kobieta";
            else
                plec = "inne";

            // Utworzenie osoby
            Osoba osoba = new Osoba
            {
                Plec = plec,
                Wiek = wiek,
                Kolor = wybranyKolor.Content.ToString() ?? "",
                Zgoda = chkZgoda.IsChecked == true
            };

            // Zapis do listy
            osoby.Add(osoba);

            // Zapis do pliku
            try
            {
                string sciezka = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "a.txt");

                string linia =
                    $"Płeć: {osoba.Plec}; " +
                    $"Wiek: {osoba.Wiek}; " +
                    $"Kolor: {osoba.Kolor}; " +
                    $"Zgoda: {(osoba.Zgoda ? "tak" : "nie")}";

                File.AppendAllText(
                    sciezka,
                    linia + Environment.NewLine,
                    Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Nie udało się zapisać danych do pliku.\n" + ex.Message,
                    "Błąd zapisu",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

            // Aktualizacja wyników
            AktualizujWyniki();

            // Przygotowanie formularza dla następnej osoby
            txtWiek.Clear();
            cmbKolor.SelectedIndex = -1;
            chkZgoda.IsChecked = false;
            rbMezczyzna.IsChecked = true;
            txtWiek.Focus();
        }

        private void AktualizujWyniki()
        {
            if (osoby.Count == 0)
            {
                txtSredniWiek.Text = "-średnia wieku: brak danych";
                txtKolor.Text = "-najczęstszy kolor: brak danych";
                txtMezczyzni.Text = "-ile m: 0";
                txtKobiety.Text = "-ile k: 0";
                txtZgoda.Text = "-ile zgoda: 0";
                return;
            }

            // Średnia wieku
            double sredniWiek = osoby.Average(o => o.Wiek);

            // Najczęściej wybierany kolor
            var najczestszyKolor = osoby
                .GroupBy(o => o.Kolor)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;

            // Liczba osób według płci
            int mezczyzni = osoby.Count(
                o => o.Plec == "mężczyzna");

            int kobiety = osoby.Count(
                o => o.Plec == "kobieta");

            // Liczba zgód
            int zgody = osoby.Count(o => o.Zgoda);

            // Wyświetlenie wyników
            txtSredniWiek.Text =
                $"-średnia wieku: {sredniWiek:F1}";

            txtKolor.Text =
                $"-najczęstszy kolor: {najczestszyKolor}";

            txtMezczyzni.Text =
                $"-ile m: {mezczyzni}";

            txtKobiety.Text =
                $"-ile k: {kobiety}";

            txtZgoda.Text =
                $"-ile zgoda: {zgody}";
        }
    }
}
