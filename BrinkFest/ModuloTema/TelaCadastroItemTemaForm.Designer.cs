namespace BrinkFest.WinApp.ModuloTema2
{
    partial class TelaCadastroItemTemaForm
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
            listItens = new ListBox();
            btnAdicionar = new Button();
            txtId = new TextBox();
            txtNovoItem = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label4 = new Label();
            txtValor = new NumericUpDown();
            txtTema = new TextBox();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 54);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Tema: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 92);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome Item:";
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(28, 149);
            listItens.Name = "listItens";
            listItens.Size = new Size(668, 214);
            listItens.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(529, 87);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(167, 25);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 6;
            // 
            // txtNovoItem
            // 
            txtNovoItem.Location = new Point(104, 89);
            txtNovoItem.Name = "txtNovoItem";
            txtNovoItem.Size = new Size(178, 23);
            txtNovoItem.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(592, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 69);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(28, 369);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(112, 69);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 92);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 41;
            label4.Text = "Valor Item:";
            // 
            // txtValor
            // 
            txtValor.DecimalPlaces = 2;
            txtValor.Location = new Point(393, 89);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(120, 23);
            txtValor.TabIndex = 42;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(104, 51);
            txtTema.Name = "txtTema";
            txtTema.ReadOnly = true;
            txtTema.Size = new Size(100, 23);
            txtTema.TabIndex = 43;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(529, 118);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(167, 23);
            btnRemover.TabIndex = 44;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // TelaCadastroItemTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(726, 450);
            Controls.Add(btnRemover);
            Controls.Add(txtTema);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNovoItem);
            Controls.Add(txtId);
            Controls.Add(btnAdicionar);
            Controls.Add(listItens);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastroItemTemaForm";
            Text = "TelaCadastroItemTemaForm";
            ((System.ComponentModel.ISupportInitialize)txtValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listItens;
        private Button btnAdicionar;
        private TextBox txtId;
        private TextBox txtNovoItem;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label4;
        private NumericUpDown txtValor;
        private TextBox txtTema;
        private Button btnRemover;
    }
}