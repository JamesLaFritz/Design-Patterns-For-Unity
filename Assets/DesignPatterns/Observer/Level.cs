// Level.cs
// 03-01-2022
// James LaFritz

using System.Collections;
using UnityEngine;

namespace Observer
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private int m_pointsPerLevel = 200;
        public int ExperiencePoints { get; private set; }

        public int CurrentLevel => ExperiencePoints / m_pointsPerLevel;

        private IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.2f);
                GainExperience(10);
            }
        }

        public void GainExperience(int amountToGain)
        {
            ExperiencePoints += amountToGain;
        }
    }
}