using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace TestMaker
{
    public partial class CreateTest : Form
    {
        private string test;

        private List<Question> questions;
        private int currentQuestion;

        private RadioButton[] rboAnswers;
        private Label[] lblAnswers;
        private int selectedAnswer;
        private List<Answer> answers;

        private void TitleUpdate()
        {
            Text = "Criar Teste (Questão: " + currentQuestion + ")" + (string.IsNullOrEmpty(test) ? string.Empty : " [" + test + "]");
        }

        private void ResetTest()
        {
            test = null;
            rtbQtnTitle.Clear();
            pnlAws.Controls.Clear();
            questions.Clear();
            currentQuestion = 0;
            rboAnswers = new RadioButton[5];
            lblAnswers = new Label[5];
            selectedAnswer = -1;
            answers.Clear();
        }

        private void InstanceObjects()
        {
            pnlAws.HorizontalScroll.Enabled = false;
            pnlAws.VerticalScroll.Enabled = true;
            questions = new List<Question>();
            currentQuestion = 0;
            rboAnswers = new RadioButton[5];
            lblAnswers = new Label[5];
            selectedAnswer = -1;
            answers = new List<Answer>();
        }

        private void CreateAnswer(string answer)
        {
            int id = answers.Count;
            lblAnswers[id] = new Label
            {
                AutoSize = true,
                Location = new Point(18, id == 0 ? 3 : lblAnswers[id - 1].Location.Y + lblAnswers[id - 1].Height + 20),
                Name = "lblAnswers" + id,
                Font = new Font("Microsoft Sans Serif", 9F),
                MaximumSize = new Size(pnlAws.Width - 35, 0),
                Text = answer,
                TextAlign = ContentAlignment.MiddleLeft,
                TabIndex = id * 2 + 1
            };
            pnlAws.Controls.Add(lblAnswers[id]);
            rboAnswers[id] = new RadioButton
            {
                AutoSize = true,
                Location = new Point(3, lblAnswers[id].Location.Y + (lblAnswers[id].Height / 2) - 5),
                Name = "rboAnswers" + id,
                Font = new Font("Microsoft Sans Serif", 9F),
                TabIndex = id * 2,
                TabStop = true,
                UseVisualStyleBackColor = true
            };
            pnlAws.Controls.Add(rboAnswers[id]);
            lblAnswers[id].MouseHover += (sender, e) => lblAnswers[id].BackColor = SystemColors.ControlLight;
            lblAnswers[id].MouseLeave += (sender, e) => lblAnswers[id].BackColor = SystemColors.Control;
            rboAnswers[id].MouseHover += (sender, e) => lblAnswers[id].BackColor = SystemColors.ControlLight;
            rboAnswers[id].MouseLeave += (sender, e) => lblAnswers[id].BackColor = SystemColors.Control;
            rboAnswers[id].CheckedChanged += (sender, e) => selectedAnswer = id;
            lblAnswers[id].Click += (sender, e) =>
            {
                selectedAnswer = id;
                rboAnswers[id].Checked = true;
            };
            answers.Add(new Answer(id, answer));
        }

        private delegate void ResizeAnswersDelegate();

        private void ResizeAnswers()
        {
            if (InvokeRequired)
            {
                Invoke((ResizeAnswersDelegate) ResizeAnswers);
            }
            else
            {
                int i = 0;
                while (i < rboAnswers.Length && rboAnswers[i] != null)
                {
                    lblAnswers[i].MaximumSize = new Size(pnlAws.Width - 35, 0);
                    if (i > 0)
                    {
                        lblAnswers[i].Location = new Point(18, lblAnswers[i - 1].Location.Y + lblAnswers[i - 1].Height + 20);
                    }
                    rboAnswers[i].Location = new Point(3, lblAnswers[i].Location.Y + (lblAnswers[i].Height / 2) - 5);
                    i++;
                }
            }
        }

        public CreateTest()
        {
            InitializeComponent();
            InstanceObjects();
        }

        private void CreateTest_Load(object sender, EventArgs e)
        {
            currentQuestion = questions.Count;
            TitleUpdate();
        }

        private void CreateTest_SizeChanged(object sender, EventArgs e)
        {
            //new Thread(ResizeAnswers).Start();
            
            int i = 0;
            while (i < rboAnswers.Length && rboAnswers[i] != null)
            {
                lblAnswers[i].MaximumSize = new Size(pnlAws.Width - 35, 0);
                if (i > 0)
                {
                    lblAnswers[i].Location = new Point(18, lblAnswers[i - 1].Location.Y + lblAnswers[i - 1].Height + 20);
                }
                rboAnswers[i].Location = new Point(3, lblAnswers[i].Location.Y + (lblAnswers[i].Height / 2) - 5);
                i++;
            }
            
        }

        private void BtnAddAws_Click(object sender, EventArgs e)
        {
            if (answers.Count >= rboAnswers.Length)
            {
                MessageBox.Show("Quantidade máxima de respostas atingida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(rtbAws.Text))
            {
                MessageBox.Show("Digite a resposta antes de adicioná-la.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateAnswer(rtbAws.Text);
                rtbAws.Clear();
            }
        }

        private void BtnRemoveAws_Click(object sender, EventArgs e)
        {
            if (answers.Count > 0)
            {
                if (selectedAnswer > -1)
                {
                    pnlAws.Controls.Clear();
                    this.answers.RemoveAt(selectedAnswer);
                    List<Answer> answers = new List<Answer>(this.answers);
                    this.answers.Clear();
                    for (int i = 0; i < answers.Count; i++)
                    {
                        CreateAnswer(answers[i].Value);
                    }
                    selectedAnswer = -1;
                }
                else
                {
                    MessageBox.Show("Selecione uma resposta para removê-la.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRemoveQtn_Click(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                if (currentQuestion < questions.Count)
                {
                    questions.RemoveAt(currentQuestion);
                    for (int i = currentQuestion; i < questions.Count; i++)
                    {
                        questions[i].ID = i;
                    }
                    rtbQtnTitle.Clear();
                    pnlAws.Controls.Clear();
                    answers.Clear();
                    if (currentQuestion < questions.Count)
                    {
                        rtbQtnTitle.Text = questions[currentQuestion].Title;
                        for (int i = 0; i < questions[currentQuestion].Answers.Count; i++)
                        {
                            CreateAnswer(questions[currentQuestion].Answers[i].Value);
                        }
                        rboAnswers[questions[currentQuestion].CorrectAnswerID].Checked = true;
                    }
                    else
                    {
                        btnAddQtn.Text = "Adicionar Questão";
                    }
                    MessageBox.Show("Questão removida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TitleUpdate();
                }
                else
                {
                    MessageBox.Show("Navegue até uma questão já adicionada para removê-la.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não existe questão para ser removida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddQtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbQtnTitle.Text))
            {
                if (answers.Count > 1)
                {
                    if (selectedAnswer > -1)
                    {
                        if (currentQuestion < questions.Count)
                        {
                            questions[currentQuestion] = new Question(currentQuestion, rtbQtnTitle.Text, answers, selectedAnswer);
                            MessageBox.Show("Questão salva com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            questions.Add(new Question(currentQuestion, rtbQtnTitle.Text, answers, selectedAnswer));
                            rtbQtnTitle.Clear();
                            rtbAws.Clear();
                            pnlAws.Controls.Clear();
                            answers.Clear();
                            MessageBox.Show("Questão adicionada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            currentQuestion++;
                            selectedAnswer = -1;
                            TitleUpdate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione a resposta correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Adicione ao menos duas respostas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A questão precisa ter um enunciado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackQtn_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 0)
            {
                if (currentQuestion == questions.Count && (!String.IsNullOrEmpty(rtbQtnTitle.Text) || answers.Count > 0) &&
                    MessageBox.Show("A questão atual ainda não foi adicionada, ao retroceder entre as questões o que já foi adicionado aqui será perdido.\n\nTem certeza que deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                currentQuestion--;
                rtbQtnTitle.Clear();
                pnlAws.Controls.Clear();
                answers.Clear();
                Question questao = questions[currentQuestion];
                rtbQtnTitle.Text = questao.Title;
                for (int i = 0; i < questao.Answers.Count; i++)
                {
                    CreateAnswer(questao.Answers[i].Value);
                }
                rboAnswers[questao.CorrectAnswerID].Checked = true;
                btnAddQtn.Text = "Salvar Questão";
                TitleUpdate();
            }
            else
            {
                MessageBox.Show("Não existe questão anterior.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNextQtn_Click(object sender, EventArgs e)
        {
            if (currentQuestion < questions.Count)
            {
                currentQuestion++;
                rtbQtnTitle.Clear();
                pnlAws.Controls.Clear();
                answers.Clear();
                if (currentQuestion < questions.Count)
                {
                    Question question = questions[currentQuestion];
                    rtbQtnTitle.Text = question.Title;
                    for (int i = 0; i < question.Answers.Count; i++)
                    {
                        CreateAnswer(question.Answers[i].Value);
                    }
                    rboAnswers[question.CorrectAnswerID].Checked = true;
                }
                else
                {
                    btnAddQtn.Text = "Adicionar Questão";
                }
                TitleUpdate();
            }
            else
            {
                MessageBox.Show("Não existe questão seguinte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnResetTest_Click(object sender, EventArgs e)
        {
            ResetTest();
        }

        private void BtnPreviewTest_Click(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                new PreviewTest(questions).ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existe questão alguma adicionada para ser previsualizada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadTest_Click(object sender, EventArgs e)
        {
            if (questions.Count > 0 &&
                        MessageBox.Show("Caso o teste atual ainda não estiver salvo em arquivo, todo o progresso será perdido ao carregar um teste.\n\nTem certeza que deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    InitialDirectory = Application.StartupPath,
                    Title = "Carregar Teste",
                    Filter = "Arquivo JSON (*.json)|*.json",
                    RestoreDirectory = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ResetTest();
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    questions = new JavaScriptSerializer().Deserialize<List<Question>>(sr.ReadToEnd());
                    sr.Close();
                    test = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    currentQuestion = questions.Count;
                    TitleUpdate();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o arquivo de teste.\nTalvez o arquivo tenha sido modificado incorretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveTest_Click(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                if (currentQuestion == questions.Count && (!String.IsNullOrEmpty(rtbQtnTitle.Text) || answers.Count > 0) &&
                        MessageBox.Show("A questão atual ainda não foi adicionada, ao salvar o questionário em arquivo, essa questão não será salva junto.\n\nTem certeza que deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog()
                    {
                        InitialDirectory = Application.StartupPath,
                        Title = "Salvar Teste",
                        Filter = "Arquivo JSON (*.json)|*.json",
                        FileName = String.IsNullOrEmpty(test) ? null : test,
                        RestoreDirectory = true
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                        if (fileName.Length > 32)
                        {
                            MessageBox.Show("Nome do arquivo JSON é maior que 32 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog.FileName, new JavaScriptSerializer().Serialize(questions));
                            if (MessageBox.Show("Arquivo de teste criado com sucesso.\n\nDeseja começar outro teste?", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ResetTest();
                            }
                            else
                            {
                                test = fileName;
                            }
                            TitleUpdate();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível salvar o arquivo de teste nesse diretório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não existe questão alguma adicionada para ser salva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
