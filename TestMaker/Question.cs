using System;
using System.Collections.Generic;

namespace TestMaker
{
    public class Question
    {
        private int _id;
        private string _title;
        private List<Answer> _answers;
        private int _correctAnswerID;

        public Question()
        {
            _answers = new List<Answer>();
        }

        public Question(int id, string title, List<Answer> answers, int correctAnswerID)
        {
            ID = id;
            Title = title;
            Answers = new List<Answer>(answers);
            CorrectAnswerID = correctAnswerID;
         }

        public int ID
        {
            get => _id;
            set => _id = value < 0 ? throw new Exception("ID inválido.") : value;
        }

        public string Title
        {
            get => _title;
            set => _title = string.IsNullOrEmpty(value) ? throw new Exception("Questão sem título.") : value;
        }

        public void AddAnswer(Answer answer)
        {
            _answers.Add(answer);
        }

        public List<Answer> Answers
        {
            get => _answers;
            set => _answers = value.Count > 5 ? throw new Exception("Quantidade de respostas acima do permitido.") : value;
        }

        public int CorrectAnswerID
        {
            get => _correctAnswerID;
            set => _correctAnswerID = value < 0 || value > 4 || value >= Answers.Count ? throw new Exception("Resposta selecionada como correta fora do limite permitido.") : value;
        }
    }
}
