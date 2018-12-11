using System;

namespace AzureMapsToolkit.Common
{
    public class NameArgument : Attribute
    {
        string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public NameArgument(string name)
        {
            this.name = name;
        }
    }
}
