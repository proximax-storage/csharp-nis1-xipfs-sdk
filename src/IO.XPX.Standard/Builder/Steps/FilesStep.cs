using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IO.XPX.Standard.Builder.Steps
{
    interface FilesStep<T>
    {
        T addFiles(File files);

        T addFiles(List<File> files);

        T addFile(File file);
    }
}
