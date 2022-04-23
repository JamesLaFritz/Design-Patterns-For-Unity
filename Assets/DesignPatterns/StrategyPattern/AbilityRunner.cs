// AbilityRunner.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class AbilityRunner : MonoBehaviour
    {
        enum Ability
        {
            FireBall,
            Rage,
            Heal
        }

        [SerializeField] private Ability m_currentAbility = Ability.FireBall;

        public void UseAbility()
        {
            switch (m_currentAbility)
            {
                case Ability.FireBall:
                    Debug.Log("Launch Fireball");
                    break;
                case Ability.Rage:
                    Debug.Log("Launch Fireball");
                    break;
                case Ability.Heal:
                    Debug.Log("Launch Fireball");
                    break;
                default:
                    Debug.Log("No Ability Selected using Default: Launch Fireball");
                    break;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UseAbility();
            }
        }
    }
}