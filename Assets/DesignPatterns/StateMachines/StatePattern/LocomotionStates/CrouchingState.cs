// CrouchingState.cs
// 04-13-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern.LocomotionStates
{
    public class CrouchingState : ILocomotionState
    {
        #region Implementation of ILocomotionState

        /// <inheritdoc />
        public void UpdateState(ILocomotionContext context)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                context.SetState(new GroundedState());
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                context.SetState(new GroundedState());
            }
        }

        /// <inheritdoc />
        public void EnterState(ILocomotionContext context) { }

        /// <inheritdoc />
        public void ExitState(ILocomotionContext context) { }

        #endregion
    }
}