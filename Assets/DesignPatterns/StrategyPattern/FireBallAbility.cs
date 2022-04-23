// FireBallAbility.cs
// 04-22-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StrategyPattern
{
    public class FireBallAbility : IAbility
    {
        #region Implementation of IAbility

        /// <inheritdoc />
        public void Use()
        {
            Debug.Log("Launch Fireball");
        }

        #endregion
    }
}