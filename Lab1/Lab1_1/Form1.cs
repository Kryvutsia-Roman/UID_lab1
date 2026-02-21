using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab1_1
{
    public partial class Form1 : Form
    {
        private string[] questions =
        {
            "Яку останню книгу ви читали?",
            "Якого жанру вона була?",
            "Хто її автор?",
            "Чи прочитав би ти її ще раз?",
            "Чи порадиш ти прочитати її ще комусь?"
        };

        private int currentQuestion = 0;

        public Form1()
        {
            InitializeComponent();
            QuestionLabel.Text = questions[currentQuestion];
        }

        private void SaveAnswerButton_Click(object sender, EventArgs e)
        {
            string answer = AnswersBox.Text;

            if (string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Введіть відповідь!");
                return;
            }

            string path = "answers.txt";

            // Записуємо питання + відповідь
            File.AppendAllText(path,
                questions[currentQuestion] + " " + answer + Environment.NewLine);

            AnswersBox.Clear();

            currentQuestion++;

            if (currentQuestion < questions.Length)
            {
                QuestionLabel.Text = questions[currentQuestion];
            }
            else
            {
                MessageBox.Show("Опитування завершено!");
                SaveAnswerButton.Enabled = false;
                QuestionLabel.Text = "Дякуємо за участь!";
            }
        }
    }
}
