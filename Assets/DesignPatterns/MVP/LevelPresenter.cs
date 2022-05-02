// LevelPresenter.cs
// 05-02-2022
// James LaFritz

using Observer;
using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.MVP
{
    public class LevelPresenter : MonoBehaviour
    {
        [SerializeField] private Level m_level;

        [SerializeField] private Slider m_xpSlider;

        [SerializeField] private Text m_levelText;

        [SerializeField] private Button m_gainXPButton;

        private void Awake()
        {
            if (m_level == null)
            {
                Debug.LogWarning(
                    "Level Presenter needs a Level to present please make sure one is set in The Inspector",
                    gameObject);
                enabled = false;
            }

            if (m_xpSlider == null)
            {
                Debug.LogWarning(
                    "Level Presenter needs a Slider to Update please make sure one is set in The Inspector",
                    gameObject);
                enabled = false;
            }

            if (m_levelText == null)
            {
                Debug.LogWarning(
                    "Level Presenter needs a Text to Update please make sure one is set in The Inspector",
                    gameObject);
                enabled = false;
            }
        }

        private void OnEnable()
        {
            m_gainXPButton?.onClick.AddListener(OnGainExperienceClicked);

            m_level.onExperienceChanged += OnExperienceChanged;
            m_level.OnLevelUp += OnLevelUp;
        }

        private void OnDisable()
        {
            m_gainXPButton?.onClick.RemoveListener(OnGainExperienceClicked);

            m_level.onExperienceChanged -= OnExperienceChanged;
            m_level.OnLevelUp -= OnLevelUp;
        }

        private void OnGainExperienceClicked()
        {
            m_level.GainExperience(10);
        }

        private void OnExperienceChanged() { }

        private void OnLevelUp(int currentlevel) { }
    }
}