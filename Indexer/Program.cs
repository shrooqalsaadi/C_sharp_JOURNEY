using System.Runtime.Intrinsics.X86;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phoneBook b1 = new phoneBook (7);
            b1[1, "sh"] = "345";
            b1[2, "joy"] = "987";
            Console.WriteLine(b1.getValue( "sh"));

        }
    }
}