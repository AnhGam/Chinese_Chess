using CoTuong.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    public partial class GameForm : Form
    {
        private List<ChessPiece> pieces = new();
        public GameForm()
        {
            InitializeComponent();
        }

        private void Board_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

            pieces.Add(new ChessPiece
            {
                Name = "red_general",
                Type = PieceType.General,
                IsRed = true,
                Image = Image.FromFile(GetImagePath("red_general.png")),
                Position = new Point(397, 797)
            });

            pieces.Add(new ChessPiece
            {
                Name = "black_general",
                Type = PieceType.General,
                IsRed = false,
                Image = Image.FromFile(GetImagePath("black_general.png")),
                Position = new Point(397, 80)
            });

            Board.Paint += Board_Paint;
        }
        private string GetImagePath(string filename)
        {
            string? basePath = Directory.GetParent(Application.StartupPath)?.Parent?.Parent?.Parent?.FullName;
            return Path.Combine(basePath ?? "", "Resources", filename);
        }
        private void Board_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (var p in pieces)
            {
                if (p.Image == null) continue;
                int size = 60;
                g.DrawImage(p.Image,
                    p.Position.X - size / 2,
                    p.Position.Y - size / 2,
                    size, size);
            }
        }

    }
}
