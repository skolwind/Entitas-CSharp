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

    static IMatcher<GameEntity> _matcherVector3;

    public static IMatcher<GameEntity> Vector3 {
        get {
            if(_matcherVector3 == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.Vector3);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherVector3 = matcher;
            }

            return _matcherVector3;
        }
    }
}
