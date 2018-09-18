/*/Christine Cullen 
 * Spring 2018
 * CIS269 Software Maintenance
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player (String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += name + " has just joined the game." + Environment.NewLine;
        }
        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i=1;i<=13;i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if(howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }
        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text += Name + " has " + cardsIHave.Count + " " + Card.Plural(value) + Environment.NewLine;
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
                if (cards.Count == 0)
                    cards.Add(stock.Deal(myIndex));
            Values randomValue = GetRandomValue();
            AskForACard(players, myIndex, stock, randomValue);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += Name + " asks if anyone has a " + value + Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    //while (CardsGiven.Count > 0) was adding index of player not cards needed
                    for(int x = 0; x <= CardsGiven.Count-1;++x)
                        cards.Add(CardsGiven.Deal(x));
                }
            }
            //move out of loop so only happens after you find the card not after asking each person
            if (totalCardsGiven == 0 && stock.Count > 0)
            {
                textBoxOnForm.Text += Name + " must draw from the stock." + Environment.NewLine;
                cards.Add(stock.Deal(0));//correct element to 0
            }
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

    }
}
