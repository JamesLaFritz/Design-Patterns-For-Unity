// AbilityChanger.cs
// 04-23-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    [RequireComponent(typeof(AbilityRunner))]
    public class AbilityChanger : MonoBehaviour
    {
        private AbilityRunner m_abilityRunner;

        private void Awake()
        {
            m_abilityRunner = GetComponent<AbilityRunner>();
        }

        private void Start()
        {
            m_abilityRunner.CurrentAbility = new FireBallAbility();
        }

        private void Update()
        {
            IAbility currentAbility = m_abilityRunner.CurrentAbility;

            if (Input.GetKeyDown(KeyCode.F) && currentAbility is not FireBallAbility)
                m_abilityRunner.CurrentAbility = new FireBallAbility();
            if (Input.GetKeyDown(KeyCode.H) && currentAbility is not HealAbility)
                m_abilityRunner.CurrentAbility = new HealAbility();
            if (Input.GetKeyDown(KeyCode.M) && currentAbility is not MeleeAbility)
                m_abilityRunner.CurrentAbility = new MeleeAbility();
            if (Input.GetKeyDown(KeyCode.R) && currentAbility is not RageAbility)
                m_abilityRunner.CurrentAbility = new RageAbility();
        }
    }
}