//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class TestMatcher {

    static IMatcher<TestEntity> _matcherClassHideInBlueprintsInspector;

    public static IMatcher<TestEntity> ClassHideInBlueprintsInspector {
        get {
            if(_matcherClassHideInBlueprintsInspector == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentsLookup.ClassHideInBlueprintsInspector);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherClassHideInBlueprintsInspector = matcher;
            }

            return _matcherClassHideInBlueprintsInspector;
        }
    }
}
