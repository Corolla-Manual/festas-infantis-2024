﻿namespace FestasInfantis.WinApp
{
    partial class Logo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logo));
            wmVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)wmVideo).BeginInit();
            SuspendLayout();
            // 
            // wmVideo
            // 
            wmVideo.Enabled = true;
            wmVideo.Location = new Point(-3, -4);
            wmVideo.Name = "wmVideo";
            wmVideo.OcxState = (AxHost.State)resources.GetObject("wmVideo.OcxState");
            wmVideo.Size = new Size(806, 457);
            wmVideo.TabIndex = 0;
            wmVideo.PlayStateChange += wmVideo_PlayStateChange;
            // 
            // Logo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wmVideo);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Logo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)wmVideo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmVideo;
    }
}