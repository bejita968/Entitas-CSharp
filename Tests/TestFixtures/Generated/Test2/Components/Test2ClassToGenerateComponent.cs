//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public ClassToGenerateComponent classToGenerate { get { return (ClassToGenerateComponent)GetComponent(Test2ComponentLookup.ClassToGenerate); } }
    public bool hasClassToGenerate { get { return HasComponent(Test2ComponentLookup.ClassToGenerate); } }

    public void AddClassToGenerate(My.Namespace.ClassToGenerate newValue) {
        var index = Test2ComponentLookup.ClassToGenerate;
        var component = CreateComponent<ClassToGenerateComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceClassToGenerate(My.Namespace.ClassToGenerate newValue) {
        var index = Test2ComponentLookup.ClassToGenerate;
        var component = CreateComponent<ClassToGenerateComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveClassToGenerate() {
        RemoveComponent(Test2ComponentLookup.ClassToGenerate);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity : IClassToGenerateEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher {

    static Entitas.IMatcher<Test2Entity> _matcherClassToGenerate;

    public static Entitas.IMatcher<Test2Entity> ClassToGenerate {
        get {
            if (_matcherClassToGenerate == null) {
                var matcher = (Entitas.Matcher<Test2Entity>)Entitas.Matcher<Test2Entity>.AllOf(Test2ComponentLookup.ClassToGenerate);
                matcher.componentNames = Test2ComponentLookup.componentNames;
                _matcherClassToGenerate = matcher;
            }

            return _matcherClassToGenerate;
        }
    }
}
