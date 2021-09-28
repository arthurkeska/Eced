
namespace Eced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlunosNotas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMateriaNota = new System.Windows.Forms.ComboBox();
            this.txtAssuntoNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionarNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar notas";
            // 
            // cbAlunosNotas
            // 
            this.cbAlunosNotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlunosNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlunosNotas.FormattingEnabled = true;
            this.cbAlunosNotas.Location = new System.Drawing.Point(207, 100);
            this.cbAlunosNotas.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlunosNotas.Name = "cbAlunosNotas";
            this.cbAlunosNotas.Size = new System.Drawing.Size(508, 69);
            this.cbAlunosNotas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 63);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(180, 324);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(154, 68);
            this.txtNota.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 63);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matéria:";
            // 
            // cbMateriaNota
            // 
            this.cbMateriaNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriaNota.FormattingEnabled = true;
            this.cbMateriaNota.Location = new System.Drawing.Point(249, 176);
            this.cbMateriaNota.Margin = new System.Windows.Forms.Padding(2);
            this.cbMateriaNota.Name = "cbMateriaNota";
            this.cbMateriaNota.Size = new System.Drawing.Size(466, 60);
            this.cbMateriaNota.TabIndex = 5;
            // 
            // txtAssuntoNota
            // 
            this.txtAssuntoNota.Location = new System.Drawing.Point(249, 251);
            this.txtAssuntoNota.MaxLength = 30;
            this.txtAssuntoNota.Name = "txtAssuntoNota";
            this.txtAssuntoNota.Size = new System.Drawing.Size(466, 68);
            this.txtAssuntoNota.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 63);
            this.label5.TabIndex = 7;
            this.label5.Text = "Assunto:";
            // 
            // btnAdicionarNota
            // 
            this.btnAdicionarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarNota.Location = new System.Drawing.Point(563, 338);
            this.btnAdicionarNota.Name = "btnAdicionarNota";
            this.btnAdicionarNota.Size = new System.Drawing.Size(152, 47);
            this.btnAdicionarNota.TabIndex = 9;
            this.btnAdicionarNota.Text = "Adicionar";
            this.btnAdicionarNota.UseVisualStyleBackColor = true;
            this.btnAdicionarNota.Click += new System.EventHandler(this.btnAdicionarNota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 61F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 429);
            this.Controls.Add(this.btnAdicionarNota);
            this.Controls.Add(this.txtAssuntoNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMateriaNota);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAlunosNotas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 468);
            this.MinimumSize = new System.Drawing.Size(764, 468);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECEC - Adicionar Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlunosNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMateriaNota;
        private System.Windows.Forms.TextBox txtAssuntoNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarNota;
    }
}

