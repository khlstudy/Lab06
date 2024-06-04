namespace Lab06
{
    partial class fMain
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
            this.txtX1 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.Label();
            this.txty = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.AutoSize = true;
            this.txtX1.Font = new System.Drawing.Font("Alef", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(90, 72);
            this.txtX1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(128, 31);
            this.txtX1.TabIndex = 1;
            this.txtX1.Text = "Змінна X1";
            // 
            // txtX2
            // 
            this.txtX2.AutoSize = true;
            this.txtX2.Font = new System.Drawing.Font("Alef", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(90, 134);
            this.txtX2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(130, 31);
            this.txtX2.TabIndex = 2;
            this.txtX2.Text = "Змінна X2";
            // 
            // txty
            // 
            this.txty.AutoSize = true;
            this.txty.Font = new System.Drawing.Font("Alef", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txty.Location = new System.Drawing.Point(90, 217);
            this.txty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(284, 31);
            this.txty.TabIndex = 4;
            this.txty.Text = "Результат розрахунку Y";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(93, 371);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 45);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(313, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 45);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(517, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(249, 69);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(221, 39);
            this.tbX1.TabIndex = 9;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(249, 131);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(221, 39);
            this.tbX2.TabIndex = 10;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(400, 214);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(221, 39);
            this.tbY.TabIndex = 11;
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(400, 276);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(221, 39);
            this.tbAverage.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Середнє арифметичне";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Font = new System.Drawing.Font("Alef", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtX1;
        private System.Windows.Forms.Label txtX2;
        private System.Windows.Forms.Label txty;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label1;
    }
}

