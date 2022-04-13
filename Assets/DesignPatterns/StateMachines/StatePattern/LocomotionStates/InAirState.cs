// AirState.cs
// 04-13-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern.LocomotionStates
{
    public class InAirState : ILocomotionState
    {
        #region Implementation of ILocomotionState

        /// <inheritdoc />
        public void EnterState(ILocomotionContext context) { }

        /// <inheritdoc />
        public void ExitState(ILocomotionContext context) { }

        /// <inheritdoc />
        public void UpdateState(ILocomotionContext context)
        {
            // Simulate Physics of the character being in the air gravity is being applied
            if (Random.Range(0, 10000) > 6999)
            {
                context.SetState(new GroundedState());
            }
        }

        #endregion
    }
}