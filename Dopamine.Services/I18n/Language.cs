﻿using System.Collections.Generic;

namespace Dopamine.Services.I18n
{
    public class Language
    {
        private string code;
        private string name;
        private Dictionary<string, string> texts;

        public string Code
        {
            get => this.code;
            set => this.code = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public Dictionary<string, string> Texts
        {
            get => this.texts;
            set => this.texts = value;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            return this.Code.Equals(((Language)obj).Code);
        }

        public override int GetHashCode()
        {
            return this.Code.GetHashCode();
        }
    }
}
