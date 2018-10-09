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
        public void CanParseMultipleSyllables()
        {
            CheckParse("ako", "あこ");
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
