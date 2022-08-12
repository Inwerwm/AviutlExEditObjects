using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviutlExEditObjects.ExEditProperties;
public record ExoStandardPlay(float Volume, float Side) : IExEditProperty
{
    public static string Name => "標準再生";

    public string Serialize() => $"""
        _name={Name}
        音量={Volume}
        左右={Side}

        """;
}
