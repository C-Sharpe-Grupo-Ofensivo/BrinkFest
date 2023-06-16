namespace BrinkFest.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtTelefone = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 71);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 29);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 0;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 120);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 120);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Telefone:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveBorder;
            txtId.Location = new Point(109, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(148, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.InactiveBorder;
            txtNome.Location = new Point(109, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(559, 23);
            txtNome.TabIndex = 4;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = SystemColors.InactiveBorder;
            txtEndereco.Location = new Point(109, 117);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(208, 23);
            txtEndereco.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.InactiveBorder;
            txtTelefone.Location = new Point(460, 117);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(208, 23);
            txtTelefone.TabIndex = 6;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = SystemColors.InactiveBorder;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(109, 184);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(96, 60);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.InactiveBorder;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(572, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 60);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(716, 256);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaClienteForm";
            Text = "TelaClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtTelefone;
        private Button btnGravar;
        private Button btnCancelar;
    }
}