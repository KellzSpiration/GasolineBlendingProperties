namespace GasolineBlending
{
    partial class RON
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation verticalLineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation arrowAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime7 = new System.Windows.Forms.Label();
            this.lblRON7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTime5 = new System.Windows.Forms.Label();
            this.lblTime4 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblTime6 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblRON4 = new System.Windows.Forms.Label();
            this.lblRON5 = new System.Windows.Forms.Label();
            this.lblRON6 = new System.Windows.Forms.Label();
            this.lblRON2 = new System.Windows.Forms.Label();
            this.lblRON3 = new System.Windows.Forms.Label();
            this.lblRON1 = new System.Windows.Forms.Label();
            this.btnBlend = new System.Windows.Forms.Button();
            this.txtRON1 = new System.Windows.Forms.TextBox();
            this.txtRON2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1190, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESEARCH OCTANE NUMBER (RON)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Reset);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnBlend);
            this.panel2.Controls.Add(this.txtRON1);
            this.panel2.Controls.Add(this.txtRON2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 628);
            this.panel2.TabIndex = 1;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(67, 353);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(88, 49);
            this.Reset.TabIndex = 20;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTime7);
            this.groupBox1.Controls.Add(this.lblRON7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblTime5);
            this.groupBox1.Controls.Add(this.lblTime4);
            this.groupBox1.Controls.Add(this.lblTime3);
            this.groupBox1.Controls.Add(this.lblTime6);
            this.groupBox1.Controls.Add(this.lblTime2);
            this.groupBox1.Controls.Add(this.lblTime1);
            this.groupBox1.Controls.Add(this.lblRON4);
            this.groupBox1.Controls.Add(this.lblRON5);
            this.groupBox1.Controls.Add(this.lblRON6);
            this.groupBox1.Controls.Add(this.lblRON2);
            this.groupBox1.Controls.Add(this.lblRON3);
            this.groupBox1.Controls.Add(this.lblRON1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(239, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 309);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PMS RON";
            // 
            // lblTime7
            // 
            this.lblTime7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime7.Location = new System.Drawing.Point(158, 272);
            this.lblTime7.Name = "lblTime7";
            this.lblTime7.Size = new System.Drawing.Size(73, 28);
            this.lblTime7.TabIndex = 15;
            this.lblTime7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRON7
            // 
            this.lblRON7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRON7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRON7.Location = new System.Drawing.Point(19, 272);
            this.lblRON7.Name = "lblRON7";
            this.lblRON7.Size = new System.Drawing.Size(73, 28);
            this.lblRON7.TabIndex = 14;
            this.lblRON7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(163, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Time (hrs)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime5
            // 
            this.lblTime5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime5.Location = new System.Drawing.Point(158, 194);
            this.lblTime5.Name = "lblTime5";
            this.lblTime5.Size = new System.Drawing.Size(73, 28);
            this.lblTime5.TabIndex = 12;
            this.lblTime5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime4
            // 
            this.lblTime4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime4.Location = new System.Drawing.Point(158, 152);
            this.lblTime4.Name = "lblTime4";
            this.lblTime4.Size = new System.Drawing.Size(73, 28);
            this.lblTime4.TabIndex = 10;
            this.lblTime4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime3
            // 
            this.lblTime3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3.Location = new System.Drawing.Point(158, 112);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(73, 28);
            this.lblTime3.TabIndex = 9;
            this.lblTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime6
            // 
            this.lblTime6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime6.Location = new System.Drawing.Point(158, 235);
            this.lblTime6.Name = "lblTime6";
            this.lblTime6.Size = new System.Drawing.Size(73, 28);
            this.lblTime6.TabIndex = 8;
            this.lblTime6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime2
            // 
            this.lblTime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(158, 72);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(73, 28);
            this.lblTime2.TabIndex = 7;
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime1
            // 
            this.lblTime1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(158, 32);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(73, 28);
            this.lblTime1.TabIndex = 6;
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRON4
            // 
            this.lblRON4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRON4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRON4.Location = new System.Drawing.Point(19, 152);
            this.lblRON4.Name = "lblRON4";
            this.lblRON4.Size = new System.Drawing.Size(73, 28);
            this.lblRON4.TabIndex = 5;
            this.lblRON4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRON5
            // 
            this.lblRON5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRON5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRON5.Location = new System.Drawing.Point(19, 194);
            this.lblRON5.Name = "lblRON5";
            this.lblRON5.Size = new System.Drawing.Size(73, 28);
            this.lblRON5.TabIndex = 4;
            this.lblRON5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRON6
            // 
            this.lblRON6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRON6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRON6.Location = new System.Drawing.Point(19, 235);
            this.lblRON6.Name = "lblRON6";
            this.lblRON6.Size = new System.Drawing.Size(73, 28);
            this.lblRON6.TabIndex = 3;
            this.lblRON6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRON2
            // 
            this.lblRON2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRON2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRON2.Location = new System.Drawing.Point(19, 72);
            this.lblRON2.Name = "lblRON2";
            this.lblRON2.Size = new System.Drawing.Size(73, 28);
            this.lblRON2.TabIndex = 2;
            this.lblRON2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRON3
            // 
            this.lblRON3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRON3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRON3.Location = new System.Drawing.Point(19, 112);
            this.lblRON3.Name = "lblRON3";
            this.lblRON3.Size = new System.Drawing.Size(73, 28);
            this.lblRON3.TabIndex = 1;
            this.lblRON3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRON1
            // 
            this.lblRON1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRON1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRON1.Location = new System.Drawing.Point(19, 32);
            this.lblRON1.Name = "lblRON1";
            this.lblRON1.Size = new System.Drawing.Size(73, 28);
            this.lblRON1.TabIndex = 0;
            this.lblRON1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBlend
            // 
            this.btnBlend.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBlend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlend.Font = new System.Drawing.Font("High Tower Text", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlend.Location = new System.Drawing.Point(40, 227);
            this.btnBlend.Name = "btnBlend";
            this.btnBlend.Size = new System.Drawing.Size(139, 54);
            this.btnBlend.TabIndex = 4;
            this.btnBlend.Text = "BLEND";
            this.btnBlend.UseVisualStyleBackColor = false;
            this.btnBlend.Click += new System.EventHandler(this.btnBlend_Click);
            // 
            // txtRON1
            // 
            this.txtRON1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRON1.Location = new System.Drawing.Point(293, 14);
            this.txtRON1.Name = "txtRON1";
            this.txtRON1.Size = new System.Drawing.Size(100, 35);
            this.txtRON1.TabIndex = 3;
            this.txtRON1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRON2
            // 
            this.txtRON2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRON2.Location = new System.Drawing.Point(293, 63);
            this.txtRON2.Name = "txtRON2";
            this.txtRON2.Size = new System.Drawing.Size(100, 35);
            this.txtRON2.TabIndex = 2;
            this.txtRON2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter RON for Blend 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter RON for Blend 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnGraph);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(621, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 628);
            this.panel3.TabIndex = 2;
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraph.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.Location = new System.Drawing.Point(130, 476);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(135, 53);
            this.btnGraph.TabIndex = 21;
            this.btnGraph.Text = "Plot Graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // chart1
            // 
            lineAnnotation3.Name = "LineAnnotation1";
            verticalLineAnnotation3.Name = "VerticalLineAnnotation1";
            arrowAnnotation3.Name = "ArrowAnnotation1";
            this.chart1.Annotations.Add(lineAnnotation3);
            this.chart1.Annotations.Add(verticalLineAnnotation3);
            this.chart1.Annotations.Add(arrowAnnotation3);
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.LightSteelBlue;
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Salmon;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gold;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea3.Name = "ChartArea";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(106, 139);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DeepSkyBlue;
            series3.EmptyPointStyle.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.EmptyPointStyle.MarkerColor = System.Drawing.Color.Maroon;
            series3.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(395, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = " ";
            title3.Name = "RON Graph";
            title3.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart1.Titles.Add(title3);
            // 
            // RON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RON";
            this.Size = new System.Drawing.Size(1190, 710);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBlend;
        private System.Windows.Forms.TextBox txtRON1;
        private System.Windows.Forms.TextBox txtRON2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRON4;
        private System.Windows.Forms.Label lblRON5;
        private System.Windows.Forms.Label lblRON6;
        private System.Windows.Forms.Label lblRON2;
        private System.Windows.Forms.Label lblRON3;
        private System.Windows.Forms.Label lblRON1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTime5;
        private System.Windows.Forms.Label lblTime4;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblTime6;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime7;
        private System.Windows.Forms.Label lblRON7;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button btnGraph;
    }
}
