namespace TestMaker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.grpLoadTest = new System.Windows.Forms.GroupBox();
            this.chkRandomAnswers = new System.Windows.Forms.CheckBox();
            this.btnLoadTest = new System.Windows.Forms.Button();
            this.chkRandomQuestions = new System.Windows.Forms.CheckBox();
            this.grpSaveRtf = new System.Windows.Forms.GroupBox();
            this.btnSaveRtf = new System.Windows.Forms.Button();
            this.grpRtfCorrection = new System.Windows.Forms.GroupBox();
            this.cmbRtfCorrectFontColor = new System.Windows.Forms.ComboBox();
            this.chkCreateRtfCorrection = new System.Windows.Forms.CheckBox();
            this.lblRtfCorrectFontColor = new System.Windows.Forms.Label();
            this.grpRtfAnswers = new System.Windows.Forms.GroupBox();
            this.chkRtfRandomAnswers = new System.Windows.Forms.CheckBox();
            this.cmbRtfAnswersFontColor = new System.Windows.Forms.ComboBox();
            this.lblRtfAnswersFontSize = new System.Windows.Forms.Label();
            this.lblRtfAnswersFontColor = new System.Windows.Forms.Label();
            this.txtRtfAnswersFontSize = new System.Windows.Forms.TextBox();
            this.grpRtfQuestions = new System.Windows.Forms.GroupBox();
            this.chkRtfRandomQuestions = new System.Windows.Forms.CheckBox();
            this.cmbRtfQuestionsFontColor = new System.Windows.Forms.ComboBox();
            this.lblRtfQuestionsFontColor = new System.Windows.Forms.Label();
            this.txtRtfQuestionsFontSize = new System.Windows.Forms.TextBox();
            this.lblRtfQuestionsFontSize = new System.Windows.Forms.Label();
            this.cmbRtfFont = new System.Windows.Forms.ComboBox();
            this.lblRtfFont = new System.Windows.Forms.Label();
            this.grpLoadTest.SuspendLayout();
            this.grpSaveRtf.SuspendLayout();
            this.grpRtfCorrection.SuspendLayout();
            this.grpRtfAnswers.SuspendLayout();
            this.grpRtfQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCreateTest.Location = new System.Drawing.Point(26, 19);
            this.btnCreateTest.Margin = new System.Windows.Forms.Padding(10);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(200, 26);
            this.btnCreateTest.TabIndex = 0;
            this.btnCreateTest.Text = "Criar ou Editar Teste";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.BtnCreateTest_Click);
            // 
            // grpLoadTest
            // 
            this.grpLoadTest.Controls.Add(this.chkRandomAnswers);
            this.grpLoadTest.Controls.Add(this.btnLoadTest);
            this.grpLoadTest.Controls.Add(this.chkRandomQuestions);
            this.grpLoadTest.Location = new System.Drawing.Point(19, 65);
            this.grpLoadTest.Margin = new System.Windows.Forms.Padding(10);
            this.grpLoadTest.Name = "grpLoadTest";
            this.grpLoadTest.Size = new System.Drawing.Size(212, 104);
            this.grpLoadTest.TabIndex = 1;
            this.grpLoadTest.TabStop = false;
            this.grpLoadTest.Text = "Realizar Teste";
            // 
            // chkRandomAnswers
            // 
            this.chkRandomAnswers.AutoSize = true;
            this.chkRandomAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkRandomAnswers.Location = new System.Drawing.Point(6, 47);
            this.chkRandomAnswers.Name = "chkRandomAnswers";
            this.chkRandomAnswers.Size = new System.Drawing.Size(195, 19);
            this.chkRandomAnswers.TabIndex = 1;
            this.chkRandomAnswers.Text = "Respostas em ordem aleatória";
            this.chkRandomAnswers.UseVisualStyleBackColor = true;
            // 
            // btnLoadTest
            // 
            this.btnLoadTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLoadTest.Location = new System.Drawing.Point(6, 72);
            this.btnLoadTest.Name = "btnLoadTest";
            this.btnLoadTest.Size = new System.Drawing.Size(200, 26);
            this.btnLoadTest.TabIndex = 2;
            this.btnLoadTest.Text = "Carregar Teste";
            this.btnLoadTest.UseVisualStyleBackColor = true;
            this.btnLoadTest.Click += new System.EventHandler(this.BtnLoadTest_Click);
            // 
            // chkRandomQuestions
            // 
            this.chkRandomQuestions.AutoSize = true;
            this.chkRandomQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkRandomQuestions.Location = new System.Drawing.Point(6, 22);
            this.chkRandomQuestions.Name = "chkRandomQuestions";
            this.chkRandomQuestions.Size = new System.Drawing.Size(189, 19);
            this.chkRandomQuestions.TabIndex = 0;
            this.chkRandomQuestions.Text = "Questões em ordem aleatória";
            this.chkRandomQuestions.UseVisualStyleBackColor = true;
            // 
            // grpSaveRtf
            // 
            this.grpSaveRtf.Controls.Add(this.btnSaveRtf);
            this.grpSaveRtf.Controls.Add(this.grpRtfCorrection);
            this.grpSaveRtf.Controls.Add(this.grpRtfAnswers);
            this.grpSaveRtf.Controls.Add(this.grpRtfQuestions);
            this.grpSaveRtf.Controls.Add(this.cmbRtfFont);
            this.grpSaveRtf.Controls.Add(this.lblRtfFont);
            this.grpSaveRtf.Location = new System.Drawing.Point(19, 182);
            this.grpSaveRtf.Name = "grpSaveRtf";
            this.grpSaveRtf.Size = new System.Drawing.Size(212, 397);
            this.grpSaveRtf.TabIndex = 2;
            this.grpSaveRtf.TabStop = false;
            this.grpSaveRtf.Text = "Salvar em RTF";
            // 
            // btnSaveRtf
            // 
            this.btnSaveRtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSaveRtf.Location = new System.Drawing.Point(6, 359);
            this.btnSaveRtf.Name = "btnSaveRtf";
            this.btnSaveRtf.Size = new System.Drawing.Size(201, 26);
            this.btnSaveRtf.TabIndex = 5;
            this.btnSaveRtf.Text = "Salvar";
            this.btnSaveRtf.UseVisualStyleBackColor = true;
            this.btnSaveRtf.Click += new System.EventHandler(this.BtnSaveRtf_Click);
            // 
            // grpRtfCorrection
            // 
            this.grpRtfCorrection.Controls.Add(this.cmbRtfCorrectFontColor);
            this.grpRtfCorrection.Controls.Add(this.chkCreateRtfCorrection);
            this.grpRtfCorrection.Controls.Add(this.lblRtfCorrectFontColor);
            this.grpRtfCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpRtfCorrection.Location = new System.Drawing.Point(6, 268);
            this.grpRtfCorrection.Name = "grpRtfCorrection";
            this.grpRtfCorrection.Size = new System.Drawing.Size(200, 82);
            this.grpRtfCorrection.TabIndex = 4;
            this.grpRtfCorrection.TabStop = false;
            this.grpRtfCorrection.Text = "Gabarito";
            // 
            // cmbRtfCorrectFontColor
            // 
            this.cmbRtfCorrectFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRtfCorrectFontColor.FormattingEnabled = true;
            this.cmbRtfCorrectFontColor.Location = new System.Drawing.Point(40, 45);
            this.cmbRtfCorrectFontColor.Name = "cmbRtfCorrectFontColor";
            this.cmbRtfCorrectFontColor.Size = new System.Drawing.Size(154, 23);
            this.cmbRtfCorrectFontColor.TabIndex = 3;
            // 
            // chkCreateRtfCorrection
            // 
            this.chkCreateRtfCorrection.AutoSize = true;
            this.chkCreateRtfCorrection.Location = new System.Drawing.Point(8, 20);
            this.chkCreateRtfCorrection.Name = "chkCreateRtfCorrection";
            this.chkCreateRtfCorrection.Size = new System.Drawing.Size(102, 19);
            this.chkCreateRtfCorrection.TabIndex = 0;
            this.chkCreateRtfCorrection.Text = "Criar Gabarito";
            this.chkCreateRtfCorrection.UseVisualStyleBackColor = true;
            // 
            // lblRtfCorrectFontColor
            // 
            this.lblRtfCorrectFontColor.AutoSize = true;
            this.lblRtfCorrectFontColor.Location = new System.Drawing.Point(5, 48);
            this.lblRtfCorrectFontColor.Name = "lblRtfCorrectFontColor";
            this.lblRtfCorrectFontColor.Size = new System.Drawing.Size(29, 15);
            this.lblRtfCorrectFontColor.TabIndex = 2;
            this.lblRtfCorrectFontColor.Text = "Cor:";
            // 
            // grpRtfAnswers
            // 
            this.grpRtfAnswers.Controls.Add(this.chkRtfRandomAnswers);
            this.grpRtfAnswers.Controls.Add(this.cmbRtfAnswersFontColor);
            this.grpRtfAnswers.Controls.Add(this.lblRtfAnswersFontSize);
            this.grpRtfAnswers.Controls.Add(this.lblRtfAnswersFontColor);
            this.grpRtfAnswers.Controls.Add(this.txtRtfAnswersFontSize);
            this.grpRtfAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpRtfAnswers.Location = new System.Drawing.Point(6, 160);
            this.grpRtfAnswers.Name = "grpRtfAnswers";
            this.grpRtfAnswers.Size = new System.Drawing.Size(200, 102);
            this.grpRtfAnswers.TabIndex = 3;
            this.grpRtfAnswers.TabStop = false;
            this.grpRtfAnswers.Text = "Respostas";
            // 
            // chkRtfRandomAnswers
            // 
            this.chkRtfRandomAnswers.AutoSize = true;
            this.chkRtfRandomAnswers.Location = new System.Drawing.Point(8, 76);
            this.chkRtfRandomAnswers.Name = "chkRtfRandomAnswers";
            this.chkRtfRandomAnswers.Size = new System.Drawing.Size(115, 19);
            this.chkRtfRandomAnswers.TabIndex = 4;
            this.chkRtfRandomAnswers.Text = "Ordem aleatória";
            this.chkRtfRandomAnswers.UseVisualStyleBackColor = true;
            // 
            // cmbRtfAnswersFontColor
            // 
            this.cmbRtfAnswersFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRtfAnswersFontColor.FormattingEnabled = true;
            this.cmbRtfAnswersFontColor.Location = new System.Drawing.Point(40, 47);
            this.cmbRtfAnswersFontColor.Name = "cmbRtfAnswersFontColor";
            this.cmbRtfAnswersFontColor.Size = new System.Drawing.Size(154, 23);
            this.cmbRtfAnswersFontColor.TabIndex = 3;
            // 
            // lblRtfAnswersFontSize
            // 
            this.lblRtfAnswersFontSize.AutoSize = true;
            this.lblRtfAnswersFontSize.Location = new System.Drawing.Point(5, 21);
            this.lblRtfAnswersFontSize.Name = "lblRtfAnswersFontSize";
            this.lblRtfAnswersFontSize.Size = new System.Drawing.Size(114, 15);
            this.lblRtfAnswersFontSize.TabIndex = 0;
            this.lblRtfAnswersFontSize.Text = "Tamanho da Fonte:";
            // 
            // lblRtfAnswersFontColor
            // 
            this.lblRtfAnswersFontColor.AutoSize = true;
            this.lblRtfAnswersFontColor.Location = new System.Drawing.Point(5, 50);
            this.lblRtfAnswersFontColor.Name = "lblRtfAnswersFontColor";
            this.lblRtfAnswersFontColor.Size = new System.Drawing.Size(29, 15);
            this.lblRtfAnswersFontColor.TabIndex = 2;
            this.lblRtfAnswersFontColor.Text = "Cor:";
            // 
            // txtRtfAnswersFontSize
            // 
            this.txtRtfAnswersFontSize.Location = new System.Drawing.Point(125, 20);
            this.txtRtfAnswersFontSize.MaxLength = 2;
            this.txtRtfAnswersFontSize.Name = "txtRtfAnswersFontSize";
            this.txtRtfAnswersFontSize.Size = new System.Drawing.Size(69, 21);
            this.txtRtfAnswersFontSize.TabIndex = 1;
            this.txtRtfAnswersFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRtfAnswersFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRtfAnswersFontSize_KeyPress);
            // 
            // grpRtfQuestions
            // 
            this.grpRtfQuestions.Controls.Add(this.chkRtfRandomQuestions);
            this.grpRtfQuestions.Controls.Add(this.cmbRtfQuestionsFontColor);
            this.grpRtfQuestions.Controls.Add(this.lblRtfQuestionsFontColor);
            this.grpRtfQuestions.Controls.Add(this.txtRtfQuestionsFontSize);
            this.grpRtfQuestions.Controls.Add(this.lblRtfQuestionsFontSize);
            this.grpRtfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpRtfQuestions.Location = new System.Drawing.Point(6, 52);
            this.grpRtfQuestions.Name = "grpRtfQuestions";
            this.grpRtfQuestions.Size = new System.Drawing.Size(200, 102);
            this.grpRtfQuestions.TabIndex = 2;
            this.grpRtfQuestions.TabStop = false;
            this.grpRtfQuestions.Text = "Questões";
            // 
            // chkRtfRandomQuestions
            // 
            this.chkRtfRandomQuestions.AutoSize = true;
            this.chkRtfRandomQuestions.Location = new System.Drawing.Point(9, 76);
            this.chkRtfRandomQuestions.Name = "chkRtfRandomQuestions";
            this.chkRtfRandomQuestions.Size = new System.Drawing.Size(115, 19);
            this.chkRtfRandomQuestions.TabIndex = 4;
            this.chkRtfRandomQuestions.Text = "Ordem aleatória";
            this.chkRtfRandomQuestions.UseVisualStyleBackColor = true;
            // 
            // cmbRtfQuestionsFontColor
            // 
            this.cmbRtfQuestionsFontColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRtfQuestionsFontColor.FormattingEnabled = true;
            this.cmbRtfQuestionsFontColor.Location = new System.Drawing.Point(41, 47);
            this.cmbRtfQuestionsFontColor.Name = "cmbRtfQuestionsFontColor";
            this.cmbRtfQuestionsFontColor.Size = new System.Drawing.Size(153, 23);
            this.cmbRtfQuestionsFontColor.TabIndex = 3;
            // 
            // lblRtfQuestionsFontColor
            // 
            this.lblRtfQuestionsFontColor.AutoSize = true;
            this.lblRtfQuestionsFontColor.Location = new System.Drawing.Point(6, 50);
            this.lblRtfQuestionsFontColor.Name = "lblRtfQuestionsFontColor";
            this.lblRtfQuestionsFontColor.Size = new System.Drawing.Size(29, 15);
            this.lblRtfQuestionsFontColor.TabIndex = 2;
            this.lblRtfQuestionsFontColor.Text = "Cor:";
            // 
            // txtRtfQuestionsFontSize
            // 
            this.txtRtfQuestionsFontSize.Location = new System.Drawing.Point(126, 20);
            this.txtRtfQuestionsFontSize.MaxLength = 2;
            this.txtRtfQuestionsFontSize.Name = "txtRtfQuestionsFontSize";
            this.txtRtfQuestionsFontSize.Size = new System.Drawing.Size(68, 21);
            this.txtRtfQuestionsFontSize.TabIndex = 1;
            this.txtRtfQuestionsFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRtfQuestionsFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRtfQuestionsFontSize_KeyPress);
            // 
            // lblRtfQuestionsFontSize
            // 
            this.lblRtfQuestionsFontSize.AutoSize = true;
            this.lblRtfQuestionsFontSize.Location = new System.Drawing.Point(6, 21);
            this.lblRtfQuestionsFontSize.Name = "lblRtfQuestionsFontSize";
            this.lblRtfQuestionsFontSize.Size = new System.Drawing.Size(114, 15);
            this.lblRtfQuestionsFontSize.TabIndex = 0;
            this.lblRtfQuestionsFontSize.Text = "Tamanho da Fonte:";
            // 
            // cmbRtfFont
            // 
            this.cmbRtfFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRtfFont.FormattingEnabled = true;
            this.cmbRtfFont.Location = new System.Drawing.Point(53, 22);
            this.cmbRtfFont.Name = "cmbRtfFont";
            this.cmbRtfFont.Size = new System.Drawing.Size(153, 24);
            this.cmbRtfFont.TabIndex = 1;
            // 
            // lblRtfFont
            // 
            this.lblRtfFont.AutoSize = true;
            this.lblRtfFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRtfFont.Location = new System.Drawing.Point(6, 25);
            this.lblRtfFont.Name = "lblRtfFont";
            this.lblRtfFont.Size = new System.Drawing.Size(41, 15);
            this.lblRtfFont.TabIndex = 0;
            this.lblRtfFont.Text = "Fonte:";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(249, 595);
            this.Controls.Add(this.grpSaveRtf);
            this.Controls.Add(this.grpLoadTest);
            this.Controls.Add(this.btnCreateTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 634);
            this.MinimumSize = new System.Drawing.Size(265, 634);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestMaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpLoadTest.ResumeLayout(false);
            this.grpLoadTest.PerformLayout();
            this.grpSaveRtf.ResumeLayout(false);
            this.grpSaveRtf.PerformLayout();
            this.grpRtfCorrection.ResumeLayout(false);
            this.grpRtfCorrection.PerformLayout();
            this.grpRtfAnswers.ResumeLayout(false);
            this.grpRtfAnswers.PerformLayout();
            this.grpRtfQuestions.ResumeLayout(false);
            this.grpRtfQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.GroupBox grpLoadTest;
        private System.Windows.Forms.CheckBox chkRandomAnswers;
        private System.Windows.Forms.CheckBox chkRandomQuestions;
        private System.Windows.Forms.Button btnLoadTest;
        private System.Windows.Forms.GroupBox grpSaveRtf;
        private System.Windows.Forms.ComboBox cmbRtfFont;
        private System.Windows.Forms.Label lblRtfFont;
        private System.Windows.Forms.Button btnSaveRtf;
        private System.Windows.Forms.GroupBox grpRtfCorrection;
        private System.Windows.Forms.ComboBox cmbRtfCorrectFontColor;
        private System.Windows.Forms.CheckBox chkCreateRtfCorrection;
        private System.Windows.Forms.GroupBox grpRtfAnswers;
        private System.Windows.Forms.ComboBox cmbRtfAnswersFontColor;
        private System.Windows.Forms.Label lblRtfAnswersFontSize;
        private System.Windows.Forms.Label lblRtfAnswersFontColor;
        private System.Windows.Forms.TextBox txtRtfAnswersFontSize;
        private System.Windows.Forms.GroupBox grpRtfQuestions;
        private System.Windows.Forms.ComboBox cmbRtfQuestionsFontColor;
        private System.Windows.Forms.Label lblRtfQuestionsFontColor;
        private System.Windows.Forms.TextBox txtRtfQuestionsFontSize;
        private System.Windows.Forms.Label lblRtfQuestionsFontSize;
        private System.Windows.Forms.Label lblRtfCorrectFontColor;
        private System.Windows.Forms.CheckBox chkRtfRandomAnswers;
        private System.Windows.Forms.CheckBox chkRtfRandomQuestions;
    }
}