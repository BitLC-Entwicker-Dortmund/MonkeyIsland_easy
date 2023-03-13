namespace MonkeyIsland_easy {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Piratenwelt!");

            Schiff schiff = new Schiff();

            Insel insel = new Insel();
            Console.WriteLine(  insel.GetKneipe().GetHashCode() );

            Meer meer = new Meer();
            meer.SetSchiff(schiff);
            Console.WriteLine( meer.GetSchiff().GetHashCode() );    


            Console.Read();
        }
    }
}