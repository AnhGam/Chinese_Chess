namespace CoTuong
{
    partial class GameForm
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
            Board = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Board).BeginInit();
            SuspendLayout();
            // 
            // Board
            // 
            Board.Image = Properties.Resources.XiangquiBoard;
            Board.Location = new Point(22, 12);
            Board.Name = "Board";
            Board.Size = new Size(800, 884);
            Board.TabIndex = 0;
            Board.TabStop = false;
            Board.Click += Board_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 908);
            Controls.Add(Board);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            ((System.ComponentModel.ISupportInitialize)Board).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Board;
    }
}