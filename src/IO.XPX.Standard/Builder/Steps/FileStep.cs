using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IO.XPX.Standard.Builder.Steps
{
    interface FileStep<T>
    {
        T file(File file);
    }
}
