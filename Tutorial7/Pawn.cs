using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial7
{
    public class Pawn
    {
        public string color;
        public bool pawnMoved;
        public Pawn(string color)
        {
            this.color = color;
            pawnMoved = false;
        }

        public bool isCaptured()
        {
            return true;
        }

        public bool hasMoved()
        {
            return pawnMoved;
        }

        public void moved()
        {
            pawnMoved = true;
        }
    }
}
