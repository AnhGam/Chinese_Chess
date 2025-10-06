namespace CoTuong
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
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
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ModeSelectForm modeForm = new ModeSelectForm();
            modeForm.Show();
            this.Hide();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này sẽ load ván trước (chưa làm).");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở form cài đặt (âm thanh, nước đi, giao diện...)");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Continue = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // 
            // button2
            // 
            button2.Location = new Point(309, 181);
            button2.Name = "button2";
            button2.Size = new Size(182, 29);
            button2.TabIndex = 1;
            button2.Text = "New game";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(309, 216);
            button3.Name = "button3";
            button3.Size = new Size(182, 29);
            button3.TabIndex = 2;
            button3.Text = "Setting";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(309, 251);
            button4.Name = "button4";
            button4.Size = new Size(182, 29);
            button4.TabIndex = 3;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Continue);
            Name = "MainMenu";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button Continue;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}