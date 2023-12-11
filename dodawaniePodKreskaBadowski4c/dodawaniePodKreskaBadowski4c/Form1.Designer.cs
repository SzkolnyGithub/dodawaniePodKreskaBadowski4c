
namespace dodawaniePodKreskaBadowski4c
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
            this.liczba1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.liczba2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.MaskedTextBox();
            this.l2 = new System.Windows.Forms.MaskedTextBox();
            this.p3 = new System.Windows.Forms.MaskedTextBox();
            this.l4 = new System.Windows.Forms.MaskedTextBox();
            this.l3 = new System.Windows.Forms.MaskedTextBox();
            this.p1 = new System.Windows.Forms.MaskedTextBox();
            this.l6 = new System.Windows.Forms.MaskedTextBox();
            this.l5 = new System.Windows.Forms.MaskedTextBox();
            this.p4 = new System.Windows.Forms.MaskedTextBox();
            this.p2 = new System.Windows.Forms.MaskedTextBox();
            this.p5 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // liczba1
            // 
            this.liczba1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.liczba1.Location = new System.Drawing.Point(303, 151);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(142, 36);
            this.liczba1.TabIndex = 1;
            this.liczba1.Text = "1   2   3   4   5";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(314, 375);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(97, 34);
            this.b1.TabIndex = 3;
            this.b1.Text = "Placeholder";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // liczba2
            // 
            this.liczba2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.liczba2.Location = new System.Drawing.Point(303, 197);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(142, 36);
            this.liczba2.TabIndex = 4;
            this.liczba2.Text = "1   2   3   4   5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(271, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "+";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "System liczbowy 9-owy";
            // 
            // l1
            // 
            this.l1.Location = new System.Drawing.Point(408, 236);
            this.l1.Mask = "0";
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(20, 23);
            this.l1.TabIndex = 16;
            this.l1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.l1_MaskInputRejected);
            this.l1.TextChanged += new System.EventHandler(this.l1_TextChanged);
            // 
            // l2
            // 
            this.l2.Location = new System.Drawing.Point(382, 236);
            this.l2.Mask = "0";
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(20, 23);
            this.l2.TabIndex = 17;
            this.l2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.l2_MaskInputRejected);
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(330, 125);
            this.p3.Mask = "0";
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(20, 23);
            this.p3.TabIndex = 18;
            this.p3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.p3_MaskInputRejected);
            // 
            // l4
            // 
            this.l4.Location = new System.Drawing.Point(330, 236);
            this.l4.Mask = "0";
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(20, 23);
            this.l4.TabIndex = 19;
            this.l4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.l4_MaskInputRejected);
            // 
            // l3
            // 
            this.l3.Location = new System.Drawing.Point(356, 236);
            this.l3.Mask = "0";
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(20, 23);
            this.l3.TabIndex = 20;
            this.l3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.l3_MaskInputRejected);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(382, 125);
            this.p1.Mask = "0";
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(20, 23);
            this.p1.TabIndex = 21;
            this.p1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.p1_MaskInputRejected);
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // l6
            // 
            this.l6.Location = new System.Drawing.Point(277, 236);
            this.l6.Mask = "0";
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(20, 23);
            this.l6.TabIndex = 22;
            this.l6.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.l6_MaskInputRejected);
            // 
            // l5
            // 
            this.l5.Location = new System.Drawing.Point(304, 236);
            this.l5.Mask = "0";
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(20, 23);
            this.l5.TabIndex = 23;
            this.l5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.l5_MaskInputRejected);
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(304, 125);
            this.p4.Mask = "0";
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(20, 23);
            this.p4.TabIndex = 24;
            this.p4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.p4_MaskInputRejected);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(356, 125);
            this.p2.Mask = "0";
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(20, 23);
            this.p2.TabIndex = 25;
            this.p2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.p2_MaskInputRejected);
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(278, 125);
            this.p5.Mask = "0";
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(20, 23);
            this.p5.TabIndex = 26;
            this.p5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.p5_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.liczba1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Nauka dodawania pod kreską";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label liczba1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label liczba2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox l1;
        private System.Windows.Forms.MaskedTextBox l2;
        private System.Windows.Forms.MaskedTextBox p3;
        private System.Windows.Forms.MaskedTextBox l4;
        private System.Windows.Forms.MaskedTextBox l3;
        private System.Windows.Forms.MaskedTextBox p1;
        private System.Windows.Forms.MaskedTextBox l6;
        private System.Windows.Forms.MaskedTextBox l5;
        private System.Windows.Forms.MaskedTextBox p4;
        private System.Windows.Forms.MaskedTextBox p2;
        private System.Windows.Forms.MaskedTextBox p5;
    }
}

