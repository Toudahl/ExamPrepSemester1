using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XMLAndPersistence
{
    [Serializable]
    public class PersonModel
    {
        private string _name;
        private byte _age;
        private string _gender;

        public PersonModel()
        {
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public override string ToString()
        {
            return "Hi, my name is " + Name + ", my gender is " + Gender + " and i am " + Age + " old.";
        }

    }
}
