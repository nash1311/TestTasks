namespace ConsoleAppPhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Phone
    {
        private static char[][] _keyBoard = new List<char[]>
           {
               new []{' '},            //0
               new []{_empty},         //1
               new []{'a','b','c'},    //2    
               new []{'d','e','f'},    //3
               new []{'g','h','i'},    //4
               new []{'j','k','l'},    //5
               new []{'m','n','o'},    //6
               new []{'p','q','r','s'},//7
               new []{'t','u','v'},    //8
               new []{'w','x','y','z' }//9
           }.ToArray();

        private const char _delete = '*';
        private const char _send = '#';
        private const char _delay = ' ';
        private const char _empty = default(char);

        public static string ConvertToText(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            var someString = new StringBuilder(input);
            var result = new StringBuilder();
            char current;
            char? previous = null;
            var together = 0;

            for (int i = 0; i < someString.Length; i++)
            {
                current = someString[i];

                switch (current)
                {
                    case _send:
                        goto Result;
                    case _delay:
                        together = 0;
                        previous = null;
                        continue;
                    case _delete:
                        together = 0;
                        previous = null;
                        result.Remove(result.Length - 1, 1);
                        continue;
                }
                if (previous.HasValue && previous == current)
                {
                    together++;
                    result.Remove(result.Length - 1, 1);
                }
                else
                {
                    together = 0;
                }

                var valueRange = _keyBoard[Convert.ToInt32(current.ToString())];
                var value = valueRange[together % valueRange.Length];
                if (value == _empty)
                {
                    previous = null;
                    continue;
                }
                previous = current;
                result.Append(value);
            }
            Result:
            return result.ToString();
        }
    }
}
