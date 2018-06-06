using System;
using System.Collections.Generic;
using System.Text;
using CSharp2nem.Model.Transfer.Mosaics;

namespace IO.XPX.Standard.Builder.Steps
{
    interface MosiacsStep<T>
    {
        T mosiacs(Mosaic mosaics);
    }
}
