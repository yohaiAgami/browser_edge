using Microsoft.Toolkit.Forms.UI.Controls;
using System.Windows.Forms;

namespace Browser_Eadge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private WebView webView1;
        private System.ComponentModel.IContainer components = null;

        private ToolStrip toolStrip1, toolStrip2;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton goButton, backButton,
            forwardButton, stopButton, refreshButton,
            btnCallJavaScript;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
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
            this.webBrowser1 = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.btnInject = new System.Windows.Forms.ToolStripButton();
            this.btnCallJavaScript = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 50);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(783, 403);
            this.webBrowser1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goButton,
            this.backButton,
            this.forwardButton,
            this.stopButton,
            this.refreshButton,
            this.btnInject,
            this.toolStripButton1,
            this.btnCallJavaScript});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // goButton
            // 
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(26, 22);
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(36, 22);
            this.backButton.Text = "Back";
            // 
            // forwardButton
            // 
            this.forwardButton.Enabled = false;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(54, 22);
            this.forwardButton.Text = "Forward";
            // 
            // stopButton
            // 
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(35, 22);
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(50, 22);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // btnInject
            // 
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(98, 22);
            this.btnInject.Text = "Inject Java Script";
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // btnCallJavaScript
            // 
            this.btnCallJavaScript.Name = "btnCallJavaScript";
            this.btnCallJavaScript.Size = new System.Drawing.Size(84, 22);
            this.btnCallJavaScript.Text = "Call javascript";
            this.btnCallJavaScript.Click += new System.EventHandler(this.btnCallJavaScript_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(783, 25);
            this.toolStrip2.TabIndex = 1;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(600, 25);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(129, 22);
            this.toolStripButton1.Text = "Call c# from javascript";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(783, 475);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.WebBrowser webBrowser1;
        private WebView webBrowser1;
        private ToolStripButton btnInject;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton toolStripButton1;
    }
}

