using battousai.jpParse;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace jpParse.Tests
{
    public class KatakanaSyllableTests
    {
        private void CheckParse(string roumaji, string katakana, bool isWordSpacing = false)
        {
            Assert.Equal(katakana, NihonParser.ToKatakana(roumaji, isWordSpacing));
        }

        [Theory]
        [InlineData("a", "ア")]
        [InlineData("i", "イ")]
        [InlineData("u", "ウ")]
        [InlineData("e", "エ")]
        [InlineData("o", "オ")]
        [InlineData("ka", "カ")]
        [InlineData("ki", "キ")]
        [InlineData("ku", "ク")]
        [InlineData("ke", "ケ")]
        [InlineData("ko", "コ")]
        [InlineData("kou", "コウ")]
        [InlineData("ga", "ガ")]
        [InlineData("gi", "ギ")]
        [InlineData("gu", "グ")]
        [InlineData("ge", "ゲ")]
        [InlineData("go", "ゴ")]
        [InlineData("gou", "ゴウ")]
        [InlineData("ta", "タ")]
        [InlineData("chi", "チ")]
        [InlineData("tsu", "ツ")]
        [InlineData("te", "テ")]
        [InlineData("to", "ト")]
        [InlineData("tou", "トウ")]
        [InlineData("da", "ダ")]
        [InlineData("di", "ヂ")]
        [InlineData("du", "ヅ")]
        [InlineData("de", "デ")]
        [InlineData("do", "ド")]
        [InlineData("dou", "ドウ")]
        [InlineData("sa", "サ")]
        [InlineData("shi", "シ")]
        [InlineData("su", "ス")]
        [InlineData("se", "セ")]
        [InlineData("so", "ソ")]
        [InlineData("sou", "ソウ")]
        [InlineData("za", "ザ")]
        [InlineData("ji", "ジ")]
        [InlineData("zu", "ズ")]
        [InlineData("ze", "ゼ")]
        [InlineData("zo", "ゾ")]
        [InlineData("zou", "ゾウ")]
        [InlineData("na", "ナ")]
        [InlineData("ni", "ニ")]
        [InlineData("nu", "ヌ")]
        [InlineData("ne", "ネ")]
        [InlineData("no", "ノ")]
        [InlineData("nou", "ノウ")]
        [InlineData("ha", "ハ")]
        [InlineData("hi", "ヒ")]
        [InlineData("fu", "フ")]
        [InlineData("he", "ヘ")]
        [InlineData("ho", "ホ")]
        [InlineData("hou", "ホウ")]
        [InlineData("ba", "バ")]
        [InlineData("bi", "ビ")]
        [InlineData("bu", "ブ")]
        [InlineData("be", "ベ")]
        [InlineData("bo", "ボ")]
        [InlineData("bou", "ボウ")]
        [InlineData("pa", "パ")]
        [InlineData("pi", "ピ")]
        [InlineData("pu", "プ")]
        [InlineData("pe", "ペ")]
        [InlineData("po", "ポ")]
        [InlineData("pou", "ポウ")]
        [InlineData("ma", "マ")]
        [InlineData("mi", "ミ")]
        [InlineData("mu", "ム")]
        [InlineData("me", "メ")]
        [InlineData("mo", "モ")]
        [InlineData("mou", "モウ")]
        [InlineData("ra", "ラ")]
        [InlineData("ri", "リ")]
        [InlineData("ru", "ル")]
        [InlineData("re", "レ")]
        [InlineData("ro", "ロ")]
        [InlineData("rou", "ロウ")]
        [InlineData("ya", "ヤ")]
        [InlineData("yu", "ユ")]
        [InlineData("yo", "ヨ")]
        [InlineData("you", "ヨウ")]
        [InlineData("wa", "ワ")]
        [InlineData("wo", "ヲ")]
        [InlineData("n", "ン")]
        [InlineData("kya", "キャ")]
        [InlineData("kyu", "キュ")]
        [InlineData("kyo", "キョ")]
        [InlineData("gya", "ギャ")]
        [InlineData("gyu", "ギュ")]
        [InlineData("gyo", "ギョ")]
        [InlineData("nya", "ニャ")]
        [InlineData("nyu", "ニュ")]
        [InlineData("nyo", "ニョ")]
        [InlineData("hya", "ヒャ")]
        [InlineData("hyu", "ヒュ")]
        [InlineData("hyo", "ヒョ")]
        [InlineData("bya", "ビャ")]
        [InlineData("byu", "ビュ")]
        [InlineData("byo", "ビョ")]
        [InlineData("pya", "ピャ")]
        [InlineData("pyu", "ピュ")]
        [InlineData("pyo", "ピョ")]
        [InlineData("mya", "ミャ")]
        [InlineData("myu", "ミュ")]
        [InlineData("myo", "ミョ")]
        [InlineData("rya", "リャ")]
        [InlineData("ryu", "リュ")]
        [InlineData("ryo", "リョ")]
        [InlineData("ja", "ジャ")]
        [InlineData("ju", "ジュ")]
        [InlineData("jo", "ジョ")]
        [InlineData("cha", "チャ")]
        [InlineData("chu", "チュ")]
        [InlineData("cho", "チョ")]
        [InlineData("sha", "シャ")]
        [InlineData("shu", "シュ")]
        [InlineData("sho", "ショ")]
        [InlineData("kka", "ッカ")]
        [InlineData("kki", "ッキ")]
        [InlineData("kku", "ック")]
        [InlineData("kke", "ッケ")]
        [InlineData("kko", "ッコ")]
        [InlineData("ssa", "ッサ")]
        [InlineData("sshi", "ッシ")]
        [InlineData("ssu", "ッス")]
        [InlineData("sse", "ッセ")]
        [InlineData("sso", "ッソ")]
        [InlineData("tta", "ッタ")]
        [InlineData("cchi", "ッチ")]
        [InlineData("ttsu", "ッツ")]
        [InlineData("tte", "ッテ")]
        [InlineData("tto", "ット")]
        [InlineData("bba", "ッバ")]
        [InlineData("bbi", "ッビ")]
        [InlineData("bbu", "ッブ")]
        [InlineData("bbe", "ッベ")]
        [InlineData("bbo", "ッボ")]
        [InlineData("ppa", "ッパ")]
        [InlineData("ppi", "ッピ")]
        [InlineData("ppu", "ップ")]
        [InlineData("ppe", "ッペ")]
        [InlineData("ppo", "ッポ")]
        public void CanParseSyllable(string roumaji, string katakana)
        {
            CheckParse(roumaji, katakana);
        }

        [Fact]
        public void CanParseMultipleSyllables()
        {
            CheckParse("ako", "アコ");
        }

        [Fact]
        public void CanParseMultipleSyllablesIncludingSokuons()
        {
            CheckParse("battousai", "バットウサイ");
        }

        [Fact]
        public void CanParseMultipleWords1()
        {
            CheckParse("atoka itedo", "アトカ イテド", true);
        }

        [Fact]
        public void CanParseMultipleWords2()
        {
            CheckParse("katsu getou akate", "カツ ゲトウ アカテ", true);
        }

        [Fact]
        public void CanParseMultipleWordsCollapsingSpaces1()
        {
            CheckParse("atoka itedo", "アトカイテド");
        }

        [Fact]
        public void CanParseMultipleWordsCollapsingSpaces2()
        {
            CheckParse("katsu getou akate", "カツゲトウアカテ");
        }

        [Fact]
        public void CanParseComplicatedNs()
        {
            CheckParse("konnichi", "コンニチ");
        }
    }
}
