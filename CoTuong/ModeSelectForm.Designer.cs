namespace CoTuong
{
    partial class ModeSelectForm
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
        private void InitializeComponent()
        {
            ModeBack = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ModeBack
            // 
            ModeBack.Location = new Point(346, 286);
            ModeBack.Name = "ModeBack";
            ModeBack.Size = new Size(94, 29);
            ModeBack.TabIndex = 0;
            ModeBack.Text = "Back";
            ModeBack.UseVisualStyleBackColor = true;
            ModeBack.Click += ModeBack_Click;
            // 
            // button1
            // 
            button1.Location = new Point(318, 123);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 1;
            button1.Text = "game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ModeSelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ModeBack);
            Name = "ModeSelectForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ModeBack;
        private Button button1;
    }
}
