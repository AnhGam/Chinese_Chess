using System;
using System.Windows.Forms;

namespace CoTuong
{
    public partial class MainMenuForm : Form
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
            Continue = new Button();
            newgame = new Button();
            setting = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // Continue
            // 
            Continue.BackColor = SystemColors.ActiveCaption;
            Continue.Location = new Point(309, 146);
            Continue.Name = "Continue";
            Continue.Size = new Size(182, 29);
            Continue.TabIndex = 0;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // newgame
            // 
            newgame.Location = new Point(309, 181);
            newgame.Name = "newgame";
            newgame.Size = new Size(182, 29);
            newgame.TabIndex = 1;
            newgame.Text = "New game";
            newgame.UseVisualStyleBackColor = true;
            newgame.Click += newgame_Click;
            // 
            // setting
            // 
            setting.Location = new Point(309, 216);
            setting.Name = "setting";
            setting.Size = new Size(182, 29);
            setting.TabIndex = 2;
            setting.Text = "Setting";
            setting.UseVisualStyleBackColor = true;
            setting.Click += setting_Click;
            // 
            // exit
            // 
            exit.Location = new Point(309, 251);
            exit.Name = "exit";
            exit.Size = new Size(182, 29);
            exit.TabIndex = 3;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(setting);
            Controls.Add(newgame);
            Controls.Add(Continue);
            Name = "MainMenuForm";
            ResumeLayout(false);
        }

        #endregion  

        private Button Continue;
        private Button newgame;
        private Button setting;
        private Button exit;
    }
}