// LocomotionAnimatorFSM.cs
// 04-10-2022
// James LaFritz

using UnityEngine;

namespace DesignPatterns.StateMachines.FSM
{
    [RequireComponent(typeof(Animator))]
    public class LocomotionAnimatorFSM : MonoBehaviour
    {
        private Animator m_animator;

        private static readonly int IsGroundedID = Animator.StringToHash("IsGrounded");
        private static readonly int CrouchID = Animator.StringToHash("Crouch");

        private void Start()
        {
            m_animator = GetComponent<Animator>();
        }

        private void Update()
        {
            bool isGrounded = m_animator.GetBool(IsGroundedID);
            if (!isGrounded)
            {
                // Simulate Physics of the character being in the air gravity is being applied
                if (Random.Range(0, 10000) > 5999)
                {
                    m_animator.SetBool(IsGroundedID, true);
                }

                return;
            }

            // Simulate physics and the character falling of a ledge
            if (Random.Range(0, 10000) > 9999)
            {
                m_animator.SetBool(IsGroundedID, false);
                return;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_animator.SetBool(m_animator.GetBool(CrouchID) ? CrouchID : IsGroundedID, false);
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                m_animator.SetBool(CrouchID, !m_animator.GetBool(CrouchID));
            }
        }
    }
}