using System;
using System.Collections;
using System.IO;


namespace Adai46
{
    class Rating 
    {
        private static string _pathToFile;   
        private static string _caption;

        Hashtable hashtable = new Hashtable();

        public Rating(string fromFile, string item)
        {
            _pathToFile = fromFile;
            _caption = item;
            ToHashtable();
        }

        private void ToHashtable()
        {
            StreamReader file = new StreamReader(_pathToFile);
            string str = "";
            while ((str = file.ReadLine()) != null)
            {
                string[] half = StringSpacer(str);
                hashtable.Add(half[0], half[1]);
            }
        }

        private string[] StringSpacer(string str)
        {
            return str.Split(new char[] { '\t' });
        }

        private bool IsHaveThisItem()
        {
            return hashtable.ContainsKey(_caption);           
        }     

        public double GetRating()
        {
            if (IsHaveThisItem() == true)
            {
                return Convert.ToDouble(hashtable[_caption]);
            }  
            return 0;
        }

    }
}
