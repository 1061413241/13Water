using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13water
{
    class BattleDetailInfo
    {
        public int battle_id { get; set; }
        public long timestamp { get; set; }
        public int player_id { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public string[] card { get; set; }
        public string cardStr { get; set; }
    }
}
