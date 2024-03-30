namespace Modbus_Graph
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            labelStatusConnection = new Label();
            label2 = new Label();
            textBoxPort = new TextBox();
            label1 = new Label();
            textBoxIP = new TextBox();
            buttonDisconnect = new Button();
            buttonConnect = new Button();
            buttonSimulateSin = new Button();
            textBoxReadPortGraph = new TextBox();
            label3 = new Label();
            buttonReadPortGraph = new Button();
            label4 = new Label();
            textBoxSimulatorPort = new TextBox();
            label5 = new Label();
            buttonReadPortCoil = new Button();
            textBoxReadPortCoil = new TextBox();
            label6 = new Label();
            textBoxWritePortCoil = new TextBox();
            buttonWritePortCoil = new Button();
            buttonWritePortInt = new Button();
            textBoxWritePortInt = new TextBox();
            label7 = new Label();
            textBoxReadPortInt = new TextBox();
            buttonReadPortInt = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(287, 29);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1082, 598);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelStatusConnection);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxPort);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxIP);
            groupBox1.Controls.Add(buttonDisconnect);
            groupBox1.Controls.Add(buttonConnect);
            groupBox1.Location = new Point(13, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 171);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuracao Modbus";
            // 
            // labelStatusConnection
            // 
            labelStatusConnection.AutoSize = true;
            labelStatusConnection.Location = new Point(88, 110);
            labelStatusConnection.Name = "labelStatusConnection";
            labelStatusConnection.Size = new Size(82, 15);
            labelStatusConnection.TabIndex = 6;
            labelStatusConnection.Text = "Desconectado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Porta";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(62, 77);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(166, 23);
            textBoxPort.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "IP";
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(62, 37);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(166, 23);
            textBoxIP.TabIndex = 2;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new Point(21, 133);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(89, 23);
            buttonDisconnect.TabIndex = 1;
            buttonDisconnect.Text = "Desconectar";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(151, 133);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(88, 23);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Conectar";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonSimulateSin
            // 
            buttonSimulateSin.Location = new Point(131, 602);
            buttonSimulateSin.Name = "buttonSimulateSin";
            buttonSimulateSin.Size = new Size(110, 23);
            buttonSimulateSin.TabIndex = 2;
            buttonSimulateSin.Text = "Simular Senoide";
            buttonSimulateSin.UseVisualStyleBackColor = true;
            buttonSimulateSin.Click += buttonSimulateSin_Click;
            // 
            // textBoxReadPortGraph
            // 
            textBoxReadPortGraph.Location = new Point(126, 200);
            textBoxReadPortGraph.Name = "textBoxReadPortGraph";
            textBoxReadPortGraph.Size = new Size(113, 23);
            textBoxReadPortGraph.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 208);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Porta Leitura";
            // 
            // buttonReadPortGraph
            // 
            buttonReadPortGraph.Location = new Point(151, 229);
            buttonReadPortGraph.Name = "buttonReadPortGraph";
            buttonReadPortGraph.Size = new Size(88, 23);
            buttonReadPortGraph.TabIndex = 5;
            buttonReadPortGraph.Text = "Ler";
            buttonReadPortGraph.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 569);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Porta Escrita";
            // 
            // textBoxSimulatorPort
            // 
            textBoxSimulatorPort.Location = new Point(128, 566);
            textBoxSimulatorPort.Name = "textBoxSimulatorPort";
            textBoxSimulatorPort.Size = new Size(113, 23);
            textBoxSimulatorPort.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 275);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 8;
            label5.Text = "Porta Leitura Coil";
            // 
            // buttonReadPortCoil
            // 
            buttonReadPortCoil.Location = new Point(151, 296);
            buttonReadPortCoil.Name = "buttonReadPortCoil";
            buttonReadPortCoil.Size = new Size(88, 23);
            buttonReadPortCoil.TabIndex = 9;
            buttonReadPortCoil.Text = "Ler";
            buttonReadPortCoil.UseVisualStyleBackColor = true;
            // 
            // textBoxReadPortCoil
            // 
            textBoxReadPortCoil.Location = new Point(126, 267);
            textBoxReadPortCoil.Name = "textBoxReadPortCoil";
            textBoxReadPortCoil.Size = new Size(113, 23);
            textBoxReadPortCoil.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 347);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Porta Escrita Coil";
            // 
            // textBoxWritePortCoil
            // 
            textBoxWritePortCoil.Location = new Point(124, 339);
            textBoxWritePortCoil.Name = "textBoxWritePortCoil";
            textBoxWritePortCoil.Size = new Size(113, 23);
            textBoxWritePortCoil.TabIndex = 12;
            // 
            // buttonWritePortCoil
            // 
            buttonWritePortCoil.Location = new Point(151, 368);
            buttonWritePortCoil.Name = "buttonWritePortCoil";
            buttonWritePortCoil.Size = new Size(88, 23);
            buttonWritePortCoil.TabIndex = 13;
            buttonWritePortCoil.Text = "Escrever";
            buttonWritePortCoil.UseVisualStyleBackColor = true;
            // 
            // buttonWritePortInt
            // 
            buttonWritePortInt.Location = new Point(151, 507);
            buttonWritePortInt.Name = "buttonWritePortInt";
            buttonWritePortInt.Size = new Size(88, 23);
            buttonWritePortInt.TabIndex = 19;
            buttonWritePortInt.Text = "Escrever";
            buttonWritePortInt.UseVisualStyleBackColor = true;
            // 
            // textBoxWritePortInt
            // 
            textBoxWritePortInt.Location = new Point(124, 478);
            textBoxWritePortInt.Name = "textBoxWritePortInt";
            textBoxWritePortInt.Size = new Size(113, 23);
            textBoxWritePortInt.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 486);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 17;
            label7.Text = "Porta Escrita Int";
            // 
            // textBoxReadPortInt
            // 
            textBoxReadPortInt.Location = new Point(126, 406);
            textBoxReadPortInt.Name = "textBoxReadPortInt";
            textBoxReadPortInt.Size = new Size(113, 23);
            textBoxReadPortInt.TabIndex = 16;
            // 
            // buttonReadPortInt
            // 
            buttonReadPortInt.Location = new Point(151, 435);
            buttonReadPortInt.Name = "buttonReadPortInt";
            buttonReadPortInt.Size = new Size(88, 23);
            buttonReadPortInt.TabIndex = 15;
            buttonReadPortInt.Text = "Ler";
            buttonReadPortInt.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 414);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 14;
            label8.Text = "Porta Leitura Int";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 229);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 20;
            label9.Text = "ValueRead";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 435);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 21;
            label10.Text = "ValueRead";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 296);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 23;
            label12.Text = "ValueRead";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 639);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(buttonWritePortInt);
            Controls.Add(textBoxWritePortInt);
            Controls.Add(label7);
            Controls.Add(textBoxReadPortInt);
            Controls.Add(buttonReadPortInt);
            Controls.Add(label8);
            Controls.Add(buttonWritePortCoil);
            Controls.Add(textBoxWritePortCoil);
            Controls.Add(label6);
            Controls.Add(textBoxReadPortCoil);
            Controls.Add(buttonReadPortCoil);
            Controls.Add(label5);
            Controls.Add(textBoxSimulatorPort);
            Controls.Add(label4);
            Controls.Add(buttonReadPortGraph);
            Controls.Add(label3);
            Controls.Add(textBoxReadPortGraph);
            Controls.Add(buttonSimulateSin);
            Controls.Add(groupBox1);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxIP;
        private Button buttonDisconnect;
        private Button buttonConnect;
        private Label labelStatusConnection;
        private Label label2;
        private TextBox textBoxPort;
        private Button buttonSimulateSin;
        private TextBox textBoxReadPortGraph;
        private Label label3;
        private Button buttonReadPortGraph;
        private Label label4;
        private TextBox textBoxSimulatorPort;
        private Label label5;
        private Button buttonReadPortCoil;
        private TextBox textBoxReadPortCoil;
        private Label label6;
        private TextBox textBoxWritePortCoil;
        private Button buttonWritePortCoil;
        private Button buttonWritePortInt;
        private TextBox textBoxWritePortInt;
        private Label label7;
        private TextBox textBoxReadPortInt;
        private Button buttonReadPortInt;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
    }
}