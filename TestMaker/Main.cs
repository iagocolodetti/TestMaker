using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Linq;

namespace TestMaker
{
    public partial class Main : Form
    {
        private readonly string INI_FILE = Application.StartupPath + @"\TestMaker.ini";
        private readonly RTF rtf = new RTF();

        public Main()
        {
            InitializeComponent();
            for (int i = 0; i < rtf.fonts.Length; i++)
            {
                cmbRtfFont.Items.Add(rtf.fonts[i]);
            }
            cmbRtfFont.SelectedIndex = 0;
            for (int i = 0; i < rtf.ColorsLength; i++)
            {
                cmbRtfQuestionsFontColor.Items.Add(rtf.colors[i, 0]);
                cmbRtfAnswersFontColor.Items.Add(rtf.colors[i, 0]);
                cmbRtfCorrectFontColor.Items.Add(rtf.colors[i, 0]);
            }
            txtRtfQuestionsFontSize.Text = "12";
            cmbRtfQuestionsFontColor.SelectedIndex = 0;
            txtRtfAnswersFontSize.Text = "10";
            cmbRtfAnswersFontColor.SelectedIndex = 0;
            cmbRtfCorrectFontColor.SelectedIndex = 1;
        }

        private void BtnCreateTest_Click(object sender, EventArgs e)
        {
            CreateTest createTest = new CreateTest();
            createTest.ShowDialog();
        }

        private void BtnLoadTest_Click(object sender, EventArgs e)
        {
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
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    List<Question> questions = new JavaScriptSerializer().Deserialize<List<Question>>(sr.ReadToEnd());
                    sr.Close();
                    Test test = new Test(Path.GetFileNameWithoutExtension(openFileDialog.FileName), questions, chkRandomQuestions.Checked, chkRandomAnswers.Checked);
                    test.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o arquivo de teste.\nTalvez o arquivo tenha sido modificado incorretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(INI_FILE))
            {
                try
                {
                    IniFile ini = new IniFile(INI_FILE);
                    chkRandomQuestions.Checked = Boolean.Parse(ini.IniReadValue("LoadTest", "chkRandomQuestions"));
                    chkRandomAnswers.Checked = Boolean.Parse(ini.IniReadValue("LoadTest", "chkRandomAnswers"));
                    cmbRtfFont.SelectedIndex = int.Parse(ini.IniReadValue("RTF", "cmbRtfFont"));
                    txtRtfQuestionsFontSize.Text = int.Parse(ini.IniReadValue("RTF", "txtRtfQuestionsFontSize")).ToString();
                    cmbRtfQuestionsFontColor.SelectedIndex = int.Parse(ini.IniReadValue("RTF", "cmbRtfQuestionsFontColor"));
                    chkRtfRandomQuestions.Checked = Boolean.Parse(ini.IniReadValue("RTF", "chkRtfRandomQuestions"));
                    txtRtfAnswersFontSize.Text = int.Parse(ini.IniReadValue("RTF", "txtRtfAnswersFontSize")).ToString();
                    cmbRtfAnswersFontColor.SelectedIndex = int.Parse(ini.IniReadValue("RTF", "cmbRtfAnswersFontColor"));
                    chkRtfRandomAnswers.Checked = Boolean.Parse(ini.IniReadValue("RTF", "chkRtfRandomAnswers"));
                    chkCreateRtfCorrection.Checked = Boolean.Parse(ini.IniReadValue("RTF", "chkCreateRtfCorrection"));
                    cmbRtfCorrectFontColor.SelectedIndex = int.Parse(ini.IniReadValue("RTF", "cmbRtfCorrectFontColor"));
                }
                catch
                {
                    MessageBox.Show("Não foi possível carregar as configurações.\n\nArquivo de configuração possivelmente modificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Delete(INI_FILE);
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IniFile ini = new IniFile(INI_FILE);
                ini.IniWriteValue("LoadTest", "chkRandomQuestions", chkRandomQuestions.Checked.ToString());
                ini.IniWriteValue("LoadTest", "chkRandomAnswers", chkRandomAnswers.Checked.ToString());
                ini.IniWriteValue("RTF", "cmbRtfFont", cmbRtfFont.SelectedIndex.ToString());
                ini.IniWriteValue("RTF", "txtRtfQuestionsFontSize", txtRtfQuestionsFontSize.Text);
                ini.IniWriteValue("RTF", "cmbRtfQuestionsFontColor", cmbRtfQuestionsFontColor.SelectedIndex.ToString());
                ini.IniWriteValue("RTF", "chkRtfRandomQuestions", chkRtfRandomQuestions.Checked.ToString());
                ini.IniWriteValue("RTF", "txtRtfAnswersFontSize", txtRtfAnswersFontSize.Text);
                ini.IniWriteValue("RTF", "cmbRtfAnswersFontColor", cmbRtfAnswersFontColor.SelectedIndex.ToString());
                ini.IniWriteValue("RTF", "chkRtfRandomAnswers", chkRtfRandomQuestions.Checked.ToString());
                ini.IniWriteValue("RTF", "chkCreateRtfCorrection", chkCreateRtfCorrection.Checked.ToString());
                ini.IniWriteValue("RTF", "cmbRtfCorrectFontColor", cmbRtfCorrectFontColor.SelectedIndex.ToString());
            }
            catch
            {
                MessageBox.Show("Não foi possível criar o arquivo de configuração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveRtf_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRtfQuestionsFontSize.Text.Length > 0 && txtRtfAnswersFontSize.Text.Length > 0)
                {
                    int questionsFontSize = int.Parse(txtRtfQuestionsFontSize.Text);
                    int answersFontSize = int.Parse(txtRtfAnswersFontSize.Text);
                    if (questionsFontSize >= 3 && questionsFontSize <= 30 && answersFontSize >= 3 && answersFontSize <= 30)
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
                            StreamReader sr = new StreamReader(openFileDialog.FileName);
                            List<Question> questions = new JavaScriptSerializer().Deserialize<List<Question>>(sr.ReadToEnd());
                            sr.Close();

                            Random random = new Random();
                            questions = chkRtfRandomQuestions.Checked ? questions.OrderBy(question => random.Next()).ToList() : new List<Question>(questions);
                            if (chkRtfRandomAnswers.Checked)
                            {
                                for (int i = 0; i < questions.Count; i++)
                                {
                                    questions[i].Answers = questions[i].Answers.OrderBy(answer => random.Next()).ToList();
                                    questions[i].CorrectAnswerID = questions[i].Answers.FindIndex(answer => answer.ID == questions[i].CorrectAnswerID);
                                }
                            }

                            string dir = Path.GetDirectoryName(openFileDialog.FileName) + "\\";
                            string filename = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                            string newFilename = filename;
                            for (int i = 1; File.Exists(dir + newFilename + ".rtf"); i++)
                            {
                                newFilename = filename + " (" + i + ")";
                            }

                            rtf.SaveRTF(dir + newFilename, questions, cmbRtfFont.SelectedIndex,
                                questionsFontSize, cmbRtfQuestionsFontColor.SelectedIndex,
                                answersFontSize, cmbRtfAnswersFontColor.SelectedIndex,
                                chkCreateRtfCorrection.Checked, cmbRtfCorrectFontColor.SelectedIndex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O tamanho da fonte deve ser no mínimo 3 e no máximo 30.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Defina os tamanhos para as fontes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Os valores para as fontes devem ser números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtRtfQuestionsFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtRtfAnswersFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
