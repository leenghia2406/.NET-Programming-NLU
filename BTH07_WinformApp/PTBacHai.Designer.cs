namespace BTH07_WinformApp
{
    partial class PTBac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.numATxt = new System.Windows.Forms.TextBox();
            this.numCTxt = new System.Windows.Forms.TextBox();
            this.numBTxt = new System.Windows.Forms.TextBox();
            this.resolveBtn = new System.Windows.Forms.Button();
            this.resTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải phương trình bậc 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblA.Location = new System.Drawing.Point(12, 81);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(142, 25);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Nhập hệ số A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblB.Location = new System.Drawing.Point(12, 123);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(142, 25);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Nhập hệ số B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblC.Location = new System.Drawing.Point(12, 165);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(143, 25);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "Nhập hệ số C";
            // 
            // numATxt
            // 
            this.numATxt.Location = new System.Drawing.Point(182, 86);
            this.numATxt.Name = "numATxt";
            this.numATxt.Size = new System.Drawing.Size(167, 20);
            this.numATxt.TabIndex = 4;
            // 
            // numCTxt
            // 
            this.numCTxt.Location = new System.Drawing.Point(182, 170);
            this.numCTxt.Name = "numCTxt";
            this.numCTxt.Size = new System.Drawing.Size(167, 20);
            this.numCTxt.TabIndex = 5;
            // 
            // numBTxt
            // 
            this.numBTxt.Location = new System.Drawing.Point(182, 129);
            this.numBTxt.Name = "numBTxt";
            this.numBTxt.Size = new System.Drawing.Size(167, 20);
            this.numBTxt.TabIndex = 6;
            // 
            // resolveBtn
            // 
            this.resolveBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resolveBtn.Location = new System.Drawing.Point(147, 212);
            this.resolveBtn.Name = "resolveBtn";
            this.resolveBtn.Size = new System.Drawing.Size(86, 36);
            this.resolveBtn.TabIndex = 8;
            this.resolveBtn.Text = "Thực hiện";
            this.resolveBtn.UseVisualStyleBackColor = false;
            this.resolveBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // resTxtBox
            // 
            this.resTxtBox.Location = new System.Drawing.Point(28, 254);
            this.resTxtBox.Multiline = true;
            this.resTxtBox.Name = "resTxtBox";
            this.resTxtBox.Size = new System.Drawing.Size(321, 88);
            this.resTxtBox.TabIndex = 9;
            // 
            // PTBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 354);
            this.Controls.Add(this.resTxtBox);
            this.Controls.Add(this.resolveBtn);
            this.Controls.Add(this.numBTxt);
            this.Controls.Add(this.numCTxt);
            this.Controls.Add(this.numATxt);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Name = "PTBac2";
            this.Text = "Giải phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox numATxt;
        private System.Windows.Forms.TextBox numCTxt;
        private System.Windows.Forms.TextBox numBTxt;
        private System.Windows.Forms.Button resolveBtn;
        private System.Windows.Forms.TextBox resTxtBox;
    }
}

