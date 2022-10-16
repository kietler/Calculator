namespace Calculator
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
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.lbsoa = new System.Windows.Forms.Label();
            this.txtsob = new System.Windows.Forms.TextBox();
            this.lbsob = new System.Windows.Forms.Label();
            this.txtkqua = new System.Windows.Forms.TextBox();
            this.lbkqua = new System.Windows.Forms.Label();
            this.btcong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsoa
            // 
            this.txtsoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoa.Location = new System.Drawing.Point(214, 126);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(292, 38);
            this.txtsoa.TabIndex = 0;
            // 
            // lbsoa
            // 
            this.lbsoa.AutoSize = true;
            this.lbsoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoa.Location = new System.Drawing.Point(85, 126);
            this.lbsoa.Name = "lbsoa";
            this.lbsoa.Size = new System.Drawing.Size(69, 31);
            this.lbsoa.TabIndex = 1;
            this.lbsoa.Text = "Số a";
            // 
            // txtsob
            // 
            this.txtsob.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsob.Location = new System.Drawing.Point(214, 189);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(292, 38);
            this.txtsob.TabIndex = 0;
            // 
            // lbsob
            // 
            this.lbsob.AutoSize = true;
            this.lbsob.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsob.Location = new System.Drawing.Point(85, 189);
            this.lbsob.Name = "lbsob";
            this.lbsob.Size = new System.Drawing.Size(69, 31);
            this.lbsob.TabIndex = 1;
            this.lbsob.Text = "Số b";
            // 
            // txtkqua
            // 
            this.txtkqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkqua.Location = new System.Drawing.Point(214, 248);
            this.txtkqua.Name = "txtkqua";
            this.txtkqua.Size = new System.Drawing.Size(292, 38);
            this.txtkqua.TabIndex = 0;
            // 
            // lbkqua
            // 
            this.lbkqua.AutoSize = true;
            this.lbkqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkqua.Location = new System.Drawing.Point(85, 248);
            this.lbkqua.Name = "lbkqua";
            this.lbkqua.Size = new System.Drawing.Size(107, 31);
            this.lbkqua.TabIndex = 1;
            this.lbkqua.Text = "Kết quả";
            // 
            // btcong
            // 
            this.btcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcong.Location = new System.Drawing.Point(421, 346);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(85, 36);
            this.btcong.TabIndex = 2;
            this.btcong.Text = "Cộng";
            this.btcong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 493);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.lbkqua);
            this.Controls.Add(this.lbsob);
            this.Controls.Add(this.lbsoa);
            this.Controls.Add(this.txtkqua);
            this.Controls.Add(this.txtsob);
            this.Controls.Add(this.txtsoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.Label lbsoa;
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.Label lbsob;
        private System.Windows.Forms.TextBox txtkqua;
        private System.Windows.Forms.Label lbkqua;
        private System.Windows.Forms.Button btcong;
    }
}

