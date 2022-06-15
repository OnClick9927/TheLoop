/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.204
 *UnityVersion:   2019.4.36f1c1
 *Date:           2022-03-09
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine.U2D;
using UnityEditor.U2D;

namespace IFramework.Hotfix.Asset
{
    class AssetsBuild
    {
        public static AssetBundleManifest Build(Type collectType)
        {
            var list = ColectAssetBundleBuild(collectType);
            CollectMain(list);
            AssetBuildSetting setting = AssetBuildSetting.Load();
            AssetBundleManifest main = BuildPipeline.BuildAssetBundles(AssetBuildSetting.outputPath, list.ToArray(), setting.option, EditorUserBuildSettings.activeBuildTarget);

            var bundles = main.GetAllAssetBundles();
            AssetsVersion version = new AssetsVersion();
            foreach (var bundle in bundles)
            {
                string path = AssetBuildSetting.outputPath.CombinePath(bundle);
                FileInfo fileInfo = new FileInfo(path);
                AssetsVersion.VersionData data = new AssetsVersion.VersionData();
                data.length = fileInfo.Length;
                data.bundleName = bundle;
                data.md5 = AssetsTool.GetFileMD5(path);
                data.lastWriteTime = fileInfo.LastWriteTime.Ticks;
                version.versions.Add(data);
            }
            version.ticks = DateTime.Now.Ticks;
            var v = JsonUtility.ToJson(version, true);
            File.WriteAllText(AssetBuildSetting.outputPath.CombinePath("version_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")), v);
            return main;
        }
        static List<AssetBundleBuild> ColectAssetBundleBuild(Type collectType)
        {
            AssetBuildSetting setting = AssetBuildSetting.Load();
            Dictionary<AssetInfo, List<AssetInfo>> dic = setting.GetDpDic();
            List<AssetInfo> all = new List<AssetInfo>(setting.GetAssets());
            List<string> singles = setting.GetSingleFiles();
            all.RemoveAll(x => x.IsDirectory());
            var creater = Activator.CreateInstance(collectType) as ICollectAssetBundleBuild;
            var builds = new List<AssetBundleBuild>();
            creater.Create(all, singles, dic, builds);
            return builds;
        }

        static void CollectMain(List<AssetBundleBuild> builds)
        {
            for (int i = 0; i < builds.Count; i++)
            {
                AssetBundleBuild build = builds[i];
                build.assetBundleName = AssetsTool.GetMd5(build.assetBundleName);
                builds[i] = build;
            }
            Dictionary<string, string> allAssets = new Dictionary<string, string>();
            Dictionary<string, List<string>> assetdps = new Dictionary<string, List<string>>();

            foreach (var build in builds)
            {
                foreach (var assetPath in build.assetNames)
                {
                    allAssets.Add(assetPath, build.assetBundleName);
                }
            }
            AssetBuildSetting setting = AssetBuildSetting.Load();
            foreach (var item in allAssets)
            {
                var path = item.Key;
                var dps = setting.GetDps(path);
                if (dps != null)
                    assetdps.Add(path, dps);
            }
            if (!File.Exists(AssetManifest.Path))
                EditorTools.AssetTool.CreateScriptableObject<AssetManifest>(AssetManifest.Path);
            AssetManifest main = EditorTools.AssetTool.Load<AssetManifest>(AssetManifest.Path);
            main.Read(allAssets, assetdps);
            EditorTools.AssetTool.Update(main);
            AssetBundleBuild mainbuild = new AssetBundleBuild();
            mainbuild.assetNames = new string[] { AssetManifest.Path };
            mainbuild.assetBundleName = AssetsTool.GetMd5(AssetManifest.Path);
            builds.Add(mainbuild);
        }

        public static void BuildAtlas()
        {
            AssetBuildSetting setting = AssetBuildSetting.Load();
            var paths = setting.GetAtlasPaths();
            foreach (var path in paths)
            {
                BuildAtlas(path);
            }
        }
        static void BuildAtlas(string directory)
        {
            SpriteAtlas atlas = new SpriteAtlas();
            // 设置参数 可根据项目具体情况进行设置
            SpriteAtlasPackingSettings packSetting = new SpriteAtlasPackingSettings()
            {
                blockOffset = 1,
                enableRotation = false,
                enableTightPacking = false,
                padding = 2,
            };
            atlas.SetPackingSettings(packSetting);

            SpriteAtlasTextureSettings textureSetting = new SpriteAtlasTextureSettings()
            {
                readable = false,
                generateMipMaps = false,
                sRGB = true,
                filterMode = FilterMode.Bilinear,
            };
            atlas.SetTextureSettings(textureSetting);

            TextureImporterPlatformSettings platformSetting = new TextureImporterPlatformSettings()
            {
                maxTextureSize = 2048,
                format = TextureImporterFormat.Automatic,
                crunchedCompression = true,
                textureCompression = TextureImporterCompression.Compressed,
                compressionQuality = 50,
            };
            atlas.SetPlatformSettings(platformSetting);

            AssetDatabase.CreateAsset(atlas, directory.Append(".spriteatlas"));
            atlas.Add(new[]
            {
                AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(directory)
            });
            EditorUtility.SetDirty(atlas);
            AssetDatabase.Refresh();
        }

    }
}
