using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestMaker
{
    public class RTF
    {
        public const int colorsLength = 4;

        public int ColorsLength { get => colorsLength; }

        public readonly string[] fonts = new string[5]
        {
            "Arial",
            "Comic Sans MS",
            "Consolas",
            "Tahoma",
            "Verdana"
        };

        public readonly string[,] colors = new string[colorsLength, 2]
        {
            { "Preto", @"\cf1 " },
            { "Vermelho", @"\cf2 " },
            { "Verde", @"\cf3 " },
            { "Azul", @"\cf4 " }
        };

        public void SaveRTF(string dir, List<Question> questions, int font, int questionFontSize, int questionFontColor, int answerFontSize, int answerFontColor, bool saveWithCorrection = false, int correctAnswerFontColor = 1)
        {
            try
            {
                questionFontSize *= 2;
                answerFontSize *= 2;

                RichTextBox RTF = new RichTextBox();
                RTF.AppendText(@"{\rtf1\ansi\deff0 {\fonttbl {\f0 " + fonts[font] + ";}}");
                RTF.AppendText(Environment.NewLine);
                RTF.AppendText(@"{\colortbl;\red0\green0\blue0;\red255\green0\blue0;\red0\green255\blue0;\red0\green0\blue255;}");
                RTF.AppendText(Environment.NewLine);
                RTF.AppendText(@"\paperw11900\paperh16840\margl850\margr850\margt850\margb850");
                RTF.AppendText(Environment.NewLine);
                for (int i = 0; i < questions.Count; i++)
                {
                    RTF.AppendText(@"\fs" + questionFontSize + @"\b0"); RTF.AppendText(colors[questionFontColor, 1]); RTF.AppendText((i + 1).ToString() + ") " + questions[i].Title); RTF.AppendText(@"\line");
                    for (int j = 0; j < questions[i].Answers.Count; j++)
                    {
                        RTF.AppendText(@"\fs" + answerFontSize + @"\b0"); RTF.AppendText(colors[answerFontColor, 1]); RTF.AppendText(" " + (char)(j + 97) + ") " + questions[i].Answers[j].Value); RTF.AppendText(@"\line");
                    }
                    RTF.AppendText(@"\line");
                }
                RTF.AppendText("}");
                RTF.SaveFile(dir + ".rtf", RichTextBoxStreamType.PlainText);

                if (saveWithCorrection)
                {
                    RTF = new RichTextBox();
                    RTF.AppendText(@"{\rtf1\ansi\deff0 {\fonttbl {\f0 " + fonts[font] + ";}}");
                    RTF.AppendText(Environment.NewLine);
                    RTF.AppendText(@"{\colortbl;\red0\green0\blue0;\red255\green0\blue0;\red0\green255\blue0;\red0\green0\blue255;}");
                    RTF.AppendText(Environment.NewLine);
                    RTF.AppendText(@"\paperw11900\paperh16840\margl850\margr850\margt850\margb850");
                    RTF.AppendText(Environment.NewLine);
                    for (int i = 0; i < questions.Count; i++)
                    {
                        RTF.AppendText(@"\fs" + questionFontSize + @"\b0"); RTF.AppendText(colors[questionFontColor, 1]); RTF.AppendText((i + 1).ToString() + ") " + questions[i].Title); RTF.AppendText(@"\line");
                        for (int j = 0; j < questions[i].Answers.Count; j++)
                        {
                            RTF.AppendText(@"\fs" + answerFontSize + @"\b0"); RTF.AppendText(questions[i].CorrectAnswerID == j ? colors[correctAnswerFontColor, 1] : colors[answerFontColor, 1]); RTF.AppendText(" " + (char)(j + 97) + ") " + questions[i].Answers[j].Value); RTF.AppendText(@"\line");
                        }
                        RTF.AppendText(@"\line");
                    }
                    RTF.AppendText("}");
                    RTF.SaveFile(dir + " [GABARITO].rtf", RichTextBoxStreamType.PlainText);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível salvar o arquivo RTF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
