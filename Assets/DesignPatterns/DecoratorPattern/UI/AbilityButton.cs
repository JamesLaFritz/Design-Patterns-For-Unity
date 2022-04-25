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

        [SerializeField] protected AbilityCanvasRunner m_abilityRunner;

        protected virtual void Awake()
        {
            if (m_abilityRunner != null) return;
            try
            {
                m_abilityRunner = FindObjectOfType<AbilityCanvasRunner>();
            }
            catch (System.Exception e)
            {
                Debug.LogError(e);
                Destroy(this);
            }

            if (m_abilityRunner != null) return;

            Debug.LogWarning("No Ability Runner found please make sure that there is one in the scene and assigned in the Inspector", gameObject);

            Destroy(this);
        }

        public void SetAbility()
        {
            m_abilityRunner.CurrentAbility = m_ability;
        }

        public virtual void Use()
        {
            SetAbility();
            m_ability.Use();
        }
    }
}