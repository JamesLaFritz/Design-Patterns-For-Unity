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
    }
}