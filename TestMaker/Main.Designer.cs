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
            this.gpbLoadTest = new System.Windows.Forms.GroupBox();
            this.cbRandomAnswers = new System.Windows.Forms.CheckBox();
            this.btnLoadTest = new System.Windows.Forms.Button();
            this.cbRandomQuestions = new System.Windows.Forms.CheckBox();
            this.gpbLoadTest.SuspendLayout();
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
            // gpbLoadTest
            // 
            this.gpbLoadTest.Controls.Add(this.cbRandomAnswers);
            this.gpbLoadTest.Controls.Add(this.btnLoadTest);
            this.gpbLoadTest.Controls.Add(this.cbRandomQuestions);
            this.gpbLoadTest.Location = new System.Drawing.Point(19, 65);
            this.gpbLoadTest.Margin = new System.Windows.Forms.Padding(10);
            this.gpbLoadTest.Name = "gpbLoadTest";
            this.gpbLoadTest.Size = new System.Drawing.Size(212, 104);
            this.gpbLoadTest.TabIndex = 1;
            this.gpbLoadTest.TabStop = false;
            this.gpbLoadTest.Text = "Realizar Teste";
            // 
            // cbRandomAnswers
            // 
            this.cbRandomAnswers.AutoSize = true;
            this.cbRandomAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbRandomAnswers.Location = new System.Drawing.Point(6, 47);
            this.cbRandomAnswers.Name = "cbRandomAnswers";
            this.cbRandomAnswers.Size = new System.Drawing.Size(195, 19);
            this.cbRandomAnswers.TabIndex = 1;
            this.cbRandomAnswers.Text = "Respostas em ordem aleatória";
            this.cbRandomAnswers.UseVisualStyleBackColor = true;
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
            // cbRandomQuestions
            // 
            this.cbRandomQuestions.AutoSize = true;
            this.cbRandomQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbRandomQuestions.Location = new System.Drawing.Point(6, 22);
            this.cbRandomQuestions.Name = "cbRandomQuestions";
            this.cbRandomQuestions.Size = new System.Drawing.Size(189, 19);
            this.cbRandomQuestions.TabIndex = 0;
            this.cbRandomQuestions.Text = "Questões em ordem aleatória";
            this.cbRandomQuestions.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(251, 186);
            this.Controls.Add(this.gpbLoadTest);
            this.Controls.Add(this.btnCreateTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(267, 225);
            this.MinimumSize = new System.Drawing.Size(267, 225);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestMaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gpbLoadTest.ResumeLayout(false);
            this.gpbLoadTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.GroupBox gpbLoadTest;
        private System.Windows.Forms.CheckBox cbRandomAnswers;
        private System.Windows.Forms.CheckBox cbRandomQuestions;
        private System.Windows.Forms.Button btnLoadTest;
    }
}