using System;
using System.Collections.Generic;
using System.Text;

namespace signature
{
    public interface IStorage
    {
        string SaveImage(byte[] byteData);

    }
}
