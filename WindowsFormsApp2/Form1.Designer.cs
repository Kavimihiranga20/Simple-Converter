namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metervalues = new System.Windows.Forms.TextBox();
            this.kilometervalues = new System.Windows.Forms.TextBox();
            this.CONVERT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meter Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(67, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilo Meter Values";
            // 
            // metervalues
            // 
            this.metervalues.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metervalues.Location = new System.Drawing.Point(486, 173);
            this.metervalues.Name = "metervalues";
            this.metervalues.Size = new System.Drawing.Size(100, 38);
            this.metervalues.TabIndex = 2;
            this.metervalues.Text = "1000";
            this.metervalues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kilometervalues
            // 
            this.kilometervalues.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometervalues.Location = new System.Drawing.Point(486, 253);
            this.kilometervalues.Name = "kilometervalues";
            this.kilometervalues.Size = new System.Drawing.Size(100, 38);
            this.kilometervalues.TabIndex = 3;
            this.kilometervalues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CONVERT
            // 
            this.CONVERT.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONVERT.Location = new System.Drawing.Point(574, 350);
            this.CONVERT.Name = "CONVERT";
            this.CONVERT.Size = new System.Drawing.Size(136, 40);
            this.CONVERT.TabIndex = 4;
            this.CONVERT.Text = "CONVERT";
            this.CONVERT.UseVisualStyleBackColor = true;
            this.CONVERT.Click += new System.EventHandler(this.CONVERT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CONVERT);
            this.Controls.Add(this.kilometervalues);
            this.Controls.Add(this.metervalues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox metervalues;
        private System.Windows.Forms.TextBox kilometervalues;
        private System.Windows.Forms.Button CONVERT;
    }
}

