namespace Slide_Show
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.feedbackPanel = new System.Windows.Forms.Panel();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.speedButton = new System.Windows.Forms.ToolStripButton();
            this.speedInput = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.randomButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.loopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOutput = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedInputNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
<<<<<<< HEAD
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
=======
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.feedbackPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedInputNull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
=======
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picBox);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
<<<<<<< HEAD
            this.splitContainer1.Size = new System.Drawing.Size(926, 439);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.SplitterWidth = 2;
=======
            this.splitContainer1.Size = new System.Drawing.Size(2150, 1255);
            this.splitContainer1.SplitterDistance = 1057;
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
            this.splitContainer1.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
<<<<<<< HEAD
            this.picBox.Size = new System.Drawing.Size(926, 371);
=======
            this.picBox.Size = new System.Drawing.Size(2150, 1057);
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.feedbackPanel);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
<<<<<<< HEAD
            this.panel1.Size = new System.Drawing.Size(926, 63);
=======
            this.panel1.Size = new System.Drawing.Size(2150, 189);
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
            this.panel1.TabIndex = 0;
            // 
            // feedbackPanel
            // 
            this.feedbackPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.feedbackPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.feedbackPanel.Controls.Add(this.feedbackLabel);
            this.feedbackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbackPanel.Location = new System.Drawing.Point(0, 26);
            this.feedbackPanel.Margin = new System.Windows.Forms.Padding(2);
            this.feedbackPanel.Name = "feedbackPanel";
<<<<<<< HEAD
            this.feedbackPanel.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.feedbackPanel.Size = new System.Drawing.Size(922, 33);
=======
            this.feedbackPanel.Padding = new System.Windows.Forms.Padding(5);
            this.feedbackPanel.Size = new System.Drawing.Size(2146, 135);
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
            this.feedbackPanel.TabIndex = 1;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbackLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.feedbackLabel.Location = new System.Drawing.Point(2, 3);
            this.feedbackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(19, 13);
            this.feedbackLabel.TabIndex = 0;
            this.feedbackLabel.Text = "....";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startButton,
            this.toolStripSeparator1,
            this.loadButton,
            this.toolStripSeparator2,
            this.speedButton,
            this.speedInput,
            this.toolStripSeparator3,
            this.randomButton,
            this.toolStripSeparator4,
            this.loopButton,
            this.toolStripSeparator5,
            this.toolOutput});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(0, 26);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(400, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(922, 26);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startButton
            // 
            this.startButton.AutoSize = false;
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startButton.Enabled = false;
            this.startButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 36);
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // loadButton
            // 
            this.loadButton.AutoSize = false;
            this.loadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loadButton.Image = ((System.Drawing.Image)(resources.GetObject("loadButton.Image")));
            this.loadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(110, 36);
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.InfoText;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(10, 42);
            // 
            // speedButton
            // 
            this.speedButton.AutoSize = false;
            this.speedButton.BackColor = System.Drawing.SystemColors.Control;
            this.speedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.speedButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.speedButton.Image = ((System.Drawing.Image)(resources.GetObject("speedButton.Image")));
            this.speedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(250, 36);
            this.speedButton.Text = "Set Slide Show Speed";
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // speedInput
            // 
            this.speedInput.Name = "speedInput";
            this.speedInput.Size = new System.Drawing.Size(52, 26);
            this.speedInput.Text = "5000";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(10, 42);
            // 
            // randomButton
            // 
            this.randomButton.AutoSize = false;
            this.randomButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.randomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.randomButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.randomButton.Image = ((System.Drawing.Image)(resources.GetObject("randomButton.Image")));
            this.randomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(110, 36);
            this.randomButton.Text = "Random";
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // loopButton
            // 
            this.loopButton.AutoSize = false;
            this.loopButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loopButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loopButton.Image = ((System.Drawing.Image)(resources.GetObject("loopButton.Image")));
            this.loopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(110, 36);
            this.loopButton.Text = "Loop";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(20, 42);
            // 
            // toolOutput
            // 
            this.toolOutput.Name = "toolOutput";
            this.toolOutput.Size = new System.Drawing.Size(16, 23);
            this.toolOutput.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedInputNull
            // 
            this.speedInputNull.ContainerControl = this.splitContainer1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 439);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(408, 331);
            this.Name = "Form1";
            this.Text = "Slide Show";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.feedbackPanel.ResumeLayout(false);
            this.feedbackPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedInputNull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
=======
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loadButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox speedInput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton randomButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton loopButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolOutput;
        private System.Windows.Forms.Panel feedbackPanel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton speedButton;
        private System.Windows.Forms.ErrorProvider speedInputNull;
        private System.Windows.Forms.ErrorProvider errorProvider1;
<<<<<<< HEAD
        private System.Windows.Forms.ErrorProvider errorProvider2;
=======
>>>>>>> 89bf2b9484b93364800deb0ba0c1dd7624e71282
    }
}

