using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviutlExEditObjects;
public static class IOExtensions
{
    static IOExtensions()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }

    public static void Write(this ExEditObject exo, string path)
    {
        File.WriteAllText(path, exo.Serialize(), Encoding.GetEncoding("Shift_JIS"));
    }
}
