namespace AppComMultiplasJanelas
{
    partial class FormNovoCliente
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
            buttonOk = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxNome = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxEnderecoLagradouro = new TextBox();
            textBoxEnderecoNumero = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxEnderecoComplemento = new TextBox();
            textBoxEnderecoCidade = new TextBox();
            textBoxEnderecoEstado = new TextBox();
            textBoxEnderecoCEP = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(148, 357);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(287, 357);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 30);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 5;
            label4.Text = "Lagradouro (Rua):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 59);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 6;
            label5.Text = "Número:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(162, 21);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 7;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(162, 50);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(200, 23);
            textBoxTelefone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(162, 79);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxEnderecoLagradouro
            // 
            textBoxEnderecoLagradouro.Location = new Point(159, 22);
            textBoxEnderecoLagradouro.Name = "textBoxEnderecoLagradouro";
            textBoxEnderecoLagradouro.Size = new Size(201, 23);
            textBoxEnderecoLagradouro.TabIndex = 10;
            // 
            // textBoxEnderecoNumero
            // 
            textBoxEnderecoNumero.Location = new Point(159, 51);
            textBoxEnderecoNumero.Name = "textBoxEnderecoNumero";
            textBoxEnderecoNumero.Size = new Size(201, 23);
            textBoxEnderecoNumero.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxEnderecoCEP);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxEnderecoEstado);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxEnderecoCidade);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxEnderecoComplemento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxEnderecoLagradouro);
            groupBox1.Controls.Add(textBoxEnderecoNumero);
            groupBox1.Location = new Point(2, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 208);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereco";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 88);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 13;
            label6.Text = "Complemento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 117);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 14;
            label7.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 146);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 15;
            label8.Text = "UF (Estado):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 175);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 16;
            label9.Text = "CEP:";
            // 
            // textBoxEnderecoComplemento
            // 
            textBoxEnderecoComplemento.Location = new Point(159, 80);
            textBoxEnderecoComplemento.Name = "textBoxEnderecoComplemento";
            textBoxEnderecoComplemento.Size = new Size(201, 23);
            textBoxEnderecoComplemento.TabIndex = 13;
            // 
            // textBoxEnderecoCidade
            // 
            textBoxEnderecoCidade.Location = new Point(159, 109);
            textBoxEnderecoCidade.Name = "textBoxEnderecoCidade";
            textBoxEnderecoCidade.Size = new Size(201, 23);
            textBoxEnderecoCidade.TabIndex = 14;
            // 
            // textBoxEnderecoEstado
            // 
            textBoxEnderecoEstado.Location = new Point(160, 138);
            textBoxEnderecoEstado.Name = "textBoxEnderecoEstado";
            textBoxEnderecoEstado.Size = new Size(200, 23);
            textBoxEnderecoEstado.TabIndex = 15;
            // 
            // textBoxEnderecoCEP
            // 
            textBoxEnderecoCEP.Location = new Point(160, 167);
            textBoxEnderecoCEP.Name = "textBoxEnderecoCEP";
            textBoxEnderecoCEP.Size = new Size(200, 23);
            textBoxEnderecoCEP.TabIndex = 16;
            // 
            // FormNovoCliente
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(407, 419);
            Controls.Add(groupBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "FormNovoCliente";
            Text = "FormNovoCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNome;
        private TextBox textBoxTelefone;
        private TextBox textBoxEmail;
        private TextBox textBoxEnderecoLagradouro;
        private TextBox textBoxEnderecoNumero;
        private GroupBox groupBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxEnderecoCEP;
        private TextBox textBoxEnderecoEstado;
        private TextBox textBoxEnderecoCidade;
        private TextBox textBoxEnderecoComplemento;
    }
}