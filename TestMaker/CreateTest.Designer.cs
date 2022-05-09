﻿namespace TestMaker
{
    partial class CreateTest
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQtnTitle = new System.Windows.Forms.Label();
            this.rtbQtnTitle = new System.Windows.Forms.RichTextBox();
            this.btnNextQtn = new System.Windows.Forms.Button();
            this.btnBackQtn = new System.Windows.Forms.Button();
            this.btnAddQtn = new System.Windows.Forms.Button();
            this.btnPreviewTest = new System.Windows.Forms.Button();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.btnRemoveQtn = new System.Windows.Forms.Button();
            this.gpbAws = new System.Windows.Forms.GroupBox();
            this.rtbAws = new System.Windows.Forms.RichTextBox();
            this.pnlAws = new System.Windows.Forms.Panel();
            this.btnRemoveAws = new System.Windows.Forms.Button();
            this.btAddAws = new System.Windows.Forms.Button();
            this.gpbQtn = new System.Windows.Forms.GroupBox();
            this.gpbTest = new System.Windows.Forms.GroupBox();
            this.btnResetTest = new System.Windows.Forms.Button();
            this.btnLoadTest = new System.Windows.Forms.Button();
            this.gpbAws.SuspendLayout();
            this.gpbQtn.SuspendLayout();
            this.gpbTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQtnTitle
            // 
            this.lblQtnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtnTitle.AutoSize = true;
            this.lblQtnTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblQtnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQtnTitle.Location = new System.Drawing.Point(12, 9);
            this.lblQtnTitle.Name = "lblQtnTitle";
            this.lblQtnTitle.Size = new System.Drawing.Size(79, 17);
            this.lblQtnTitle.TabIndex = 0;
            this.lblQtnTitle.Text = "Enunciado:";
            this.lblQtnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbQtnTitle
            // 
            this.rtbQtnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQtnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtbQtnTitle.Location = new System.Drawing.Point(15, 30);
            this.rtbQtnTitle.Name = "rtbQtnTitle";
            this.rtbQtnTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbQtnTitle.Size = new System.Drawing.Size(757, 116);
            this.rtbQtnTitle.TabIndex = 1;
            this.rtbQtnTitle.Text = "";
            // 
            // btnNextQtn
            // 
            this.btnNextQtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNextQtn.Location = new System.Drawing.Point(142, 54);
            this.btnNextQtn.Name = "btnNextQtn";
            this.btnNextQtn.Size = new System.Drawing.Size(130, 26);
            this.btnNextQtn.TabIndex = 11;
            this.btnNextQtn.Text = "Próxima";
            this.btnNextQtn.UseVisualStyleBackColor = true;
            this.btnNextQtn.Click += new System.EventHandler(this.BtnNextQtn_Click);
            // 
            // btnBackQtn
            // 
            this.btnBackQtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBackQtn.Location = new System.Drawing.Point(6, 54);
            this.btnBackQtn.Name = "btnBackQtn";
            this.btnBackQtn.Size = new System.Drawing.Size(130, 26);
            this.btnBackQtn.TabIndex = 10;
            this.btnBackQtn.Text = "Anterior";
            this.btnBackQtn.UseVisualStyleBackColor = true;
            this.btnBackQtn.Click += new System.EventHandler(this.BtnBackQtn_Click);
            // 
            // btnAddQtn
            // 
            this.btnAddQtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddQtn.Location = new System.Drawing.Point(142, 22);
            this.btnAddQtn.Name = "btnAddQtn";
            this.btnAddQtn.Size = new System.Drawing.Size(130, 26);
            this.btnAddQtn.TabIndex = 9;
            this.btnAddQtn.Text = "Adicionar";
            this.btnAddQtn.UseVisualStyleBackColor = true;
            this.btnAddQtn.Click += new System.EventHandler(this.BtnAddQtn_Click);
            // 
            // btnPreviewTest
            // 
            this.btnPreviewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPreviewTest.Location = new System.Drawing.Point(142, 22);
            this.btnPreviewTest.Name = "btnPreviewTest";
            this.btnPreviewTest.Size = new System.Drawing.Size(130, 26);
            this.btnPreviewTest.TabIndex = 14;
            this.btnPreviewTest.Text = "Previsualizar";
            this.btnPreviewTest.UseVisualStyleBackColor = true;
            this.btnPreviewTest.Click += new System.EventHandler(this.BtnPreviewTest_Click);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSaveTest.Location = new System.Drawing.Point(142, 54);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(130, 26);
            this.btnSaveTest.TabIndex = 16;
            this.btnSaveTest.Text = "Salvar";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.BtnSaveTest_Click);
            // 
            // btnRemoveQtn
            // 
            this.btnRemoveQtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRemoveQtn.Location = new System.Drawing.Point(6, 22);
            this.btnRemoveQtn.Name = "btnRemoveQtn";
            this.btnRemoveQtn.Size = new System.Drawing.Size(130, 26);
            this.btnRemoveQtn.TabIndex = 8;
            this.btnRemoveQtn.Text = "Remover";
            this.btnRemoveQtn.UseVisualStyleBackColor = true;
            this.btnRemoveQtn.Click += new System.EventHandler(this.BtnRemoveQtn_Click);
            // 
            // gpbAws
            // 
            this.gpbAws.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAws.Controls.Add(this.rtbAws);
            this.gpbAws.Controls.Add(this.pnlAws);
            this.gpbAws.Controls.Add(this.btnRemoveAws);
            this.gpbAws.Controls.Add(this.btAddAws);
            this.gpbAws.Location = new System.Drawing.Point(12, 152);
            this.gpbAws.Name = "gpbAws";
            this.gpbAws.Size = new System.Drawing.Size(760, 303);
            this.gpbAws.TabIndex = 2;
            this.gpbAws.TabStop = false;
            this.gpbAws.Text = "Respostas";
            // 
            // rtbAws
            // 
            this.rtbAws.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAws.Location = new System.Drawing.Point(6, 22);
            this.rtbAws.Name = "rtbAws";
            this.rtbAws.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAws.Size = new System.Drawing.Size(612, 58);
            this.rtbAws.TabIndex = 3;
            this.rtbAws.Text = "";
            // 
            // pnlAws
            // 
            this.pnlAws.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAws.AutoScroll = true;
            this.pnlAws.Location = new System.Drawing.Point(2, 86);
            this.pnlAws.Name = "pnlAws";
            this.pnlAws.Size = new System.Drawing.Size(756, 214);
            this.pnlAws.TabIndex = 6;
            // 
            // btnRemoveAws
            // 
            this.btnRemoveAws.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAws.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRemoveAws.Location = new System.Drawing.Point(624, 54);
            this.btnRemoveAws.Name = "btnRemoveAws";
            this.btnRemoveAws.Size = new System.Drawing.Size(130, 26);
            this.btnRemoveAws.TabIndex = 5;
            this.btnRemoveAws.Text = "Remover";
            this.btnRemoveAws.UseVisualStyleBackColor = true;
            this.btnRemoveAws.Click += new System.EventHandler(this.BtnRemoveAws_Click);
            // 
            // btAddAws
            // 
            this.btAddAws.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddAws.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btAddAws.Location = new System.Drawing.Point(624, 22);
            this.btAddAws.Name = "btAddAws";
            this.btAddAws.Size = new System.Drawing.Size(130, 26);
            this.btAddAws.TabIndex = 4;
            this.btAddAws.Text = "Adicionar";
            this.btAddAws.UseVisualStyleBackColor = true;
            this.btAddAws.Click += new System.EventHandler(this.BtnAddAws_Click);
            // 
            // gpbQtn
            // 
            this.gpbQtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbQtn.Controls.Add(this.btnRemoveQtn);
            this.gpbQtn.Controls.Add(this.btnNextQtn);
            this.gpbQtn.Controls.Add(this.btnBackQtn);
            this.gpbQtn.Controls.Add(this.btnAddQtn);
            this.gpbQtn.Location = new System.Drawing.Point(12, 461);
            this.gpbQtn.Name = "gpbQtn";
            this.gpbQtn.Size = new System.Drawing.Size(279, 88);
            this.gpbQtn.TabIndex = 7;
            this.gpbQtn.TabStop = false;
            this.gpbQtn.Text = "Questão";
            // 
            // gpbTest
            // 
            this.gpbTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbTest.Controls.Add(this.btnResetTest);
            this.gpbTest.Controls.Add(this.btnPreviewTest);
            this.gpbTest.Controls.Add(this.btnLoadTest);
            this.gpbTest.Controls.Add(this.btnSaveTest);
            this.gpbTest.Location = new System.Drawing.Point(493, 461);
            this.gpbTest.Name = "gpbTest";
            this.gpbTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpbTest.Size = new System.Drawing.Size(279, 88);
            this.gpbTest.TabIndex = 12;
            this.gpbTest.TabStop = false;
            this.gpbTest.Text = "Teste";
            // 
            // btnResetTest
            // 
            this.btnResetTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnResetTest.Location = new System.Drawing.Point(6, 22);
            this.btnResetTest.Name = "btnResetTest";
            this.btnResetTest.Size = new System.Drawing.Size(130, 26);
            this.btnResetTest.TabIndex = 13;
            this.btnResetTest.Text = "Resetar";
            this.btnResetTest.UseVisualStyleBackColor = true;
            this.btnResetTest.Click += new System.EventHandler(this.BtnResetTest_Click);
            // 
            // btnLoadTest
            // 
            this.btnLoadTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLoadTest.Location = new System.Drawing.Point(6, 54);
            this.btnLoadTest.Name = "btnLoadTest";
            this.btnLoadTest.Size = new System.Drawing.Size(130, 26);
            this.btnLoadTest.TabIndex = 15;
            this.btnLoadTest.Text = "Carregar";
            this.btnLoadTest.UseVisualStyleBackColor = true;
            this.btnLoadTest.Click += new System.EventHandler(this.BtnLoadTest_Click);
            // 
            // CreateTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbTest);
            this.Controls.Add(this.gpbQtn);
            this.Controls.Add(this.gpbAws);
            this.Controls.Add(this.rtbQtnTitle);
            this.Controls.Add(this.lblQtnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CreateTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Teste (Questão: 0)";
            this.Load += new System.EventHandler(this.CreateTest_Load);
            this.SizeChanged += new System.EventHandler(this.CreateTest_SizeChanged);
            this.gpbAws.ResumeLayout(false);
            this.gpbQtn.ResumeLayout(false);
            this.gpbTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQtnTitle;
        private System.Windows.Forms.RichTextBox rtbQtnTitle;
        private System.Windows.Forms.Button btnNextQtn;
        private System.Windows.Forms.Button btnBackQtn;
        private System.Windows.Forms.Button btnAddQtn;
        private System.Windows.Forms.Button btnPreviewTest;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.Button btnRemoveQtn;
        private System.Windows.Forms.GroupBox gpbAws;
        private System.Windows.Forms.Button btnRemoveAws;
        private System.Windows.Forms.Button btAddAws;
        private System.Windows.Forms.Panel pnlAws;
        private System.Windows.Forms.GroupBox gpbQtn;
        private System.Windows.Forms.GroupBox gpbTest;
        private System.Windows.Forms.Button btnResetTest;
        private System.Windows.Forms.Button btnLoadTest;
        private System.Windows.Forms.RichTextBox rtbAws;
    }
}

