using System;
using Xunit;
using battousai.jpParse;

namespace jpParse_core.Tests
{
    public class UnitTest1
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
        public void CanParseMultipleSyllables()
        {
            var value = NihonParser.ToHiragana("ako");

            Assert.Equal("あこ", value);
        }
    }
}
