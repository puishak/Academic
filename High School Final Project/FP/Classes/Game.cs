using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace FP

{
    public static class Game
    {
        public static string[,] userInfo; //contains all of the user data from the User.txt file
        public static Image[] avatars = { global::FP.Properties.Resources.Avatar1, global::FP.Properties.Resources.Avatar2, global::FP.Properties.Resources.Avatar3, global::FP.Properties.Resources.Avatar4, global::FP.Properties.Resources.Avatar5, global::FP.Properties.Resources.Avatar6, global::FP.Properties.Resources.Avatar7, global::FP.Properties.Resources.Avatar8 };
        //create an array with all the images
        //Regex Patterns
        public static string regNamePattern = @"^[a-zA-Z]*$";
        public static string regUserNamePattern = @"^[\w-.]*$";
        public static string regPassPattern = @"^[^:\s]*$";


        public static void init() //this function is called once when the game is loaded, if the game is loaded for the 
                                  //first time it creates the file called Users.txt in the directory
        {
            if (!File.Exists("Users.txt")) using (var myFile = File.Create("Users.txt")) { }
            loadData();
        }


        public static void loadData() //loads the data from Users.txt and saves it in userInfo[,].
        {
            var readFile = new StreamReader("Users.txt");
            try
            {
                userInfo = new string[File.ReadAllLines("Users.txt").Length, 7];
                string[] readLine = new string[7];
                for (int i = 0; !readFile.EndOfStream; i++)
                {
                    readLine = readFile.ReadLine().Split(':');
                    for (int j = 0; j < 7; j++)
                    {
                        userInfo[i, j] = readLine[j];
                    }
                }
            }
            finally
            {
                readFile.Close();
            }
            
        }

        public static void saveData() //Saves the data from userInfo to the file Users.txt
        {
            var writeFile = new StreamWriter("Users.txt");
            try
            {
                for (int i = 0; i < userInfo.GetLength(0); i++)
                {
                    writeFile.WriteLine(userInfo[i, 0] + ":" + userInfo[i, 1] + ":" + userInfo[i, 2] + ":" + userInfo[i, 3] + ":" + userInfo[i, 4] + ":" +
                        userInfo[i, 5] + ":" + userInfo[i, 6]);
                }
            }
            finally
            {
                writeFile.Close();
            }         
        }

        public static void addUser(string userName, string pass, string firstName, string lastName, string score = "0,0,0,0", int avatar = 0) //adds an extra line to the file Users.txt with the new user information.
        {
            saveData();
            string output = userInfo.GetLength(0) + ":" + userName + ":" + pass + ":" + firstName + ":" + lastName + ":" + score + ":" + avatar; 
            using (StreamWriter writeFile = File.AppendText("Users.txt"))
            {
                writeFile.WriteLine(output);
            }            
            loadData();
        }

        public static void initUser(int index)
        {
            string[] output = new string[userInfo.GetLength(1)];
            for (int i = 0; i < output.Length; i++) output[i] = userInfo[index, i];
            User.init(output);
        }

        public static void guestUser()
        {
            string[] output = {"-1", "Guest", "", "", "", "0,0,0,0", "-1"};
            User.init(output);
            User.loggedIn = false;
        }

        public static bool regexHandler(object sender, string pattern) //handles all the regex.
        {
            var _sender = sender as TextBox;
            string input = _sender.Text;
            Match match = Regex.Match(_sender.Text, pattern);
            if (match.Success) return true;
            else return false;
        }
    }
}
