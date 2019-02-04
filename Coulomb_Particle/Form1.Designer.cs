namespace Coulomb_Particle
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.btnCharge1 = new System.Windows.Forms.Button();
            this.btnCharge2 = new System.Windows.Forms.Button();
            this.lblCharge1 = new System.Windows.Forms.Label();
            this.lblCharge2 = new System.Windows.Forms.Label();
            this.chartEvsD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldistance = new System.Windows.Forms.Label();
            this.lbltable = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvsD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1024, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 37);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(1024, 80);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 20);
            this.txtCharge.TabIndex = 2;
            // 
            // btnCharge1
            // 
            this.btnCharge1.Location = new System.Drawing.Point(1024, 119);
            this.btnCharge1.Name = "btnCharge1";
            this.btnCharge1.Size = new System.Drawing.Size(100, 38);
            this.btnCharge1.TabIndex = 3;
            this.btnCharge1.Text = "Change Charge Red";
            this.btnCharge1.UseVisualStyleBackColor = true;
            this.btnCharge1.Click += new System.EventHandler(this.btnCharge1_Click);
            // 
            // btnCharge2
            // 
            this.btnCharge2.Location = new System.Drawing.Point(1024, 177);
            this.btnCharge2.Name = "btnCharge2";
            this.btnCharge2.Size = new System.Drawing.Size(100, 39);
            this.btnCharge2.TabIndex = 4;
            this.btnCharge2.Text = "Change Charge Blue";
            this.btnCharge2.UseVisualStyleBackColor = true;
            this.btnCharge2.Click += new System.EventHandler(this.btnCharge2_Click);
            // 
            // lblCharge1
            // 
            this.lblCharge1.AutoSize = true;
            this.lblCharge1.Location = new System.Drawing.Point(719, 26);
            this.lblCharge1.Name = "lblCharge1";
            this.lblCharge1.Size = new System.Drawing.Size(13, 13);
            this.lblCharge1.TabIndex = 5;
            this.lblCharge1.Text = "0";
            // 
            // lblCharge2
            // 
            this.lblCharge2.AutoSize = true;
            this.lblCharge2.Location = new System.Drawing.Point(719, 55);
            this.lblCharge2.Name = "lblCharge2";
            this.lblCharge2.Size = new System.Drawing.Size(13, 13);
            this.lblCharge2.TabIndex = 6;
            this.lblCharge2.Text = "0";
            // 
            // chartEvsD
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEvsD.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Distance vs Force";
            this.chartEvsD.Legends.Add(legend2);
            this.chartEvsD.Location = new System.Drawing.Point(776, 420);
            this.chartEvsD.Name = "chartEvsD";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "ForceDistance";
            this.chartEvsD.Series.Add(series2);
            this.chartEvsD.Size = new System.Drawing.Size(411, 230);
            this.chartEvsD.TabIndex = 7;
            this.chartEvsD.Text = "Electric Force vs Distance";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(1024, 222);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(100, 42);
            this.btnAddPoint.TabIndex = 8;
            this.btnAddPoint.Text = "Add data point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter New Charge";
            // 
            // lbldistance
            // 
            this.lbldistance.AutoSize = true;
            this.lbldistance.Location = new System.Drawing.Point(719, 119);
            this.lbldistance.Name = "lbldistance";
            this.lbldistance.Size = new System.Drawing.Size(13, 13);
            this.lbldistance.TabIndex = 11;
            this.lbldistance.Text = "0";
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.Location = new System.Drawing.Point(719, 162);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(129, 13);
            this.lbltable.TabIndex = 12;
            this.lbltable.Text = "Distance     Electric Force";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbltable);
            this.Controls.Add(this.lbldistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.chartEvsD);
            this.Controls.Add(this.lblCharge2);
            this.Controls.Add(this.lblCharge1);
            this.Controls.Add(this.btnCharge2);
            this.Controls.Add(this.btnCharge1);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Coulomb\'s Law";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Graphics);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Particle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Particle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Particle_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chartEvsD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Button btnCharge1;
        private System.Windows.Forms.Button btnCharge2;
        private System.Windows.Forms.Label lblCharge1;
        private System.Windows.Forms.Label lblCharge2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvsD;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldistance;
        private System.Windows.Forms.Label lbltable;
        private System.Windows.Forms.Label lblInfo;
    }
}

