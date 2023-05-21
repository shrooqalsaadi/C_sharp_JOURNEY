using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Indexer
{
    internal class phoneBook
    {

        public string[] Name;
        public string[] Number;
        public int size;
        int counter = 0;

        public phoneBook(int size)
        {
            this.size = size;
            this.Name = new string[this.size];
            this.Number = new string[this.size];

        }

        public string this[int idx, string Name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (this.Name[i] == Name)
                    {
                        return this.Number[i];
                    }
                }
                return "NOOOOOT THERE";

            }
            set
            {
                Number[idx] = value;
                this.Name[idx] = Name;

            }
        }
            public string this[string Name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (this.Name[i] == Name)
                    {
                        return this.Number[i];
                    }
                }
                return "NOOOOOT THERE";

            }
        }
            public void setValues(int index, string name, string numbers)
        {
            //validation
            if ((index > 0) && (index < size) && (index > counter))
            {
                this.Number[index] = numbers;
                this.Name[index] = name;
                counter++;
            }
        }

        public string getValue(string name)
        {
            //? for check
            for (int i = 0; i < name?.Length; i++)
            {
                if (this.Name[i] == name)
                {
                    return Number[i];
                }


            }
            return "not found";

        }

    }


}

