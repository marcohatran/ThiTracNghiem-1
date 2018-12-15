namespace ThiTracNghiem
{
    partial class FormThi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGiay = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.lbPhut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.pnThi = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGiay);
            this.groupBox1.Controls.Add(this.lbGio);
            this.groupBox1.Controls.Add(this.lbPhut);
            this.groupBox1.Location = new System.Drawing.Point(1270, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian còn lại";
            // 
            // lbGiay
            // 
            this.lbGiay.AutoSize = true;
            this.lbGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiay.Location = new System.Drawing.Point(322, 20);
            this.lbGiay.Name = "lbGiay";
            this.lbGiay.Padding = new System.Windows.Forms.Padding(37, 0, 37, 0);
            this.lbGiay.Size = new System.Drawing.Size(76, 33);
            this.lbGiay.TabIndex = 2;
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.Location = new System.Drawing.Point(46, 20);
            this.lbGio.Name = "lbGio";
            this.lbGio.Padding = new System.Windows.Forms.Padding(37, 0, 37, 0);
            this.lbGio.Size = new System.Drawing.Size(76, 33);
            this.lbGio.TabIndex = 1;
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhut.Location = new System.Drawing.Point(187, 20);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Padding = new System.Windows.Forms.Padding(37, 0, 37, 0);
            this.lbPhut.Size = new System.Drawing.Size(76, 33);
            this.lbPhut.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNopBai);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1739, 93);
            this.panel1.TabIndex = 4;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.Lime;
            this.btnNopBai.Font = new System.Drawing.Font("Tahoma", 25F);
            this.btnNopBai.Location = new System.Drawing.Point(635, 18);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(261, 54);
            this.btnNopBai.TabIndex = 4;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // pnThi
            // 
            this.pnThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThi.Location = new System.Drawing.Point(0, 93);
            this.pnThi.Name = "pnThi";
            this.pnThi.Size = new System.Drawing.Size(1739, 606);
            this.pnThi.TabIndex = 5;
            // 
            // FormThi
            // 
            this.AllowDrop = true;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1739, 699);
            this.ControlBox = false;
            this.Controls.Add(this.pnThi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormThi";
            this.Text = "Phần mềm thi trắc nghiệm PTIT";
            this.Load += new System.EventHandler(this.FormThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGiay;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbPhut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Panel pnThi;
    }
}