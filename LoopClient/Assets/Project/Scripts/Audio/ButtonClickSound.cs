/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-15
 *Description:    Description
 *History:        2022-04-15--
*********************************************************************************/
using System;

using UnityEngine;
using IFramework;
using UnityEngine.UI;

namespace LoopClient
{
    [RequireComponent(typeof(Button))]
    public class ButtonClickSound : MonoBehaviour
    {
        public string path = "Assets/Project/Audios/click.mp3";
        private Button btn;
        private void Awake()
        {
            btn = GetComponent<Button>();
        }
        private void OnEnable()
        {
            btn.onClick.AddListener(Listen);

        }
        private void OnDisable()
        {
            btn.onClick.RemoveListener(Listen);
        }
        private void Listen()
        {
            LoopClientGame game = Launcher.Instance.game as LoopClientGame;
            if (string.IsNullOrEmpty(path)) return;
            game.unityModules.Audio.PlaySound(path);
        }

    }
}
