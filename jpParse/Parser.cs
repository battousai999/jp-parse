using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;

namespace battousai.jpParse
{
    public static class NihonParser
    {
        public static string ToHiragana(string text)
        {
            return GetTerms(HiraganaMapper.Map).Parse(text);
        }

        private static Parser<string> GetTerms(Func<JapaneseSyllable, string> mapper)
        {
            return Terms.End().Select(termSet => String.Join(" ", termSet.Terms.Select(term => String.Join("", term.Syllables.Select(x => mapper(x))))));
        }

        private static readonly Parser<JapaneseSyllable> Syllable =
            Parse.String("kou").Select(x => JapaneseSyllable.Kou)
            .Or(Parse.String("a").Select(x => JapaneseSyllable.A))
            .Or(Parse.String("i").Select(x => JapaneseSyllable.I))
            .Or(Parse.String("u").Select(x => JapaneseSyllable.U))
            .Or(Parse.String("e").Select(x => JapaneseSyllable.E))
            .Or(Parse.String("o").Select(x => JapaneseSyllable.O))
            .Or(Parse.String("ka").Select(x => JapaneseSyllable.Ka))
            .Or(Parse.String("ki").Select(x => JapaneseSyllable.Ki))
            .Or(Parse.String("ku").Select(x => JapaneseSyllable.Ku))
            .Or(Parse.String("ke").Select(x => JapaneseSyllable.Ke))
            .Or(Parse.String("ko").Select(x => JapaneseSyllable.Ko));

        private static readonly Parser<Term> Term = Syllable.Many().Select(x => new Term { Syllables = x });

        private static readonly Parser<TermSet> Terms = Term.Many().Select(x => new TermSet { Terms = x });
    }

    public class TermSet
    {
        public IEnumerable<Term> Terms { get; set; }
    }

    public class Term
    {
        public IEnumerable<JapaneseSyllable> Syllables { get; set; }
    }
}
