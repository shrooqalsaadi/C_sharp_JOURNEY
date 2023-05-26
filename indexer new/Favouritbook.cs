using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace indexer_new
{
    internal class Favouritbook
    {
        private string[] bookname;
        private string[] Author;
        private int Len;


        public Favouritbook(int Len)
        {
            this.Len = Len;
            bookname = new string[Len];
            Author = new string[Len];

        }

        public string this[int indexer, string Name]

        {
            set {
                bookname[indexer] = Name;
                Author[indexer] = value;


            }


            get
            {
                string res = $"This is book Name :{bookname[indexer]} The Author Name : {Author[indexer]} ";
                return res;
            }


        }
        public string this[string name]
        {
            get
            {
                for (int i = 0; i < this.bookname.Length; i++)
                {
                    if (this.bookname[i] == name)
                        return $"{bookname[i]} {Author[i]}";
                }
                return "Not Found";
            }
        }

    }
    }

