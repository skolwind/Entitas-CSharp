//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class GameMatcher {

    static IMatcher<GameEntity> _matcherTexture2D;

    public static IMatcher<GameEntity> Texture2D {
        get {
            if(_matcherTexture2D == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.Texture2D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTexture2D = matcher;
            }

            return _matcherTexture2D;
        }
    }
}
