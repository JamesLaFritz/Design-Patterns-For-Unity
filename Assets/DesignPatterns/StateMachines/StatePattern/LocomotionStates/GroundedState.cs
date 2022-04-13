// GroundedState.cs
// 04-13-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern.LocomotionStates
{
    public class GroundedState : ILocomotionState
    {
        #region Implementation of ILocomotionState

        /// <inheritdoc />
        public void EnterState(ILocomotionContext context) { }

        /// <inheritdoc />
        public void ExitState(ILocomotionContext context) { }

        /// <inheritdoc />
        public void UpdateState(ILocomotionContext context)
        {
            // Simulate physics and the character falling of a ledge
            if (Random.Range(0, 10000) > 9999)
            {
                context.SetState(new InAirState());
                return;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                context.SetState(new InAirState());
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                context.SetState(new CrouchingState());
            }
        }

        #endregion
    }
}