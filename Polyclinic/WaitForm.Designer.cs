namespace Polyclinic
{
    partial class WaitForm
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
            this.WaitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WaitLabel
            // 
            this.WaitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaitLabel.Location = new System.Drawing.Point(0, 0);
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(341, 126);
            this.WaitLabel.TabIndex = 0;
            this.WaitLabel.Text = "Пожалуйста подождите...";
            this.WaitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 126);
            this.ControlBox = false;
            this.Controls.Add(this.WaitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WaitForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспорт в Excel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WaitLabel;
    }
}