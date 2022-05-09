using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestMaker
{
    public partial class PreviewTest : Form
    {
        private bool loading;

        private List<Question> questions;
        private Label[] lblQtnsTitle;
        private Panel[] panels;
        private RadioButton[,] rboAnswers;
        private Label[,] lblAnswers;

        public PreviewTest(List<Question> questions)
        {
            loading = true;
            InitializeComponent();
            HorizontalScroll.Enabled = false;
            VerticalScroll.Enabled = true;
            this.questions = new List<Question>(questions);
            lblQtnsTitle = new Label[questions.Count];
            panels = new Panel[questions.Count];
            rboAnswers = new RadioButton[questions.Count, 5];
            lblAnswers = new Label[questions.Count, 5];
        }

        private void PreviewTest_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                lblQtnsTitle[i] = new Label
                {
                    AutoSize = true,
                    Location = new Point(12, i == 0 ? 9 : panels[i - 1].Location.Y + panels[i - 1].Height + 46),
                    Name = "lblQtnsTitle" + i,
                    Font = new Font("Microsoft Sans Serif", 9F),
                    MaximumSize = new Size(this.Width - 50, 0),
                    TabIndex = 2 * i,
                    Text = i + 1 + ") " + questions[i].Title
                };
                Controls.Add(lblQtnsTitle[i]);
                panels[i] = new Panel
                {
                    AutoSize = true,
                    Location = new Point(15, lblQtnsTitle[i].Location.Y + lblQtnsTitle[i].Height + 14),
                    Name = "panels" + i,
                    MaximumSize = new Size(this.Width - 54, 0),
                    Size = new Size(this.Width - 54, 0),
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
                        UseVisualStyleBackColor = true,
                        Enabled = false
                    };
                    panels[i].Controls.Add(rboAnswers[i, j]);
                }
                rboAnswers[i, questions[i].CorrectAnswerID].Checked = true;
            }
            loading = false;
        }

        private void PreviewTest_SizeChanged(object sender, EventArgs e)
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
            }
        }
    }
}
