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

    static IMatcher<TestEntity> _matcherCustomPrefixFlag;

    public static IMatcher<TestEntity> CustomPrefixFlag {
        get {
            if(_matcherCustomPrefixFlag == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentsLookup.CustomPrefixFlag);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherCustomPrefixFlag = matcher;
            }

            return _matcherCustomPrefixFlag;
        }
    }
}
