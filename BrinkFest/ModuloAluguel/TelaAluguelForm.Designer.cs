namespace BrinkFest.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            chkSelecionarTema = new CheckBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtEndereco = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label6 = new Label();
            cmbTemas = new ComboBox();
            txtHorarioFinal = new DateTimePicker();
            label5 = new Label();
            txtHorarioInicio = new DateTimePicker();
            label4 = new Label();
            txtData = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            cmbCliente = new ComboBox();
            rdbNovo = new RadioButton();
            rdbAntigo = new RadioButton();
            txtValorEntrada = new TextBox();
            txtValorTotal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkSelecionarTema
            // 
            chkSelecionarTema.AutoSize = true;
            chkSelecionarTema.Location = new Point(32, 164);
            chkSelecionarTema.Name = "chkSelecionarTema";
            chkSelecionarTema.RightToLeft = RightToLeft.Yes;
            chkSelecionarTema.Size = new Size(170, 19);
            chkSelecionarTema.TabIndex = 38;
            chkSelecionarTema.Text = "?Deseja selecionar umTema";
            chkSelecionarTema.UseVisualStyleBackColor = true;
            chkSelecionarTema.CheckedChanged += chkSelecionarTema_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Location = new Point(43, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 99);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 29);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 40;
            label7.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(94, 26);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(286, 23);
            txtEndereco.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(354, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(273, 347);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 35;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 164);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 34;
            label6.Text = "Temas";
            // 
            // cmbTemas
            // 
            cmbTemas.DisplayMember = "nome";
            cmbTemas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemas.Enabled = false;
            cmbTemas.FormattingEnabled = true;
            cmbTemas.Location = new Point(292, 161);
            cmbTemas.Name = "cmbTemas";
            cmbTemas.Size = new Size(137, 23);
            cmbTemas.TabIndex = 33;
            cmbTemas.SelectedIndexChanged += cmbTemas_SelectedIndexChanged;
            // 
            // txtHorarioFinal
            // 
            txtHorarioFinal.CustomFormat = "HH:mm";
            txtHorarioFinal.Format = DateTimePickerFormat.Custom;
            txtHorarioFinal.Location = new Point(292, 118);
            txtHorarioFinal.Name = "txtHorarioFinal";
            txtHorarioFinal.ShowUpDown = true;
            txtHorarioFinal.Size = new Size(137, 23);
            txtHorarioFinal.TabIndex = 32;
            // 
            // label5
            // 
            label5.Location = new Point(223, 114);
            label5.Name = "label5";
            label5.Size = new Size(63, 34);
            label5.TabIndex = 31;
            label5.Text = "Horário Final:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.CustomFormat = "HH:mm";
            txtHorarioInicio.Format = DateTimePickerFormat.Custom;
            txtHorarioInicio.Location = new Point(97, 118);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.ShowUpDown = true;
            txtHorarioInicio.Size = new Size(124, 23);
            txtHorarioInicio.TabIndex = 30;
            // 
            // label4
            // 
            label4.Location = new Point(32, 107);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(53, 37);
            label4.TabIndex = 29;
            label4.Text = "Horário Início:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(97, 82);
            txtData.Name = "txtData";
            txtData.Size = new Size(124, 23);
            txtData.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 85);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 27;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 51);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 25;
            label2.Text = "Cliente";
            // 
            // txtId
            // 
            txtId.Location = new Point(97, 19);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 24;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 23;
            label1.Text = "Id:";
            // 
            // cmbCliente
            // 
            cmbCliente.DisplayMember = "nome";
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(97, 48);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(137, 23);
            cmbCliente.TabIndex = 39;
            // 
            // rdbNovo
            // 
            rdbNovo.AutoSize = true;
            rdbNovo.Location = new Point(292, 20);
            rdbNovo.Name = "rdbNovo";
            rdbNovo.Size = new Size(94, 19);
            rdbNovo.TabIndex = 40;
            rdbNovo.TabStop = true;
            rdbNovo.Text = "Cliente Novo";
            rdbNovo.UseVisualStyleBackColor = true;
            rdbNovo.CheckedChanged += rdbNovo_CheckedChanged;
            // 
            // rdbAntigo
            // 
            rdbAntigo.AutoSize = true;
            rdbAntigo.Location = new Point(292, 52);
            rdbAntigo.Name = "rdbAntigo";
            rdbAntigo.Size = new Size(101, 19);
            rdbAntigo.TabIndex = 41;
            rdbAntigo.TabStop = true;
            rdbAntigo.Text = "Cliente Antigo";
            rdbAntigo.UseVisualStyleBackColor = true;
            rdbAntigo.CheckedChanged += rdbAntigo_CheckedChanged;
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Location = new Point(110, 368);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.ReadOnly = true;
            txtValorEntrada.Size = new Size(152, 23);
            txtValorEntrada.TabIndex = 45;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(110, 319);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(152, 23);
            txtValorTotal.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 372);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 43;
            label8.Text = "Valor Entrada:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 323);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 42;
            label9.Text = "Valor Total:";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(495, 425);
            Controls.Add(txtValorEntrada);
            Controls.Add(txtValorTotal);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(rdbAntigo);
            Controls.Add(rdbNovo);
            Controls.Add(cmbCliente);
            Controls.Add(chkSelecionarTema);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label6);
            Controls.Add(cmbTemas);
            Controls.Add(txtHorarioFinal);
            Controls.Add(label5);
            Controls.Add(txtHorarioInicio);
            Controls.Add(label4);
            Controls.Add(txtData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaAluguelForm";
            Text = "TelaAluguelForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSelecionarTema;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtEndereco;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label6;
        private ComboBox cmbTemas;
        private DateTimePicker txtHorarioFinal;
        private Label label5;
        private DateTimePicker txtHorarioInicio;
        private Label label4;
        private DateTimePicker txtData;
        private Label label3;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private ComboBox cmbCliente;
        private RadioButton rdbNovo;
        private RadioButton rdbAntigo;
        private TextBox txtValorEntrada;
        private TextBox txtValorTotal;
        private Label label8;
        private Label label9;
    }
}