using battousai.jpParse;
using System;

namespace jptrans
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                return;

            var translation = NihonParser.ToHiragana(args[0]);

            Console.WriteLine(translation);
        }
    }
}
