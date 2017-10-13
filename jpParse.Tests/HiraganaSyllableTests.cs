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
    }
}
