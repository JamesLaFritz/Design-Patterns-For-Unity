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
    }
}