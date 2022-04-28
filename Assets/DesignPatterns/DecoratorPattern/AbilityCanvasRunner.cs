// AbilityRunner.cs
// 04-24-2022
// James LaFritz

using DesignPatterns.CompositePattern;
using DesignPatterns.StrategyPattern;
using UnityEngine;

namespace DesignPatterns.DecoratorPattern
{
    public class AbilityCanvasRunner : MonoBehaviour
    {
        private IAbility m_currentAbility;

        public IAbility CurrentAbility
        {
            get => m_currentAbility;
            set => m_currentAbility = value;
        }

        private readonly SequenceAbility m_powerAttackAbility = new SequenceAbility(
            new IAbility[]
            {
                new HealAbility(), new RageAbility(),
                new ParallelAbility(new IAbility[]
                {
                    new MeleeAbility(),
                    new DelayedDecorator(new MeleeAbility())
                })
            });

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Use();
            }
        }

        private void Use()
        {
            m_currentAbility?.Use();
        }

        public void SetPowerAttackAbility()
        {
            m_currentAbility = m_powerAttackAbility;
            Use();
        }

        public void SetFireballAbility()
        {
            if (m_currentAbility is not DelayedDecorator && (m_currentAbility as DelayedDecorator)?.Ability is not FireBallAbility)
                m_currentAbility = new DelayedDecorator(new FireBallAbility());

            Use();
        }

        public void SetHealAbility()
        {
            if (m_currentAbility is not HealAbility)
                m_currentAbility = new HealAbility();
            Use();
        }

        public void SetMeleeAbility()
        {
            if (m_currentAbility is not MeleeAbility)
                m_currentAbility = new MeleeAbility();
            Use();
        }

        public void SetRageAbility()
        {
            if (m_currentAbility is not CoolDownDecorator &&
                (m_currentAbility as CoolDownDecorator)?.Ability is not RageAbility)
                m_currentAbility = new CoolDownDecorator(new RageAbility());
            Use();
        }
    }
}