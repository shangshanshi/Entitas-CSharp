//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyMyEventListenerComponent anyMyEventListener { get { return (AnyMyEventListenerComponent)GetComponent(GameComponentsLookup.AnyMyEventListener); } }
    public bool hasAnyMyEventListener { get { return HasComponent(GameComponentsLookup.AnyMyEventListener); } }

    public void AddAnyMyEventListener(System.Collections.Generic.List<IAnyMyEventListener> newValue) {
        var index = GameComponentsLookup.AnyMyEventListener;
        var component = (AnyMyEventListenerComponent)CreateComponent(index, typeof(AnyMyEventListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyMyEventListener(System.Collections.Generic.List<IAnyMyEventListener> newValue) {
        var index = GameComponentsLookup.AnyMyEventListener;
        var component = (AnyMyEventListenerComponent)CreateComponent(index, typeof(AnyMyEventListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyMyEventListener() {
        RemoveComponent(GameComponentsLookup.AnyMyEventListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnyMyEventListener;

    public static Entitas.IMatcher<GameEntity> AnyMyEventListener {
        get {
            if (_matcherAnyMyEventListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyMyEventListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyMyEventListener = matcher;
            }

            return _matcherAnyMyEventListener;
        }
    }
}