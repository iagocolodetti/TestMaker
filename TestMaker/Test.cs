using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestMaker
{
    public partial class Test : Form
    {
        private bool loading;

        private bool finalized;
        private List<Question> questions;
        private Random random;
        private bool randomAnswers;
        private Label[] lblQtnsTitle;
        private Panel[] panels;
        private RadioButton[,] rboAnswers;
        private Label[,] lblAnswers;
        private Label lblResult;
        private Button btnFinalize;
        private int correctAnswers;

        private void TestFinalize(object sender, EventArgs e)
        {
            if (!finalized)
            {
                string questionsNotAnswered = string.Empty;
                for (int i = 0; i < questions.Count; i++)
                {
                    for (int j = 0; j < questions[i].Answers.Count && !rboAnswers[i, j].Checked; j++)
                    {
                        if (j == questions[i].Answers.Count - 1)
                        {
                            questionsNotAnswered += string.IsNullOrEmpty(questionsNotAnswered) ? (i + 1).ToString() : ", " + (i + 1);
                        }
                    }
                }
                if (string.IsNullOrEmpty(questionsNotAnswered))
                {
                    for (int i = 0; i < questions.Count; i++)
                    {
                        if (rboAnswers[i, questions[i].CorrectAnswerID].Checked)
                        {
                            lblAnswers[i, questions[i].CorrectAnswerID].ForeColor = Color.Green;
                            correctAnswers++;
                        }
                        else
                        {
                            lblAnswers[i, questions[i].CorrectAnswerID].ForeColor = Color.Red;
                        }
                        int j = 0;
                        while (j < 5 && rboAnswers[i, j] != null)
                        {
                            rboAnswers[i, j++].Enabled = false;
                        }
                    }
                    lblResult.Text = "Você acertou " + correctAnswers + (correctAnswers < 2 ? " questão de " : " questões de ") + questions.Count + (questions.Count < 2 ? " questão" : " questões");
                    finalized = true;
                }
                else
                {
                    MessageBox.Show("Você ainda não respondeu " + (questionsNotAnswered.Length == 1 ? "a questão: " : "as questões: ") + questionsNotAnswered, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Esse teste já está finalizado, feche essa janela e inicie outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Test(string test, List<Question> questions, bool randomQuestions, bool randomAnswers)
        {
            loading = true;
            InitializeComponent();
            HorizontalScroll.Enabled = false;
            VerticalScroll.Enabled = true;
            finalized = false;
            random = new Random();
            this.questions = randomQuestions ? questions.OrderBy(question => random.Next()).ToList() : new List<Question>(questions);
            this.randomAnswers = randomAnswers;
            Text = "Teste [" + test + "]";
            lblQtnsTitle = new Label[questions.Count];
            panels = new Panel[questions.Count];
            rboAnswers = new RadioButton[questions.Count, 5];
            lblAnswers = new Label[questions.Count, 5];
            correctAnswers = 0;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                if (randomAnswers)
                {
                    questions[i].Answers = questions[i].Answers.OrderBy(answer => random.Next()).ToList();
                    questions[i].CorrectAnswerID = questions[i].Answers.FindIndex(answer => answer.ID == questions[i].CorrectAnswerID);
                }
                lblQtnsTitle[i] = new Label
                {
                    AutoSize = true,
                    Location = new Point(12, i == 0 ? 9 : panels[i - 1].Location.Y + panels[i - 1].Height + 46),
                    Name = "lblQtnsTitle" + i,
                    Font = new Font("Microsoft Sans Serif", 9F),
                    MaximumSize = new Size(Width - 50, 0),
                    TabIndex = 2 * i,
                    Text = i + 1 + ") " + questions[i].Title
                };
                Controls.Add(lblQtnsTitle[i]);
                panels[i] = new Panel
                {
                    AutoSize = true,
                    Location = new Point(15, lblQtnsTitle[i].Location.Y + lblQtnsTitle[i].Height + 14),
                    Name = "panels" + i,
                    MaximumSize = new Size(Width - 54, 0),
                    Size = new Size(Width - 54, 0),
                    TabIndex = 2 * i + 1
                };
                Controls.Add(panels[i]);
                for (int j = 0; j < questions[i].Answers.Count; j++)
                {
                    lblAnswers[i, j] = new Label
                    {
                        AutoSize = true,
                        Location = new Point(18, j == 0 ? 3 : lblAnswers[i, j - 1].Location.Y + lblAnswers[i, j - 1].Height + 20),
                        Name = "lblAnswers[" + i + "," + j + "]",
                        Font = new Font("Microsoft Sans Serif", 9F),
                        MaximumSize = new Size(panels[i].Width - 35, 0),
                        Text = questions[i].Answers[j].Value,
                        TextAlign = ContentAlignment.MiddleLeft,
                        TabIndex = j * 2 + 1
                    };
                    panels[i].Controls.Add(lblAnswers[i, j]);
                    rboAnswers[i, j] = new RadioButton
                    {
                        AutoSize = true,
                        Location = new Point(3, lblAnswers[i, j].Location.Y + (lblAnswers[i, j].Height / 2) - 5),
                        Name = "rboAnswers[" + i + "," + j + "]",
                        Font = new Font("Microsoft Sans Serif", 9F),
                        TabIndex = j,
                        TabStop = true,
                        UseVisualStyleBackColor = true
                    };
                    panels[i].Controls.Add(rboAnswers[i, j]);
                    int _i = i, _j = j;
                    lblAnswers[i, j].MouseHover += (_sender, _e) => lblAnswers[_i, _j].BackColor = SystemColors.ControlLight;
                    lblAnswers[i, j].MouseLeave += (_sender, _e) => lblAnswers[_i, _j].BackColor = SystemColors.Control;
                    rboAnswers[i, j].MouseHover += (_sender, _e) => lblAnswers[_i, _j].BackColor = SystemColors.ControlLight;
                    rboAnswers[i, j].MouseLeave += (_sender, _e) => lblAnswers[_i, _j].BackColor = SystemColors.Control;
                    lblAnswers[i, j].Click += (_sender, _e) => rboAnswers[_i, _j].Checked = true;
                }
            }
            lblResult = new Label
            {
                AutoSize = true,
                Location = new Point(3, panels[questions.Count - 1].Location.Y + panels[questions.Count - 1].Height + 50),
                Name = "lblResult",
                Font = new Font("Microsoft Sans Serif", 9F),
                TabIndex = questions.Count + 1
            };
            Controls.Add(lblResult);
            btnFinalize = new Button
            {
                Location = new Point(Width - 238, panels[questions.Count - 1].Location.Y + panels[questions.Count - 1].Height + 46),
                Name = "btnFinalize",
                Font = new Font("Microsoft Sans Serif", 9F),
                Size = new Size(200, 26),
                Text = "Finalizar Teste",
                TabIndex = questions.Count + 2,
                UseVisualStyleBackColor = true
            };
            btnFinalize.Click += new EventHandler(TestFinalize);
            Controls.Add(btnFinalize);
            loading = false;
        }

        private void Test_SizeChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    if (i > 0)
                    {
                        lblQtnsTitle[i].Location = new Point(12, panels[i - 1].Location.Y + panels[i - 1].Height + 46);
                    }
                    lblQtnsTitle[i].MaximumSize = new Size(Width - 50, 0);
                    panels[i].Location = new Point(15, lblQtnsTitle[i].Location.Y + lblQtnsTitle[i].Height + 14);
                    panels[i].MaximumSize = new Size(Width - 54, 0);
                    panels[i].Size = new Size(Width - 54, 0);
                    int j = 0;
                    while (j < 5 && rboAnswers[i, j] != null)
                    {
                        lblAnswers[i, j].MaximumSize = new Size(panels[i].Width - 35, 0);
                        if (j > 0)
                        {
                            lblAnswers[i, j].Location = new Point(18, lblAnswers[i, j - 1].Location.Y + lblAnswers[i, j - 1].Height + 20);
                        }
                        rboAnswers[i, j].Location = new Point(3, lblAnswers[i, j].Location.Y + (lblAnswers[i, j].Height / 2) - 5);
                        j++;
                    }
                }
                lblResult.Location = new Point(3, panels[questions.Count - 1].Location.Y + panels[questions.Count - 1].Height + 50);
                btnFinalize.Location = new Point(Width - 238, panels[questions.Count - 1].Location.Y + panels[questions.Count - 1].Height + 46);
            }
        }
    }
}
