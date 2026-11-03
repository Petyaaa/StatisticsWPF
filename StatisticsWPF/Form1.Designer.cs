namespace StatisticsWPF
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
            this.lblNumbers = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbers.Location = new System.Drawing.Point(280, 18);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(233, 37);
            this.lblNumbers.TabIndex = 0;
            this.lblNumbers.Text = "Input  number: ";
            this.lblNumbers.Click += new System.EventHandler(this.lblNumbers_Click);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumbers.Location = new System.Drawing.Point(19, 78);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(751, 44);
            this.txtNumbers.TabIndex = 1;
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAverage.Location = new System.Drawing.Point(19, 142);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(241, 88);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "Average of the numbers ";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(327, 293);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(114, 37);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // btnMode
            // 
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMode.Location = new System.Drawing.Point(272, 142);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(241, 88);
            this.btnMode.TabIndex = 4;
            this.btnMode.Text = "Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedian.Location = new System.Drawing.Point(529, 142);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(241, 88);
            this.btnMedian.TabIndex = 5;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.lblNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnMedian;
    }
}

