using Robust.Shared.Configuration;

namespace Content.Shared._starcup.CCVars;

/// <summary>
/// starcup specific cvars.
/// </summary>
[CVarDefs]
public sealed class scCCVars
{
    /// <summary>
    /// Toggles default movement speed.
    /// </summary>

    public static readonly CVarDef<bool> DefaultSprint =
        CVarDef.Create("interaction.defaultsprint", false, CVar.CLIENTONLY | CVar.ARCHIVE);
}
