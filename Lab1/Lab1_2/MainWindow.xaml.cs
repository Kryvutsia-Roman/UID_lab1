using System;
using System.Windows;
using System.IO;

namespace Lab1_2
{
    public partial class MainWindow : Window
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

        public MainWindow()
        {
            InitializeComponent();
            QuestionLabel.Content = questions[currentQuestion];
        }

        private void SaveAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            string answer = AnswersBox.Text;

            if (string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Введіть відповідь!");
                return;
            }

            string path = "answers.txt";

            File.AppendAllText(path,
                questions[currentQuestion] + " " + answer + Environment.NewLine);

            AnswersBox.Clear();

            currentQuestion++;

            if (currentQuestion < questions.Length)
            {
                QuestionLabel.Content = questions[currentQuestion];
            }
            else
            {
                MessageBox.Show("Опитування завершено!");
                SaveAnswerButton.IsEnabled = false;
                QuestionLabel.Content = "Дякуємо за участь!";
            }
        }
    }
}