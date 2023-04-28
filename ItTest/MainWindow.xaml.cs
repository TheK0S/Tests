using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    public partial class MainWindow : Window
    {
        Ellipse[] indicators = new Ellipse[20];
        QuestionBlock[] questionBlocks = new QuestionBlock[20];
        List<List<object>> elements = new List<List<object>>();
        int correctAnswerCount = 0;
        int currentQuestion = 0;

        public MainWindow()
        {
            InitializeComponent();

            WindowState = WindowState.Maximized;

            for (int i = 0; i < indicators.Length; i++)
            {
                indicators[i] = new Ellipse { Height = 20, Width = 20, Fill = new SolidColorBrush(Color.FromRgb(128, 128, 128)) };
                indicators[i].MouseLeftButtonDown += Ellipse_MouseLeftButtonDown;
                lamps.Children.Add(indicators[i]);
            }

            indicators[0].Width = 30;
            indicators[0].Height = 30;

            questionBlocks = AddQuestions();            

            foreach (var item in questionBlocks)
            {
                List<object> answerList = new List<object>();

                if (item.CorrectAnswers.Length > 1)
                    foreach (var answer in item.Answers)
                        answerList.Add(new CheckBox { Content = answer, Margin = new Thickness(10) });
                else
                    foreach (var answer in item.Answers)
                        answerList.Add(new RadioButton { Content = answer, Margin = new Thickness(10) });
                
                elements.Add(answerList);
            }

            PrintQuestionBlock(currentQuestion, this);
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < indicators.Length; i++)
            {
                if (indicators[i] == sender)
                {
                    SetLamps(currentQuestion, i, this);
                    currentQuestion = i;
                    PrintQuestionBlock(currentQuestion, this);                    
                    break;
                }
            }
        }

        private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void SetLamps(int prevQuestion, int nextQuestion, MainWindow window)
        {
            window.indicators[prevQuestion].Height = 20;
            window.indicators[prevQuestion].Width = 20;

            window.indicators[nextQuestion].Height = 30;
            window.indicators[nextQuestion].Width = 30;
        }

        static void PrintQuestionBlock(int index,MainWindow window)
        {
            window.questionField.Text = $"{index + 1}. {window.questionBlocks[index].Question}";

            window.answers.Children.Clear();

            if(window.questionBlocks[index].CorrectAnswers.Length > 1)
                foreach (var el in window.elements[index])
                    window.answers.Children.Add((CheckBox)el);
            else
                foreach (var el in window.elements[index])
                    window.answers.Children.Add((RadioButton)el);
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
                new int[] { 0, 2 }
                );
            
            blocks[2] = new QuestionBlock(
                "Выберите циклы",
                new string[] { "foreach", "switch", "do while", "if" },
                new int[] { 0, 2 }
                );

            blocks[3] = new QuestionBlock(
                "Выберите циклы",
                new string[] { "foreach", "switch", "do while", "if" },
                new int[] { 0, 2 }
                );

            blocks[4] = new QuestionBlock(
                "Выберите циклы",
                new string[] { "foreach", "switch", "do while", "if" },
                new int[] { 0, 2 }
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
            {
                SetLamps(0, questionBlocks.Length - 1, this);
                PrintQuestionBlock(questionBlocks.Length - 1, this);                
            }                
            else
            {
                SetLamps(currentQuestion, currentQuestion - 1, this);
                PrintQuestionBlock(--currentQuestion, this);
            }
                
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestion == questionBlocks.Length - 1)
            {
                SetLamps(currentQuestion, 0, this);
                PrintQuestionBlock(0, this);
            }                
            else
            {
                SetLamps(currentQuestion, currentQuestion + 1, this);
                PrintQuestionBlock(++currentQuestion, this);
            }
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (questionBlocks[currentQuestion].IsAnswered)
            {
                MessageBox.Show("Вы уже ответили на этот вопрос");
            }
            else
            {
                questionBlocks[currentQuestion].IsAnswered = true;

                if (questionBlocks[currentQuestion].CorrectAnswers.Length > 1)
                {
                    bool isCorrectAnswer = true;

                    int[] corAns = questionBlocks[currentQuestion].CorrectAnswers;

                    List<CheckBox> cbx = new List<CheckBox>();

                    foreach (var element in elements[currentQuestion])
                        cbx.Add((CheckBox)element);

                    for (int i = 0; i < cbx.Count; i++)
                    {
                        if ((!corAns.Contains(i) && cbx[i].IsChecked == true) || (corAns.Contains(i) && cbx[i].IsChecked == false))
                        {
                            isCorrectAnswer = false;
                            break;
                        }
                    }

                    if (isCorrectAnswer)
                    {
                        correctAnswerCount++;
                        indicators[currentQuestion].Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    }
                    else
                    {
                        indicators[currentQuestion].Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    }
                }
                else
                {
                    RadioButton rbtn = (RadioButton)elements[currentQuestion][questionBlocks[currentQuestion].CorrectAnswers[0]];
                    if (rbtn.IsChecked == true)
                    {
                        correctAnswerCount++;
                        indicators[currentQuestion].Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    }
                    else
                    {
                        indicators[currentQuestion].Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    }
                }

                bool isAllQuestionsAnswered = true;

                foreach (var item in questionBlocks)
                {
                    if (!item.IsAnswered)
                    {
                        isAllQuestionsAnswered = false;
                        break;
                    }
                }

                if (isAllQuestionsAnswered)
                {
                    result.Text = $"Ваш результат {correctAnswerCount * 100 / questionBlocks.Length}% " +
                        $"({correctAnswerCount} правильных ответов из {questionBlocks.Length})";
                }
            }    
        }
    }
}
