namespace Cember
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
            this.pb_circle = new System.Windows.Forms.PictureBox();
            this.lb_p1 = new System.Windows.Forms.Label();
            this.lb_cordinateX = new System.Windows.Forms.Label();
            this.lb_cordinateY = new System.Windows.Forms.Label();
            this.lb_p2 = new System.Windows.Forms.Label();
            this.lb_p3 = new System.Windows.Forms.Label();
            this.lb_yaricap = new System.Windows.Forms.Label();
            this.lb_merkez = new System.Windows.Forms.Label();
            this.lb_alan = new System.Windows.Forms.Label();
            this.lb_cevre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_p1x = new System.Windows.Forms.NumericUpDown();
            this.nud_p1y = new System.Windows.Forms.NumericUpDown();
            this.nud_p2y = new System.Windows.Forms.NumericUpDown();
            this.nud_p2x = new System.Windows.Forms.NumericUpDown();
            this.nud_p3y = new System.Windows.Forms.NumericUpDown();
            this.nud_p3x = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pb_circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p1x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p1y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p2y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p2x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p3y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p3x)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_circle
            // 
            this.pb_circle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_circle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_circle.Location = new System.Drawing.Point(228, 21);
            this.pb_circle.Name = "pb_circle";
            this.pb_circle.Size = new System.Drawing.Size(300, 400);
            this.pb_circle.TabIndex = 0;
            this.pb_circle.TabStop = false;
            // 
            // lb_p1
            // 
            this.lb_p1.AutoSize = true;
            this.lb_p1.Location = new System.Drawing.Point(25, 132);
            this.lb_p1.Name = "lb_p1";
            this.lb_p1.Size = new System.Drawing.Size(20, 13);
            this.lb_p1.TabIndex = 2;
            this.lb_p1.Text = "P1";
            // 
            // lb_cordinateX
            // 
            this.lb_cordinateX.AutoSize = true;
            this.lb_cordinateX.Location = new System.Drawing.Point(62, 84);
            this.lb_cordinateX.Name = "lb_cordinateX";
            this.lb_cordinateX.Size = new System.Drawing.Size(18, 39);
            this.lb_cordinateX.TabIndex = 5;
            this.lb_cordinateX.Text = "X\r\n→\r\n←";
            // 
            // lb_cordinateY
            // 
            this.lb_cordinateY.AutoSize = true;
            this.lb_cordinateY.Location = new System.Drawing.Point(114, 84);
            this.lb_cordinateY.Name = "lb_cordinateY";
            this.lb_cordinateY.Size = new System.Drawing.Size(14, 39);
            this.lb_cordinateY.TabIndex = 6;
            this.lb_cordinateY.Text = "Y\r\n↑\r\n↓";
            // 
            // lb_p2
            // 
            this.lb_p2.AutoSize = true;
            this.lb_p2.Location = new System.Drawing.Point(25, 158);
            this.lb_p2.Name = "lb_p2";
            this.lb_p2.Size = new System.Drawing.Size(20, 13);
            this.lb_p2.TabIndex = 8;
            this.lb_p2.Text = "P2";
            // 
            // lb_p3
            // 
            this.lb_p3.AutoSize = true;
            this.lb_p3.Location = new System.Drawing.Point(25, 185);
            this.lb_p3.Name = "lb_p3";
            this.lb_p3.Size = new System.Drawing.Size(20, 13);
            this.lb_p3.TabIndex = 11;
            this.lb_p3.Text = "P3";
            // 
            // lb_yaricap
            // 
            this.lb_yaricap.AutoSize = true;
            this.lb_yaricap.Location = new System.Drawing.Point(25, 277);
            this.lb_yaricap.Name = "lb_yaricap";
            this.lb_yaricap.Size = new System.Drawing.Size(27, 13);
            this.lb_yaricap.TabIndex = 13;
            this.lb_yaricap.Text = "R = ";
            // 
            // lb_merkez
            // 
            this.lb_merkez.AutoSize = true;
            this.lb_merkez.Location = new System.Drawing.Point(25, 294);
            this.lb_merkez.Name = "lb_merkez";
            this.lb_merkez.Size = new System.Drawing.Size(26, 13);
            this.lb_merkez.TabIndex = 14;
            this.lb_merkez.Text = "C = ";
            // 
            // lb_alan
            // 
            this.lb_alan.AutoSize = true;
            this.lb_alan.Location = new System.Drawing.Point(25, 311);
            this.lb_alan.Name = "lb_alan";
            this.lb_alan.Size = new System.Drawing.Size(26, 13);
            this.lb_alan.TabIndex = 15;
            this.lb_alan.Text = "A = ";
            // 
            // lb_cevre
            // 
            this.lb_cevre.AutoSize = true;
            this.lb_cevre.Location = new System.Drawing.Point(25, 328);
            this.lb_cevre.Name = "lb_cevre";
            this.lb_cevre.Size = new System.Drawing.Size(26, 13);
            this.lb_cevre.TabIndex = 16;
            this.lb_cevre.Text = "P = ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "İŞLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "π(pi) = 3 alındı.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Serdar Eyüp ALTIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(531, 180);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(16, 51);
            this.label3.TabIndex = 20;
            this.label3.Text = "4\r\n0\r\n0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(363, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "3 0 0";
            // 
            // nud_p1x
            // 
            this.nud_p1x.ForeColor = System.Drawing.Color.Blue;
            this.nud_p1x.Location = new System.Drawing.Point(51, 129);
            this.nud_p1x.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_p1x.Name = "nud_p1x";
            this.nud_p1x.Size = new System.Drawing.Size(44, 20);
            this.nud_p1x.TabIndex = 22;
            this.nud_p1x.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            // 
            // nud_p1y
            // 
            this.nud_p1y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nud_p1y.Location = new System.Drawing.Point(101, 129);
            this.nud_p1y.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nud_p1y.Name = "nud_p1y";
            this.nud_p1y.Size = new System.Drawing.Size(44, 20);
            this.nud_p1y.TabIndex = 23;
            this.nud_p1y.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nud_p2y
            // 
            this.nud_p2y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nud_p2y.Location = new System.Drawing.Point(101, 155);
            this.nud_p2y.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nud_p2y.Name = "nud_p2y";
            this.nud_p2y.Size = new System.Drawing.Size(44, 20);
            this.nud_p2y.TabIndex = 25;
            this.nud_p2y.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // nud_p2x
            // 
            this.nud_p2x.ForeColor = System.Drawing.Color.Blue;
            this.nud_p2x.Location = new System.Drawing.Point(51, 155);
            this.nud_p2x.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_p2x.Name = "nud_p2x";
            this.nud_p2x.Size = new System.Drawing.Size(44, 20);
            this.nud_p2x.TabIndex = 24;
            this.nud_p2x.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // nud_p3y
            // 
            this.nud_p3y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nud_p3y.Location = new System.Drawing.Point(101, 181);
            this.nud_p3y.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nud_p3y.Name = "nud_p3y";
            this.nud_p3y.Size = new System.Drawing.Size(44, 20);
            this.nud_p3y.TabIndex = 27;
            this.nud_p3y.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // nud_p3x
            // 
            this.nud_p3x.ForeColor = System.Drawing.Color.Blue;
            this.nud_p3x.Location = new System.Drawing.Point(51, 181);
            this.nud_p3x.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_p3x.Name = "nud_p3x";
            this.nud_p3x.Size = new System.Drawing.Size(44, 20);
            this.nud_p3x.TabIndex = 26;
            this.nud_p3x.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(547, 429);
            this.Controls.Add(this.nud_p3y);
            this.Controls.Add(this.nud_p3x);
            this.Controls.Add(this.nud_p2y);
            this.Controls.Add(this.nud_p2x);
            this.Controls.Add(this.nud_p1y);
            this.Controls.Add(this.nud_p1x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_cevre);
            this.Controls.Add(this.lb_alan);
            this.Controls.Add(this.lb_merkez);
            this.Controls.Add(this.lb_yaricap);
            this.Controls.Add(this.lb_p3);
            this.Controls.Add(this.lb_p2);
            this.Controls.Add(this.lb_cordinateY);
            this.Controls.Add(this.lb_cordinateX);
            this.Controls.Add(this.lb_p1);
            this.Controls.Add(this.pb_circle);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p1x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p1y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p2y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p2x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p3y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p3x)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_circle;
        private System.Windows.Forms.Label lb_p1;
        private System.Windows.Forms.Label lb_cordinateX;
        private System.Windows.Forms.Label lb_cordinateY;
        private System.Windows.Forms.Label lb_p2;
        private System.Windows.Forms.Label lb_p3;
        private System.Windows.Forms.Label lb_yaricap;
        private System.Windows.Forms.Label lb_merkez;
        private System.Windows.Forms.Label lb_cevre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_alan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_p1x;
        private System.Windows.Forms.NumericUpDown nud_p2y;
        private System.Windows.Forms.NumericUpDown nud_p2x;
        private System.Windows.Forms.NumericUpDown nud_p3y;
        private System.Windows.Forms.NumericUpDown nud_p1y;
        private System.Windows.Forms.NumericUpDown nud_p3x;
    }
}

