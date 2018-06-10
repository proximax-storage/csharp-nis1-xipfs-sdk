using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IO.XPX.Standard.Models
{
    public class  NemMessageType
    {
        public enum eNemMessageType
        {
            PLAIN,
            SECURE
        }

        private int value;

        NemMessageType(int value)
        {
            this.value = value;
        }

        public int getValue()
        {
            return value;
        }

        public static eNemMessageType fromInt(int type)
        {
            return (eNemMessageType)type;
        }
    }
}
