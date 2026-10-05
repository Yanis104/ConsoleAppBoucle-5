namespace ConsoleAppBoucle_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consommation = 100;
            double doublement = consommation * 2;
            int annees = 0;

            while (consommation < doublement)
            {
                consommation = consommation * 1.08;
                annees = annees + 1;
            }

            Console.WriteLine("La consommation aura doublé après " + annees + " ans.");
        }
    }
}
