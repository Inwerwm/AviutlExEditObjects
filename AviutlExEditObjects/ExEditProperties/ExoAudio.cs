using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviutlExEditObjects.ExEditProperties;
public record ExoAudio(float Start, float Speed, bool Loop, bool Linkage, string FilePath) : IExEditProperty
{
    public static string Name => "音声ファイル";

    public string Serialize() => $"""
        _name={Name}
        再生位置={Start}
        再生速度={Speed}
        ループ再生={(Loop ? 1 : 0)}
        動画ファイルと連携{(Linkage ? 1 : 0)}
        file={FilePath}

        """;
}
