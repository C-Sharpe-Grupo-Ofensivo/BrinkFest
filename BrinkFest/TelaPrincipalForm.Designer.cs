namespace BrinkFest
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            temaToolStripMenuItem = new ToolStripMenuItem();
            festaToolStripMenuItem = new ToolStripMenuItem();
            tema2ToolStripMenuItem = new ToolStripMenuItem();
            adicionarItensToolStripMenuItem = new ToolStripMenuItem();
            adicionarTemasToolStripMenuItem = new ToolStripMenuItem();
            telaPrincipalToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            barraFerramentas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            labelTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            labelRodape3 = new ToolStripStatusLabel();
            panelRegistros = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnCliente = new Button();
            menuStrip1.SuspendLayout();
            barraFerramentas.SuspendLayout();
            statusStrip1.SuspendLayout();
            panelRegistros.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, menuPrincipalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, temaToolStripMenuItem, festaToolStripMenuItem, tema2ToolStripMenuItem, telaPrincipalToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // temaToolStripMenuItem
            // 
            temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            temaToolStripMenuItem.Size = new Size(180, 22);
            temaToolStripMenuItem.Text = "Tema";
            temaToolStripMenuItem.Click += temaToolStripMenuItem_Click;
            // 
            // festaToolStripMenuItem
            // 
            festaToolStripMenuItem.Name = "festaToolStripMenuItem";
            festaToolStripMenuItem.Size = new Size(180, 22);
            festaToolStripMenuItem.Text = "Aluguel";
            festaToolStripMenuItem.Click += festaToolStripMenuItem_Click;
            // 
            // tema2ToolStripMenuItem
            // 
            tema2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarItensToolStripMenuItem, adicionarTemasToolStripMenuItem });
            tema2ToolStripMenuItem.Name = "tema2ToolStripMenuItem";
            tema2ToolStripMenuItem.Size = new Size(180, 22);
            tema2ToolStripMenuItem.Text = "Festa";
            tema2ToolStripMenuItem.Click += tema2ToolStripMenuItem_Click;
            // 
            // adicionarItensToolStripMenuItem
            // 
            adicionarItensToolStripMenuItem.Name = "adicionarItensToolStripMenuItem";
            adicionarItensToolStripMenuItem.Size = new Size(180, 22);
            adicionarItensToolStripMenuItem.Text = "Adicionar Itens";
            adicionarItensToolStripMenuItem.Click += adicionarItensToolStripMenuItem_Click;
            // 
            // adicionarTemasToolStripMenuItem
            // 
            adicionarTemasToolStripMenuItem.Name = "adicionarTemasToolStripMenuItem";
            adicionarTemasToolStripMenuItem.Size = new Size(180, 22);
            adicionarTemasToolStripMenuItem.Text = "Adicionar Temas";
            adicionarTemasToolStripMenuItem.Click += adicionarTemasToolStripMenuItem_Click;
            // 
            // telaPrincipalToolStripMenuItem
            // 
            telaPrincipalToolStripMenuItem.Name = "telaPrincipalToolStripMenuItem";
            telaPrincipalToolStripMenuItem.Size = new Size(180, 22);
            telaPrincipalToolStripMenuItem.Text = "Tela Principal";
            telaPrincipalToolStripMenuItem.Click += telaPrincipalToolStripMenuItem_Click;
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(88, 20);
            menuPrincipalToolStripMenuItem.Text = "Tela Principal";
            menuPrincipalToolStripMenuItem.Click += menuPrincipalToolStripMenuItem_Click;
            // 
            // barraFerramentas
            // 
            barraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, labelTipoCadastro });
            barraFerramentas.Location = new Point(0, 24);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Size = new Size(800, 45);
            barraFerramentas.TabIndex = 1;
            barraFerramentas.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = WinApp.Properties.Resources.add_circle_FILL1_wght400_GRAD0_opsz24_1_;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "toolStripButton1";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = WinApp.Properties.Resources.edit_FILL1_wght400_GRAD0_opsz24_1_;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = WinApp.Properties.Resources.delete_FILL1_wght400_GRAD0_opsz24_1_;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(75, 42);
            labelTipoCadastro.Text = "tipoCadastro";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape3 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape3
            // 
            labelRodape3.BackColor = SystemColors.ControlLightLight;
            labelRodape3.Name = "labelRodape3";
            labelRodape3.Size = new Size(52, 17);
            labelRodape3.Text = "[rodape]";
            // 
            // panelRegistros
            // 
            panelRegistros.BackColor = SystemColors.GradientActiveCaption;
            panelRegistros.BackgroundImageLayout = ImageLayout.None;
            panelRegistros.BorderStyle = BorderStyle.Fixed3D;
            panelRegistros.Controls.Add(button2);
            panelRegistros.Controls.Add(button1);
            panelRegistros.Controls.Add(btnCliente);
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 359);
            panelRegistros.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Image = WinApp.Properties.Resources.pngwing_com_1_;
            button2.Location = new Point(580, 24);
            button2.Name = "button2";
            button2.Size = new Size(147, 177);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Image = WinApp.Properties.Resources.pngwing_com;
            button1.Location = new Point(325, 24);
            button1.Name = "button1";
            button1.Size = new Size(147, 177);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.GradientActiveCaption;
            btnCliente.BackgroundImageLayout = ImageLayout.None;
            btnCliente.Image = WinApp.Properties.Resources.pngegg;
            btnCliente.Location = new Point(61, 24);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(147, 177);
            btnCliente.TabIndex = 0;
            btnCliente.Tag = "";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(barraFerramentas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            barraFerramentas.ResumeLayout(false);
            barraFerramentas.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelRegistros.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem temaToolStripMenuItem;
        private ToolStripMenuItem festaToolStripMenuItem;
        private ToolStrip barraFerramentas;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape3;
        private ToolStripLabel labelTipoCadastro;
        private Panel panelRegistros;
        private Button btnCliente;
        private ToolStripMenuItem telaPrincipalToolStripMenuItem;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem tema2ToolStripMenuItem;
        private ToolStripButton btnAdicionarItens;
        private ToolStripMenuItem adicionarItensToolStripMenuItem;
        private ToolStripMenuItem adicionarTemasToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
    }
}