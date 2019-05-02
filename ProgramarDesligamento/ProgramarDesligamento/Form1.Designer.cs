namespace ProgramarDesligamento
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnProgramar = new System.Windows.Forms.Button();
            this.cboxForcar = new System.Windows.Forms.CheckBox();
            this.btnPausar = new System.Windows.Forms.Button();
            this.lblDoisPontos2 = new System.Windows.Forms.Label();
            this.cmbboxMetodo = new System.Windows.Forms.ComboBox();
            this.icone = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsIcone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PausarResumirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dezMinutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDoisPontos1 = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.timerCancelarEsconderIcone = new System.Windows.Forms.Timer(this.components);
            this.tudMinutos = new ProgramarDesligamento.TimeUpDown();
            this.tudHoras = new ProgramarDesligamento.TimeUpDown();
            this.cmsIcone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tudHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProgramar
            // 
            this.btnProgramar.BackColor = System.Drawing.Color.Gold;
            this.btnProgramar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProgramar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProgramar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnProgramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramar.ForeColor = System.Drawing.Color.Black;
            this.btnProgramar.Location = new System.Drawing.Point(35, 182);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(85, 31);
            this.btnProgramar.TabIndex = 4;
            this.btnProgramar.Text = "Iniciar";
            this.btnProgramar.UseVisualStyleBackColor = false;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // cboxForcar
            // 
            this.cboxForcar.AutoSize = true;
            this.cboxForcar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxForcar.Location = new System.Drawing.Point(181, 125);
            this.cboxForcar.Name = "cboxForcar";
            this.cboxForcar.Size = new System.Drawing.Size(185, 23);
            this.cboxForcar.TabIndex = 3;
            this.cboxForcar.Text = "Forçar o desligamento";
            this.cboxForcar.UseVisualStyleBackColor = true;
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.Gold;
            this.btnPausar.Enabled = false;
            this.btnPausar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPausar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPausar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.ForeColor = System.Drawing.Color.Black;
            this.btnPausar.Location = new System.Drawing.Point(149, 182);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(82, 31);
            this.btnPausar.TabIndex = 5;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // lblDoisPontos2
            // 
            this.lblDoisPontos2.AutoSize = true;
            this.lblDoisPontos2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoisPontos2.Location = new System.Drawing.Point(271, 30);
            this.lblDoisPontos2.Name = "lblDoisPontos2";
            this.lblDoisPontos2.Size = new System.Drawing.Size(42, 58);
            this.lblDoisPontos2.TabIndex = 4;
            this.lblDoisPontos2.Text = ":";
            // 
            // cmbboxMetodo
            // 
            this.cmbboxMetodo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbboxMetodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbboxMetodo.BackColor = System.Drawing.Color.Gold;
            this.cmbboxMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbboxMetodo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxMetodo.ForeColor = System.Drawing.Color.Black;
            this.cmbboxMetodo.FormattingEnabled = true;
            this.cmbboxMetodo.Items.AddRange(new object[] {
            "Desligar",
            "Reiniciar"});
            this.cmbboxMetodo.Location = new System.Drawing.Point(35, 123);
            this.cmbboxMetodo.Name = "cmbboxMetodo";
            this.cmbboxMetodo.Size = new System.Drawing.Size(121, 27);
            this.cmbboxMetodo.TabIndex = 2;
            this.cmbboxMetodo.Text = "Desligar";
            // 
            // icone
            // 
            this.icone.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icone.ContextMenuStrip = this.cmsIcone;
            this.icone.Icon = ((System.Drawing.Icon)(resources.GetObject("icone.Icon")));
            this.icone.Text = "Programar Desligamento";
            this.icone.DoubleClick += new System.EventHandler(this.icone_Click);
            // 
            // cmsIcone
            // 
            this.cmsIcone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PausarResumirToolStripMenuItem,
            this.CancelarToolStripMenuItem,
            this.dezMinutosToolStripMenuItem});
            this.cmsIcone.Name = "cmsIcone";
            this.cmsIcone.Size = new System.Drawing.Size(158, 70);
            // 
            // PausarResumirToolStripMenuItem
            // 
            this.PausarResumirToolStripMenuItem.Name = "PausarResumirToolStripMenuItem";
            this.PausarResumirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.PausarResumirToolStripMenuItem.Text = "Pausar/Resumir";
            this.PausarResumirToolStripMenuItem.Click += new System.EventHandler(this.PausarResumirToolStripMenuItem_Click);
            // 
            // CancelarToolStripMenuItem
            // 
            this.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem";
            this.CancelarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.CancelarToolStripMenuItem.Text = "Cancelar";
            this.CancelarToolStripMenuItem.Click += new System.EventHandler(this.CancelarToolStripMenuItem_Click);
            // 
            // dezMinutosToolStripMenuItem
            // 
            this.dezMinutosToolStripMenuItem.Name = "dezMinutosToolStripMenuItem";
            this.dezMinutosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dezMinutosToolStripMenuItem.Text = "+10 minutos";
            this.dezMinutosToolStripMenuItem.Visible = false;
            this.dezMinutosToolStripMenuItem.Click += new System.EventHandler(this.dezMinutosToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDoisPontos1
            // 
            this.lblDoisPontos1.AutoSize = true;
            this.lblDoisPontos1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoisPontos1.Location = new System.Drawing.Point(126, 30);
            this.lblDoisPontos1.Name = "lblDoisPontos1";
            this.lblDoisPontos1.Size = new System.Drawing.Size(42, 58);
            this.lblDoisPontos1.TabIndex = 3;
            this.lblDoisPontos1.Text = ":";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(306, 48);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(60, 45);
            this.lblSegundos.TabIndex = 6;
            this.lblSegundos.Text = "00";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(25, 30);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(77, 58);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "00";
            this.lblHoras.Visible = false;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(171, 30);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(77, 58);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "00";
            this.lblMinutos.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gold;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(262, 182);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // timerCancelarEsconderIcone
            // 
            this.timerCancelarEsconderIcone.Interval = 5000;
            this.timerCancelarEsconderIcone.Tick += new System.EventHandler(this.timerCancelarEsconderIcone_Tick);
            // 
            // tudMinutos
            // 
            this.tudMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tudMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tudMinutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tudMinutos.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tudMinutos.ForeColor = System.Drawing.Color.White;
            this.tudMinutos.Location = new System.Drawing.Point(168, 28);
            this.tudMinutos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.tudMinutos.Name = "tudMinutos";
            this.tudMinutos.Size = new System.Drawing.Size(97, 65);
            this.tudMinutos.TabIndex = 1;
            this.tudMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tudMinutos.ValueChanged += new System.EventHandler(this.tudMinutos_ValueChanged);
            // 
            // tudHoras
            // 
            this.tudHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tudHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tudHoras.Cursor = System.Windows.Forms.Cursors.Default;
            this.tudHoras.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tudHoras.ForeColor = System.Drawing.Color.White;
            this.tudHoras.Location = new System.Drawing.Point(23, 28);
            this.tudHoras.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.tudHoras.Name = "tudHoras";
            this.tudHoras.Size = new System.Drawing.Size(97, 65);
            this.tudHoras.TabIndex = 0;
            this.tudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(398, 245);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.cmbboxMetodo);
            this.Controls.Add(this.lblDoisPontos2);
            this.Controls.Add(this.lblDoisPontos1);
            this.Controls.Add(this.tudMinutos);
            this.Controls.Add(this.tudHoras);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.cboxForcar);
            this.Controls.Add(this.btnProgramar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Programar Desligamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.cmsIcone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tudHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.CheckBox cboxForcar;
        private System.Windows.Forms.Button btnPausar;
        private TimeUpDown tudHoras;
        private TimeUpDown tudMinutos;
        private System.Windows.Forms.Label lblDoisPontos2;
        private System.Windows.Forms.ComboBox cmbboxMetodo;
        private System.Windows.Forms.NotifyIcon icone;
        private System.Windows.Forms.ContextMenuStrip cmsIcone;
        private System.Windows.Forms.ToolStripMenuItem PausarResumirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDoisPontos1;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem CancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dezMinutosToolStripMenuItem;
        private System.Windows.Forms.Timer timerCancelarEsconderIcone;
    }
}

