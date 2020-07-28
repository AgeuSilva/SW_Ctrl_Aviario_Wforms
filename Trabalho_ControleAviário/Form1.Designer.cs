namespace Trabalho_ControleAviário
{
    partial class Monitora_Aviario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSetpointTemp = new System.Windows.Forms.Label();
            this.btnDiminuiTemp = new System.Windows.Forms.Button();
            this.btnAumentaTemp = new System.Windows.Forms.Button();
            this.btnAumentaUmi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSetpointUmi = new System.Windows.Forms.Label();
            this.btnDiminuiUmi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTempUmi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelUmi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAquecedor = new System.Windows.Forms.Button();
            this.buttonUmidificador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelInfoConexao = new System.Windows.Forms.Label();
            this.buttonDesconectaPlaca = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.buttonConectaPlaca = new System.Windows.Forms.Button();
            this.comboBoxPortaCom = new System.Windows.Forms.ComboBox();
            this.textBoxRecepcao = new System.Windows.Forms.TextBox();
            this.buttonLimpaLog = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempUmi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelSetpointTemp);
            this.groupBox2.Controls.Add(this.btnDiminuiTemp);
            this.groupBox2.Controls.Add(this.btnAumentaTemp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setpoint Temperatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "ºC";
            // 
            // labelSetpointTemp
            // 
            this.labelSetpointTemp.AutoSize = true;
            this.labelSetpointTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetpointTemp.Location = new System.Drawing.Point(142, 36);
            this.labelSetpointTemp.Name = "labelSetpointTemp";
            this.labelSetpointTemp.Size = new System.Drawing.Size(53, 37);
            this.labelSetpointTemp.TabIndex = 5;
            this.labelSetpointTemp.Text = "25";
            // 
            // btnDiminuiTemp
            // 
            this.btnDiminuiTemp.Location = new System.Drawing.Point(6, 50);
            this.btnDiminuiTemp.Name = "btnDiminuiTemp";
            this.btnDiminuiTemp.Size = new System.Drawing.Size(85, 23);
            this.btnDiminuiTemp.TabIndex = 4;
            this.btnDiminuiTemp.Text = "Diminui";
            this.btnDiminuiTemp.UseVisualStyleBackColor = true;
            this.btnDiminuiTemp.Click += new System.EventHandler(this.btnDiminuiTemp_Click);
            // 
            // btnAumentaTemp
            // 
            this.btnAumentaTemp.Location = new System.Drawing.Point(6, 21);
            this.btnAumentaTemp.Name = "btnAumentaTemp";
            this.btnAumentaTemp.Size = new System.Drawing.Size(85, 23);
            this.btnAumentaTemp.TabIndex = 4;
            this.btnAumentaTemp.Text = "Aumenta";
            this.btnAumentaTemp.UseVisualStyleBackColor = true;
            this.btnAumentaTemp.Click += new System.EventHandler(this.btnAumentaTemp_Click);
            // 
            // btnAumentaUmi
            // 
            this.btnAumentaUmi.Location = new System.Drawing.Point(6, 21);
            this.btnAumentaUmi.Name = "btnAumentaUmi";
            this.btnAumentaUmi.Size = new System.Drawing.Size(85, 23);
            this.btnAumentaUmi.TabIndex = 0;
            this.btnAumentaUmi.Text = "Aumenta";
            this.btnAumentaUmi.UseVisualStyleBackColor = true;
            this.btnAumentaUmi.Click += new System.EventHandler(this.btnAumentaUmi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelSetpointUmi);
            this.groupBox3.Controls.Add(this.btnDiminuiUmi);
            this.groupBox3.Controls.Add(this.btnAumentaUmi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(305, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setpoint Umidade Relativa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "%";
            // 
            // labelSetpointUmi
            // 
            this.labelSetpointUmi.AutoSize = true;
            this.labelSetpointUmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetpointUmi.Location = new System.Drawing.Point(142, 36);
            this.labelSetpointUmi.Name = "labelSetpointUmi";
            this.labelSetpointUmi.Size = new System.Drawing.Size(53, 37);
            this.labelSetpointUmi.TabIndex = 4;
            this.labelSetpointUmi.Text = "50";
            // 
            // btnDiminuiUmi
            // 
            this.btnDiminuiUmi.Location = new System.Drawing.Point(6, 50);
            this.btnDiminuiUmi.Name = "btnDiminuiUmi";
            this.btnDiminuiUmi.Size = new System.Drawing.Size(85, 23);
            this.btnDiminuiUmi.TabIndex = 4;
            this.btnDiminuiUmi.Text = "Diminui";
            this.btnDiminuiUmi.UseVisualStyleBackColor = true;
            this.btnDiminuiUmi.Click += new System.EventHandler(this.btnDiminuiUmi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monitoramento";
            // 
            // chartTempUmi
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTempUmi.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTempUmi.Legends.Add(legend4);
            this.chartTempUmi.Location = new System.Drawing.Point(12, 231);
            this.chartTempUmi.Name = "chartTempUmi";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.MarkerSize = 20;
            series13.Name = "Setpoint Temperatura";
            series13.YValuesPerPoint = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "Setpoint Umidade";
            series14.YValuesPerPoint = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series15.EmptyPointStyle.BorderWidth = 5;
            series15.Legend = "Legend1";
            series15.Name = "Temperatura Medida";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series16.Legend = "Legend1";
            series16.Name = "Umidade Medida";
            this.chartTempUmi.Series.Add(series13);
            this.chartTempUmi.Series.Add(series14);
            this.chartTempUmi.Series.Add(series15);
            this.chartTempUmi.Series.Add(series16);
            this.chartTempUmi.Size = new System.Drawing.Size(806, 300);
            this.chartTempUmi.TabIndex = 5;
            this.chartTempUmi.Text = "Temperatura / Umidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "ºC";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(688, 321);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(53, 37);
            this.labelTemp.TabIndex = 7;
            this.labelTemp.Text = "25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(738, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = " %";
            // 
            // labelUmi
            // 
            this.labelUmi.AutoSize = true;
            this.labelUmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUmi.Location = new System.Drawing.Point(688, 368);
            this.labelUmi.Name = "labelUmi";
            this.labelUmi.Size = new System.Drawing.Size(53, 37);
            this.labelUmi.TabIndex = 6;
            this.labelUmi.Text = "50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(635, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "T=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(635, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 37);
            this.label10.TabIndex = 9;
            this.label10.Text = "U=";
            // 
            // buttonAquecedor
            // 
            this.buttonAquecedor.BackColor = System.Drawing.Color.Gray;
            this.buttonAquecedor.Location = new System.Drawing.Point(625, 442);
            this.buttonAquecedor.Name = "buttonAquecedor";
            this.buttonAquecedor.Size = new System.Drawing.Size(177, 23);
            this.buttonAquecedor.TabIndex = 10;
            this.buttonAquecedor.Text = "AQUECEDOR DESLIGADO";
            this.buttonAquecedor.UseVisualStyleBackColor = false;
            // 
            // buttonUmidificador
            // 
            this.buttonUmidificador.BackColor = System.Drawing.Color.Gray;
            this.buttonUmidificador.Location = new System.Drawing.Point(625, 471);
            this.buttonUmidificador.Name = "buttonUmidificador";
            this.buttonUmidificador.Size = new System.Drawing.Size(177, 23);
            this.buttonUmidificador.TabIndex = 11;
            this.buttonUmidificador.Text = "UMIDIFICADOR DESLIGADO";
            this.buttonUmidificador.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelInfoConexao);
            this.groupBox1.Controls.Add(this.buttonDesconectaPlaca);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.buttonConectaPlaca);
            this.groupBox1.Controls.Add(this.comboBoxPortaCom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(598, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 145);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração Porta COM";
            // 
            // labelInfoConexao
            // 
            this.labelInfoConexao.AutoSize = true;
            this.labelInfoConexao.BackColor = System.Drawing.Color.Red;
            this.labelInfoConexao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfoConexao.Location = new System.Drawing.Point(57, 113);
            this.labelInfoConexao.Name = "labelInfoConexao";
            this.labelInfoConexao.Size = new System.Drawing.Size(111, 18);
            this.labelInfoConexao.TabIndex = 15;
            this.labelInfoConexao.Text = "Desconectado";
            this.labelInfoConexao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonDesconectaPlaca
            // 
            this.buttonDesconectaPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconectaPlaca.Location = new System.Drawing.Point(6, 61);
            this.buttonDesconectaPlaca.Name = "buttonDesconectaPlaca";
            this.buttonDesconectaPlaca.Size = new System.Drawing.Size(97, 34);
            this.buttonDesconectaPlaca.TabIndex = 14;
            this.buttonDesconectaPlaca.Text = "Desconecta Placa";
            this.buttonDesconectaPlaca.UseVisualStyleBackColor = true;
            this.buttonDesconectaPlaca.Click += new System.EventHandler(this.buttonDesconectaPlaca_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(109, 67);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(105, 24);
            this.comboBoxBaudRate.TabIndex = 13;
            // 
            // buttonConectaPlaca
            // 
            this.buttonConectaPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectaPlaca.Location = new System.Drawing.Point(6, 21);
            this.buttonConectaPlaca.Name = "buttonConectaPlaca";
            this.buttonConectaPlaca.Size = new System.Drawing.Size(97, 34);
            this.buttonConectaPlaca.TabIndex = 13;
            this.buttonConectaPlaca.Text = "Conecta Placa";
            this.buttonConectaPlaca.UseVisualStyleBackColor = true;
            this.buttonConectaPlaca.Click += new System.EventHandler(this.buttonConectaPlaca_Click);
            // 
            // comboBoxPortaCom
            // 
            this.comboBoxPortaCom.FormattingEnabled = true;
            this.comboBoxPortaCom.Location = new System.Drawing.Point(109, 27);
            this.comboBoxPortaCom.Name = "comboBoxPortaCom";
            this.comboBoxPortaCom.Size = new System.Drawing.Size(105, 24);
            this.comboBoxPortaCom.TabIndex = 5;
            // 
            // textBoxRecepcao
            // 
            this.textBoxRecepcao.Location = new System.Drawing.Point(824, 101);
            this.textBoxRecepcao.Multiline = true;
            this.textBoxRecepcao.Name = "textBoxRecepcao";
            this.textBoxRecepcao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRecepcao.Size = new System.Drawing.Size(175, 430);
            this.textBoxRecepcao.TabIndex = 13;
            // 
            // buttonLimpaLog
            // 
            this.buttonLimpaLog.Location = new System.Drawing.Point(824, 58);
            this.buttonLimpaLog.Name = "buttonLimpaLog";
            this.buttonLimpaLog.Size = new System.Drawing.Size(175, 26);
            this.buttonLimpaLog.TabIndex = 14;
            this.buttonLimpaLog.Text = "Limpa Log";
            this.buttonLimpaLog.UseVisualStyleBackColor = true;
            this.buttonLimpaLog.Click += new System.EventHandler(this.buttonLimpaLog_Click);
            // 
            // Monitora_Aviario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 543);
            this.Controls.Add(this.buttonLimpaLog);
            this.Controls.Add(this.textBoxRecepcao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUmidificador);
            this.Controls.Add(this.buttonAquecedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUmi);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.chartTempUmi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Monitora_Aviario";
            this.Text = "Controle e Moniltoramento de Ambiente de Aves";
            this.Load += new System.EventHandler(this.Monitora_Aviario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempUmi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSetpointTemp;
        private System.Windows.Forms.Button btnDiminuiTemp;
        private System.Windows.Forms.Button btnAumentaTemp;
        private System.Windows.Forms.Button btnAumentaUmi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSetpointUmi;
        private System.Windows.Forms.Button btnDiminuiUmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTempUmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelUmi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAquecedor;
        private System.Windows.Forms.Button buttonUmidificador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxPortaCom;
        private System.Windows.Forms.Label labelInfoConexao;
        private System.Windows.Forms.Button buttonDesconectaPlaca;
        private System.Windows.Forms.Button buttonConectaPlaca;
        private System.Windows.Forms.TextBox textBoxRecepcao;
        private System.Windows.Forms.Button buttonLimpaLog;
    }
}

