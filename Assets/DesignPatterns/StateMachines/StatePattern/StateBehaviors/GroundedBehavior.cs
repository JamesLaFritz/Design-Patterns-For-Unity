// GroundedBehavior.cs
// 04-13-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern.StateBehaviors
{
    public class GroundedBehavior : StateMachineBehaviour
    {
        private static readonly int CrouchPressedID = Animator.StringToHash("CrouchPressed");
        private static readonly int JumpPressedID = Animator.StringToHash("JumpPressed");
        private static readonly int IsGroundedID = Animator.StringToHash("IsGrounded");

        #region Overrides of StateMachineBehaviour

        /// <inheritdoc />
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animator.ResetTrigger(CrouchPressedID);
            animator.ResetTrigger(JumpPressedID);
            base.OnStateEnter(animator, stateInfo, layerIndex);
        }

        /// <inheritdoc />
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateUpdate(animator, stateInfo, layerIndex);

            if (Input.GetKeyDown(KeyCode.C))
                animator.SetTrigger(CrouchPressedID);
            if (Input.GetKeyDown(KeyCode.Space))
                animator.SetTrigger(JumpPressedID);

            if (Random.Range(0, 100) > 90)
                animator.SetBool(IsGroundedID, true);
        }

        #endregion
    }
}