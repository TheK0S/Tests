using System;
using System.Collections.Generic;
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

namespace ItTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse[] indicators = new Ellipse[20];
        QuestionBlock[] questionBlocks = new QuestionBlock[20];
        int correctAnswerCount = 0;
        int currentQuestion = 0;

        public MainWindow()
        {
            InitializeComponent();

            WindowState = WindowState.Maximized;

            for (int i = 0; i < indicators.Length; i++)
            {
                indicators[i] = new Ellipse { Height = 20, Width = 20, Fill = new SolidColorBrush(Color.FromRgb(128, 128, 128)) };
                lamps.Children.Add(indicators[i]);
            }

            indicators[0].Width = 30;
            indicators[0].Height = 30;

            questionBlocks = AddQuestions();

            PrintQuestionBlock(currentQuestion, this);
        }

        static void PrintQuestionBlock(int index,MainWindow window)
        {
            window.questionField.Text = window.questionBlocks[index].Question;

            window.answers.Children.Clear();

            if (window.questionBlocks[index].CorrectAnswers.Length > 1) 
            {
                foreach (var item in window.questionBlocks[index].Answers)
                {
                    window.answers.Children.Add(new CheckBox { Content = item, Margin = new Thickness(10) });
                }
            }
            else
            {
                foreach (var item in window.questionBlocks[index].Answers)
                {
                    window.answers.Children.Add(new RadioButton { Content = item, Margin = new Thickness(10) });
                }
            }
        }

        static QuestionBlock[] AddQuestions()
        {
            QuestionBlock[] blocks = new QuestionBlock[20];

            blocks[0] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64"},
                new int[] {1}
                );

            blocks[1] = new QuestionBlock(
                "Выберите циклы",
                new string[] { "foreach", "switch", "do while", "if" },
                new int[] { 0, 3 }
                );
            
            blocks[2] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );
            
            blocks[3] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[4] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[5] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[6] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[7] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[8] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[9] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[10] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[11] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[12] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[13] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[14] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[15] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[16] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[17] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[18] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            blocks[19] = new QuestionBlock(
                "Сколько бит в обном байте",
                new string[] { "1024", "8", "32", "64" },
                new int[] { 1 }
                );

            return blocks;
        }

        private void prev_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestion == 0)
                PrintQuestionBlock(questionBlocks.Length - 1, this);
            else
                PrintQuestionBlock(--currentQuestion, this);
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestion == questionBlocks.Length - 1)
                PrintQuestionBlock(0, this);
            else
                PrintQuestionBlock(++currentQuestion, this);
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
