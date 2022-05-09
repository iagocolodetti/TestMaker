using System;

namespace TestMaker
{
    public class Answer
    {
        private int _id;
        private string _value;

        public Answer()
        {
        }

        public Answer(int id, string value)
        {
            ID = id;
            Value = value;
        }

        public int ID
        {
            get => _id;
            set => _id = value < 0 ? throw new Exception("ID inválido.") : value;
        }

        public string Value
        {
            get => _value;
            set => _value = string.IsNullOrEmpty(value) ? throw new Exception("Resposta vazia.") : value;
        }
    }
}
