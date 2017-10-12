using battousai.jpParse;
using System;
using System.Linq;
using Xunit;

namespace jpParse.Tests
{
    public class ParserTests
    {
        [Fact]
        public void CanParseA()
        {
            var value = NihonParser.ToHiragana("a");

            Assert.Equal(value, "あ");
        }
    }
}
