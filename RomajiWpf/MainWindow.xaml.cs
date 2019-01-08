using battousai.jpParse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battousai.RomajiConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool isHiraganaConversion = true;
        private string enteredText = "";

        public string ConvertMethod => (isHiraganaConversion ? "Hiragana" : "Katakana") + " (click to switch)";

        public string EnteredText
        {
            get { return enteredText; }
            set { enteredText = value; Notify(); Notify(nameof(ConvertedText)); }
        }

        public bool IsHiraganaConversion
        {
            get { return isHiraganaConversion; }
            set { isHiraganaConversion = value; Notify(); Notify(nameof(ConvertedText)); }
        }

        public string ConvertedText
        {
            get
            {
                if (String.IsNullOrWhiteSpace(enteredText))
                    return "";

                var lines = enteredText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                var convertedLines = lines
                    .Select(line =>
                    {
                        try
                        {
                            return (isHiraganaConversion ? NihonParser.ToHiragana(line.Trim(), true) : NihonParser.ToKatakana(line.Trim(), true));
                        }
                        catch (Exception)
                        {
                            return "";
                        }
                    });

                return String.Join(Environment.NewLine, convertedLines);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            DataContext = this;

            InitializeComponent();
        }

        private void Notify([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ConvertMethodButton_Click(object sender, RoutedEventArgs e)
        {
            IsHiraganaConversion = !IsHiraganaConversion;
        }
    }
}
