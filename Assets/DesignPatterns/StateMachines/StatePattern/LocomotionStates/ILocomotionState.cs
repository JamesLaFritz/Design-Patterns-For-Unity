// ILocomotionState.cs
// 04-13-2022
// James LaFritz

namespace DesignPatterns.StateMachines.StatePattern.LocomotionStates
{
    public interface ILocomotionState
    {
        /// <summary>
        /// This is where you enter the state and do things you only need to do once when you first enter the state.
        /// </summary>
        public void EnterState(ILocomotionContext context);

        /// <summary>
        /// This is where you do any clean-up once before the state changes to a new state.
        /// </summary>
        public void ExitState(ILocomotionContext context);

        /// <summary>
        /// This is where the core update logic, which executes in every frame the state exists.
        /// </summary>
        public void UpdateState(ILocomotionContext context);
    }
}