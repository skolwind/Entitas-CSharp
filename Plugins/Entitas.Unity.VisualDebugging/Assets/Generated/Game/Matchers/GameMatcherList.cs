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

    static IMatcher<GameEntity> _matcherList;

    public static IMatcher<GameEntity> List {
        get {
            if(_matcherList == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.List);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherList = matcher;
            }

            return _matcherList;
        }
    }
}