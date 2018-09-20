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
            .Or(Parse.String("dou").Select(x => JapaneseSyllable.Dou))
            .Or(Parse.String("sou").Select(x => JapaneseSyllable.Sou))
            .Or(Parse.String("zou").Select(x => JapaneseSyllable.Zou))
            .Or(Parse.String("nou").Select(x => JapaneseSyllable.Nou))
            .Or(Parse.String("hou").Select(x => JapaneseSyllable.Hou))
            .Or(Parse.String("bou").Select(x => JapaneseSyllable.Bou))
            .Or(Parse.String("pou").Select(x => JapaneseSyllable.Pou))
            .Or(Parse.String("mou").Select(x => JapaneseSyllable.Mou))
            .Or(Parse.String("rou").Select(x => JapaneseSyllable.Rou))
            .Or(Parse.String("you").Select(x => JapaneseSyllable.You));

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

        private static readonly Parser<JapaneseSyllable> sSyllables =
            Parse.String("sa").Select(x => JapaneseSyllable.Sa)
            .Or(Parse.String("shi").Select(x => JapaneseSyllable.Shi))
            .Or(Parse.String("su").Select(x => JapaneseSyllable.Su))
            .Or(Parse.String("se").Select(x => JapaneseSyllable.Se))
            .Or(Parse.String("so").Select(x => JapaneseSyllable.So));

        private static readonly Parser<JapaneseSyllable> zSyllables =
            Parse.String("za").Select(x => JapaneseSyllable.Za)
            .Or(Parse.String("ji").Select(x => JapaneseSyllable.Ji))
            .Or(Parse.String("zu").Select(x => JapaneseSyllable.Zu))
            .Or(Parse.String("ze").Select(x => JapaneseSyllable.Ze))
            .Or(Parse.String("zo").Select(x => JapaneseSyllable.Zo));

        private static readonly Parser<JapaneseSyllable> nSyllables =
            Parse.String("na").Select(x => JapaneseSyllable.Na)
            .Or(Parse.String("ni").Select(x => JapaneseSyllable.Ni))
            .Or(Parse.String("nu").Select(x => JapaneseSyllable.Nu))
            .Or(Parse.String("ne").Select(x => JapaneseSyllable.Ne))
            .Or(Parse.String("no").Select(x => JapaneseSyllable.No));

        private static readonly Parser<JapaneseSyllable> hSyllables =
            Parse.String("ha").Select(x => JapaneseSyllable.Ha)
            .Or(Parse.String("hi").Select(x => JapaneseSyllable.Hi))
            .Or(Parse.String("fu").Select(x => JapaneseSyllable.Fu))
            .Or(Parse.String("he").Select(x => JapaneseSyllable.He))
            .Or(Parse.String("ho").Select(x => JapaneseSyllable.Ho));

        private static readonly Parser<JapaneseSyllable> bSyllables =
            Parse.String("ba").Select(x => JapaneseSyllable.Ba)
            .Or(Parse.String("bi").Select(x => JapaneseSyllable.Bi))
            .Or(Parse.String("bu").Select(x => JapaneseSyllable.Bu))
            .Or(Parse.String("be").Select(x => JapaneseSyllable.Be))
            .Or(Parse.String("bo").Select(x => JapaneseSyllable.Bo));

        private static readonly Parser<JapaneseSyllable> pSyllables =
            Parse.String("pa").Select(x => JapaneseSyllable.Pa)
            .Or(Parse.String("pi").Select(x => JapaneseSyllable.Pi))
            .Or(Parse.String("pu").Select(x => JapaneseSyllable.Pu))
            .Or(Parse.String("pe").Select(x => JapaneseSyllable.Pe))
            .Or(Parse.String("po").Select(x => JapaneseSyllable.Po));

        private static readonly Parser<JapaneseSyllable> mSyllables =
            Parse.String("ma").Select(x => JapaneseSyllable.Ma)
            .Or(Parse.String("mi").Select(x => JapaneseSyllable.Mi))
            .Or(Parse.String("mu").Select(x => JapaneseSyllable.Mu))
            .Or(Parse.String("me").Select(x => JapaneseSyllable.Me))
            .Or(Parse.String("mo").Select(x => JapaneseSyllable.Mo));

        private static readonly Parser<JapaneseSyllable> rSyllables =
            Parse.String("ra").Select(x => JapaneseSyllable.Ra)
            .Or(Parse.String("ri").Select(x => JapaneseSyllable.Ri))
            .Or(Parse.String("ru").Select(x => JapaneseSyllable.Ru))
            .Or(Parse.String("re").Select(x => JapaneseSyllable.Re))
            .Or(Parse.String("ro").Select(x => JapaneseSyllable.Ro));

        private static readonly Parser<JapaneseSyllable> ySyllables =
            Parse.String("ya").Select(x => JapaneseSyllable.Ya)
            .Or(Parse.String("yu").Select(x => JapaneseSyllable.Yu))
            .Or(Parse.String("yo").Select(x => JapaneseSyllable.Yo));

        private static readonly Parser<JapaneseSyllable> wSyllables =
            Parse.String("wa").Select(x => JapaneseSyllable.Wa)
            .Or(Parse.String("wo").Select(x => JapaneseSyllable.Wo));

        private static readonly Parser<JapaneseSyllable> nnSyllable =
            Parse.String("n").Select(x => JapaneseSyllable.N);

        private static readonly Parser<JapaneseSyllable> Syllable =
            longOSyllables
            .Or(kSyllables)
            .Or(gSyllables)
            .Or(tSyllables)
            .Or(dSyllables)
            .Or(sSyllables)
            .Or(zSyllables)
            .Or(nSyllables)
            .Or(hSyllables)
            .Or(bSyllables)
            .Or(pSyllables)
            .Or(mSyllables)
            .Or(rSyllables)
            .Or(ySyllables)    
            .Or(wSyllables)
            .Or(shortSyllables)
            .Or(nnSyllable);

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
