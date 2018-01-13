using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    public class CountLetters
    {
        #region PRIVATE MEMBERS
        StreamReader _textFile;
        string _line;
        bool _success = false;
        SortedDictionary<char, int> _charCounter;
        #endregion

        #region CONSTRUCTION/DESTRUCTION
        public CountLetters(string fileName)
        {
            _charCounter = new SortedDictionary<char, int>();
            _textFile = new StreamReader(fileName);
            _success = countChars();
        }

        ~CountLetters()
        {
            _charCounter?.Clear();
            _charCounter = null;
        }


        #endregion CONSTRUCTION/DESTRUCTION

        bool countChars()
        {
            bool success = true;
            try
            {
                while ((_line = _textFile.ReadLine()) != null)
                {
                    foreach (char ch in _line)
                    {
                        if (_charCounter.ContainsKey(ch))
                        {
                            _charCounter[ch]++;
                        }
                        else
                        {
                            _charCounter.Add(ch, 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                success = false;
                throw new Exception("CountLetters.countChars(): " + ex.Message);
            }
            return success;
        }

        #region PUBLIC ACCESS
        public SortedDictionary<char, int> SortedCharacterCount
        {
            get { return _charCounter; }
        }

        public bool Success
        {
            get { return _success; }
        }
        #endregion PUBLIC ACCESS
    }
}
