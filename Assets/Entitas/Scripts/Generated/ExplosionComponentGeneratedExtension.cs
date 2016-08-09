//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        static readonly ExplosionComponent explosionComponent = new ExplosionComponent();

        public bool isExplosion {
            get { return HasComponent(ComponentIds.Explosion); }
            set {
                if (value != isExplosion) {
                    if (value) {
                        AddComponent(ComponentIds.Explosion, explosionComponent);
                    } else {
                        RemoveComponent(ComponentIds.Explosion);
                    }
                }
            }
        }

        public Entity IsExplosion(bool value) {
            isExplosion = value;
            return this;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherExplosion;

        public static IMatcher Explosion {
            get {
                if (_matcherExplosion == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Explosion);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherExplosion = matcher;
                }

                return _matcherExplosion;
            }
        }
    }
}
