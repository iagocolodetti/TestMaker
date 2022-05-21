using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TestMaker
{
    using INI;
    public partial class Main : Form
    {
        private readonly string INI_FILE = Application.StartupPath + @"\TestMaker.ini";

        public Main()
        {
            InitializeComponent();
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
                    Test test = new Test(Path.GetFileNameWithoutExtension(openFileDialog.FileName), questions, cbRandomQuestions.Checked, cbRandomAnswers.Checked);
                    test.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o arquivo de teste.\nTalvez o arquivo tenha sido modificado incorretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IniFile ini = new IniFile(INI_FILE);
                ini.IniWriteValue("LoadTest", "cbRandomQuestions", cbRandomQuestions.Checked.ToString());
                ini.IniWriteValue("LoadTest", "cbRandomAnswers", cbRandomAnswers.Checked.ToString());
            }
            catch
            {
                MessageBox.Show("Não foi possível criar o arquivo de configuração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(INI_FILE))
            {
                try
                {
                    IniFile ini = new IniFile(INI_FILE);
                    cbRandomQuestions.Checked = Boolean.Parse(ini.IniReadValue("LoadTest", "cbRandomQuestions"));
                    cbRandomAnswers.Checked = Boolean.Parse(ini.IniReadValue("LoadTest", "cbRandomAnswers"));
                }
                catch
                {
                    MessageBox.Show("Não foi possível carregar as configurações.\n\nArquivo de configuração possivelmente modificado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Delete(INI_FILE);
                }
            }
        }
    }
}
