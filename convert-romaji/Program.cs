using battousai.jpParse;
using System;

namespace convert_romaji
{
    class Program
    {
        static void Main(string[] args)
        {
            var romaji = String.Join(" ", args);

            if (String.IsNullOrWhiteSpace(romaji))
                return;

            var hiragana = NihonParser.ToHiragana(romaji);
            var katakana = NihonParser.ToKatakana(romaji);

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(hiragana);
            Console.WriteLine(katakana);
        }
    }
}
