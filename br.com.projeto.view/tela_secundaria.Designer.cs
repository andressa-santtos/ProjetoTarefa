namespace ProjetoTarefa
{
    partial class tela_secundaria
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbalta = new System.Windows.Forms.RadioButton();
            this.rbmedia = new System.Windows.Forms.RadioButton();
            this.rbbaixa = new System.Windows.Forms.RadioButton();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtassunto = new System.Windows.Forms.TextBox();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimeData = new System.Windows.Forms.DateTimePicker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgtarefas = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbalta);
            this.tabPage1.Controls.Add(this.rbmedia);
            this.tabPage1.Controls.Add(this.rbbaixa);
            this.tabPage1.Controls.Add(this.txttitulo);
            this.tabPage1.Controls.Add(this.txtassunto);
            this.tabPage1.Controls.Add(this.btndeletar);
            this.tabPage1.Controls.Add(this.btnadicionar);
            this.tabPage1.Controls.Add(this.labelTitulo);
            this.tabPage1.Controls.Add(this.labelAssunto);
            this.tabPage1.Controls.Add(this.btneditar);
            this.tabPage1.Controls.Add(this.labelData);
            this.tabPage1.Controls.Add(this.dateTimeData);
            this.tabPage1.Controls.Add(this.labelStatus);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Tarefas";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rbalta
            // 
            this.rbalta.AutoSize = true;
            this.rbalta.Location = new System.Drawing.Point(432, 116);
            this.rbalta.Name = "rbalta";
            this.rbalta.Size = new System.Drawing.Size(43, 17);
            this.rbalta.TabIndex = 18;
            this.rbalta.TabStop = true;
            this.rbalta.Text = "Alta";
            this.rbalta.UseVisualStyleBackColor = true;
            // 
            // rbmedia
            // 
            this.rbmedia.AutoSize = true;
            this.rbmedia.Location = new System.Drawing.Point(354, 116);
            this.rbmedia.Name = "rbmedia";
            this.rbmedia.Size = new System.Drawing.Size(54, 17);
            this.rbmedia.TabIndex = 17;
            this.rbmedia.TabStop = true;
            this.rbmedia.Text = "Média";
            this.rbmedia.UseVisualStyleBackColor = true;
            // 
            // rbbaixa
            // 
            this.rbbaixa.AutoSize = true;
            this.rbbaixa.Location = new System.Drawing.Point(287, 116);
            this.rbbaixa.Name = "rbbaixa";
            this.rbbaixa.Size = new System.Drawing.Size(51, 17);
            this.rbbaixa.TabIndex = 16;
            this.rbbaixa.TabStop = true;
            this.rbbaixa.Text = "Baixa";
            this.rbbaixa.UseVisualStyleBackColor = true;
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.Color.White;
            this.txttitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txttitulo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(9, 91);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(219, 26);
            this.txttitulo.TabIndex = 7;
            this.txttitulo.Text = " ";
            // 
            // txtassunto
            // 
            this.txtassunto.BackColor = System.Drawing.Color.White;
            this.txtassunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtassunto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtassunto.Location = new System.Drawing.Point(6, 165);
            this.txtassunto.Name = "txtassunto";
            this.txtassunto.Size = new System.Drawing.Size(511, 26);
            this.txtassunto.TabIndex = 0;
            this.txtassunto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(287, 219);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(88, 37);
            this.btndeletar.TabIndex = 14;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(29, 219);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(100, 37);
            this.btnadicionar.TabIndex = 15;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitulo.Location = new System.Drawing.Point(6, 72);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(75, 16);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Digite o título";
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssunto.ForeColor = System.Drawing.Color.Firebrick;
            this.labelAssunto.Location = new System.Drawing.Point(6, 136);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(141, 16);
            this.labelAssunto.TabIndex = 4;
            this.labelAssunto.Text = "Digite o assunto da tarefa:";
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(163, 219);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(85, 37);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Firebrick;
            this.labelData.Location = new System.Drawing.Point(284, 15);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(74, 16);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "Defina a data";
            // 
            // dateTimeData
            // 
            this.dateTimeData.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dateTimeData.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dateTimeData.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimeData.Location = new System.Drawing.Point(287, 40);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(230, 20);
            this.dateTimeData.TabIndex = 3;
            this.dateTimeData.UseWaitCursor = true;
            this.dateTimeData.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.dateTimeData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Firebrick;
            this.labelStatus.Location = new System.Drawing.Point(284, 91);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status:";
            this.labelStatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 172);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 368);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.dgtarefas);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Adicionadas";
            // 
            // dgtarefas
            // 
            this.dgtarefas.AllowUserToOrderColumns = true;
            this.dgtarefas.BackgroundColor = System.Drawing.Color.Beige;
            this.dgtarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtarefas.Location = new System.Drawing.Point(6, 6);
            this.dgtarefas.Name = "dgtarefas";
            this.dgtarefas.Size = new System.Drawing.Size(621, 274);
            this.dgtarefas.TabIndex = 0;
            this.dgtarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtarefas_CellClick);
            this.dgtarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtarefas_CellContentClick);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(41, 15);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(72, 26);
            this.txtid.TabIndex = 20;
            this.txtid.Text = " ";
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoTarefa.Properties.Resources.Planner_Semanal_boho_em_tons_pastéis;
            this.pictureBox2.Location = new System.Drawing.Point(261, -159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(672, 527);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoTarefa.Properties.Resources.lista2;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tela_secundaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(696, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "tela_secundaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "tela_secundaria";
            this.Load += new System.EventHandler(this.tela_secundaria_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtassunto;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgtarefas;
        private System.Windows.Forms.RadioButton rbbaixa;
        private System.Windows.Forms.RadioButton rbalta;
        private System.Windows.Forms.RadioButton rbmedia;
        private System.Windows.Forms.DateTimePicker dateTimeData;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}