using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa4_TicTacToe
{
    public class Player
    {

        public string Name { get; set; }

        public bool GetIsNameentered()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}
