using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions
{
    internal struct PhoneNoteBook
    {
        #region Attributes
        private string[]? Names;
        private int[]? Numbers;
        public int Size { get; private set; }
        #endregion
        #region Constructors
        public PhoneNoteBook(int size)
        {
            Size = size;
            Names = new string[size];
            Numbers = new int[size];
        }
        #endregion
        #region Methods
        public void AddPerson(int pos, string name, int number)
        {
            if(Names == null || Numbers == null)
            {
                throw new InvalidOperationException("PhoneNoteBook is not initialized.");
            }
            if (pos < 0 || pos >= Size)
            {
                throw new ArgumentOutOfRangeException(nameof(pos), "Position is out of range.");
            }
            if(name == null)
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            }
            Names[pos] = name;
            Numbers[pos] = number;
            
        }

        #endregion
        #region Getters and Setters
        public int GetNumber(string name)
        {
            if (Names == null || Numbers == null)
            {
                throw new InvalidOperationException("PhoneNoteBook is not initialized.");
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            }
            for (int i = 0; i < Size; i++)
            {
                if (Names[i] == name)
                {
                    return Numbers[i];
                }
            }
            throw new KeyNotFoundException($"Name '{name}' not found in PhoneNoteBook.");
        }

        public void SetNumber(string name, int number)
        {
            if (Names == null || Numbers == null)
            {
                throw new InvalidOperationException("PhoneNoteBook is not initialized.");
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            }
            for (int i = 0; i < Size; i++)
            {
                if (Names[i] == name)
                {
                    Numbers[i] = number;
                    return;
                }
            }
            throw new KeyNotFoundException($"Name '{name}' not found in PhoneNoteBook.");
        }

        #endregion
        #region indexer
        public int this[string name]
        {
            get => GetNumber(name);
            //set => SetNumber(name, value);

            set
            {
                if (Names == null || Numbers == null)
                {
                    throw new InvalidOperationException("PhoneNoteBook is not initialized.");
                }
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name), "Name cannot be null.");
                }
                for (int i = 0; i < Size; i++)
                {
                    if (Names[i] == name)
                    {
                        Numbers[i] = value;
                        return;
                    }
                }
                throw new KeyNotFoundException($"Name '{name}' not found in PhoneNoteBook.");
            }
        }
        
        public string this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= Size)
                {
                    throw new ArgumentOutOfRangeException(nameof(pos), "Position is out of range.");
                }
                return $"{Names?[pos]}: {Numbers?[pos]}";
            }
        }
        #endregion
    }
}
