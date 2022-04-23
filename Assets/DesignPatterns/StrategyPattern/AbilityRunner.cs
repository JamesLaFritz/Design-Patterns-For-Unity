// AbilityRunner.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class AbilityRunner : MonoBehaviour
    {
        [SerializeField] private IAbility m_currentAbility;

        /*public void UseAbility()
        {
            switch (m_currentAbility)
            {
                case Ability.FireBall:
                    Debug.Log("Launch Fireball");
                    break;
                case Ability.Rage:
                    Debug.Log("Rage Mode");
                    break;
                case Ability.Heal:
                    Debug.Log("This should cure your wounds");
                    break;
                case Ability.Melee:
                    Debug.Log("Laying down the smack down!");
                    break;
                default:
                    Debug.Log("No Ability Selected using Default: Launch Fireball");
                    break;
            }
        }*/

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_currentAbility?.Use();
            }
        }
    }
}