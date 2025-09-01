namespace ReproduzAudioViaMsg
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpMostrar = new System.Windows.Forms.TabPage();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.tracVelocidade = new System.Windows.Forms.TrackBar();
            this.btnVelocidade = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.gbTexto = new System.Windows.Forms.GroupBox();
            this.txt_Texto = new System.Windows.Forms.RichTextBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.lbSelecionarVoz = new System.Windows.Forms.Label();
            this.cbVoices = new System.Windows.Forms.ComboBox();
            this.tpProdutos = new System.Windows.Forms.TabPage();
            this.pnFundoTitulo = new System.Windows.Forms.Panel();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tlpOpcoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpBarraProgresso = new System.Windows.Forms.TableLayoutPanel();
            this.pbProgresso = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbDev = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpMostrar.SuspendLayout();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracVelocidade)).BeginInit();
            this.gbTexto.SuspendLayout();
            this.tpProdutos.SuspendLayout();
            this.pnFundoTitulo.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.tlpOpcoes.SuspendLayout();
            this.tlpBarraProgresso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.pnPrincipal, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnFundoTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpOpcoes, 1, 2);
            this.tlpPrincipal.Controls.Add(this.tlpBarraProgresso, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.Size = new System.Drawing.Size(429, 450);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnPrincipal
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnPrincipal, 2);
            this.pnPrincipal.Controls.Add(this.tcPrincipal);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(3, 43);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(423, 364);
            this.pnPrincipal.TabIndex = 0;
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpMostrar);
            this.tcPrincipal.Controls.Add(this.tpProdutos);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(423, 364);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpMostrar
            // 
            this.tpMostrar.Controls.Add(this.gbParametros);
            this.tpMostrar.Controls.Add(this.gbTexto);
            this.tpMostrar.Location = new System.Drawing.Point(4, 22);
            this.tpMostrar.Name = "tpMostrar";
            this.tpMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpMostrar.Size = new System.Drawing.Size(415, 338);
            this.tpMostrar.TabIndex = 0;
            this.tpMostrar.Text = "Mostrar";
            this.tpMostrar.UseVisualStyleBackColor = true;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.trackVolume);
            this.gbParametros.Controls.Add(this.tracVelocidade);
            this.gbParametros.Controls.Add(this.btnVelocidade);
            this.gbParametros.Controls.Add(this.btnSound);
            this.gbParametros.Location = new System.Drawing.Point(6, 210);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(403, 122);
            this.gbParametros.TabIndex = 2;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parâmetros";
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(46, 19);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(351, 45);
            this.trackVolume.TabIndex = 3;
            this.trackVolume.Value = 70;
            // 
            // tracVelocidade
            // 
            this.tracVelocidade.Location = new System.Drawing.Point(46, 71);
            this.tracVelocidade.Minimum = -10;
            this.tracVelocidade.Name = "tracVelocidade";
            this.tracVelocidade.Size = new System.Drawing.Size(351, 45);
            this.tracVelocidade.TabIndex = 2;
            this.tracVelocidade.Value = 6;
            // 
            // btnVelocidade
            // 
            this.btnVelocidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVelocidade.BackgroundImage")));
            this.btnVelocidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVelocidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVelocidade.FlatAppearance.BorderSize = 0;
            this.btnVelocidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVelocidade.Location = new System.Drawing.Point(15, 71);
            this.btnVelocidade.Name = "btnVelocidade";
            this.btnVelocidade.Size = new System.Drawing.Size(25, 25);
            this.btnVelocidade.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnVelocidade, "Controle de velocidade do áudio");
            this.btnVelocidade.UseVisualStyleBackColor = true;
            this.btnVelocidade.Click += new System.EventHandler(this.btnVelocidade_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSound.BackgroundImage")));
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Location = new System.Drawing.Point(15, 19);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(25, 25);
            this.btnSound.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSound, "Controle de volume do áudio");
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // gbTexto
            // 
            this.gbTexto.Controls.Add(this.txt_Texto);
            this.gbTexto.Controls.Add(this.lbTexto);
            this.gbTexto.Controls.Add(this.lbSelecionarVoz);
            this.gbTexto.Controls.Add(this.cbVoices);
            this.gbTexto.Location = new System.Drawing.Point(6, 6);
            this.gbTexto.Name = "gbTexto";
            this.gbTexto.Size = new System.Drawing.Size(403, 198);
            this.gbTexto.TabIndex = 1;
            this.gbTexto.TabStop = false;
            this.gbTexto.Text = "Texto para Fala";
            // 
            // txt_Texto
            // 
            this.txt_Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Texto.Location = new System.Drawing.Point(6, 87);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(391, 105);
            this.txt_Texto.TabIndex = 5;
            this.txt_Texto.Text = "";
            this.toolTip1.SetToolTip(this.txt_Texto, "Digite o que deseja converter");
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Location = new System.Drawing.Point(6, 71);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(34, 13);
            this.lbTexto.TabIndex = 3;
            this.lbTexto.Text = "Texto";
            // 
            // lbSelecionarVoz
            // 
            this.lbSelecionarVoz.AutoSize = true;
            this.lbSelecionarVoz.Location = new System.Drawing.Point(6, 31);
            this.lbSelecionarVoz.Name = "lbSelecionarVoz";
            this.lbSelecionarVoz.Size = new System.Drawing.Size(78, 13);
            this.lbSelecionarVoz.TabIndex = 2;
            this.lbSelecionarVoz.Text = "Selecionar Voz";
            // 
            // cbVoices
            // 
            this.cbVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoices.FormattingEnabled = true;
            this.cbVoices.Location = new System.Drawing.Point(6, 47);
            this.cbVoices.Name = "cbVoices";
            this.cbVoices.Size = new System.Drawing.Size(391, 21);
            this.cbVoices.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbVoices, "Selecione uma voz de narração");
            this.cbVoices.SelectedIndexChanged += new System.EventHandler(this.cbVoices_SelectedIndexChanged);
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.lbDev);
            this.tpProdutos.Location = new System.Drawing.Point(4, 22);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdutos.Size = new System.Drawing.Size(415, 338);
            this.tpProdutos.TabIndex = 1;
            this.tpProdutos.Text = "Produtos";
            this.tpProdutos.UseVisualStyleBackColor = true;
            // 
            // pnFundoTitulo
            // 
            this.pnFundoTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlpPrincipal.SetColumnSpan(this.pnFundoTitulo, 2);
            this.pnFundoTitulo.Controls.Add(this.tlpTitulo);
            this.pnFundoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundoTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnFundoTitulo.Name = "pnFundoTitulo";
            this.pnFundoTitulo.Size = new System.Drawing.Size(423, 34);
            this.pnFundoTitulo.TabIndex = 1;
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 3;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitulo.Controls.Add(this.lbTitulo, 1, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(423, 34);
            this.tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(112, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(198, 30);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Sintetizador de voz";
            // 
            // tlpOpcoes
            // 
            this.tlpOpcoes.ColumnCount = 5;
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpOpcoes.Controls.Add(this.btnGerar, 1, 0);
            this.tlpOpcoes.Controls.Add(this.btnExportar, 0, 0);
            this.tlpOpcoes.Controls.Add(this.btnCancelar, 3, 0);
            this.tlpOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOpcoes.Location = new System.Drawing.Point(217, 413);
            this.tlpOpcoes.Name = "tlpOpcoes";
            this.tlpOpcoes.RowCount = 1;
            this.tlpOpcoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOpcoes.Size = new System.Drawing.Size(209, 34);
            this.tlpOpcoes.TabIndex = 2;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Navy;
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(38, 3);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 28);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.toolTip1.SetToolTip(this.btnGerar, "Pressione para iniciar");
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(3, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(25, 25);
            this.btnExportar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnExportar, "Exportar Áudio");
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(125, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Pressione para parar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tlpBarraProgresso
            // 
            this.tlpBarraProgresso.ColumnCount = 3;
            this.tlpBarraProgresso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBarraProgresso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBarraProgresso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBarraProgresso.Controls.Add(this.pbProgresso, 1, 1);
            this.tlpBarraProgresso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBarraProgresso.Location = new System.Drawing.Point(3, 413);
            this.tlpBarraProgresso.Name = "tlpBarraProgresso";
            this.tlpBarraProgresso.RowCount = 3;
            this.tlpBarraProgresso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBarraProgresso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBarraProgresso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBarraProgresso.Size = new System.Drawing.Size(208, 34);
            this.tlpBarraProgresso.TabIndex = 3;
            // 
            // pbProgresso
            // 
            this.pbProgresso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProgresso.Location = new System.Drawing.Point(9, 14);
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(190, 5);
            this.pbProgresso.TabIndex = 0;
            // 
            // lbDev
            // 
            this.lbDev.AutoSize = true;
            this.lbDev.Location = new System.Drawing.Point(155, 163);
            this.lbDev.Name = "lbDev";
            this.lbDev.Size = new System.Drawing.Size(105, 13);
            this.lbDev.TabIndex = 0;
            this.lbDev.Text = "Em desenvolvimento";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sintetizador de Voz";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnPrincipal.ResumeLayout(false);
            this.tcPrincipal.ResumeLayout(false);
            this.tpMostrar.ResumeLayout(false);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracVelocidade)).EndInit();
            this.gbTexto.ResumeLayout(false);
            this.gbTexto.PerformLayout();
            this.tpProdutos.ResumeLayout(false);
            this.tpProdutos.PerformLayout();
            this.pnFundoTitulo.ResumeLayout(false);
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.tlpOpcoes.ResumeLayout(false);
            this.tlpBarraProgresso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnFundoTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpMostrar;
        private System.Windows.Forms.TabPage tpProdutos;
        private System.Windows.Forms.TableLayoutPanel tlpOpcoes;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlpBarraProgresso;
        private System.Windows.Forms.ProgressBar pbProgresso;
        private System.Windows.Forms.GroupBox gbTexto;
        private System.Windows.Forms.ComboBox cbVoices;
        private System.Windows.Forms.Label lbSelecionarVoz;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnVelocidade;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.TrackBar tracVelocidade;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.RichTextBox txt_Texto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbDev;
    }
}

