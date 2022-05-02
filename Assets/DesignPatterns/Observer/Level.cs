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

        public int MaxExperiencePoints => m_pointsPerLevel * (CurrentLevel + 1);

        public int CurrentLevel => ExperiencePoints / m_pointsPerLevel;

        public delegate void LevelUpActionType(int currentLevel);

        public event LevelUpActionType OnLevelUp;

        public Action onExperienceChanged;

        public void GainExperience(int amountToGain)
        {
            int previousLevel = CurrentLevel;
            ExperiencePoints += amountToGain;
            onExperienceChanged?.Invoke();
            if (CurrentLevel <= previousLevel) return;

            m_levelUpEvent?.Invoke();
            OnLevelUp?.Invoke(CurrentLevel);
        }
    }
}