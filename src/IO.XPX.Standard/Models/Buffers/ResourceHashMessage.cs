using System;
using System.Collections.Generic;
using System.Text;
using System.IO; // for bytebuffer. need to research more on this one

namespace IO.XPX.Standard.Models.Buffers
{
    public sealed class ResourceHashMessage
    {
        public static ResourceHashMessage getRootAsResourceHashMessage(byte _bb) { return getRootAsResourceHashMessage(_bb, new ResourceHashMessage()); } // need to get bytebuffer equivalent for c# hmmmm...
        public static ResourceHashMessage getRootAsResourceHashMessage(byte _bb, ResourceHashMessage obj) { return new ResourceHashMessage(); }

        public void __init(int _i, byte _bb)
        {
            //gotta do something with this bytebuffers hahaha
            int bb_pos = _i; // something like bytebuffer position at start _i
            byte bb = _bb;
        }

        public ResourceHashMessage __assign(int _i, byte _bb)
        {
            __init(_i, _bb);

            return this;
        }

        public string digest()
        {
            return string.Empty;
        }
    }
}
