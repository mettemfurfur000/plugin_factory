using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Admin;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Utils;

namespace template.src;

public class template : BasePlugin, IPluginConfig<templateConfig>
{
    public override string ModuleName => "template";
    public override string ModuleVersion => "0.0.1";
    public override string ModuleAuthor => "username";
    public templateConfig Config { get; set; } = new templateConfig();
    public override void Load(bool hotReload)
    {
    }
    public override void Unload(bool hotReload)
    {
    }
    public void OnConfigParsed(templateConfig config)
    {
        Config = config;
    }

}