using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Domain
{
    public class GameScore
    {
        public string PlayerName { get; set; }
        public DateTime GameDate { get; set; }
        public string PlayScore { get; set; }
        public Guid LogID { get; set; }

    }
}
