using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    public class book
    {
        private string _name;
        public NameChangedDelegate NameChanged;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                //We want notify once the name has changed
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if(NameChanged!=null)
                    NameChanged(oldValue, _name);
                }
            }
        }

    }
}
