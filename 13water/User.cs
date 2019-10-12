using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13water
{
    static class User
    {
        public static string token;
        public static int user_id;//用户id
        public static int battle_id;//战局id
        public static string card;

        public static int[] cardInt = new int[13];
        public static int[] first = new int[3];
        public static int[] second = new int[5];
        public static int[] third = new int[5];

        //最终转化成的有花色的牌
        public static List<string> cardFirst = new List<string>();
        public static List<string> cardSecond = new List<string>();
        public static List<string> cardThird = new List<string>();
    }
}
