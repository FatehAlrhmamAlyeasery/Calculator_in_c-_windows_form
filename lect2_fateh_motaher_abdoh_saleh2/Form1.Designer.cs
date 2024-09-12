namespace lect2_fateh_motaher_abdoh_saleh2
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
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.divsion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(310, 65);
            this.txtb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(262, 28);
            this.txtb1.TabIndex = 0;
            this.txtb1.TextChanged += new System.EventHandler(this.txtb1_TextChanged);
            this.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb1_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl1.Location = new System.Drawing.Point(403, 40);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 21);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "العدد الاول";
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(310, 188);
            this.txtb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(262, 28);
            this.txtb2.TabIndex = 2;
            this.txtb2.TextChanged += new System.EventHandler(this.txtb2_TextChanged);
            this.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb2_KeyPress);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl2.Location = new System.Drawing.Point(403, 154);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(104, 21);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "العدد الثاني";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sum.Location = new System.Drawing.Point(372, 334);
            this.sum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(170, 54);
            this.sum.TabIndex = 4;
            this.sum.Text = "جمع";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sub.Location = new System.Drawing.Point(372, 405);
            this.sub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(170, 59);
            this.sub.TabIndex = 5;
            this.sub.Text = "طرح";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mult.Location = new System.Drawing.Point(58, 318);
            this.mult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(165, 54);
            this.mult.TabIndex = 6;
            this.mult.Text = "ضرب";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // divsion
            // 
            this.divsion.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divsion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.divsion.Location = new System.Drawing.Point(60, 390);
            this.divsion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divsion.Name = "divsion";
            this.divsion.Size = new System.Drawing.Size(163, 54);
            this.divsion.TabIndex = 7;
            this.divsion.Text = "قسمة";
            this.divsion.UseVisualStyleBackColor = true;
            this.divsion.Click += new System.EventHandler(this.divsion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(13, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 104);
            this.button1.TabIndex = 8;
            this.button1.Text = "إغلاق";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Crimson;
            this.delete.Location = new System.Drawing.Point(18, 188);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(238, 82);
            this.delete.TabIndex = 9;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(311, 280);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(262, 28);
            this.result.TabIndex = 10;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl3.Location = new System.Drawing.Point(444, 256);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 21);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "الناتج";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(585, 451);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divsion);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtb1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "الة حاسبة بسيطة";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button divsion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label lbl3;
    }
}

