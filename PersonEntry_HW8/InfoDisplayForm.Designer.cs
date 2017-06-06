namespace PersonEntry_HW8
{
    partial class InfoDisplayForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameDisplayLabel = new System.Windows.Forms.Label();
            this.emailDisplayLabel = new System.Windows.Forms.Label();
            this.phoneDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // nameDisplayLabel
            // 
            this.nameDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplayLabel.Location = new System.Drawing.Point(0, 9);
            this.nameDisplayLabel.Name = "nameDisplayLabel";
            this.nameDisplayLabel.Size = new System.Drawing.Size(458, 34);
            this.nameDisplayLabel.TabIndex = 2;
            this.nameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailDisplayLabel
            // 
            this.emailDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailDisplayLabel.Location = new System.Drawing.Point(204, 83);
            this.emailDisplayLabel.Name = "emailDisplayLabel";
            this.emailDisplayLabel.Size = new System.Drawing.Size(243, 32);
            this.emailDisplayLabel.TabIndex = 3;
            // 
            // phoneDisplayLabel
            // 
            this.phoneDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phoneDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneDisplayLabel.Location = new System.Drawing.Point(204, 140);
            this.phoneDisplayLabel.Name = "phoneDisplayLabel";
            this.phoneDisplayLabel.Size = new System.Drawing.Size(243, 30);
            this.phoneDisplayLabel.TabIndex = 4;
            // 
            // InfoDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 193);
            this.Controls.Add(this.phoneDisplayLabel);
            this.Controls.Add(this.emailDisplayLabel);
            this.Controls.Add(this.nameDisplayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InfoDisplayForm";
            this.Text = "InfoDisplayForm";
            this.Load += new System.EventHandler(this.InfoDisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameDisplayLabel;
        private System.Windows.Forms.Label emailDisplayLabel;
        private System.Windows.Forms.Label phoneDisplayLabel;
    }
}