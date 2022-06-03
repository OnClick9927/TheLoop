#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass), TutorialDerivedClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ICalc), TutorialICalcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClassExtensions), TutorialDerivedClassExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaField), IFrameworkHotfixLuaLuaFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaBehaviour), IFrameworkHotfixLuaLuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass.TestEnumInner), TutorialDerivedClassTestEnumInnerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.StateMachineBehaviour), UnityEngineStateMachineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animation), UnityEngineAnimationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationState), UnityEngineAnimationStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationEvent), UnityEngineAnimationEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorClipInfo), UnityEngineAnimatorClipInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorStateInfo), UnityEngineAnimatorStateInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorTransitionInfo), UnityEngineAnimatorTransitionInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MatchTargetWeightMask), UnityEngineMatchTargetWeightMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorControllerParameter), UnityEngineAnimatorControllerParameterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorOverrideController), UnityEngineAnimatorOverrideControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorUtility), UnityEngineAnimatorUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Avatar), UnityEngineAvatarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkeletonBone), UnityEngineSkeletonBoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanLimit), UnityEngineHumanLimitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanBone), UnityEngineHumanBoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanDescription), UnityEngineHumanDescriptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AvatarBuilder), UnityEngineAvatarBuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AvatarMask), UnityEngineAvatarMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanPose), UnityEngineHumanPoseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanPoseHandler), UnityEngineHumanPoseHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanTrait), UnityEngineHumanTraitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RuntimeAnimatorController), UnityEngineRuntimeAnimatorControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngineAssetBundleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleCreateRequest), UnityEngineAssetBundleCreateRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleManifest), UnityEngineAssetBundleManifestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleRecompressOperation), UnityEngineAssetBundleRecompressOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleRequest), UnityEngineAssetBundleRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BuildCompression), UnityEngineBuildCompressionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioLowPassFilter), UnityEngineAudioLowPassFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioHighPassFilter), UnityEngineAudioHighPassFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioReverbFilter), UnityEngineAudioReverbFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioConfiguration), UnityEngineAudioConfigurationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioBehaviour), UnityEngineAudioBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioListener), UnityEngineAudioListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioReverbZone), UnityEngineAudioReverbZoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioDistortionFilter), UnityEngineAudioDistortionFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioEchoFilter), UnityEngineAudioEchoFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioChorusFilter), UnityEngineAudioChorusFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Microphone), UnityEngineMicrophoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioRenderer), UnityEngineAudioRendererWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.WebCamDevice), UnityEngineWebCamDeviceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WebCamTexture), UnityEngineWebCamTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ClothSphereColliderPair), UnityEngineClothSphereColliderPairWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ClothSkinningCoefficient), UnityEngineClothSkinningCoefficientWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Cloth), UnityEngineClothWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ClusterSerialization), UnityEngineClusterSerializationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SortingLayer), UnityEngineSortingLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CachedAssetBundle), UnityEngineCachedAssetBundleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Cache), UnityEngineCacheWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Camera), UnityEngineCameraWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoundingSphere), UnityEngineBoundingSphereWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CullingGroupEvent), UnityEngineCullingGroupEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CullingGroup), UnityEngineCullingGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FlareLayer), UnityEngineFlareLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ReflectionProbe), UnityEngineReflectionProbeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CloudStreaming), UnityEngineCloudStreamingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CrashReport), UnityEngineCrashReportWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ExposedPropertyResolver), UnityEngineExposedPropertyResolverWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoundsInt), UnityEngineBoundsIntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GeometryUtility), UnityEngineGeometryUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Plane), UnityEnginePlaneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectInt), UnityEngineRectIntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectOffset), UnityEngineRectOffsetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.DynamicGI), UnityEngineDynamicGIWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BillboardAsset), UnityEngineBillboardAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BillboardRenderer), UnityEngineBillboardRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CustomRenderTextureManager), UnityEngineCustomRenderTextureManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Display), UnityEngineDisplayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SleepTimeout), UnityEngineSleepTimeoutWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Screen), UnityEngineScreenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderBuffer), UnityEngineRenderBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Graphics), UnityEngineGraphicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GL), UnityEngineGLWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ScalableBufferManager), UnityEngineScalableBufferManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FrameTiming), UnityEngineFrameTimingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FrameTimingManager), UnityEngineFrameTimingManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LightmapData), UnityEngineLightmapDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LightmapSettings), UnityEngineLightmapSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LightProbes), UnityEngineLightProbesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HDROutputSettings), UnityEngineHDROutputSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resolution), UnityEngineResolutionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderTargetSetup), UnityEngineRenderTargetSetupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.QualitySettings), UnityEngineQualitySettingsWrap.__Register);
        
        }
        
        static void wrapInit2(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.RendererExtensions), UnityEngineRendererExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectTransformsToLDR), UnityEngineImageEffectTransformsToLDRWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectAllowedInSceneView), UnityEngineImageEffectAllowedInSceneViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectOpaque), UnityEngineImageEffectOpaqueWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectAfterScale), UnityEngineImageEffectAfterScaleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectUsesCommandBuffer), UnityEngineImageEffectUsesCommandBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mesh), UnityEngineMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Projector), UnityEngineProjectorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Shader), UnityEngineShaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TrailRenderer), UnityEngineTrailRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LineRenderer), UnityEngineLineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MaterialPropertyBlock), UnityEngineMaterialPropertyBlockWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderSettings), UnityEngineRenderSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Material), UnityEngineMaterialWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GraphicsBuffer), UnityEngineGraphicsBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.OcclusionPortal), UnityEngineOcclusionPortalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.OcclusionArea), UnityEngineOcclusionAreaWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Flare), UnityEngineFlareWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LensFlare), UnityEngineLensFlareWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LightBakingOutput), UnityEngineLightBakingOutputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Skybox), UnityEngineSkyboxWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MeshFilter), UnityEngineMeshFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LightProbeProxyVolume), UnityEngineLightProbeProxyVolumeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MeshRenderer), UnityEngineMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LightProbeGroup), UnityEngineLightProbeGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LineUtility), UnityEngineLineUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LOD), UnityEngineLODWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LODGroup), UnityEngineLODGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoneWeight), UnityEngineBoneWeightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoneWeight1), UnityEngineBoneWeight1Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CombineInstance), UnityEngineCombineInstanceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture), UnityEngineTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture2D), UnityEngineTexture2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Cubemap), UnityEngineCubemapWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture3D), UnityEngineTexture3DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture2DArray), UnityEngineTexture2DArrayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CubemapArray), UnityEngineCubemapArrayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SparseTexture), UnityEngineSparseTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderTexture), UnityEngineRenderTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CustomRenderTextureUpdateZone), UnityEngineCustomRenderTextureUpdateZoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CustomRenderTexture), UnityEngineCustomRenderTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderTextureDescriptor), UnityEngineRenderTextureDescriptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Hash128), UnityEngineHash128Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HashUtilities), UnityEngineHashUtilitiesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HashUnsafeUtilities), UnityEngineHashUnsafeUtilitiesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Logger), UnityEngineLoggerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color32), UnityEngineColor32Wrap.__Register);
        
        }
        
        static void wrapInit3(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.ColorUtility), UnityEngineColorUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GradientColorKey), UnityEngineGradientColorKeyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GradientAlphaKey), UnityEngineGradientAlphaKeyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Gradient), UnityEngineGradientWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FrustumPlanes), UnityEngineFrustumPlanesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Matrix4x4), UnityEngineMatrix4x4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2Int), UnityEngineVector2IntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3Int), UnityEngineVector3IntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefsException), UnityEnginePlayerPrefsExceptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefs), UnityEnginePlayerPrefsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PropertyName), UnityEnginePropertyNameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Random), UnityEngineRandomWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ResourceRequest), UnityEngineResourceRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ResourcesAPI), UnityEngineResourcesAPIWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AsyncOperation), UnityEngineAsyncOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ExecuteAlways), UnityEngineExecuteAlwaysWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.DefaultExecutionOrder), UnityEngineDefaultExecutionOrderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Coroutine), UnityEngineCoroutineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CustomYieldInstruction), UnityEngineCustomYieldInstructionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RangeInt), UnityEngineRangeIntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ScriptableObject), UnityEngineScriptableObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.StackTraceUtility), UnityEngineStackTraceUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UnityException), UnityEngineUnityExceptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MissingComponentException), UnityEngineMissingComponentExceptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UnassignedReferenceException), UnityEngineUnassignedReferenceExceptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MissingReferenceException), UnityEngineMissingReferenceExceptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForEndOfFrame), UnityEngineWaitForEndOfFrameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForFixedUpdate), UnityEngineWaitForFixedUpdateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSecondsRealtime), UnityEngineWaitForSecondsRealtimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitUntil), UnityEngineWaitUntilWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitWhile), UnityEngineWaitWhileWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.YieldInstruction), UnityEngineYieldInstructionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Security), UnityEngineSecurityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SerializeReference), UnityEngineSerializeReferenceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PreferBinarySerialization), UnityEnginePreferBinarySerializationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ComputeBuffer), UnityEngineComputeBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ComputeShader), UnityEngineComputeShaderWrap.__Register);
        
        }
        
        static void wrapInit4(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.Snapping), UnityEngineSnappingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.StaticBatchingUtility), UnityEngineStaticBatchingUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SystemInfo), UnityEngineSystemInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UnityEventQueueSystem), UnityEngineUnityEventQueueSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Pose), UnityEnginePoseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.DrivenRectTransformTracker), UnityEngineDrivenRectTransformTrackerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SpriteRenderer), UnityEngineSpriteRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SecondarySpriteTexture), UnityEngineSecondarySpriteTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Sprite), UnityEngineSpriteWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Grid), UnityEngineGridWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GridLayout), UnityEngineGridLayoutWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Event), UnityEngineEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ImageConversion), UnityEngineImageConversionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Touch), UnityEngineTouchWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AccelerationEvent), UnityEngineAccelerationEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Gyroscope), UnityEngineGyroscopeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LocationInfo), UnityEngineLocationInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LocationService), UnityEngineLocationServiceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Compass), UnityEngineCompassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JsonUtility), UnityEngineJsonUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LocalizationAsset), UnityEngineLocalizationAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticlePhysicsExtensions), UnityEngineParticlePhysicsExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleCollisionEvent), UnityEngineParticleCollisionEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystemRenderer), UnityEngineParticleSystemRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystemForceField), UnityEngineParticleSystemForceFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WheelFrictionCurve), UnityEngineWheelFrictionCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SoftJointLimit), UnityEngineSoftJointLimitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SoftJointLimitSpring), UnityEngineSoftJointLimitSpringWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointDrive), UnityEngineJointDriveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointMotor), UnityEngineJointMotorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointSpring), UnityEngineJointSpringWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointLimits), UnityEngineJointLimitsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ControllerColliderHit), UnityEngineControllerColliderHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collision), UnityEngineCollisionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicMaterial), UnityEnginePhysicMaterialWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), UnityEngineRaycastHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rigidbody), UnityEngineRigidbodyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collider), UnityEngineColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CharacterController), UnityEngineCharacterControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MeshCollider), UnityEngineMeshColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CapsuleCollider), UnityEngineCapsuleColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoxCollider), UnityEngineBoxColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SphereCollider), UnityEngineSphereColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ConstantForce), UnityEngineConstantForceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Joint), UnityEngineJointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HingeJoint), UnityEngineHingeJointWrap.__Register);
        
        }
        
        static void wrapInit5(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.SpringJoint), UnityEngineSpringJointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FixedJoint), UnityEngineFixedJointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CharacterJoint), UnityEngineCharacterJointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ConfigurableJoint), UnityEngineConfigurableJointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ContactPoint), UnityEngineContactPointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicsScene), UnityEnginePhysicsSceneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicsSceneExtensions), UnityEnginePhysicsSceneExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ArticulationDrive), UnityEngineArticulationDriveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ArticulationReducedSpace), UnityEngineArticulationReducedSpaceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ArticulationJacobian), UnityEngineArticulationJacobianWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ArticulationBody), UnityEngineArticulationBodyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastCommand), UnityEngineRaycastCommandWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SpherecastCommand), UnityEngineSpherecastCommandWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CapsulecastCommand), UnityEngineCapsulecastCommandWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoxcastCommand), UnityEngineBoxcastCommandWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicsScene2D), UnityEnginePhysicsScene2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicsSceneExtensions2D), UnityEnginePhysicsSceneExtensions2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Physics2D), UnityEnginePhysics2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ColliderDistance2D), UnityEngineColliderDistance2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ContactFilter2D), UnityEngineContactFilter2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collision2D), UnityEngineCollision2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ContactPoint2D), UnityEngineContactPoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointAngleLimits2D), UnityEngineJointAngleLimits2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointTranslationLimits2D), UnityEngineJointTranslationLimits2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointMotor2D), UnityEngineJointMotor2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointSuspension2D), UnityEngineJointSuspension2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit2D), UnityEngineRaycastHit2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicsJobOptions2D), UnityEnginePhysicsJobOptions2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rigidbody2D), UnityEngineRigidbody2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collider2D), UnityEngineCollider2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CircleCollider2D), UnityEngineCircleCollider2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CapsuleCollider2D), UnityEngineCapsuleCollider2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EdgeCollider2D), UnityEngineEdgeCollider2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoxCollider2D), UnityEngineBoxCollider2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PolygonCollider2D), UnityEnginePolygonCollider2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CompositeCollider2D), UnityEngineCompositeCollider2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Joint2D), UnityEngineJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnchoredJoint2D), UnityEngineAnchoredJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SpringJoint2D), UnityEngineSpringJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.DistanceJoint2D), UnityEngineDistanceJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FrictionJoint2D), UnityEngineFrictionJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HingeJoint2D), UnityEngineHingeJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RelativeJoint2D), UnityEngineRelativeJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SliderJoint2D), UnityEngineSliderJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TargetJoint2D), UnityEngineTargetJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FixedJoint2D), UnityEngineFixedJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WheelJoint2D), UnityEngineWheelJoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Effector2D), UnityEngineEffector2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AreaEffector2D), UnityEngineAreaEffector2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BuoyancyEffector2D), UnityEngineBuoyancyEffector2DWrap.__Register);
        
        }
        
        static void wrapInit6(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.PointEffector2D), UnityEnginePointEffector2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PlatformEffector2D), UnityEnginePlatformEffector2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SurfaceEffector2D), UnityEngineSurfaceEffector2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicsUpdateBehaviour2D), UnityEnginePhysicsUpdateBehaviour2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ConstantForce2D), UnityEngineConstantForce2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PhysicsMaterial2D), UnityEnginePhysicsMaterial2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ScreenCapture), UnityEngineScreenCaptureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SpriteMask), UnityEngineSpriteMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.StreamingController), UnityEngineStreamingControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.IntegratedSubsystem), UnityEngineIntegratedSubsystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.IntegratedSubsystemDescriptor), UnityEngineIntegratedSubsystemDescriptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Subsystem), UnityEngineSubsystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SubsystemDescriptor), UnityEngineSubsystemDescriptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SubsystemManager), UnityEngineSubsystemManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PatchExtents), UnityEnginePatchExtentsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextGenerationSettings), UnityEngineTextGenerationSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextMesh), UnityEngineTextMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CharacterInfo), UnityEngineCharacterInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UICharInfo), UnityEngineUICharInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UILineInfo), UnityEngineUILineInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UIVertex), UnityEngineUIVertexWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Font), UnityEngineFontWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GridBrushBase), UnityEngineGridBrushBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CanvasGroup), UnityEngineCanvasGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransformUtility), UnityEngineRectTransformUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Canvas), UnityEngineCanvasWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UISystemProfilerApi), UnityEngineUISystemProfilerApiWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RemoteSettings), UnityEngineRemoteSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RemoteConfigSettings), UnityEngineRemoteConfigSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WWWForm), UnityEngineWWWFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WheelHit), UnityEngineWheelHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WheelCollider), UnityEngineWheelColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WindZone), UnityEngineWindZoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AnimationTriggers), UnityEngineUIAnimationTriggersWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasUpdateRegistry), UnityEngineUICanvasUpdateRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ColorBlock), UnityEngineUIColorBlockWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ClipperRegistry), UnityEngineUIClipperRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Clipping), UnityEngineUIClippingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls), UnityEngineUIDefaultControlsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown), UnityEngineUIDropdownWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.FontData), UnityEngineUIFontDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.FontUpdateTracker), UnityEngineUIFontUpdateTrackerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Graphic), UnityEngineUIGraphicWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster), UnityEngineUIGraphicRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRegistry), UnityEngineUIGraphicRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField), UnityEngineUIInputFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AspectRatioFitter), UnityEngineUIAspectRatioFitterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler), UnityEngineUICanvasScalerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter), UnityEngineUIContentSizeFitterWrap.__Register);
        
        }
        
        static void wrapInit7(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup), UnityEngineUIGridLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalLayoutGroup), UnityEngineUIHorizontalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), UnityEngineUIHorizontalOrVerticalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutElement), UnityEngineUILayoutElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutGroup), UnityEngineUILayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutRebuilder), UnityEngineUILayoutRebuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutUtility), UnityEngineUILayoutUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.VerticalLayoutGroup), UnityEngineUIVerticalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Mask), UnityEngineUIMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskUtilities), UnityEngineUIMaskUtilitiesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic), UnityEngineUIMaskableGraphicWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Navigation), UnityEngineUINavigationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.RawImage), UnityEngineUIRawImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.RectMask2D), UnityEngineUIRectMask2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), UnityEngineUIScrollRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar), UnityEngineUIScrollbarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable), UnityEngineUISelectableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.SpriteState), UnityEngineUISpriteStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.StencilMaterial), UnityEngineUIStencilMaterialWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngineUIToggleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ToggleGroup), UnityEngineUIToggleGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.VertexHelper), UnityEngineUIVertexHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.BaseMeshEffect), UnityEngineUIBaseMeshEffectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Outline), UnityEngineUIOutlineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.PositionAsUV1), UnityEngineUIPositionAsUV1Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Shadow), UnityEngineUIShadowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCallCs), LuaCallCsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.CSCallLua), TutorialCSCallLuaWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ByFile), TutorialByFileWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ByString), TutorialByStringWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.CustomLoader), TutorialCustomLoaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.Param1), TutorialParam1Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.AudioEntity), LoopClientAudioEntityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.AudioSaveData), LoopClientAudioSaveDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.AudioModule), LoopClientAudioModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.ButtonClickSound), LoopClientButtonClickSoundWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.GameTools), LoopClientGameToolsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.LoopClientPanelConfig_RT), LoopClientLoopClientPanelConfig_RTWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.LoopClientGame), LoopClientLoopClientGameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.LoopClientPerfs), LoopClientLoopClientPerfsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.LoopClientAssetsSetting), LoopClientLoopClientAssetsSettingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.LoopClientUpdate), LoopClientLoopClientUpdateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.ImageRaycastAlphaFitter), LoopClientImageRaycastAlphaFitterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.UILoader), LoopClientUILoaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.UIUpdateLoader), LoopClientUIUpdateLoaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.MVVMMap), LoopClientMVVMMapWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.UIMap_MVVM), LoopClientUIMap_MVVMWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.UpdatePanel), LoopClientUpdatePanelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.UpdatePanelArgs), LoopClientUpdatePanelArgsWrap.__Register);
        
        }
        
        static void wrapInit8(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(LoopClient.UpdatePanelModel), LoopClientUpdatePanelModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.UpdatePanelView), LoopClientUpdatePanelViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.UpdatePanelViewModel), LoopClientUpdatePanelViewModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework_Demo.TweenTest), IFramework_DemoTweenTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Game), IFrameworkGameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.IAwaterEx), IFrameworkIAwaterExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Launcher), IFrameworkLauncherWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UnityEx), IFrameworkUnityExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.ViewEvent), IFrameworkUIViewEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.MvvmGroups), IFrameworkUIMvvmGroupsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.UIView), IFrameworkUIUIViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.UIViewModel), IFrameworkUIUIViewModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.LoadPanelAsyncOperation), IFrameworkUILoadPanelAsyncOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.MixedGroups), IFrameworkUIMixedGroupsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.UILayerConfig), IFrameworkUIUILayerConfigWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.UIModule), IFrameworkUIUIModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.UIPanel), IFrameworkUIUIPanelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Empty4Raycast), IFrameworkUIEmpty4RaycastWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.GuideMask), IFrameworkUIGuideMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.LoopScrollRect), IFrameworkUILoopScrollRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.RedPointTree), IFrameworkUIRedPointTreeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.UGUIEventListener), IFrameworkUIUGUIEventListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.AtlasExample), IFrameworkUIAtlasExampleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.LoopExample), IFrameworkUILoopExampleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel01), IFrameworkUIExamplePanel01Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel01Args), IFrameworkUIExamplePanel01ArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel01Model), IFrameworkUIExamplePanel01ModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel01View), IFrameworkUIExamplePanel01ViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel01ViewModel), IFrameworkUIExamplePanel01ViewModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel02), IFrameworkUIExamplePanel02Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel02Args), IFrameworkUIExamplePanel02ArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel02Model), IFrameworkUIExamplePanel02ModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel02View), IFrameworkUIExamplePanel02ViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.Panel02ViewModel), IFrameworkUIExamplePanel02ViewModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.UIMap_MVVM), IFrameworkUIExampleUIMap_MVVMWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.Example.UI_Game), IFrameworkUIExampleUI_GameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.SuperScrollView.LoopListView), IFrameworkUISuperScrollViewLoopListViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.SuperScrollView.LoopListViewItem), IFrameworkUISuperScrollViewLoopListViewItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Tweens.AnimationCurveCoverter), IFrameworkTweensAnimationCurveCoverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Tweens.EaseCoverter), IFrameworkTweensEaseCoverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Tweens.DoScaleComponent), IFrameworkTweensDoScaleComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Tweens.Tween), IFrameworkTweensTweenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Tweens.TweenEx), IFrameworkTweensTweenExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Language.LanPair), IFrameworkLanguageLanPairWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Language.LanguageModule), IFrameworkLanguageLanguageModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaArgs), IFrameworkHotfixLuaLuaArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaEX), IFrameworkHotfixLuaLuaEXWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.XLuaModule), IFrameworkHotfixLuaXLuaModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.XluaMain), IFrameworkHotfixLuaXluaMainWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaGroups), IFrameworkHotfixLuaLuaGroupsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaPanel), IFrameworkHotfixLuaLuaPanelWrap.__Register);
        
        }
        
        static void wrapInit9(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.AssetsLoader), IFrameworkHotfixLuaAssetsLoaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaGame), IFrameworkHotfixLuaLuaGameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsSetting), IFrameworkHotfixAssetAssetsSettingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool), IFrameworkHotfixAssetAssetsToolWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsVersion), IFrameworkHotfixAssetAssetsVersionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Asset), IFrameworkHotfixAssetAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetLoadArgs), IFrameworkHotfixAssetAssetLoadArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetOperation), IFrameworkHotfixAssetAssetOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.SceneAsset), IFrameworkHotfixAssetSceneAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.SceneAssetLoadArgs), IFrameworkHotfixAssetSceneAssetLoadArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetManifest), IFrameworkHotfixAssetAssetManifestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Assets), IFrameworkHotfixAssetAssetsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Bundle), IFrameworkHotfixAssetBundleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.BundleLoadArgs), IFrameworkHotfixAssetBundleLoadArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.WebRequestBundle), IFrameworkHotfixAssetWebRequestBundleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.LocalSetting), IFrameworkHotfixAssetLocalSettingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetExample), IFrameworkHotfixAssetAssetExampleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Singleton.MonoSingletonPath), IFrameworkSingletonMonoSingletonPathWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.CSCallLua.DClass), TutorialCSCallLuaDClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.LoopClientPanelConfig_RT.Data), LoopClientLoopClientPanelConfig_RTDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LoopClient.LoopClientGame.UnityModules), LoopClientLoopClientGameUnityModulesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.IAwaterEx.ResourceRequestAwaiter), IFrameworkIAwaterExResourceRequestAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.IAwaterEx.AsyncOperationAwaiter), IFrameworkIAwaterExAsyncOperationAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.SuperScrollView.LoopListView.PrefabConfData), IFrameworkUISuperScrollViewLoopListViewPrefabConfDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.UI.SuperScrollView.LoopListView.InitParam), IFrameworkUISuperScrollViewLoopListViewInitParamWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaEX.LuaTaskAwaiter), IFrameworkHotfixLuaLuaEXLuaTaskAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Lua.LuaGame.UnityModules), IFrameworkHotfixLuaLuaGameUnityModulesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.SceneAssetAwaiter), IFrameworkHotfixAssetAssetsToolSceneAssetAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.AssetAwaiter), IFrameworkHotfixAssetAssetsToolAssetAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.BundleAwaiter), IFrameworkHotfixAssetAssetsToolBundleAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.AssetBundleRequestAwaiter), IFrameworkHotfixAssetAssetsToolAssetBundleRequestAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.AssetBundleCreateRequestAwaiter), IFrameworkHotfixAssetAssetsToolAssetBundleCreateRequestAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.CheckBundleVersionOperationAwaiter), IFrameworkHotfixAssetAssetsToolCheckBundleVersionOperationAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.DownLoadBundleOperationAwaiter), IFrameworkHotfixAssetAssetsToolDownLoadBundleOperationAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.LoadManifestOperationAwaiter), IFrameworkHotfixAssetAssetsToolLoadManifestOperationAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsTool.AssetsGroupOperationAwaiter), IFrameworkHotfixAssetAssetsToolAssetsGroupOperationAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetsVersion.VersionData), IFrameworkHotfixAssetAssetsVersionVersionDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.AssetManifest.AssetData), IFrameworkHotfixAssetAssetManifestAssetDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Assets.AssetsGroupOperation), IFrameworkHotfixAssetAssetsAssetsGroupOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Assets.CheckBundleVersionOperation), IFrameworkHotfixAssetAssetsCheckBundleVersionOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Assets.DownLoadBundleOperation), IFrameworkHotfixAssetAssetsDownLoadBundleOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Assets.Downloader), IFrameworkHotfixAssetAssetsDownloaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Hotfix.Asset.Assets.LoadManifestOperation), IFrameworkHotfixAssetAssetsLoadManifestOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.BitConverterEx), IFrameworkBitConverterExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Ex), IFrameworkExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.ArrayPoolArg), IFrameworkArrayPoolArgWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Unit), IFrameworkUnitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.InjectAttribute), IFrameworkInjectAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.BindableObject), IFrameworkBindableObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.BindableObjectHandler), IFrameworkBindableObjectHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.ObservableObject), IFrameworkObservableObjectWrap.__Register);
        
        }
        
        static void wrapInit10(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(IFramework.OnEnvironmentInitAttribute), IFrameworkOnEnvironmentInitAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.ObservableObjectHandler), IFrameworkObservableObjectHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.RecyclableObject), IFrameworkRecyclableObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Framework), IFrameworkFrameworkWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.LockWait), IFrameworkLockWaitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.LockParam), IFrameworkLockParamWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Log), IFrameworkLogWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Verifier), IFrameworkVerifierWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Singleton.SingletonCollection), IFrameworkSingletonSingletonCollectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Queue.FastPriorityQueueNode), IFrameworkQueueFastPriorityQueueNodeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Queue.StablePriorityQueueNode), IFrameworkQueueStablePriorityQueueNodeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Packets.Packet), IFrameworkPacketsPacketWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Packets.PacketReader), IFrameworkPacketsPacketReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.NodeAction.ActionNodeExtension), IFrameworkNodeActionActionNodeExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.Crypt), IFrameworkNetCryptWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.SocketToken), IFrameworkNetSocketTokenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.SegmentOffset), IFrameworkNetSegmentOffsetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.SegmentToken), IFrameworkNetSegmentTokenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.NetTool), IFrameworkNetNetToolWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.NetConnectionToken), IFrameworkNetNetConnectionTokenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.WebSocket.SslHelper), IFrameworkNetWebSocketSslHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.WebSocket.WSConnectionItem), IFrameworkNetWebSocketWSConnectionItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.KCP.BufferQueue), IFrameworkNetKCPBufferQueueWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.KCP.Kcp), IFrameworkNetKCPKcpWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.KCP.KcpClient), IFrameworkNetKCPKcpClientWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.KCP.KcpSocket), IFrameworkNetKCPKcpSocketWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.Http.HttpGet), IFrameworkNetHttpHttpGetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.Http.HttpGzip), IFrameworkNetHttpHttpGzipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.Http.HttpHeader), IFrameworkNetHttpHttpHeaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.Http.HttpPost), IFrameworkNetHttpHttpPostWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.Http.HttpPayload), IFrameworkNetHttpHttpPayloadWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Net.Http.HttpUri), IFrameworkNetHttpHttpUriWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.MVVM.EmptyDataModel), IFrameworkMVVMEmptyDataModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.MVVM.MVVMGroup), IFrameworkMVVMMVVMGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.MVVM.MVVMGroups), IFrameworkMVVMMVVMGroupsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.MVVM.View), IFrameworkMVVMViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.MVVM.ViewModel), IFrameworkMVVMViewModelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.StringFormatter), IFrameworkSerializationStringFormatterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.BoolStringConverter), IFrameworkSerializationBoolStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.ByteStringConverter), IFrameworkSerializationByteStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.CharStringConverter), IFrameworkSerializationCharStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DateTimeStringConverter), IFrameworkSerializationDateTimeStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DecimalStringConverter), IFrameworkSerializationDecimalStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DoubleStringConverter), IFrameworkSerializationDoubleStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.FloatStringConverter), IFrameworkSerializationFloatStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.IntStringConverter), IFrameworkSerializationIntStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.LongStringConverter), IFrameworkSerializationLongStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.SByteStringConverter), IFrameworkSerializationSByteStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.ShortStringConverter), IFrameworkSerializationShortStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.StringConvert), IFrameworkSerializationStringConvertWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.StringConverter), IFrameworkSerializationStringConverterWrap.__Register);
        
        }
        
        static void wrapInit11(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.StringStringConverter), IFrameworkSerializationStringStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.TimeSpanStringConverter), IFrameworkSerializationTimeSpanStringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.UInt16StringConverter), IFrameworkSerializationUInt16StringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.UInt32StringConverter), IFrameworkSerializationUInt32StringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.UInt64StringConverter), IFrameworkSerializationUInt64StringConverterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.Xml), IFrameworkSerializationXmlWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DataTable.DataColumn), IFrameworkSerializationDataTableDataColumnWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DataTable.DataReadColumnIndexAttribute), IFrameworkSerializationDataTableDataReadColumnIndexAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DataTable.DataColumnNameAttribute), IFrameworkSerializationDataTableDataColumnNameAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DataTable.DataIgnoreAttribute), IFrameworkSerializationDataTableDataIgnoreAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DataTable.DataTableTool), IFrameworkSerializationDataTableDataTableToolWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DataTable.DataExplainer), IFrameworkSerializationDataTableDataExplainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Serialization.DataTable.DataRow), IFrameworkSerializationDataTableDataRowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.ModulePriority), IFrameworkModulesModulePriorityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Module), IFrameworkModulesModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.UpdateModule), IFrameworkModulesUpdateModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Fsm.BoolCondition), IFrameworkModulesFsmBoolConditionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Fsm.FloatCondition), IFrameworkModulesFsmFloatConditionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Fsm.IntCondition), IFrameworkModulesFsmIntConditionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Fsm.FsmModule), IFrameworkModulesFsmFsmModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Fsm.Transition), IFrameworkModulesFsmTransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Timer.TimerEntity), IFrameworkModulesTimerTimerEntityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Timer.TimerModule), IFrameworkModulesTimerTimerModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Recorder.OperationRecorderEx), IFrameworkModulesRecorderOperationRecorderExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Recorder.OperationRecorderModule), IFrameworkModulesRecorderOperationRecorderModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Recorder.ActionGroupState), IFrameworkModulesRecorderActionGroupStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Recorder.ActionState), IFrameworkModulesRecorderActionStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Recorder.BaseState), IFrameworkModulesRecorderBaseStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Recorder.CommandGroupState), IFrameworkModulesRecorderCommandGroupStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Recorder.CommandState), IFrameworkModulesRecorderCommandStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Message.MessageModule), IFrameworkModulesMessageMessageModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Message.MessageAwaiter), IFrameworkModulesMessageMessageAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Message.MessageUrgency), IFrameworkModulesMessageMessageUrgencyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.ECS.ECSModule), IFrameworkModulesECSECSModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.ECS.Entity), IFrameworkModulesECSEntityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.CoroutineAwaiter), IFrameworkModulesCoroutineCoroutineAwaiterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.CoroutineModuleEx), IFrameworkModulesCoroutineCoroutineModuleExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.YieldInstruction), IFrameworkModulesCoroutineYieldInstructionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.CoroutineModule), IFrameworkModulesCoroutineCoroutineModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForDays), IFrameworkModulesCoroutineWaitForDaysWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForFrame), IFrameworkModulesCoroutineWaitForFrameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForFrames), IFrameworkModulesCoroutineWaitForFramesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForHours), IFrameworkModulesCoroutineWaitForHoursWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForMilliseconds), IFrameworkModulesCoroutineWaitForMillisecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForMinutes), IFrameworkModulesCoroutineWaitForMinutesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForSeconds), IFrameworkModulesCoroutineWaitForSecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForTicks), IFrameworkModulesCoroutineWaitForTicksWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitForTimeSpan), IFrameworkModulesCoroutineWaitForTimeSpanWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitUtil), IFrameworkModulesCoroutineWaitUtilWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IFramework.Modules.Coroutine.WaitWhile), IFrameworkModulesCoroutineWaitWhileWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            wrapInit2(luaenv, translator);
            
            wrapInit3(luaenv, translator);
            
            wrapInit4(luaenv, translator);
            
            wrapInit5(luaenv, translator);
            
            wrapInit6(luaenv, translator);
            
            wrapInit7(luaenv, translator);
            
            wrapInit8(luaenv, translator);
            
            wrapInit9(luaenv, translator);
            
            wrapInit10(luaenv, translator);
            
            wrapInit11(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(IFramework.Hotfix.Lua.ILuaTask), IFrameworkHotfixLuaILuaTaskBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Tutorial.CSCallLua.ItfD), TutorialCSCallLuaItfDBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
		delegate UnityEngine.PhysicsScene __GEN_DELEGATE0( UnityEngine.SceneManagement.Scene scene);
		
		delegate UnityEngine.PhysicsScene2D __GEN_DELEGATE1( UnityEngine.SceneManagement.Scene scene);
		
		delegate string __GEN_DELEGATE2( string self);
		
		delegate string __GEN_DELEGATE3( string self);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE4( IFramework.Tweens.ITween tween,  bool rec);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE5( IFramework.Tweens.ITween tween,  System.Action onCompelete);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE6( IFramework.Tweens.ITween tween,  int loop,  IFramework.Tweens.LoopType loopType);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE7( IFramework.Tweens.ITween tween,  UnityEngine.AnimationCurve curve);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE8( IFramework.Tweens.ITween tween,  IFramework.Tweens.Ease ease);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE9( IFramework.Tweens.ITween tween,  IFramework.Tweens.TweenUpdateType type);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE10( IFramework.Tweens.ITween tween,  float delta);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE11( IFramework.Tweens.ITween tween,  float delta);
		
		delegate IFramework.Tweens.ITween __GEN_DELEGATE12( IFramework.Tweens.ITween tween,  float speed);
		
		delegate IFramework.IAwaiter __GEN_DELEGATE13( IFramework.Hotfix.Lua.ILuaTask target);
		
		delegate float __GEN_DELEGATE14( float self);
		
		delegate float __GEN_DELEGATE15( float self,  float min,  float max);
		
		delegate float __GEN_DELEGATE16( float self);
		
		delegate int __GEN_DELEGATE17( float self);
		
		delegate float __GEN_DELEGATE18( float self,  float length);
		
		delegate int __GEN_DELEGATE19( float self);
		
		delegate float __GEN_DELEGATE20( float self,  float end,  float pecent);
		
		delegate int __GEN_DELEGATE21( int self,  int min,  int max);
		
		delegate int __GEN_DELEGATE22( int self,  float end,  float pecent);
		
		delegate bool __GEN_DELEGATE23( string path);
		
		delegate bool __GEN_DELEGATE24( string path);
		
		delegate bool __GEN_DELEGATE25( string path);
		
		delegate string __GEN_DELEGATE26( string path,  string toCombinePath);
		
		delegate string __GEN_DELEGATE27( string path,  string[] paths);
		
		delegate string __GEN_DELEGATE28( string path);
		
		delegate void __GEN_DELEGATE29( string path);
		
		delegate System.Collections.Generic.IEnumerable<System.Type> __GEN_DELEGATE30( System.Type self);
		
		delegate System.Collections.Generic.IEnumerable<System.Type> __GEN_DELEGATE31( System.Type self);
		
		delegate bool __GEN_DELEGATE32( System.Type self,  System.Type Interface);
		
		delegate bool __GEN_DELEGATE33( System.Type self,  System.Type genericType);
		
		delegate System.Collections.Generic.IList<System.Type> __GEN_DELEGATE34( System.Type t);
		
		delegate System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> __GEN_DELEGATE35( System.Type self,  System.Reflection.Assembly assembly);
		
		delegate string __GEN_DELEGATE36( string self);
		
		delegate string __GEN_DELEGATE37( string self,  string toPrefix);
		
		delegate string __GEN_DELEGATE38( string self,  string toAppend);
		
		delegate string __GEN_DELEGATE39( string self,  string[] toAppend);
		
		delegate void __GEN_DELEGATE40( System.Action action,  IFramework.IEnvironment env);
		
		delegate void __GEN_DELEGATE41( System.Action action,  IFramework.IEnvironment env);
		
		delegate void __GEN_DELEGATE42( System.Action action,  IFramework.IEnvironment env);
		
		delegate void __GEN_DELEGATE43( System.Action action,  IFramework.IEnvironment env);
		
		delegate void __GEN_DELEGATE44( System.Action action,  IFramework.EnvironmentType envType);
		
		delegate void __GEN_DELEGATE45( System.Action action,  IFramework.EnvironmentType envType);
		
		delegate void __GEN_DELEGATE46( System.Action action,  IFramework.EnvironmentType envType);
		
		delegate void __GEN_DELEGATE47( System.Action action,  IFramework.EnvironmentType envType);
		
		delegate IFramework.NodeAction.ISequenceNode __GEN_DELEGATE48( object self,  IFramework.EnvironmentType envType,  bool autoRecyle);
		
		delegate IFramework.NodeAction.ISequenceNode __GEN_DELEGATE49( object self,  IFramework.IEnvironment env,  bool autoRecyle);
		
		delegate string __GEN_DELEGATE50( string value,  System.Text.Encoding encoding);
		
		delegate string __GEN_DELEGATE51( string value,  System.Text.Encoding encoding);
		
		delegate IFramework.Modules.Recorder.CommandState __GEN_DELEGATE52( IFramework.Modules.Recorder.IOperationRecorderModule t);
		
		delegate IFramework.Modules.Recorder.ActionState __GEN_DELEGATE53( IFramework.Modules.Recorder.IOperationRecorderModule t);
		
		delegate IFramework.Modules.Recorder.CommandGroupState __GEN_DELEGATE54( IFramework.Modules.Recorder.IOperationRecorderModule t);
		
		delegate IFramework.Modules.Recorder.ActionGroupState __GEN_DELEGATE55( IFramework.Modules.Recorder.IOperationRecorderModule t);
		
		delegate IFramework.Modules.Coroutine.ICoroutine __GEN_DELEGATE56( object obj,  System.Collections.IEnumerator routine,  IFramework.EnvironmentType envType);
		
		delegate IFramework.Modules.Coroutine.ICoroutine __GEN_DELEGATE57( object obj,  System.Collections.IEnumerator routine,  IFramework.IEnvironment env);
		
		delegate void __GEN_DELEGATE58( object obj,  IFramework.Modules.Coroutine.ICoroutine routine);
		
		delegate IFramework.Modules.Coroutine.ICoroutine __GEN_DELEGATE59( IFramework.Modules.Coroutine.ICoroutine self,  System.Action action);
		
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(UnityEngine.SceneManagement.Scene), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(UnityEngine.PhysicsSceneExtensions.GetPhysicsScene)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE1(UnityEngine.PhysicsSceneExtensions2D.GetPhysicsScene2D)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(string), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE2(IFramework.UnityEx.ToAbsPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE3(IFramework.UnityEx.ToAssetsPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE23(IFramework.Ex.ExistFile)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE24(IFramework.Ex.IsDirectory)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE25(IFramework.Ex.RemoveEmptyDirectory)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE26(IFramework.Ex.CombinePath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE27(IFramework.Ex.CombinePath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE28(IFramework.Ex.ToRegularPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE29(IFramework.Ex.MakeDirectoryExist)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE36(IFramework.Ex.ToUnixLineEndings)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE37(IFramework.Ex.AppendHead)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE38(IFramework.Ex.Append)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE39(IFramework.Ex.Append)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE50(IFramework.Net.Crypt.ToSha1Base64)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE51(IFramework.Net.Crypt.ToMd5)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(IFramework.Tweens.ITween), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE4(IFramework.Tweens.TweenEx.SetRecyle)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE5(IFramework.Tweens.TweenEx.OnCompelete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE6(IFramework.Tweens.TweenEx.SetLoop)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE7(IFramework.Tweens.TweenEx.SetAnimationCurve)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE8(IFramework.Tweens.TweenEx.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE9(IFramework.Tweens.TweenEx.SetUpdateType)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE10(IFramework.Tweens.TweenEx.SetDeltaTime)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE11(IFramework.Tweens.TweenEx.SetDelta)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE12(IFramework.Tweens.TweenEx.SetTimeScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(IFramework.Hotfix.Lua.ILuaTask), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE13(IFramework.Hotfix.Lua.LuaEX.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(float), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE14(IFramework.Ex.Abs)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE15(IFramework.Ex.Clamp)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE16(IFramework.Ex.Clamp01)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE17(IFramework.Ex.Floor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE18(IFramework.Ex.Repeat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE19(IFramework.Ex.RoundToInt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE20(IFramework.Ex.Lerp)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(int), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE21(IFramework.Ex.Clamp)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE22(IFramework.Ex.Lerp)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Type), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE30(IFramework.Ex.GetSubTypesInAssembly)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE31(IFramework.Ex.GetSubTypesInAssemblys)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE32(IFramework.Ex.IsExtendInterface)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE33(IFramework.Ex.IsSubclassOfGeneric)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE34(IFramework.Ex.GetTypeTree)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE35(IFramework.Ex.GetExtensionMethods)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Action), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE40(IFramework.Framework.BindEnvUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE41(IFramework.Framework.UnBindEnvUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE42(IFramework.Framework.BindEnvDispose)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE43(IFramework.Framework.UnBindEnvDispose)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE44(IFramework.Framework.BindEnvUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE45(IFramework.Framework.UnBindEnvUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE46(IFramework.Framework.BindEnvDispose)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE47(IFramework.Framework.UnBindEnvDispose)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(object), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE48(IFramework.NodeAction.ActionNodeExtension.Sequence)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE49(IFramework.NodeAction.ActionNodeExtension.Sequence)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE56(IFramework.Modules.Coroutine.CoroutineModuleEx.StartCoroutine)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE57(IFramework.Modules.Coroutine.CoroutineModuleEx.StartCoroutine)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE58(IFramework.Modules.Coroutine.CoroutineModuleEx.StopCoroutine)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(IFramework.Modules.Recorder.IOperationRecorderModule), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE52(IFramework.Modules.Recorder.OperationRecorderEx.AllocateCommand)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE53(IFramework.Modules.Recorder.OperationRecorderEx.AllocateAction)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE54(IFramework.Modules.Recorder.OperationRecorderEx.AllocateCommandGroup)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE55(IFramework.Modules.Recorder.OperationRecorderEx.AllocateActionGroup)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(IFramework.Modules.Coroutine.ICoroutine), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE59(IFramework.Modules.Coroutine.CoroutineModuleEx.OnCompelete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
