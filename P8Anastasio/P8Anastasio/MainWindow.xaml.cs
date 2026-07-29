using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace P8Anastasio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BindingList<Card> cards = new BindingList<Card>();
        private Card currentCard;
        public DBManager dBManager = new DBManager();
        public MainWindow()
        {
            InitializeComponent();

            dBManager.GetCards(cards);
            lbxmCards.ItemsSource = cards;
            GetRandomCard();
            DisplayCardQuestion();
        }

        private void GetRandomCard()
        {
            Random rand = new Random();

            int index = rand.Next(cards.Count);

            currentCard = cards[index];
        }

        private void DisplayCardQuestion()
        {
            lblCardID.Content = currentCard.CardID;
            tbxTitle.Text = currentCard.Title;
            tbxQuestion.Text = currentCard.Question;
            tbxRules.Text = "Think about the Answer then click Show Answer button";
        }

        public void tabMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabMain.SelectedItem is TabItem selectedTab)
            {
                switch (selectedTab.Header.ToString())
                {
                    case "Flash Cards":
                        GetRandomCard();
                        DisplayCardQuestion();
                        break;

                    case "Manage Cards":
                        dBManager.GetCards(cards);
                        tbxmRules.Text = "Fill the content on the right to Add a card, double click on a card on the right to edit then Update a card, double click on a card to Remove a card";
                        break;
                }
            }
        }

        public void btnShowAnswer_Click(object sender, RoutedEventArgs e)
        {
            tbxAnswers.Text = currentCard.Answer;
            tbxRules.Text = "If you got it right click Right, if not click Wrong";
        }

        public void btnRight_Click(object sender, RoutedEventArgs e)
        {
            currentCard.NumRight += 1;
            dBManager.UpdateCard(currentCard);

            GetRandomCard();
            DisplayCardQuestion();
        }

        public void btnWrong_Click(object sender, RoutedEventArgs e)
        {
            currentCard.NumWrong += 1;
            dBManager.UpdateCard(currentCard);

            GetRandomCard();
            DisplayCardQuestion();
        }

        public void lbxmCards_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lbxmCards.SelectedItem == null)
            {
                return;
            }

            currentCard = (Card)lbxmCards.SelectedItem;

            lblmCardID.Content = currentCard.CardID;
            tbxmTitle.Text = currentCard.Title;
            tbxmQuestion.Text = currentCard.Question;
            tbxmAnswer.Text = currentCard.Answer;
        }

        public void btnmAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Card newCard = new Card(0,
                    tbxmTitle.Text,
                    tbxmQuestion.Text,
                    tbxmAnswer.Text,
                    0,
                    0);

                dBManager.AddCard(newCard);
                dBManager.GetCards(cards);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void btnmUpdate_Click(object sender, RoutedEventArgs e)
        {
            currentCard.Title = tbxmTitle.Text;
            currentCard.Question = tbxmQuestion.Text;
            currentCard.Answer = tbxmAnswer.Text;


            dBManager.UpdateCard(currentCard);
            dBManager.GetCards(cards);
        }

        public void btnmRemove_Click(object sender, RoutedEventArgs e)
        {
            dBManager.RemoveCard(currentCard);

            dBManager.GetCards(cards);

        }
    }
}