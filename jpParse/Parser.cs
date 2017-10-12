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
            if (String.IsNullOrWhiteSpace(text))
                return text;

            return GetTerms(HiraganaMapper.Map).Parse(text.ToLower());
        }

        private static Parser<string> GetTerms(Func<JapaneseSyllable, string> mapper)
        {
            Func<string, IEnumerable<string>, string> join = (delimiter, list) => String.Join(delimiter, list);

            return Terms.End()
                .Select(termSet =>
                {
                    var words = termSet.Terms.Select(term => join("", term.Syllables.Select(x => mapper(x))));

                    return join(" ", words);
                });
        }

        private static readonly Parser<JapaneseSyllable> longOSyllables = Parse.String("kou").Select(x => JapaneseSyllable.Kou)
            .Or(Parse.String("gou").Select(x => JapaneseSyllable.Gou))
            .Or(Parse.String("tou").Select(x => JapaneseSyllable.Tou))
            .Or(Parse.String("dou").Select(x => JapaneseSyllable.Dou));

        private static readonly Parser<JapaneseSyllable> shortSyllables =
            Parse.String("a").Select(x => JapaneseSyllable.A)
            .Or(Parse.String("i").Select(x => JapaneseSyllable.I))
            .Or(Parse.String("u").Select(x => JapaneseSyllable.U))
            .Or(Parse.String("e").Select(x => JapaneseSyllable.E))
            .Or(Parse.String("o").Select(x => JapaneseSyllable.O));

        private static readonly Parser<JapaneseSyllable> kSyllables =
            Parse.String("ka").Select(x => JapaneseSyllable.Ka)
            .Or(Parse.String("ki").Select(x => JapaneseSyllable.Ki))
            .Or(Parse.String("ku").Select(x => JapaneseSyllable.Ku))
            .Or(Parse.String("ke").Select(x => JapaneseSyllable.Ke))
            .Or(Parse.String("ko").Select(x => JapaneseSyllable.Ko));

        private static readonly Parser<JapaneseSyllable> gSyllables =
            Parse.String("ga").Select(x => JapaneseSyllable.Ga)
            .Or(Parse.String("gi").Select(x => JapaneseSyllable.Gi))
            .Or(Parse.String("gu").Select(x => JapaneseSyllable.Gu))
            .Or(Parse.String("ge").Select(x => JapaneseSyllable.Ge))
            .Or(Parse.String("go").Select(x => JapaneseSyllable.Go));

        private static readonly Parser<JapaneseSyllable> tSyllables =
            Parse.String("ta").Select(x => JapaneseSyllable.Ta)
            .Or(Parse.String("chi").Select(x => JapaneseSyllable.Chi))
            .Or(Parse.String("tsu").Select(x => JapaneseSyllable.Tsu))
            .Or(Parse.String("te").Select(x => JapaneseSyllable.Te))
            .Or(Parse.String("to").Select(x => JapaneseSyllable.To));

        private static readonly Parser<JapaneseSyllable> dSyllables =
            Parse.String("da").Select(x => JapaneseSyllable.Da)
            .Or(Parse.String("di").Select(x => JapaneseSyllable.Di))
            .Or(Parse.String("du").Select(x => JapaneseSyllable.Du))
            .Or(Parse.String("de").Select(x => JapaneseSyllable.De))
            .Or(Parse.String("do").Select(x => JapaneseSyllable.Do));

        private static readonly Parser<JapaneseSyllable> Syllable =
            longOSyllables
            .Or(shortSyllables)
            .Or(kSyllables)
            .Or(gSyllables)
            .Or(tSyllables)
            .Or(dSyllables);

        private static readonly Parser<Term> Term = Syllable.AtLeastOnce().Select(x => new Term { Syllables = x });

        private static readonly Parser<Term> TermWithSeparator =
            from sp in Parse.WhiteSpace
            from term in Term
            select term;

        private static readonly Parser<TermSet> Terms =
            (Term.Or(TermWithSeparator)).Many().Select(x => new TermSet { Terms = x });
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
