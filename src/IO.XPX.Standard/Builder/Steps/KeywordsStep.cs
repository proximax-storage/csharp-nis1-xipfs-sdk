using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface KeywordsStep<T>
    {
        T keywords(string keywords);
    }
}
