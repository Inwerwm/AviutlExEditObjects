using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviutlExEditObjects;
public record ExEditElement(int Start, int End, int Layer, int Overlay, int Camera, int Audio, int Chain)
{
    private List<IExEditProperty> _properties = new();
    public IEnumerable<IExEditProperty> Properties => _properties;

    public ExEditElement(int start, int end, int layer, int overlay, int camera, int audio, int chain, IEnumerable<IExEditProperty> properties) : this(start, end, layer, overlay, camera, audio, chain)
    {
        _properties = properties.ToList();
    }
    public string Serialize(int index) => $"""
        [{index}]
        start={Start}
        end={End}
        layer={Layer}
        overlay={Overlay}
        camera={Camera}
        audio={Audio}
        chain={Chain}
        {string.Join("", Properties.Select((p, i) => $"[{index}.{i}]\r\n" + p.Serialize()))}

        """;
}
