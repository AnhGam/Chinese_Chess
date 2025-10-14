namespace CoTuong.Models
{
    public class ChessPiece
    {
        public string ?Name { get; set; }
        public PieceType Type { get; set; }
        public bool IsRed { get; set; }
        public Image ?Image { get; set; }
        public Point Position { get; set; }
    }
}
