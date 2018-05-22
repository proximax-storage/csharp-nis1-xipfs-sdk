using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Models
{
    public class GenericResponse<T> where T : class
    {
        public T Result { get; set; }
        public string ErrorMessage { get; set; }
    }
}
