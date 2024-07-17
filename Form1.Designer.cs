namespace WinFormsApp4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LabelKetQua = new Label();
            label7 = new Label();
            SoA = new TextBox();
            SoB = new TextBox();
            SoC = new TextBox();
            Tính = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(265, 37);
            label1.Name = "label1";
            label1.Size = new Size(276, 35);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương trình bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(265, 72);
            label2.Name = "label2";
            label2.Size = new Size(201, 35);
            label2.TabIndex = 0;
            label2.Text = "Ax2 + Bx + C = 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(160, 200);
            label3.Name = "label3";
            label3.Size = new Size(46, 35);
            label3.TabIndex = 0;
            label3.Text = "B=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(160, 146);
            label4.Name = "label4";
            label4.Size = new Size(48, 35);
            label4.TabIndex = 0;
            label4.Text = "A=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(159, 247);
            label5.Name = "label5";
            label5.Size = new Size(47, 35);
            label5.TabIndex = 0;
            label5.Text = "C=";
            // 
            // LabelKetQua
            // 
            LabelKetQua.AutoSize = true;
            LabelKetQua.Font = new Font("Segoe UI", 15F);
            LabelKetQua.Location = new Point(78, 335);
            LabelKetQua.Name = "LabelKetQua";
            LabelKetQua.Size = new Size(100, 35);
            LabelKetQua.TabIndex = 0;
            LabelKetQua.Text = "Kết quả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(248, 303);
            label7.Name = "label7";
            label7.Size = new Size(0, 35);
            label7.TabIndex = 1;
            // 
            // SoA
            // 
            SoA.Font = new Font("Segoe UI", 15F);
            SoA.Location = new Point(248, 143);
            SoA.Name = "SoA";
            SoA.Size = new Size(173, 41);
            SoA.TabIndex = 3;
            // 
            // SoB
            // 
            SoB.Font = new Font("Segoe UI", 15F);
            SoB.Location = new Point(248, 197);
            SoB.Name = "SoB";
            SoB.Size = new Size(173, 41);
            SoB.TabIndex = 3;
            // 
            // SoC
            // 
            SoC.Font = new Font("Segoe UI", 15F);
            SoC.Location = new Point(248, 252);
            SoC.Name = "SoC";
            SoC.Size = new Size(173, 41);
            SoC.TabIndex = 3;
            // 
            // Tính
            // 
            Tính.Font = new Font("Segoe UI", 15F);
            Tính.Location = new Point(519, 142);
            Tính.Name = "Tính";
            Tính.Size = new Size(138, 52);
            Tính.TabIndex = 4;
            Tính.Text = "Tính";
            Tính.UseVisualStyleBackColor = true;
            Tính.Click += Tính_Click;
            Tính.MouseHover += Tính_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(519, 229);
            button1.Name = "button1";
            button1.Size = new Size(138, 52);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 519);
            Controls.Add(button1);
            Controls.Add(Tính);
            Controls.Add(SoC);
            Controls.Add(SoB);
            Controls.Add(SoA);
            Controls.Add(label7);
            Controls.Add(LabelKetQua);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LabelKetQua;
        private Label label7;
        private TextBox SoA;
        private TextBox SoB;
        private TextBox SoC;
        private Button Tính;
        private Button button1;
    }
}
