using NLog;
using System;
using System.Collections;
using System.IO;


namespace Adai46
{
    class Rating 
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static string _pathToFile;   // Путь к файул
        private static string _caption;      // То, с чем сравнивать

        Hashtable hashtable = new Hashtable();

        public Rating(string fromFile, string item)
        {
            _pathToFile = fromFile;
            _caption = item;
            ToHashtable();
        }

        // Запись в хештаблицу
        private void ToHashtable()
        {
            StreamReader file = new StreamReader(_pathToFile);
            string str = "";
            while ((str = file.ReadLine()) != null)
            {
                string[] half = StringSpacer(str);
                hashtable.Add(half[0], half[1]);
            }
            logger.Debug("Add date to hashtable");
        }

        // Разделяем на Key/Value по символу "\t"
        private string[] StringSpacer(string str)
        {
            return str.Split(new char[] { '\t' });
        }

        // Поиск объекта (cpu/gpu) в хештаблице
        private bool IsHaveThisItem()
        {
            return hashtable.ContainsKey(_caption);           
        }     

        // Если объект существует, возвращаем его значение
        // Если нет, возвращаем 0
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
