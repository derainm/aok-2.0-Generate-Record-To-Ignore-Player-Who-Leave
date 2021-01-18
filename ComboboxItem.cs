using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generate_Record_To_Ignore_Player_Who_Leave
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
