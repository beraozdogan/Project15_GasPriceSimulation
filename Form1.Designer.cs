namespace Project15_GasPriceSimulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGasAmount = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGasolinePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDieselPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLpgPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbGasoline = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDiesel = new System.Windows.Forms.RadioButton();
            this.rdbLpg = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gas Price Simulation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yakıt Miktarı:";
            // 
            // txtGasAmount
            // 
            this.txtGasAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGasAmount.Location = new System.Drawing.Point(132, 235);
            this.txtGasAmount.Name = "txtGasAmount";
            this.txtGasAmount.Size = new System.Drawing.Size(191, 25);
            this.txtGasAmount.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTotalPrice.Location = new System.Drawing.Point(132, 266);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(191, 25);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplam Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dolum Durumu:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(133, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(481, 17);
            this.progressBar1.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnStart.Location = new System.Drawing.Point(278, 355);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 32);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "İşlemi Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLpgPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDieselPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGasolinePrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(765, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 258);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyatlar";
            // 
            // txtGasolinePrice
            // 
            this.txtGasolinePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGasolinePrice.Location = new System.Drawing.Point(96, 41);
            this.txtGasolinePrice.Name = "txtGasolinePrice";
            this.txtGasolinePrice.ReadOnly = true;
            this.txtGasolinePrice.Size = new System.Drawing.Size(151, 25);
            this.txtGasolinePrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Benzin";
            // 
            // txtDieselPrice
            // 
            this.txtDieselPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDieselPrice.Location = new System.Drawing.Point(96, 125);
            this.txtDieselPrice.Name = "txtDieselPrice";
            this.txtDieselPrice.ReadOnly = true;
            this.txtDieselPrice.Size = new System.Drawing.Size(151, 25);
            this.txtDieselPrice.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Motorin";
            // 
            // txtLpgPrice
            // 
            this.txtLpgPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLpgPrice.Location = new System.Drawing.Point(96, 197);
            this.txtLpgPrice.Name = "txtLpgPrice";
            this.txtLpgPrice.ReadOnly = true;
            this.txtLpgPrice.Size = new System.Drawing.Size(151, 25);
            this.txtLpgPrice.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "LPG";
            // 
            // rdbGasoline
            // 
            this.rdbGasoline.AutoSize = true;
            this.rdbGasoline.Location = new System.Drawing.Point(79, 48);
            this.rdbGasoline.Name = "rdbGasoline";
            this.rdbGasoline.Size = new System.Drawing.Size(57, 17);
            this.rdbGasoline.TabIndex = 11;
            this.rdbGasoline.TabStop = true;
            this.rdbGasoline.Text = "Benzin";
            this.rdbGasoline.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLpg);
            this.groupBox2.Controls.Add(this.rdbDiesel);
            this.groupBox2.Controls.Add(this.rdbGasoline);
            this.groupBox2.Location = new System.Drawing.Point(53, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yakıt Türleri";
            // 
            // rdbDiesel
            // 
            this.rdbDiesel.AutoSize = true;
            this.rdbDiesel.Location = new System.Drawing.Point(225, 48);
            this.rdbDiesel.Name = "rdbDiesel";
            this.rdbDiesel.Size = new System.Drawing.Size(60, 17);
            this.rdbDiesel.TabIndex = 12;
            this.rdbDiesel.TabStop = true;
            this.rdbDiesel.Text = "Motorin";
            this.rdbDiesel.UseVisualStyleBackColor = true;
            // 
            // rdbLpg
            // 
            this.rdbLpg.AutoSize = true;
            this.rdbLpg.Location = new System.Drawing.Point(381, 48);
            this.rdbLpg.Name = "rdbLpg";
            this.rdbLpg.Size = new System.Drawing.Size(46, 17);
            this.rdbLpg.TabIndex = 13;
            this.rdbLpg.TabStop = true;
            this.rdbLpg.Text = "LPG";
            this.rdbLpg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1155, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGasAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGasAmount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLpgPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDieselPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGasolinePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbGasoline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbLpg;
        private System.Windows.Forms.RadioButton rdbDiesel;
    }
}

