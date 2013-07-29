namespace PrintMonitorApp
{
    partial class MainForm
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
            this.ddlPrinters = new System.Windows.Forms.ComboBox();
            this.btnLoadPrinters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlPrinters
            // 
            this.ddlPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrinters.FormattingEnabled = true;
            this.ddlPrinters.Location = new System.Drawing.Point(13, 22);
            this.ddlPrinters.Name = "ddlPrinters";
            this.ddlPrinters.Size = new System.Drawing.Size(200, 21);
            this.ddlPrinters.TabIndex = 0;
            // 
            // btnLoadPrinters
            // 
            this.btnLoadPrinters.Location = new System.Drawing.Point(219, 22);
            this.btnLoadPrinters.Name = "btnLoadPrinters";
            this.btnLoadPrinters.Size = new System.Drawing.Size(150, 23);
            this.btnLoadPrinters.TabIndex = 1;
            this.btnLoadPrinters.Text = "Load Printers";
            this.btnLoadPrinters.UseVisualStyleBackColor = true;
            this.btnLoadPrinters.Click += new System.EventHandler(this.btnLoadPrinters_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.btnLoadPrinters);
            this.Controls.Add(this.ddlPrinters);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlPrinters;
        private System.Windows.Forms.Button btnLoadPrinters;
    }
}

