using System;
using Xunit;
using battousai.jpParse;

namespace jpParse_core.Tests
{
    public class HiraganaSyllableTests
    {
        [Fact]
        public void CanParse_A()
        {
            var value = NihonParser.ToHiragana("a");

            Assert.Equal("あ", value);
        }

        [Fact]
        public void CanParse_I()
        {
            var value = NihonParser.ToHiragana("i");

            Assert.Equal("い", value);
        }

        [Fact]
        public void CanParse_U()
        {
            var value = NihonParser.ToHiragana("u");

            Assert.Equal("う", value);
        }

        [Fact]
        public void CanParse_E()
        {
            var value = NihonParser.ToHiragana("e");

            Assert.Equal("え", value);
        }

        [Fact]
        public void CanParse_O()
        {
            var value = NihonParser.ToHiragana("o");

            Assert.Equal("お", value);
        }

        [Fact]
        public void CanParse_Ka()
        {
            var value = NihonParser.ToHiragana("ka");

            Assert.Equal("か", value);
        }

        [Fact]
        public void CanParse_Ki()
        {
            var value = NihonParser.ToHiragana("ki");

            Assert.Equal("き", value);
        }

        [Fact]
        public void CanParse_Ku()
        {
            var value = NihonParser.ToHiragana("ku");

            Assert.Equal("く", value);
        }

        [Fact]
        public void CanParse_Ke()
        {
            var value = NihonParser.ToHiragana("ke");

            Assert.Equal("け", value);
        }

        [Fact]
        public void CanParse_Ko()
        {
            var value = NihonParser.ToHiragana("ko");

            Assert.Equal("こ", value);
        }

        [Fact]
        public void CanParse_Kou()
        {
            var value = NihonParser.ToHiragana("kou");

            Assert.Equal("こう", value);
        }

        [Fact]
        public void CanParse_Ga()
        {
            var value = NihonParser.ToHiragana("ga");

            Assert.Equal("が", value);
        }

        [Fact]
        public void CanParse_Gi()
        {
            var value = NihonParser.ToHiragana("gi");

            Assert.Equal("ぎ", value);
        }

        [Fact]
        public void CanParse_Gu()
        {
            var value = NihonParser.ToHiragana("gu");

            Assert.Equal("ぐ", value);
        }

        [Fact]
        public void CanParse_Ge()
        {
            var value = NihonParser.ToHiragana("ge");

            Assert.Equal("げ", value);
        }

        [Fact]
        public void CanParse_Go()
        {
            var value = NihonParser.ToHiragana("go");

            Assert.Equal("ご", value);
        }

        [Fact]
        public void CanParse_Gou()
        {
            var value = NihonParser.ToHiragana("gou");

            Assert.Equal("ごう", value);
        }

        [Fact]
        public void CanParse_Ta()
        {
            var value = NihonParser.ToHiragana("ta");

            Assert.Equal("た", value);
        }

        [Fact]
        public void CanParse_Chi()
        {
            var value = NihonParser.ToHiragana("chi");

            Assert.Equal("ち", value);
        }

        [Fact]
        public void CanParse_Tsu()
        {
            var value = NihonParser.ToHiragana("tsu");

            Assert.Equal("つ", value);
        }

        [Fact]
        public void CanParse_Te()
        {
            var value = NihonParser.ToHiragana("te");

            Assert.Equal("て", value);
        }

        [Fact]
        public void CanParse_To()
        {
            var value = NihonParser.ToHiragana("to");

            Assert.Equal("と", value);
        }

        [Fact]
        public void CanParse_Tou()
        {
            var value = NihonParser.ToHiragana("tou");

            Assert.Equal("とう", value);
        }

        [Fact]
        public void CanParse_Da()
        {
            var value = NihonParser.ToHiragana("da");

            Assert.Equal("だ", value);
        }

        [Fact]
        public void CanParse_Di()
        {
            var value = NihonParser.ToHiragana("di");

            Assert.Equal("ぢ", value);
        }

        [Fact]
        public void CanParse_Du()
        {
            var value = NihonParser.ToHiragana("du");

            Assert.Equal("づ", value);
        }

        [Fact]
        public void CanParse_De()
        {
            var value = NihonParser.ToHiragana("de");

            Assert.Equal("で", value);
        }

        [Fact]
        public void CanParse_Do()
        {
            var value = NihonParser.ToHiragana("do");

            Assert.Equal("ど", value);
        }

        [Fact]
        public void CanParse_Dou()
        {
            var value = NihonParser.ToHiragana("dou");

            Assert.Equal("どう", value);
        }

        [Fact]
        public void CanParse_Sa()
        {
            var value = NihonParser.ToHiragana("sa");

            Assert.Equal("さ", value);
        }

        [Fact]
        public void CanParse_Shi()
        {
            var value = NihonParser.ToHiragana("shi");

            Assert.Equal("し", value);
        }

        [Fact]
        public void CanParse_Su()
        {
            var value = NihonParser.ToHiragana("su");

            Assert.Equal("す", value);
        }

        [Fact]
        public void CanParse_Se()
        {
            var value = NihonParser.ToHiragana("se");

            Assert.Equal("せ", value);
        }

        [Fact]
        public void CanParse_So()
        {
            var value = NihonParser.ToHiragana("so");

            Assert.Equal("そ", value);
        }

        [Fact]
        public void CanParse_Sou()
        {
            var value = NihonParser.ToHiragana("sou");

            Assert.Equal("そう", value);
        }

        [Fact]
        public void CanParse_Za()
        {
            var value = NihonParser.ToHiragana("za");

            Assert.Equal("ざ", value);
        }

        [Fact]
        public void CanParse_Ji()
        {
            var value = NihonParser.ToHiragana("ji");

            Assert.Equal("じ", value);
        }

        [Fact]
        public void CanParse_Zu()
        {
            var value = NihonParser.ToHiragana("zu");

            Assert.Equal("ず", value);
        }

        [Fact]
        public void CanParse_Ze()
        {
            var value = NihonParser.ToHiragana("ze");

            Assert.Equal("ぜ", value);
        }

        [Fact]
        public void CanParse_Zo()
        {
            var value = NihonParser.ToHiragana("zo");

            Assert.Equal("ぞ", value);
        }

        [Fact]
        public void CanParse_Zou()
        {
            var value = NihonParser.ToHiragana("zou");

            Assert.Equal("ぞう", value);
        }

        [Fact]
        public void CanParse_Na()
        {
            var value = NihonParser.ToHiragana("na");

            Assert.Equal("な", value);
        }

        [Fact]
        public void CanParse_Ni()
        {
            var value = NihonParser.ToHiragana("ni");

            Assert.Equal("に", value);
        }

        [Fact]
        public void CanParse_Nu()
        {
            var value = NihonParser.ToHiragana("nu");

            Assert.Equal("ぬ", value);
        }

        [Fact]
        public void CanParse_Ne()
        {
            var value = NihonParser.ToHiragana("ne");

            Assert.Equal("ね", value);
        }

        [Fact]
        public void CanParse_No()
        {
            var value = NihonParser.ToHiragana("no");

            Assert.Equal("の", value);
        }

        [Fact]
        public void CanParse_Nou()
        {
            var value = NihonParser.ToHiragana("nou");

            Assert.Equal("のう", value);
        }

        [Fact]
        public void CanParse_Ha()
        {
            var value = NihonParser.ToHiragana("ha");

            Assert.Equal("は", value);
        }

        [Fact]
        public void CanParse_Hi()
        {
            var value = NihonParser.ToHiragana("hi");

            Assert.Equal("ひ", value);
        }

        [Fact]
        public void CanParse_Fu()
        {
            var value = NihonParser.ToHiragana("fu");

            Assert.Equal("ふ", value);
        }

        [Fact]
        public void CanParse_He()
        {
            var value = NihonParser.ToHiragana("he");

            Assert.Equal("へ", value);
        }

        [Fact]
        public void CanParse_Ho()
        {
            var value = NihonParser.ToHiragana("ho");

            Assert.Equal("ほ", value);
        }

        [Fact]
        public void CanParse_Hou()
        {
            var value = NihonParser.ToHiragana("hou");

            Assert.Equal("ほう", value);
        }

        [Fact]
        public void CanParse_Ba()
        {
            var value = NihonParser.ToHiragana("ba");

            Assert.Equal("ば", value);
        }

        [Fact]
        public void CanParse_Bi()
        {
            var value = NihonParser.ToHiragana("bi");

            Assert.Equal("び", value);
        }

        [Fact]
        public void CanParse_Bu()
        {
            var value = NihonParser.ToHiragana("bu");

            Assert.Equal("ぶ", value);
        }

        [Fact]
        public void CanParse_Be()
        {
            var value = NihonParser.ToHiragana("be");

            Assert.Equal("べ", value);
        }

        [Fact]
        public void CanParse_Bo()
        {
            var value = NihonParser.ToHiragana("bo");

            Assert.Equal("ぼ", value);
        }

        [Fact]
        public void CanParse_Bou()
        {
            var value = NihonParser.ToHiragana("bou");

            Assert.Equal("ぼう", value);
        }

        [Fact]
        public void CanParse_Pa()
        {
            var value = NihonParser.ToHiragana("pa");

            Assert.Equal("ぱ", value);
        }

        [Fact]
        public void CanParse_Pi()
        {
            var value = NihonParser.ToHiragana("pi");

            Assert.Equal("ぴ", value);
        }

        [Fact]
        public void CanParse_Pu()
        {
            var value = NihonParser.ToHiragana("pu");

            Assert.Equal("ぷ", value);
        }

        [Fact]
        public void CanParse_Pe()
        {
            var value = NihonParser.ToHiragana("pe");

            Assert.Equal("ぺ", value);
        }

        [Fact]
        public void CanParse_Po()
        {
            var value = NihonParser.ToHiragana("po");

            Assert.Equal("ぽ", value);
        }

        [Fact]
        public void CanParse_Pou()
        {
            var value = NihonParser.ToHiragana("pou");

            Assert.Equal("ぽう", value);
        }

        [Fact]
        public void CanParse_Ma()
        {
            var value = NihonParser.ToHiragana("ma");

            Assert.Equal("ま", value);
        }

        [Fact]
        public void CanParse_Mi()
        {
            var value = NihonParser.ToHiragana("mi");

            Assert.Equal("み", value);
        }

        [Fact]
        public void CanParse_Mu()
        {
            var value = NihonParser.ToHiragana("mu");

            Assert.Equal("む", value);
        }

        [Fact]
        public void CanParse_Me()
        {
            var value = NihonParser.ToHiragana("me");

            Assert.Equal("め", value);
        }

        [Fact]
        public void CanParse_Mo()
        {
            var value = NihonParser.ToHiragana("mo");

            Assert.Equal("も", value);
        }

        [Fact]
        public void CanParse_Mou()
        {
            var value = NihonParser.ToHiragana("mou");

            Assert.Equal("もう", value);
        }

        [Fact]
        public void CanParse_Ra()
        {
            var value = NihonParser.ToHiragana("ra");

            Assert.Equal("ら", value);
        }

        [Fact]
        public void CanParse_Ri()
        {
            var value = NihonParser.ToHiragana("ri");

            Assert.Equal("り", value);
        }

        [Fact]
        public void CanParse_Ru()
        {
            var value = NihonParser.ToHiragana("ru");

            Assert.Equal("る", value);
        }

        [Fact]
        public void CanParse_Re()
        {
            var value = NihonParser.ToHiragana("re");

            Assert.Equal("れ", value);
        }

        [Fact]
        public void CanParse_Ro()
        {
            var value = NihonParser.ToHiragana("ro");

            Assert.Equal("ろ", value);
        }

        [Fact]
        public void CanParse_Rou()
        {
            var value = NihonParser.ToHiragana("rou");

            Assert.Equal("ろう", value);
        }

        [Fact]
        public void CanParse_Ya()
        {
            var value = NihonParser.ToHiragana("ya");

            Assert.Equal("や", value);
        }

        [Fact]
        public void CanParse_Yu()
        {
            var value = NihonParser.ToHiragana("yu");

            Assert.Equal("ゆ", value);
        }

        [Fact]
        public void CanParse_Yo()
        {
            var value = NihonParser.ToHiragana("yo");

            Assert.Equal("よ", value);
        }

        [Fact]
        public void CanParse_You()
        {
            var value = NihonParser.ToHiragana("you");

            Assert.Equal("よう", value);
        }

        [Fact]
        public void CanParse_Wa()
        {
            var value = NihonParser.ToHiragana("wa");

            Assert.Equal("わ", value);
        }

        [Fact]
        public void CanParse_Wo()
        {
            var value = NihonParser.ToHiragana("wo");

            Assert.Equal("を", value);
        }

        [Fact]
        public void CanParse_Nn()
        {
            var value = NihonParser.ToHiragana("n");

            Assert.Equal("ん", value);
        }

        [Fact]
        public void CanParseMultipleSyllables()
        {
            var value = NihonParser.ToHiragana("ako");

            Assert.Equal("あこ", value);
        }

        [Fact]
        public void CanParseMultipleWords1()
        {
            var value = NihonParser.ToHiragana("atoka itedo");

            Assert.Equal("あとか いてど", value);
        }

        [Fact]
        public void CanParseMultipleWords2()
        {
            var value = NihonParser.ToHiragana("katsu getou akate");

            Assert.Equal("かつ げとう あかて", value);
        }

        [Fact]
        public void CanParseComplicatedNs()
        {
            var value = NihonParser.ToHiragana("konnichi");

            Assert.Equal("こんにち", value);
        }
    }
}
