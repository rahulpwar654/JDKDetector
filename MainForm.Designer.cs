
namespace JavaJDKDetector
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxJDKs;
        private System.Windows.Forms.Button btnSetJAVA_HOME;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxJDKs = new System.Windows.Forms.ComboBox();
            this.btnSetJAVA_HOME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxJDKs
            // 
            this.comboBoxJDKs.FormattingEnabled = true;
            this.comboBoxJDKs.Location = new System.Drawing.Point(12, 12);
            this.comboBoxJDKs.Name = "comboBoxJDKs";
            this.comboBoxJDKs.Size = new System.Drawing.Size(360, 24);
            this.comboBoxJDKs.TabIndex = 0;
            // 
            // btnSetJAVA_HOME
            // 
            this.btnSetJAVA_HOME.Location = new System.Drawing.Point(12, 50);
            this.btnSetJAVA_HOME.Name = "btnSetJAVA_HOME";
            this.btnSetJAVA_HOME.Size = new System.Drawing.Size(360, 30);
            this.btnSetJAVA_HOME.TabIndex = 1;
            this.btnSetJAVA_HOME.Text = "Set JAVA_HOME";
            this.btnSetJAVA_HOME.UseVisualStyleBackColor = true;
            this.btnSetJAVA_HOME.Click += new System.EventHandler(this.btnSetJAVA_HOME_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.btnSetJAVA_HOME);
            this.Controls.Add(this.comboBoxJDKs);
            this.Name = "MainForm";
            this.Text = "JDK Detector";
            this.ResumeLayout(false);
        }
    }
}
