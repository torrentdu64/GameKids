using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKids
{
    class  User
    {
        private string userID;
        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private string schoolYear;
        private string teacherName;
        public static List<User> listUsers = new List<User>();

        private string score;
        private string level;
        private string gameOperation;
        private string datePlayed;

        // Use a single digit in case user is in year 1
        //Use single or double digits in case user is in year 2 and 3
        //Use double or triple digits in case user is in year 3 and 4

      

        public string getScore()
        {
            return this.score;
        }

        public void settScore(string score)
        {
             this.score = score;
        }

        public string getLevel()
        {
            return this.level;
        }

        public void setLevel(string level)
        {
             this.level = level;
        }

        public string getGameOperation()
        {
            return this.gameOperation;
        }

        public void setGameOperation(string gameOperation)
        {
            this.gameOperation = gameOperation;
        }

        public string getDatePlayed()
        {
            return this.datePlayed;
        }

        public void setDatePlayed(string datePlayed)
        {
             this.datePlayed = datePlayed;
        }


        public User(string firstName, string lastName , string userName, string password, string schoolYear, string teacherName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.schoolYear = schoolYear;
            this.teacherName = teacherName;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getSchoolYear()
        {
            return this.schoolYear;
        }

        public string getTeacherName()
        {
            return this.teacherName;
        }

        public string getUserID()
        {
            return this.userID;
        }

        public void setFirstName(string firstname)
        {
            this.firstName = firstname;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void getUserName(string userName)
        {
            this.userName = userName;
        }

        public void setPassword(string password)
        {
           this.password = password;
        }

        public void setSchoolYear(string schooldYear)
        {
             this.schoolYear = schooldYear;
        }

        public void setTeacherName(string teacherName)
        {
             this.teacherName = teacherName;
        }

        public void getUserID( string userID)
        {
             this.userID = userID;
        }



    }
}
