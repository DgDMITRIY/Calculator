
namespace Калькулятор
{
    partial class MyCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCalculator));
            this.textBoxCalc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnChangeSign = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCalc
            // 
            this.textBoxCalc.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCalc.Location = new System.Drawing.Point(12, 64);
            this.textBoxCalc.Multiline = true;
            this.textBoxCalc.Name = "textBoxCalc";
            this.textBoxCalc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCalc.Size = new System.Drawing.Size(459, 76);
            this.textBoxCalc.TabIndex = 1;
            this.textBoxCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCalc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCalc_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "MyCalculator";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(438, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 47);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnCLose_MouseLeave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 146);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnDiv);
            this.splitContainer1.Panel1.Controls.Add(this.BtnClear);
            this.splitContainer1.Panel1.Controls.Add(this.BtnChangeSign);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_0);
            this.splitContainer1.Panel1.Controls.Add(this.BtnMult);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_9);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_8);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_7);
            this.splitContainer1.Panel1.Controls.Add(this.BtnMinus);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_6);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_5);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_4);
            this.splitContainer1.Panel1.Controls.Add(this.BtnPlus);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_3);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_2);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnEqual);
            this.splitContainer1.Size = new System.Drawing.Size(459, 329);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 5;
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.Wheat;
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.BtnDiv.Location = new System.Drawing.Point(276, 246);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(85, 75);
            this.BtnDiv.TabIndex = 15;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.BtnClear.Location = new System.Drawing.Point(185, 246);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 75);
            this.BtnClear.TabIndex = 14;
            this.BtnClear.Text = "с";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnChangeSign
            // 
            this.BtnChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.BtnChangeSign.Location = new System.Drawing.Point(94, 246);
            this.BtnChangeSign.Name = "BtnChangeSign";
            this.BtnChangeSign.Size = new System.Drawing.Size(85, 75);
            this.BtnChangeSign.TabIndex = 13;
            this.BtnChangeSign.Text = "+/-";
            this.BtnChangeSign.UseVisualStyleBackColor = true;
            this.BtnChangeSign.Click += new System.EventHandler(this.BtnChangeSign_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_0.Location = new System.Drawing.Point(3, 246);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(85, 75);
            this.Btn_0.TabIndex = 12;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = true;
            this.Btn_0.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.BackColor = System.Drawing.Color.Wheat;
            this.BtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.BtnMult.Location = new System.Drawing.Point(276, 165);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(85, 75);
            this.BtnMult.TabIndex = 11;
            this.BtnMult.Text = "x";
            this.BtnMult.UseVisualStyleBackColor = false;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_9.Location = new System.Drawing.Point(185, 165);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(85, 75);
            this.Btn_9.TabIndex = 10;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = true;
            this.Btn_9.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_8.Location = new System.Drawing.Point(94, 165);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(85, 75);
            this.Btn_8.TabIndex = 9;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = true;
            this.Btn_8.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_7.Location = new System.Drawing.Point(3, 165);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(85, 75);
            this.Btn_7.TabIndex = 8;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = true;
            this.Btn_7.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.Wheat;
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.BtnMinus.Location = new System.Drawing.Point(276, 84);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(85, 75);
            this.BtnMinus.TabIndex = 7;
            this.BtnMinus.Text = "—";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_6.Location = new System.Drawing.Point(185, 84);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(85, 75);
            this.Btn_6.TabIndex = 6;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = true;
            this.Btn_6.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_5.Location = new System.Drawing.Point(94, 84);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(85, 75);
            this.Btn_5.TabIndex = 5;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = true;
            this.Btn_5.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_4.Location = new System.Drawing.Point(3, 84);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(85, 75);
            this.Btn_4.TabIndex = 4;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.Wheat;
            this.BtnPlus.FlatAppearance.BorderSize = 0;
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.BtnPlus.Location = new System.Drawing.Point(276, 3);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(85, 75);
            this.BtnPlus.TabIndex = 3;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_3.Location = new System.Drawing.Point(185, 3);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(85, 75);
            this.Btn_3.TabIndex = 2;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_2.Location = new System.Drawing.Point(94, 3);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(85, 75);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.Btn_1.Location = new System.Drawing.Point(3, 3);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(85, 75);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.Btn_Common_Number_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.Wheat;
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.BtnEqual.Location = new System.Drawing.Point(3, 3);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(87, 318);
            this.BtnEqual.TabIndex = 0;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimaze.Location = new System.Drawing.Point(390, 0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(45, 47);
            this.btnMinimaze.TabIndex = 7;
            this.btnMinimaze.Text = "—";
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.BtnMinimaze_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.SystemColors.Window;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.lblChange.Location = new System.Drawing.Point(19, 74);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 59);
            this.lblChange.TabIndex = 8;
            // 
            // MyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(483, 482);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnMinimaze);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnChangeSign;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Label lblChange;
    }
}

