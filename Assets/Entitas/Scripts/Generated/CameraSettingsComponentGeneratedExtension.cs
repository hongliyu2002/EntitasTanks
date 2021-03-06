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
        public CameraSettingsComponent cameraSettings { get { return (CameraSettingsComponent)GetComponent(ComponentIds.CameraSettings); } }

        public bool hasCameraSettings { get { return HasComponent(ComponentIds.CameraSettings); } }

        public Entity AddCameraSettings(float newDampTime, float newScreenEdgeBuffer, float newMinSize) {
            var component = CreateComponent<CameraSettingsComponent>(ComponentIds.CameraSettings);
            component.dampTime = newDampTime;
            component.screenEdgeBuffer = newScreenEdgeBuffer;
            component.minSize = newMinSize;
            return AddComponent(ComponentIds.CameraSettings, component);
        }

        public Entity ReplaceCameraSettings(float newDampTime, float newScreenEdgeBuffer, float newMinSize) {
            var component = CreateComponent<CameraSettingsComponent>(ComponentIds.CameraSettings);
            component.dampTime = newDampTime;
            component.screenEdgeBuffer = newScreenEdgeBuffer;
            component.minSize = newMinSize;
            ReplaceComponent(ComponentIds.CameraSettings, component);
            return this;
        }

        public Entity RemoveCameraSettings() {
            return RemoveComponent(ComponentIds.CameraSettings);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherCameraSettings;

        public static IMatcher CameraSettings {
            get {
                if (_matcherCameraSettings == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.CameraSettings);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherCameraSettings = matcher;
                }

                return _matcherCameraSettings;
            }
        }
    }
}
