using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ItTest
{
    internal class QuestionBlock
    {
        public string Question { get; set; }
        public string[] Answers { get; set; }
        public int[] CorrectAnswers { get; set; }
        public bool IsAnswered { get; set; }

        public QuestionBlock(string question, string[] answers, int[] correctAnswers)
        {
            Question = question;
            Answers = answers;
            CorrectAnswers = correctAnswers;
            IsAnswered = false;
        }
    }
}
