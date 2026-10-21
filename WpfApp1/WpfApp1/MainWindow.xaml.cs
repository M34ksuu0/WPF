using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int budget = 500;

        private ObservableCollection<string> myPlayers =
            new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            MyPlayersList.ItemsSource = myPlayers;
        }
        private void BuyPlayer(object sender, RoutedEventArgs e)
        {
            ComboBoxItem? player =
                PlayerBox.SelectedItem as ComboBoxItem;

            if (player == null || player.Tag == null || player.Content == null)
            {
                StatusBlock.Text = "Wybierz piłkarza!";
                return;
            }

            if (!int.TryParse(player.Tag.ToString(), out int price))
            {
                StatusBlock.Text = "Nieprawidłowa cena piłkarza!";
                return;
            }

            if (price > budget)
            {
                StatusBlock.Text = "Nie masz wystarczająco pieniędzy!";
                return;
            }

            string playerName = player.Content.ToString() ?? "Nieznany piłkarz";

            budget -= price;

            myPlayers.Add(playerName);

            BudgetBlock.Text = "Budżet: " + budget + " mln €";

            PlayerCountBlock.Text =
                "Liczba piłkarzy: " + myPlayers.Count;
                                                                                                                                                                                                                                                                                                                                                                                                                                                
            StatusBlock.Text = "Kupiono: " + playerName;

            PlayerBox.Items.Remove(player);

            if (PlayerBox.Items.Count > 0)
            {
                PlayerBox.SelectedIndex = 0;
            }
            else
            {
                StatusBlock.Text += "\nRynek jest pusty!";
            }
        }

    }
}
