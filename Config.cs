using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Core;

namespace template.src;

public class templateConfig : IBasePluginConfig
{
    [JsonPropertyName("some_field")]
    public int some_field { get; set; } = 255;
	public int Version { get; set; } = 0;
}