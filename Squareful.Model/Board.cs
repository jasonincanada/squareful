namespace Squareful.Model
{
    public class Board
    {
        public List<Square> Squares { get; private set; }

        /// <summary>
        /// Construct a board of squares tiled from top-left to bottom-right by a 36-digit sequence
        /// of square sizes
        /// </summary>
        /// <param name="sequence">A 36-digit string (not checked for malformedness other than size)</param>
        public Board(string sequence)
        {
            if (sequence.Length != 36)
                throw new ArgumentOutOfRangeException($"sequence should be 36 chars but is {sequence.Length}");

            Squares = new List<Square>();

            int[] squareSizes = sequence.ToCharArray()
                .Select(c => c - '0')
                .ToArray();

            // column levels, how far down each of the 36 columns we've filled so far
            int[] levels = new int[36];

            for (int i = 0; i < 36; i++)
                levels[i] = 0;

            foreach (var size in squareSizes)
            {
                // get the next top-left cell for this square
                int row = levels.Min();
                int col = Array.IndexOf(levels, row);

                Squares.Add(new Square(row, col, size));

                // the columns of empty space underneath the squares has grown this much smaller
                for (int i = 0; i < size; i++)
                    levels[col+i] += size;
            }
        }

        /// <summary>
        /// Return the name of the server-side file containing the board with a given ID
        /// </summary>
        /// <param name="boardID">The 1-indexed board ID from 1 to 18,656</param>
        public static string BoardFileFor(int boardID)
        {
            int chunk = (boardID - 1) / 100;
            return $"boards-{chunk:D3}.txt";
        }

        /// <summary>
        /// Return the 0-based index of the line within the board file
        /// </summary>
        /// <param name="boardID">The 1-indexed board ID from 1 to 18,656</param>
        public static int BoardFileLineNumberFor(int boardID)
        {
            return (boardID - 1) % 100;
        }
    }
}
