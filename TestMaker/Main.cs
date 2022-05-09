using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TestMaker
{
    public partial class Main : Form
    {
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
    }
}
