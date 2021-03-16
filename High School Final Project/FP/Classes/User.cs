using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public static class User
    {
        public static bool loggedIn;
        public static int index;
        public static string userName;
        public static string passWord;
        public static string firstName;
        public static string lastName;
        public static int[] scores;
        public static int avatar;

        public static void init(string[] input)
        {
            index = int.Parse(input[0]);
            userName = input[1];
            passWord = input[2];
            firstName = input[3];
            lastName = input[4];
            avatar = int.Parse(input[6]);
            string[] tempScores = input[5].Split(',');
            scores = new int[tempScores.Length];
            for (int i = 0; i < tempScores.Length; i++) scores[i] = int.Parse(tempScores[i]);
            loggedIn = true;
        }





        public static void logout()
        {
            index = -1;
            userName = null;
            passWord = null;
            firstName = null;
            lastName = null;
            scores = null;
            avatar = 0;
            loggedIn = false;
        }
    }
}
