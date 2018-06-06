using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface CommonUploadBuildSteps<T> : 
        KeywordsStep<T>, MetaDataStep<T>, MosiacsStep<T>, PrivacyStrategyUploadStep<T> 
    {

    }
}
