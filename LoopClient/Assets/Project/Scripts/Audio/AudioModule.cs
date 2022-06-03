/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-15
 *Description:    Description
 *History:        2022-04-15--
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using IFramework;
using IFramework.Hotfix.Asset;
using IFramework.Modules;
using UnityEngine;

namespace LoopClient
{
    public class AudioEntity : Unit
    {
        public AudioSource source;
        public AudioModule module;
        public bool sound;
        public AudioEntity(AudioSource source)
        {
            this.source = source;
        }
        public void Play(AudioClip audio, bool loop)
        {

            source.clip = audio;
            var volume = sound ? module.soundVolume : module.musicVolume;
            bool mute = sound ? module.soundMute : module.musicMute;
            source.volume = volume;
            source.loop = loop;
            source.mute = mute;
            source.Play();
            if (!loop)
                Reclye(audio);
        }

        private async void Reclye(AudioClip clip)
        {
            float time = clip.length;
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(time));
            module.SetEntity(this);
        }

        protected override void OnDispose()
        {

        }
    }
    public class AudioSaveData
    {
        public float soundVolume, musicVolume;
        public bool soundMute, musicMute;
    }
    public class AudioModule : Module
    {

        public ObservableValue<float> soundVolume = new ObservableValue<float>(1);
        public ObservableValue<float> musicVolume = new ObservableValue<float>(1);
        public ObservableValue<bool> soundMute = new ObservableValue<bool>(false);
        public ObservableValue<bool> musicMute = new ObservableValue<bool>(false);

        public GameObject root { get { return _root; } }
        private GameObject _root;
        private EntityPool pool;
        private class EntityPool : ObjectPool<AudioEntity>
        {
            public GameObject root;

            public EntityPool(GameObject root)
            {
                this.root = root;
            }

            protected override AudioEntity CreatNew(IEventArgs arg)
            {
                AudioSource audio = root.AddComponent<AudioSource>();
                AudioEntity entity = new AudioEntity(audio);
                return entity;
            }
        }
        public void ReadData(AudioSaveData data)
        {
            if (data == null) return;
            soundVolume.value = data.soundVolume;
            musicVolume.value = data.musicVolume;
            musicMute.value = data.musicMute;
            soundMute.value = data.soundMute;
        }
        public AudioSaveData GetSaveData()
        {
            return new AudioSaveData()
            {
                soundMute = soundMute.value,
                soundVolume = soundVolume.value,
                musicVolume = musicVolume.value,
                musicMute = musicMute.value,
            };
        }



        public AudioEntity GetEntity()
        {
            var entity = pool.Get();
            entity.module = this;
            return entity;
        }

        public void SetEntity(AudioEntity entity)
        {
            pool.Set(entity);
        }
        public async void PlaySound(string path)
        {
            var asset = await Assets.LoadAsset(path);
            AudioClip clip = asset.GetAsset<AudioClip>();
            AudioEntity entity = GetEntity();
            entity.Play(clip, false);
        }


        protected override void Awake()
        {
            _root = new GameObject(name);
            pool = new EntityPool(_root);
        }

        protected override void OnDispose()
        {
            pool.Dispose();
        }



    }
}
