// LocomotionAnimatorController.cs
// 04-13-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.StatePattern
{
    [RequireComponent(typeof(Animator))]
    public class LocomotionAnimatorController : MonoBehaviour
    {
        private Animator m_animator;
        private static readonly int CrouchPressedID = Animator.StringToHash("CrouchPressed");
        private static readonly int JumpPressedID = Animator.StringToHash("JumpPressed");

        private void Awake()
        {
            m_animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
                m_animator.SetTrigger(CrouchPressedID);

            if (Input.GetKeyDown(KeyCode.Space))
                m_animator.SetTrigger(JumpPressedID);
        }
    }
}