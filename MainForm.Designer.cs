
namespace JavaJDKDetector
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxJDKs;
        private System.Windows.Forms.Button btnSetJAVA_HOME;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnCopyPath;

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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnCopyPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxJDKs
            // 
            this.comboBoxJDKs.FormattingEnabled = true;
            this.comboBoxJDKs.Location = new System.Drawing.Point(12, 12);
            this.comboBoxJDKs.Name = "comboBoxJDKs";
            this.comboBoxJDKs.Size = new System.Drawing.Size(460, 24);
            this.comboBoxJDKs.TabIndex = 0;
            this.comboBoxJDKs.SelectedIndexChanged += new System.EventHandler(this.comboBoxJDKs_SelectedIndexChanged);
            // 
            // btnSetJAVA_HOME
            // 
            this.btnSetJAVA_HOME.Location = new System.Drawing.Point(12, 90);
            this.btnSetJAVA_HOME.Name = "btnSetJAVA_HOME";
            this.btnSetJAVA_HOME.Size = new System.Drawing.Size(460, 30);
            this.btnSetJAVA_HOME.TabIndex = 1;
            this.btnSetJAVA_HOME.Text = "Set JAVA_HOME";
            this.btnSetJAVA_HOME.UseVisualStyleBackColor = true;
            this.btnSetJAVA_HOME.Click += new System.EventHandler(this.btnSetJAVA_HOME_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 50);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(360, 22);
            this.textBoxPath.TabIndex = 2;
            // 
            // btnCopyPath
            // 
            this.btnCopyPath.Location = new System.Drawing.Point(380, 48);
            this.btnCopyPath.Name = "btnCopyPath";
            this.btnCopyPath.Size = new System.Drawing.Size(92, 25);
            this.btnCopyPath.TabIndex = 3;
            this.btnCopyPath.Text = "Copy Path";
            this.btnCopyPath.UseVisualStyleBackColor = true;
            this.btnCopyPath.Click += new System.EventHandler(this.btnCopyPath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 141);
            this.Controls.Add(this.btnCopyPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnSetJAVA_HOME);
            this.Controls.Add(this.comboBoxJDKs);
            this.Name = "MainForm";
            this.Text = "JDK Detector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
