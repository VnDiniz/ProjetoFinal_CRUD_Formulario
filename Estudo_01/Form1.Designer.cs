namespace Estudo_01
{
    partial class FormPrincipal
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.DgvInfoColab = new System.Windows.Forms.DataGridView();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblAreaConvertida = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTurnoConvertido = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblTurnoNovoConvertido = new System.Windows.Forms.Label();
            this.lblAreaNovaConvertida = new System.Windows.Forms.Label();
            this.cbTurnoNovo = new System.Windows.Forms.ComboBox();
            this.cbAreaNova = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNomeAlterar = new System.Windows.Forms.TextBox();
            this.lblRemover = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxNomeRemover = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblColaboradores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoColab)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(32, 171);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(234, 40);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Registrar Colaborador";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // DgvInfoColab
            // 
            this.DgvInfoColab.AllowUserToAddRows = false;
            this.DgvInfoColab.AllowUserToResizeColumns = false;
            this.DgvInfoColab.AllowUserToResizeRows = false;
            this.DgvInfoColab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInfoColab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Area,
            this.Turno});
            this.DgvInfoColab.Location = new System.Drawing.Point(313, 56);
            this.DgvInfoColab.Name = "DgvInfoColab";
            this.DgvInfoColab.Size = new System.Drawing.Size(393, 523);
            this.DgvInfoColab.TabIndex = 1;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(83, 56);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(144, 20);
            this.tbxNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(29, 128);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 6;
            this.lblTurno.Text = "Turno:";
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.Location = new System.Drawing.Point(29, 23);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(151, 15);
            this.lblInformacoes.TabIndex = 7;
            this.lblInformacoes.Text = "Registrar colaborador:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(29, 94);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area:";
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbArea.Location = new System.Drawing.Point(83, 91);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(49, 21);
            this.cbArea.TabIndex = 9;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3"});
            this.cbTurno.Location = new System.Drawing.Point(83, 125);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(49, 21);
            this.cbTurno.TabIndex = 10;
            this.cbTurno.SelectedIndexChanged += new System.EventHandler(this.cbTurno_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(547, 20);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(159, 30);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar Colaboradores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblAreaConvertida
            // 
            this.lblAreaConvertida.AutoSize = true;
            this.lblAreaConvertida.Location = new System.Drawing.Point(153, 94);
            this.lblAreaConvertida.Name = "lblAreaConvertida";
            this.lblAreaConvertida.Size = new System.Drawing.Size(16, 13);
            this.lblAreaConvertida.TabIndex = 12;
            this.lblAreaConvertida.Text = "---";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // Area
            // 
            this.Area.HeaderText = "Área";
            this.Area.Name = "Area";
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            // 
            // lblTurnoConvertido
            // 
            this.lblTurnoConvertido.AutoSize = true;
            this.lblTurnoConvertido.Location = new System.Drawing.Point(153, 128);
            this.lblTurnoConvertido.Name = "lblTurnoConvertido";
            this.lblTurnoConvertido.Size = new System.Drawing.Size(16, 13);
            this.lblTurnoConvertido.TabIndex = 13;
            this.lblTurnoConvertido.Text = "---";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(32, 392);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(234, 40);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar Informações";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblTurnoNovoConvertido
            // 
            this.lblTurnoNovoConvertido.AutoSize = true;
            this.lblTurnoNovoConvertido.Location = new System.Drawing.Point(171, 351);
            this.lblTurnoNovoConvertido.Name = "lblTurnoNovoConvertido";
            this.lblTurnoNovoConvertido.Size = new System.Drawing.Size(16, 13);
            this.lblTurnoNovoConvertido.TabIndex = 23;
            this.lblTurnoNovoConvertido.Text = "---";
            // 
            // lblAreaNovaConvertida
            // 
            this.lblAreaNovaConvertida.AutoSize = true;
            this.lblAreaNovaConvertida.Location = new System.Drawing.Point(171, 317);
            this.lblAreaNovaConvertida.Name = "lblAreaNovaConvertida";
            this.lblAreaNovaConvertida.Size = new System.Drawing.Size(16, 13);
            this.lblAreaNovaConvertida.TabIndex = 22;
            this.lblAreaNovaConvertida.Text = "---";
            // 
            // cbTurnoNovo
            // 
            this.cbTurnoNovo.FormattingEnabled = true;
            this.cbTurnoNovo.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3"});
            this.cbTurnoNovo.Location = new System.Drawing.Point(101, 348);
            this.cbTurnoNovo.Name = "cbTurnoNovo";
            this.cbTurnoNovo.Size = new System.Drawing.Size(49, 21);
            this.cbTurnoNovo.TabIndex = 21;
            this.cbTurnoNovo.SelectedIndexChanged += new System.EventHandler(this.cbTurnoNovo_SelectedIndexChanged);
            // 
            // cbAreaNova
            // 
            this.cbAreaNova.FormattingEnabled = true;
            this.cbAreaNova.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbAreaNova.Location = new System.Drawing.Point(101, 314);
            this.cbAreaNova.Name = "cbAreaNova";
            this.cbAreaNova.Size = new System.Drawing.Size(49, 21);
            this.cbAreaNova.TabIndex = 20;
            this.cbAreaNova.SelectedIndexChanged += new System.EventHandler(this.cbAreaNova_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nova Área:";
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterar.Location = new System.Drawing.Point(29, 248);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(237, 15);
            this.lblAlterar.TabIndex = 18;
            this.lblAlterar.Text = "Alterar informações do colaborador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Novo Turno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Colaborador:";
            // 
            // tbxNomeAlterar
            // 
            this.tbxNomeAlterar.Location = new System.Drawing.Point(102, 281);
            this.tbxNomeAlterar.Name = "tbxNomeAlterar";
            this.tbxNomeAlterar.Size = new System.Drawing.Size(125, 20);
            this.tbxNomeAlterar.TabIndex = 15;
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemover.Location = new System.Drawing.Point(29, 466);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(149, 15);
            this.lblRemover.TabIndex = 28;
            this.lblRemover.Text = "Remover colaborador:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Colaborador:";
            // 
            // tbxNomeRemover
            // 
            this.tbxNomeRemover.Location = new System.Drawing.Point(102, 499);
            this.tbxNomeRemover.Name = "tbxNomeRemover";
            this.tbxNomeRemover.Size = new System.Drawing.Size(125, 20);
            this.tbxNomeRemover.TabIndex = 25;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(32, 536);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(234, 40);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover Colaborador";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblColaboradores
            // 
            this.lblColaboradores.AutoSize = true;
            this.lblColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaboradores.Location = new System.Drawing.Point(310, 27);
            this.lblColaboradores.Name = "lblColaboradores";
            this.lblColaboradores.Size = new System.Drawing.Size(158, 15);
            this.lblColaboradores.TabIndex = 29;
            this.lblColaboradores.Text = "Lista de colaboradores:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 606);
            this.Controls.Add(this.lblColaboradores);
            this.Controls.Add(this.lblRemover);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxNomeRemover);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblTurnoNovoConvertido);
            this.Controls.Add(this.lblAreaNovaConvertida);
            this.Controls.Add(this.cbTurnoNovo);
            this.Controls.Add(this.cbAreaNova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxNomeAlterar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblTurnoConvertido);
            this.Controls.Add(this.lblAreaConvertida);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.DgvInfoColab);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Controle de Colaboradores - LET";
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoColab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView DgvInfoColab;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.Label lblAreaConvertida;
        private System.Windows.Forms.Label lblTurnoConvertido;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblTurnoNovoConvertido;
        private System.Windows.Forms.Label lblAreaNovaConvertida;
        private System.Windows.Forms.ComboBox cbTurnoNovo;
        private System.Windows.Forms.ComboBox cbAreaNova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNomeAlterar;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxNomeRemover;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblColaboradores;
    }
}

