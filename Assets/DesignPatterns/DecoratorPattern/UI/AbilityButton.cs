// AbilityButton.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.StrategyPattern;
using UnityEngine;

namespace DesignPatterns.DecoratorPattern.UI
{
    public abstract class AbilityButton<T> : MonoBehaviour, IAbility where T : IAbility, new()
    {
        protected T m_ability = new T();

        public abstract void Use();
    }
}