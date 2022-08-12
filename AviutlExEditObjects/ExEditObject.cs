using System;

namespace AviutlExEditObjects;
public record ExEditObject(int Width, int Height, int FPS, int Scale, int Length, int AudioRate, byte AudioCh)
{
    private readonly List<ExEditElement> _elements = new();
    public IEnumerable<ExEditElement> Elements => _elements;

    public string Serialize() => $"""
        [exedit]
        width={Width}
        height={Height}
        rate={FPS}
        scale={Scale}
        length={Length}
        audio_rate={AudioRate}
        audio_ch={AudioCh}
        {string.Join("", Elements.Select((p, i) => p.Serialize(i)))}

        """;
}
