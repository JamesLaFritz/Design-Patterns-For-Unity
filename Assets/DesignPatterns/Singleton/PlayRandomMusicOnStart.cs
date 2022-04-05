// PlayRandomMusicOnStart.cs
// 04-04-2022
// James LaFritz

using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Singleton
{
    public class PlayRandomMusicOnStart : MonoBehaviour
    {
        [SerializeField] private List<AudioClip> m_audioClips;

        private void Start()
        {
            if (m_audioClips == null || m_audioClips.Count < 1)
            {
                Destroy(this);
            }

            try
            {
                AmbientAudioPlayer.GetInstance()!.Play(m_audioClips[Random.Range(0, m_audioClips.Count)]);
            }
            catch (Exception e)
            {
                Debug.LogWarning(e);
                Destroy(this);
            }
        }
    }
}