using System;
using Xunit;
using battousai.jpParse;

namespace jpParse_core.Tests
{
    public class HiraganaSyllableTests
    {
        private void CheckParse(string roumaji, string hiragana)
        {
            Assert.Equal(hiragana, NihonParser.ToHiragana(roumaji));
        }

        [Fact]
        public void CanParse_A()
        {
            CheckParse("a", "あ");
        }

        [Fact]
        public void CanParse_I()
        {
            CheckParse("i", "い");
        }

        [Fact]
        public void CanParse_U()
        {
            CheckParse("u", "う");
        }

        [Fact]
        public void CanParse_E()
        {
            CheckParse("e", "え");
        }

        [Fact]
        public void CanParse_O()
        {
            CheckParse("o", "お");
        }

        [Fact]
        public void CanParse_Ka()
        {
            CheckParse("ka", "か");
        }

        [Fact]
        public void CanParse_Ki()
        {
            CheckParse("ki", "き");
        }

        [Fact]
        public void CanParse_Ku()
        {
            CheckParse("ku", "く");
        }

        [Fact]
        public void CanParse_Ke()
        {
            CheckParse("ke", "け");
        }

        [Fact]
        public void CanParse_Ko()
        {
            CheckParse("ko", "こ");
        }

        [Fact]
        public void CanParse_Kou()
        {
            CheckParse("kou", "こう");
        }

        [Fact]
        public void CanParse_Ga()
        {
            CheckParse("ga", "が");
        }

        [Fact]
        public void CanParse_Gi()
        {
            CheckParse("gi", "ぎ");
        }

        [Fact]
        public void CanParse_Gu()
        {
            CheckParse("gu", "ぐ");
        }

        [Fact]
        public void CanParse_Ge()
        {
            CheckParse("ge", "げ");
        }

        [Fact]
        public void CanParse_Go()
        {
            CheckParse("go", "ご");
        }

        [Fact]
        public void CanParse_Gou()
        {
            CheckParse("gou", "ごう");
        }

        [Fact]
        public void CanParse_Ta()
        {
            CheckParse("ta", "た");
        }

        [Fact]
        public void CanParse_Chi()
        {
            CheckParse("chi", "ち");
        }

        [Fact]
        public void CanParse_Tsu()
        {
            CheckParse("tsu", "つ");
        }

        [Fact]
        public void CanParse_Te()
        {
            CheckParse("te", "て");
        }

        [Fact]
        public void CanParse_To()
        {
            CheckParse("to", "と");
        }

        [Fact]
        public void CanParse_Tou()
        {
            CheckParse("tou", "とう");
        }

        [Fact]
        public void CanParse_Da()
        {
            CheckParse("da", "だ");
        }

        [Fact]
        public void CanParse_Di()
        {
            CheckParse("di", "ぢ");
        }

        [Fact]
        public void CanParse_Du()
        {
            CheckParse("du", "づ");
        }

        [Fact]
        public void CanParse_De()
        {
            CheckParse("de", "で");
        }

        [Fact]
        public void CanParse_Do()
        {
            CheckParse("do", "ど");
        }

        [Fact]
        public void CanParse_Dou()
        {
            CheckParse("dou", "どう");
        }

        [Fact]
        public void CanParse_Sa()
        {
            CheckParse("sa", "さ");
        }

        [Fact]
        public void CanParse_Shi()
        {
            CheckParse("shi", "し");
        }

        [Fact]
        public void CanParse_Su()
        {
            CheckParse("su", "す");
        }

        [Fact]
        public void CanParse_Se()
        {
            CheckParse("se", "せ");
        }

        [Fact]
        public void CanParse_So()
        {
            CheckParse("so", "そ");
        }

        [Fact]
        public void CanParse_Sou()
        {
            CheckParse("sou", "そう");
        }

        [Fact]
        public void CanParse_Za()
        {
            CheckParse("za", "ざ");
        }

        [Fact]
        public void CanParse_Ji()
        {
            CheckParse("ji", "じ");
        }

        [Fact]
        public void CanParse_Zu()
        {
            CheckParse("zu", "ず");
        }

        [Fact]
        public void CanParse_Ze()
        {
            CheckParse("ze", "ぜ");
        }

        [Fact]
        public void CanParse_Zo()
        {
            CheckParse("zo", "ぞ");
        }

        [Fact]
        public void CanParse_Zou()
        {
            CheckParse("zou", "ぞう");
        }

        [Fact]
        public void CanParse_Na()
        {
            CheckParse("na", "な");
        }

        [Fact]
        public void CanParse_Ni()
        {
            CheckParse("ni", "に");
        }

        [Fact]
        public void CanParse_Nu()
        {
            CheckParse("nu", "ぬ");
        }

        [Fact]
        public void CanParse_Ne()
        {
            CheckParse("ne", "ね");
        }

        [Fact]
        public void CanParse_No()
        {
            CheckParse("no", "の");
        }

        [Fact]
        public void CanParse_Nou()
        {
            CheckParse("nou", "のう");
        }

        [Fact]
        public void CanParse_Ha()
        {
            CheckParse("ha", "は");
        }

        [Fact]
        public void CanParse_Hi()
        {
            CheckParse("hi", "ひ");
        }

        [Fact]
        public void CanParse_Fu()
        {
            CheckParse("fu", "ふ");
        }

        [Fact]
        public void CanParse_He()
        {
            CheckParse("he", "へ");
        }

        [Fact]
        public void CanParse_Ho()
        {
            CheckParse("ho", "ほ");
        }

        [Fact]
        public void CanParse_Hou()
        {
            CheckParse("hou", "ほう");
        }

        [Fact]
        public void CanParse_Ba()
        {
            CheckParse("ba", "ば");
        }

        [Fact]
        public void CanParse_Bi()
        {
            CheckParse("bi", "び");
        }

        [Fact]
        public void CanParse_Bu()
        {
            CheckParse("bu", "ぶ");
        }

        [Fact]
        public void CanParse_Be()
        {
            CheckParse("be", "べ");
        }

        [Fact]
        public void CanParse_Bo()
        {
            CheckParse("bo", "ぼ");
        }

        [Fact]
        public void CanParse_Bou()
        {
            CheckParse("bou", "ぼう");
        }

        [Fact]
        public void CanParse_Pa()
        {
            CheckParse("pa", "ぱ");
        }

        [Fact]
        public void CanParse_Pi()
        {
            CheckParse("pi", "ぴ");
        }

        [Fact]
        public void CanParse_Pu()
        {
            CheckParse("pu", "ぷ");
        }

        [Fact]
        public void CanParse_Pe()
        {
            CheckParse("pe", "ぺ");
        }

        [Fact]
        public void CanParse_Po()
        {
            CheckParse("po", "ぽ");
        }

        [Fact]
        public void CanParse_Pou()
        {
            CheckParse("pou", "ぽう");
        }

        [Fact]
        public void CanParse_Ma()
        {
            CheckParse("ma", "ま");
        }

        [Fact]
        public void CanParse_Mi()
        {
            CheckParse("mi", "み");
        }

        [Fact]
        public void CanParse_Mu()
        {
            CheckParse("mu", "む");
        }

        [Fact]
        public void CanParse_Me()
        {
            CheckParse("me", "め");
        }

        [Fact]
        public void CanParse_Mo()
        {
            CheckParse("mo", "も");
        }

        [Fact]
        public void CanParse_Mou()
        {
            CheckParse("mou", "もう");
        }

        [Fact]
        public void CanParse_Ra()
        {
            CheckParse("ra", "ら");
        }

        [Fact]
        public void CanParse_Ri()
        {
            CheckParse("ri", "り");
        }

        [Fact]
        public void CanParse_Ru()
        {
            CheckParse("ru", "る");
        }

        [Fact]
        public void CanParse_Re()
        {
            CheckParse("re", "れ");
        }

        [Fact]
        public void CanParse_Ro()
        {
            CheckParse("ro", "ろ");
        }

        [Fact]
        public void CanParse_Rou()
        {
            CheckParse("rou", "ろう");
        }

        [Fact]
        public void CanParse_Ya()
        {
            CheckParse("ya", "や");
        }

        [Fact]
        public void CanParse_Yu()
        {
            CheckParse("yu", "ゆ");
        }

        [Fact]
        public void CanParse_Yo()
        {
            CheckParse("yo", "よ");
        }

        [Fact]
        public void CanParse_You()
        {
            CheckParse("you", "よう");
        }

        [Fact]
        public void CanParse_Wa()
        {
            CheckParse("wa", "わ");
        }

        [Fact]
        public void CanParse_Wo()
        {
            CheckParse("wo", "を");
        }

        [Fact]
        public void CanParse_Nn()
        {
            CheckParse("n", "ん");
        }

        [Fact]
        public void CanParse_Kya()
        {
            CheckParse("kya", "きゃ");
        }

        [Fact]
        public void CanParse_Kyu()
        {
            CheckParse("kyu", "きゅ");
        }

        [Fact]
        public void CanParse_Kyo()
        {
            CheckParse("kyo", "きょ");
        }

        [Fact]
        public void CanParse_Gya()
        {
            CheckParse("gya", "ぎゃ");
        }

        [Fact]
        public void CanParse_Gyu()
        {
            CheckParse("gyu", "ぎゅ");
        }

        [Fact]
        public void CanParse_Gyo()
        {
            CheckParse("gyo", "ぎょ");
        }

        [Fact]
        public void CanParse_Nya()
        {
            CheckParse("nya", "にゃ");
        }

        [Fact]
        public void CanParse_Nyu()
        {
            CheckParse("nyu", "にゅ");
        }

        [Fact]
        public void CanParse_Nyo()
        {
            CheckParse("nyo", "にょ");
        }

        [Fact]
        public void CanParse_Hya()
        {
            CheckParse("hya", "ひゃ");
        }

        [Fact]
        public void CanParse_Hyu()
        {
            CheckParse("hyu", "ひゅ");
        }

        [Fact]
        public void CanParse_Hyo()
        {
            CheckParse("hyo", "ひょ");
        }

        [Fact]
        public void CanParse_Bya()
        {
            CheckParse("bya", "びゃ");
        }

        [Fact]
        public void CanParse_Byu()
        {
            CheckParse("byu", "びゅ");
        }

        [Fact]
        public void CanParse_Byo()
        {
            CheckParse("byo", "びょ");
        }

        [Fact]
        public void CanParse_Pya()
        {
            CheckParse("pya", "ぴゃ");
        }

        [Fact]
        public void CanParse_Pyu()
        {
            CheckParse("pyu", "ぴゅ");
        }

        [Fact]
        public void CanParse_Pyo()
        {
            CheckParse("pyo", "ぴょ");
        }

        [Fact]
        public void CanParse_Mya()
        {
            CheckParse("mya", "みゃ");
        }

        [Fact]
        public void CanParse_Myu()
        {
            CheckParse("myu", "みゅ");
        }

        [Fact]
        public void CanParse_Myo()
        {
            CheckParse("myo", "みょ");
        }

        [Fact]
        public void CanParse_Rya()
        {
            CheckParse("rya", "りゃ");
        }

        [Fact]
        public void CanParse_Ryu()
        {
            CheckParse("ryu", "りゅ");
        }

        [Fact]
        public void CanParse_Ryo()
        {
            CheckParse("ryo", "りょ");
        }

        [Fact]
        public void CanParse_Ja()
        {
            CheckParse("ja", "じゃ");
        }

        [Fact]
        public void CanParse_Ju()
        {
            CheckParse("ju", "じゅ");
        }

        [Fact]
        public void CanParse_Jo()
        {
            CheckParse("jo", "じょ");
        }

        [Fact]
        public void CanParse_Cha()
        {
            CheckParse("cha", "ちゃ");
        }

        [Fact]
        public void CanParse_Chu()
        {
            CheckParse("chu", "ちゅ");
        }

        [Fact]
        public void CanParse_Cho()
        {
            CheckParse("cho", "ちょ");
        }

        [Fact]
        public void CanParse_Sha()
        {
            CheckParse("sha", "しゃ");
        }

        [Fact]
        public void CanParse_Shu()
        {
            CheckParse("shu", "しゅ");
        }

        [Fact]
        public void CanParse_Sho()
        {
            CheckParse("sho", "しょ");
        }

        [Fact]
        public void CanParse_Kka()
        {
            CheckParse("kka", "っか");
        }

        [Fact]
        public void CanParse_Kki()
        {
            CheckParse("kki", "っき");
        }

        [Fact]
        public void CanParse_Kku()
        {
            CheckParse("kku", "っく");
        }

        [Fact]
        public void CanParse_Kke()
        {
            CheckParse("kke", "っけ");
        }

        [Fact]
        public void CanParse_Kko()
        {
            CheckParse("kko", "っこ");
        }

        [Fact]
        public void CanParse_Ssa()
        {
            CheckParse("ssa", "っさ");
        }

        [Fact]
        public void CanParse_Ssi()
        {
            CheckParse("sshi", "っし");
        }

        [Fact]
        public void CanParse_Ssu()
        {
            CheckParse("ssu", "っす");
        }

        [Fact]
        public void CanParse_Sse()
        {
            CheckParse("sse", "っせ");
        }

        [Fact]
        public void CanParse_Sso()
        {
            CheckParse("sso", "っそ");
        }

        [Fact]
        public void CanParse_Tta()
        {
            CheckParse("tta", "った");
        }

        [Fact]
        public void CanParse_Cchi()
        {
            CheckParse("cchi", "っち");
        }

        [Fact]
        public void CanParse_Ttsu()
        {
            CheckParse("ttsu", "っつ");
        }

        [Fact]
        public void CanParse_Tte()
        {
            CheckParse("tte", "って");
        }

        [Fact]
        public void CanParse_Tto()
        {
            CheckParse("tto", "っと");
        }
        
        [Fact]
        public void CanParse_Bba()
        {
            CheckParse("bba", "っば");
        }

        [Fact]
        public void CanParse_Bbi()
        {
            CheckParse("bbi", "っび");
        }

        [Fact]
        public void CanParse_Bbu()
        {
            CheckParse("bbu", "っぶ");
        }

        [Fact]
        public void CanParse_Bbe()
        {
            CheckParse("bbe", "っべ");
        }

        [Fact]
        public void CanParse_Bbo()
        {
            CheckParse("bbo", "っぼ");
        }

        [Fact]
        public void CanParse_Ppa()
        {
            CheckParse("ppa", "っぱ");
        }

        [Fact]
        public void CanParse_Ppi()
        {
            CheckParse("ppi", "っぴ");
        }

        [Fact]
        public void CanParse_Ppu()
        {
            CheckParse("ppu", "っぷ");
        }

        [Fact]
        public void CanParse_Ppe()
        {
            CheckParse("ppe", "っぺ");
        }

        [Fact]
        public void CanParse_Ppo()
        {
            CheckParse("ppo", "っぽ");
        }

        [Fact]
        public void CanParseMultipleSyllables()
        {
            CheckParse("ako", "あこ");
        }

        [Fact]
        public void CanParseMultipleSyllablesIncludingSokuons()
        {
            CheckParse("battousai", "ばっとうさい");
        }

        [Fact]
        public void CanParseMultipleWords1()
        {
            CheckParse("atoka itedo", "あとか いてど");
        }

        [Fact]
        public void CanParseMultipleWords2()
        {
            CheckParse("katsu getou akate", "かつ げとう あかて");
        }

        [Fact]
        public void CanParseComplicatedNs()
        {
            CheckParse("konnichi", "こんにち");
        }
    }
}
