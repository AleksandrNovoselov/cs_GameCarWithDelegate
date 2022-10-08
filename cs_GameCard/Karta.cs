namespace cs_GameCard
{
    public class Karta
    {
        public readonly KartaValue value;
        public readonly KartaSuit suit;

        public Karta(KartaValue value, KartaSuit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{value} {suit}";
        }
    }

    public enum KartaValue
    { Шесть, Семь, Восемь, Девять, Десять, Валет, Дама, Король, Туз }

    public enum KartaSuit
    {
        Черви = 0, Буби, Пики, Крести
    }
}