namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string? line = Console.ReadLine();

            if ( int.TryParse(line, out int numberOfCards))
            {
                //foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                //{
                //    Console.WriteLine(card);
                //}     This was my answer to the exercise, but the book's answer is below.

                string[] cards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in cards)
                {
                    Console.WriteLine(card);
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
