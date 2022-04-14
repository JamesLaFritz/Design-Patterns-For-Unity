using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern.StateBehaviors
{
    public class InAirBehavior : StateMachineBehaviour
    {
        private static readonly int IsGroundedID = Animator.StringToHash("IsGrounded");

        [SerializeField] private float m_airTime = 2;
        private float m_currentAirTime = 0;

        #region Overrides of StateMachineBehaviour

        /// <inheritdoc />
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateEnter(animator, stateInfo, layerIndex);
            animator.SetBool(IsGroundedID, false);
        }

        /// <inheritdoc />
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateExit(animator, stateInfo, layerIndex);
            m_currentAirTime = 0;
        }

        /// <inheritdoc />
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateUpdate(animator, stateInfo, layerIndex);

            m_currentAirTime += Time.deltaTime;

            if (m_currentAirTime > m_airTime)
                animator.SetBool(IsGroundedID, true);
        }

        #endregion
    }
}