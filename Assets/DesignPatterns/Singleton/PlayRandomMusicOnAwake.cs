// PlayRandomMusicOnAwake.cs
// 04-04-2022
// James LaFritz

using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{
    public class PlayRandomMusicOnAwake : MonoBehaviour
    {
        [SerializeField] private List<AudioClip> m_audioClips;

        private void Awake()
        {
            if (m_audioClips == null || m_audioClips.Count < 1)
            {
                Destroy(this);
            }
        }
    }
}