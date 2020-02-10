namespace AgendaTelefonica.WindowsForms.UI
{
    partial class Form1
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
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_Nome = new System.Windows.Forms.ListBox();
            this.lst_Telefone = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(266, 319);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(92, 39);
            this.btn_Adicionar.TabIndex = 0;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(375, 319);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(92, 39);
            this.btn_Deletar.TabIndex = 1;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(480, 319);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(92, 39);
            this.btn_Alterar.TabIndex = 2;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(86, 93);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(156, 22);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(86, 150);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(156, 22);
            this.txt_Telefone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // lst_Nome
            // 
            this.lst_Nome.FormattingEnabled = true;
            this.lst_Nome.ItemHeight = 16;
            this.lst_Nome.Location = new System.Drawing.Point(279, 93);
            this.lst_Nome.Name = "lst_Nome";
            this.lst_Nome.Size = new System.Drawing.Size(132, 180);
            this.lst_Nome.TabIndex = 9;
            this.lst_Nome.SelectedIndexChanged += new System.EventHandler(this.lst_Nome_SelectedIndexChanged);
            // 
            // lst_Telefone
            // 
            this.lst_Telefone.FormattingEnabled = true;
            this.lst_Telefone.ItemHeight = 16;
            this.lst_Telefone.Location = new System.Drawing.Point(431, 93);
            this.lst_Telefone.Name = "lst_Telefone";
            this.lst_Telefone.Size = new System.Drawing.Size(132, 180);
            this.lst_Telefone.TabIndex = 10;
            this.lst_Telefone.SelectedIndexChanged += new System.EventHandler(this.lst_Nome_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_Telefone);
            this.Controls.Add(this.lst_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Adicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_Nome;
        private System.Windows.Forms.ListBox lst_Telefone;
    }
}

