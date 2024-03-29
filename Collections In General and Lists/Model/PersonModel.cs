﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Collections_In_General_and_Lists.Model
{
    [DataContract]
    class PersonModel
    {
        [DataMember]
        private string _name;
        [DataMember]
        private byte _age;
        [DataMember]
        private Gender _gender;

        public PersonModel(Gender gender, string name, byte age)
        {
            Gender = gender;
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public byte Age
        {
            get { return _age; }
            private set { _age = value; }
        }

        public Gender Gender
        {
            get { return _gender; }
            private set { _gender = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
