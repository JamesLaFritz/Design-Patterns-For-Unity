// Level.cs
// 03-01-2022
// James LaFritz

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Observer
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private UnityEvent m_levelUpEvent;
        [SerializeField] private int m_pointsPerLevel = 200;
        public int ExperiencePoints { get; private set; }

        public int CurrentLevel => ExperiencePoints / m_pointsPerLevel;

        public Action<int> LevelUpIntAction;

        public Action levelUpAction;

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
            int previousLevel = CurrentLevel;
            ExperiencePoints += amountToGain;
            if (CurrentLevel > previousLevel)
            {
                m_levelUpEvent.Invoke();
                if (LevelUpIntAction != null)
                    LevelUpIntAction.Invoke(CurrentLevel);
                if (levelUpAction != null)
                    levelUpAction.Invoke();
            }
        }
    }
}