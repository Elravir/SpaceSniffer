namespace SpaceSniffer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            HardDiskComboBox = new ComboBox();
            startButton = new Button();
            stopButton = new Button();
            treeView1 = new TreeView();
            uiLogsTextBox = new TextBox();
            SuspendLayout();
            // 
            // HardDiskComboBox
            // 
            HardDiskComboBox.FormattingEnabled = true;
            HardDiskComboBox.Location = new Point(42, 16);
            HardDiskComboBox.Name = "HardDiskComboBox";
            HardDiskComboBox.Size = new Size(267, 28);
            HardDiskComboBox.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(45, 72);
            startButton.Name = "startButton";
            startButton.Size = new Size(264, 29);
            startButton.TabIndex = 1;
            startButton.Text = "start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(45, 130);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(264, 29);
            stopButton.TabIndex = 2;
            stopButton.Text = "stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView1.Location = new Point(331, 17);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(405, 441);
            treeView1.TabIndex = 3;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            // 
            // uiLogsTextBox
            // 
            uiLogsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiLogsTextBox.Location = new Point(45, 201);
            uiLogsTextBox.Multiline = true;
            uiLogsTextBox.Name = "uiLogsTextBox";
            uiLogsTextBox.ScrollBars = ScrollBars.Vertical;
            uiLogsTextBox.Size = new Size(264, 257);
            uiLogsTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 470);
            Controls.Add(uiLogsTextBox);
            Controls.Add(treeView1);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(HardDiskComboBox);
            Name = "MainForm";
            Text = "SpaceSnoop";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox HardDiskComboBox;
        private Button startButton;
        private Button stopButton;
        private TreeView treeView1;
        private TextBox uiLogsTextBox;
    }
}
