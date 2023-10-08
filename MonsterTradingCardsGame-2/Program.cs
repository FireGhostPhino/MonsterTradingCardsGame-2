namespace MonsterTradingCardsGame_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm MonsterTradingCardsGame Start 1!\n");

            Card cardMonster = new MonsterCard();
            Card cardSpell = new SpellCard();

            cardMonster.TestMethod();
            cardSpell.TestMethod();
            Console.WriteLine($"Type of Card: {cardMonster.CardType}");
            Console.WriteLine($"Type of Card: {cardSpell.CardType}");

            cardMonster.TestParentClass();

            Console.WriteLine("\nProgramm End!");
        }
    }
}