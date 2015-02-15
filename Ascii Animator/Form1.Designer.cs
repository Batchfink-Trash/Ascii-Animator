﻿namespace Ascii_Animator
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.frameSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FpsBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.frameEditor = new System.Windows.Forms.TextBox();
            this.playLbl = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playButton = new System.Windows.Forms.Button();
            this.fpsClock = new System.Windows.Forms.Timer(this.components);
            this.frameBck = new System.Windows.Forms.Button();
            this.frameFwd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.frameSelector);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.FpsBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(433, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 72);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frame: ";
            // 
            // frameSelector
            // 
            this.frameSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frameSelector.FormattingEnabled = true;
            this.frameSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.frameSelector.Location = new System.Drawing.Point(65, 3);
            this.frameSelector.Name = "frameSelector";
            this.frameSelector.Size = new System.Drawing.Size(121, 24);
            this.frameSelector.TabIndex = 4;
            this.frameSelector.SelectedIndexChanged += new System.EventHandler(this.frameSelector_SelectedIndexChanged);
            this.frameSelector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frameSelector_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "FPS:    ";
            // 
            // FpsBox
            // 
            this.FpsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FpsBox.FormattingEnabled = true;
            this.FpsBox.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.FpsBox.Location = new System.Drawing.Point(63, 33);
            this.FpsBox.Name = "FpsBox";
            this.FpsBox.Size = new System.Drawing.Size(123, 24);
            this.FpsBox.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.frameEditor);
            this.flowLayoutPanel2.Controls.Add(this.playLbl);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(414, 305);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // frameEditor
            // 
            this.frameEditor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameEditor.Location = new System.Drawing.Point(3, 3);
            this.frameEditor.Multiline = true;
            this.frameEditor.Name = "frameEditor";
            this.frameEditor.Size = new System.Drawing.Size(397, 145);
            this.frameEditor.TabIndex = 1;
            // 
            // playLbl
            // 
            this.playLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLbl.Location = new System.Drawing.Point(3, 151);
            this.playLbl.Name = "playLbl";
            this.playLbl.Size = new System.Drawing.Size(397, 135);
            this.playLbl.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrip,
            this.editStrip,
            this.helpStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(682, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(44, 24);
            this.fileStrip.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // editStrip
            // 
            this.editStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.clearFrameToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.editStrip.Name = "editStrip";
            this.editStrip.Size = new System.Drawing.Size(47, 24);
            this.editStrip.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // clearFrameToolStripMenuItem
            // 
            this.clearFrameToolStripMenuItem.Name = "clearFrameToolStripMenuItem";
            this.clearFrameToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.clearFrameToolStripMenuItem.Text = "Clear Frame";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // helpStrip
            // 
            this.helpStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpStrip.Name = "helpStrip";
            this.helpStrip.Size = new System.Drawing.Size(53, 24);
            this.helpStrip.Text = "Help";
            // 
            // openHelpToolStripMenuItem
            // 
            this.openHelpToolStripMenuItem.Name = "openHelpToolStripMenuItem";
            this.openHelpToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.openHelpToolStripMenuItem.Text = "Open Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(433, 117);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(218, 27);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // fpsClock
            // 
            this.fpsClock.Tick += new System.EventHandler(this.fpsClock_Tick);
            // 
            // frameBck
            // 
            this.frameBck.Location = new System.Drawing.Point(433, 150);
            this.frameBck.Name = "frameBck";
            this.frameBck.Size = new System.Drawing.Size(105, 23);
            this.frameBck.TabIndex = 2;
            this.frameBck.Text = "<<";
            this.frameBck.UseVisualStyleBackColor = true;
            this.frameBck.Click += new System.EventHandler(this.frameBck_Click);
            // 
            // frameFwd
            // 
            this.frameFwd.Location = new System.Drawing.Point(541, 150);
            this.frameFwd.Name = "frameFwd";
            this.frameFwd.Size = new System.Drawing.Size(105, 23);
            this.frameFwd.TabIndex = 3;
            this.frameFwd.Text = ">>";
            this.frameFwd.UseVisualStyleBackColor = true;
            this.frameFwd.Click += new System.EventHandler(this.frameFwd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.frameFwd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.frameBck;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.frameFwd);
            this.Controls.Add(this.frameBck);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ascii Animator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox frameSelector;
        private System.Windows.Forms.TextBox frameEditor;
        private System.Windows.Forms.Label playLbl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStrip;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStrip;
        private System.Windows.Forms.ToolStripMenuItem openHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FpsBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Timer fpsClock;
        private System.Windows.Forms.Button frameBck;
        private System.Windows.Forms.Button frameFwd;
    }
}
