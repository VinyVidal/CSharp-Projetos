namespace Gerador_de_Senhas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botaogerar = new System.Windows.Forms.Button();
            this.qntdigitos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CaixaSenhas = new System.Windows.Forms.ListBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.botaolimpar = new System.Windows.Forms.Button();
            this.copiarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaogerar
            // 
            this.botaogerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaogerar.Location = new System.Drawing.Point(37, 325);
            this.botaogerar.Name = "botaogerar";
            this.botaogerar.Size = new System.Drawing.Size(101, 32);
            this.botaogerar.TabIndex = 1;
            this.botaogerar.Text = "Gerar Senha";
            this.botaogerar.UseVisualStyleBackColor = true;
            this.botaogerar.Click += new System.EventHandler(this.botaogerar_Click);
            // 
            // qntdigitos
            // 
            this.qntdigitos.AccessibleName = "DigitosQnt";
            this.qntdigitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntdigitos.FormattingEnabled = true;
            this.qntdigitos.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.qntdigitos.Location = new System.Drawing.Point(144, 289);
            this.qntdigitos.Name = "qntdigitos";
            this.qntdigitos.Size = new System.Drawing.Size(50, 26);
            this.qntdigitos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de dígitos";
            // 
            // SubMenu
            // 
            this.SubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.copiarTudoToolStripMenuItem,
            this.limparToolStripMenuItem});
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(141, 70);
            this.SubMenu.Opening += new System.ComponentModel.CancelEventHandler(this.SubMenu_Opening);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // CaixaSenhas
            // 
            this.CaixaSenhas.ContextMenuStrip = this.SubMenu;
            this.CaixaSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaSenhas.FormattingEnabled = true;
            this.CaixaSenhas.ItemHeight = 18;
            this.CaixaSenhas.Location = new System.Drawing.Point(12, 12);
            this.CaixaSenhas.Name = "CaixaSenhas";
            this.CaixaSenhas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CaixaSenhas.Size = new System.Drawing.Size(363, 256);
            this.CaixaSenhas.TabIndex = 0;
            this.CaixaSenhas.UseTabStops = false;
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Apenas Números",
            "Apenas Caracteres",
            "Números e Caracteres"});
            this.tipo.Location = new System.Drawing.Point(216, 289);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(159, 26);
            this.tipo.TabIndex = 4;
            // 
            // botaolimpar
            // 
            this.botaolimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaolimpar.Location = new System.Drawing.Point(243, 325);
            this.botaolimpar.Name = "botaolimpar";
            this.botaolimpar.Size = new System.Drawing.Size(101, 32);
            this.botaolimpar.TabIndex = 5;
            this.botaolimpar.Text = "Limpar";
            this.botaolimpar.UseVisualStyleBackColor = true;
            this.botaolimpar.Click += new System.EventHandler(this.botaolimpar_Click);
            // 
            // copiarTudoToolStripMenuItem
            // 
            this.copiarTudoToolStripMenuItem.Name = "copiarTudoToolStripMenuItem";
            this.copiarTudoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.copiarTudoToolStripMenuItem.Text = "Copiar Tudo";
            this.copiarTudoToolStripMenuItem.Click += new System.EventHandler(this.copiarTudoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 369);
            this.Controls.Add(this.botaolimpar);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qntdigitos);
            this.Controls.Add(this.botaogerar);
            this.Controls.Add(this.CaixaSenhas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerador de Senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botaogerar;
        private System.Windows.Forms.ComboBox qntdigitos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip SubMenu;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ListBox CaixaSenhas;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Button botaolimpar;
        private System.Windows.Forms.ToolStripMenuItem copiarTudoToolStripMenuItem;
    }
}

