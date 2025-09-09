namespace calc2
{
    partial class Calculator
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
            this.calcBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.ceBtn = new System.Windows.Forms.Button();
            this.buttonBox = new System.Windows.Forms.TableLayoutPanel();
            this.oneBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.xBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.takeBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.buttonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcBox
            // 
            this.calcBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calcBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBox.Location = new System.Drawing.Point(12, 12);
            this.calcBox.Multiline = true;
            this.calcBox.Name = "calcBox";
            this.calcBox.Size = new System.Drawing.Size(544, 173);
            this.calcBox.TabIndex = 0;
            this.calcBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(-15, 157);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(0, 0);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // cBtn
            // 
            this.cBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBtn.Location = new System.Drawing.Point(286, 191);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(270, 137);
            this.cBtn.TabIndex = 2;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = false;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ceBtn.Location = new System.Drawing.Point(12, 191);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(268, 137);
            this.ceBtn.TabIndex = 3;
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = false;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // buttonBox
            // 
            this.buttonBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBox.ColumnCount = 4;
            this.buttonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.Controls.Add(this.addBtn, 3, 3);
            this.buttonBox.Controls.Add(this.equalBtn, 2, 3);
            this.buttonBox.Controls.Add(this.zeroBtn, 1, 3);
            this.buttonBox.Controls.Add(this.changeBtn, 0, 3);
            this.buttonBox.Controls.Add(this.divBtn, 3, 2);
            this.buttonBox.Controls.Add(this.nineBtn, 2, 2);
            this.buttonBox.Controls.Add(this.eightBtn, 1, 2);
            this.buttonBox.Controls.Add(this.sevenBtn, 0, 2);
            this.buttonBox.Controls.Add(this.takeBtn, 3, 1);
            this.buttonBox.Controls.Add(this.sixBtn, 2, 1);
            this.buttonBox.Controls.Add(this.fiveBtn, 1, 1);
            this.buttonBox.Controls.Add(this.fourBtn, 0, 1);
            this.buttonBox.Controls.Add(this.xBtn, 3, 0);
            this.buttonBox.Controls.Add(this.threeBtn, 2, 0);
            this.buttonBox.Controls.Add(this.button2, 1, 0);
            this.buttonBox.Controls.Add(this.oneBtn, 0, 0);
            this.buttonBox.Location = new System.Drawing.Point(9, 334);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.RowCount = 4;
            this.buttonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonBox.Size = new System.Drawing.Size(550, 607);
            this.buttonBox.TabIndex = 4;
            // 
            // oneBtn
            // 
            this.oneBtn.Location = new System.Drawing.Point(3, 3);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(131, 145);
            this.oneBtn.TabIndex = 0;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 145);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Location = new System.Drawing.Point(277, 3);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(131, 145);
            this.threeBtn.TabIndex = 2;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // xBtn
            // 
            this.xBtn.Location = new System.Drawing.Point(414, 3);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(133, 145);
            this.xBtn.TabIndex = 3;
            this.xBtn.Text = "X";
            this.xBtn.UseVisualStyleBackColor = true;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Location = new System.Drawing.Point(3, 154);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(131, 145);
            this.fourBtn.TabIndex = 4;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Location = new System.Drawing.Point(140, 154);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(131, 145);
            this.fiveBtn.TabIndex = 5;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Location = new System.Drawing.Point(277, 154);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(131, 145);
            this.sixBtn.TabIndex = 6;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(414, 154);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(133, 145);
            this.takeBtn.TabIndex = 7;
            this.takeBtn.Text = "-";
            this.takeBtn.UseVisualStyleBackColor = true;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Location = new System.Drawing.Point(3, 305);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(131, 145);
            this.sevenBtn.TabIndex = 8;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Location = new System.Drawing.Point(140, 305);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(131, 145);
            this.eightBtn.TabIndex = 9;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Location = new System.Drawing.Point(277, 305);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(131, 145);
            this.nineBtn.TabIndex = 10;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(414, 305);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(133, 145);
            this.divBtn.TabIndex = 11;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Location = new System.Drawing.Point(140, 456);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(131, 145);
            this.zeroBtn.TabIndex = 13;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Location = new System.Drawing.Point(277, 456);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(131, 145);
            this.equalBtn.TabIndex = 14;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(414, 456);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 145);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(3, 456);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(131, 145);
            this.changeBtn.TabIndex = 12;
            this.changeBtn.Text = "±";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 951);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.ceBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.buttonBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button ceBtn;
        private System.Windows.Forms.TableLayoutPanel buttonBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button takeBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button changeBtn;
    }
}

