using Squareful.Model;
using Xunit;

namespace Squareful.Tests
{
    public class TestBoard
    {
        [Fact]
        public void TestFromSequence()
        {
            // board #18,178
            var board = new Board("888666688445522333178876768555777744");

            Assert.Equal(36, board.Squares.Count);

            Assert.Equal(new Square(0, 0, 8), board.Squares[0]);
            Assert.Equal(new Square(0, 8, 8), board.Squares[1]);
            Assert.Equal(new Square(0, 16, 8), board.Squares[2]);
            Assert.Equal(new Square(0, 24, 6), board.Squares[3]);
            Assert.Equal(new Square(0, 30, 6), board.Squares[4]);

            Assert.Equal(new Square(6, 24, 6), board.Squares[5]);
            Assert.Equal(new Square(6, 30, 6), board.Squares[6]);

            Assert.Equal(new Square(32, 4, 4), board.Squares[35]);
        }

        [Fact]
        public void TestBoardFileFor()
        {
            Assert.Equal("boards-000.txt", Board.BoardFileFor(1));
            Assert.Equal("boards-000.txt", Board.BoardFileFor(100));
            Assert.Equal("boards-001.txt", Board.BoardFileFor(101));
            Assert.Equal("boards-186.txt", Board.BoardFileFor(18656));
        }

        [Fact]
        public void TestBoardFileLineNumberFor()
        {
            Assert.Equal(0, Board.BoardFileLineNumberFor(1));
            Assert.Equal(99, Board.BoardFileLineNumberFor(100));
            Assert.Equal(0, Board.BoardFileLineNumberFor(101));
        }
    }
}