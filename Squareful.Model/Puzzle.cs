namespace Squareful.Model
{
    /// <summary>
    /// A Puzzle is a particular Board and a list of Squares that are shrouded
    /// </summary>
    public class Puzzle
    {
        public int PuzzleID { get; private set; }
        public DateTime Published { get; set; }

        // The board doesn't contain much data, so duplicate it within Puzzle to keep things simple
        public int BoardID { get; set; }
        public string Sequence { get; set; } = string.Empty;

        public List<Square> Shroud { get; set; } = new();
    }
}
