namespace indexer_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Favouritbook book = new Favouritbook (8);
            book[1, "sunshine evrey day"] = "joy";
            book[2, "ask why"] = "Temothy";
            book[3, "Hw to kill Man"] = "Agatha";
            Console.WriteLine(book["sunshine evrey day"]);

        }
    }
}