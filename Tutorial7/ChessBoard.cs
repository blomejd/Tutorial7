using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial7
{
    public class ChessBoard
    {
        Dictionary<Tuple<char, int>, Pawn> board;
        public ChessBoard()
        {
            board = new Dictionary<Tuple<char, int>, Pawn>();
        }

        public void placePiece(Pawn p, Tuple<char, int> loc)
        {
            board.Add(loc, p);
        }

        public void movePiece(Tuple<char, int> from, Tuple<char, int> to)
        {
            int forward1 = 1;
            int forward2 = 2;
            string otherColor;
            Pawn pFrom;
            board.TryGetValue(from, out pFrom);
            if (pFrom == null)
            {
                return;
            } else if (pFrom.color.Equals("black"))
            {
                forward1 = -1;
                forward2 = -2;
                otherColor = "white";
            } else // It is white
            {
                forward1 = 1;
                forward2 = 2;
                otherColor = "black";
            }
            int verticalDist = to.Item2 - from.Item2;
            int horizontalDist = (int)from.Item1 - (int)to.Item1;
            // Move is not within one or two spaces
            if (verticalDist > forward2 || verticalDist < forward1)
            {
                return;
            }
            else if (!from.Item1.Equals(to.Item1)) // Same column
            {
                if (Math.Abs(horizontalDist) > 1)
                {
                    return;
                }
                else if (verticalDist != forward1)
                {
                    return;
                }
                else {
                    Pawn toPawn;
                    board.TryGetValue(to, out toPawn);
                    if (toPawn == null || !toPawn.color.Equals(otherColor))
                    {
                        return;
                    }
                }
            }
            if (verticalDist == forward2)
            {
                if (pFrom.hasMoved())
                {
                    return;
                } else if (board.Keys.Contains(new Tuple<char, int>(from.Item1, from.Item2 + forward1)))
                {
                    return;
                }
            }

            board.Remove(from);
            board.Remove(to);
            board.Add(to, pFrom);
            pFrom.moved();
        }

        public Pawn GetPieceAt(char x, int y)
        {
            Pawn p = null;
            board.TryGetValue(new Tuple<char, int>(x, y), out p);
            return p;
        }

        public Tuple<char, int> getLocation(Pawn p)
        {
            Pawn pout;
            foreach (Tuple<char, int> t in board.Keys)
            {
                board.TryGetValue(t, out pout);
                if (p.Equals(pout))
                {
                    return t;
                }
            }
            return null;
        }
    }
}
