using System;
using Xunit;
using battousai.jpParse;

namespace jpParse_core.Tests
{
    public class HiraganaSyllableTests
    {
        [Fact]
        public void CanParseA()
        {
            var value = NihonParser.ToHiragana("a");

            Assert.Equal("あ", value);
        }

        [Fact]
        public void CanParseI()
        {
            var value = NihonParser.ToHiragana("i");

            Assert.Equal("い", value);
        }

        [Fact]
        public void CanParseU()
        {
            var value = NihonParser.ToHiragana("u");

            Assert.Equal("う", value);
        }

        [Fact]
        public void CanParseE()
        {
            var value = NihonParser.ToHiragana("e");

            Assert.Equal("え", value);
        }

        [Fact]
        public void CanParseO()
        {
            var value = NihonParser.ToHiragana("o");

            Assert.Equal("お", value);
        }

        [Fact]
        public void CanParseKa()
        {
            var value = NihonParser.ToHiragana("ka");

            Assert.Equal("か", value);
        }

        [Fact]
        public void CanParseKi()
        {
            var value = NihonParser.ToHiragana("ki");

            Assert.Equal("き", value);
        }

        [Fact]
        public void CanParseKu()
        {
            var value = NihonParser.ToHiragana("ku");

            Assert.Equal("く", value);
        }

        [Fact]
        public void CanParseKe()
        {
            var value = NihonParser.ToHiragana("ke");

            Assert.Equal("け", value);
        }

        [Fact]
        public void CanParseKo()
        {
            var value = NihonParser.ToHiragana("ko");

            Assert.Equal("こ", value);
        }

        [Fact]
        public void CanParseKou()
        {
            var value = NihonParser.ToHiragana("kou");

            Assert.Equal("こう", value);
        }

        [Fact]
        public void CanParseGa()
        {
            var value = NihonParser.ToHiragana("ga");

            Assert.Equal("が", value);
        }

        [Fact]
        public void CanParseGi()
        {
            var value = NihonParser.ToHiragana("gi");

            Assert.Equal("ぎ", value);
        }

        [Fact]
        public void CanParseGu()
        {
            var value = NihonParser.ToHiragana("gu");

            Assert.Equal("ぐ", value);
        }

        [Fact]
        public void CanParseGe()
        {
            var value = NihonParser.ToHiragana("ge");

            Assert.Equal("げ", value);
        }

        [Fact]
        public void CanParseGo()
        {
            var value = NihonParser.ToHiragana("go");

            Assert.Equal("ご", value);
        }

        [Fact]
        public void CanParseGou()
        {
            var value = NihonParser.ToHiragana("gou");

            Assert.Equal("ごう", value);
        }

        [Fact]
        public void CanParseTa()
        {
            var value = NihonParser.ToHiragana("ta");

            Assert.Equal("た", value);
        }

        [Fact]
        public void CanParseChi()
        {
            var value = NihonParser.ToHiragana("chi");

            Assert.Equal("ち", value);
        }

        [Fact]
        public void CanParseTsu()
        {
            var value = NihonParser.ToHiragana("tsu");

            Assert.Equal("つ", value);
        }

        [Fact]
        public void CanParseTe()
        {
            var value = NihonParser.ToHiragana("te");

            Assert.Equal("て", value);
        }

        [Fact]
        public void CanParseTo()
        {
            var value = NihonParser.ToHiragana("to");

            Assert.Equal("と", value);
        }

        [Fact]
        public void CanParseTou()
        {
            var value = NihonParser.ToHiragana("tou");

            Assert.Equal("とう", value);
        }

        [Fact]
        public void CanParseDa()
        {
            var value = NihonParser.ToHiragana("da");

            Assert.Equal("だ", value);
        }

        [Fact]
        public void CanParseDi()
        {
            var value = NihonParser.ToHiragana("di");

            Assert.Equal("ぢ", value);
        }

        [Fact]
        public void CanParseDu()
        {
            var value = NihonParser.ToHiragana("du");

            Assert.Equal("づ", value);
        }

        [Fact]
        public void CanParseDe()
        {
            var value = NihonParser.ToHiragana("de");

            Assert.Equal("で", value);
        }

        [Fact]
        public void CanParseDo()
        {
            var value = NihonParser.ToHiragana("do");

            Assert.Equal("ど", value);
        }

        [Fact]
        public void CanParseDou()
        {
            var value = NihonParser.ToHiragana("dou");

            Assert.Equal("どう", value);
        }

        [Fact]
        public void CanParseMultipleSyllables()
        {
            var value = NihonParser.ToHiragana("ako");

            Assert.Equal("あこ", value);
        }

        [Fact]
        public void CanParseMultipleWords()
        {
            var value = NihonParser.ToHiragana("atoka itedo");

            Assert.Equal("あとか いてど", value);
        }
    }
}
