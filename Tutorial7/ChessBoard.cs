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
            Pawn pFrom;
            Pawn pTo;
            board.TryGetValue(from, out pFrom);
            
            board.Remove(from);
            board.Remove(to);
            board.Add(to, pFrom);
            pFrom.moved();
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
