// Debugger.cs
// 03-01-2022
// James LaFritz

using System.Collections;
using UnityEngine;

namespace Observer
{
    [RequireComponent(typeof(Health), typeof(Level))]
    public class Debugger : MonoBehaviour
    {
        private IEnumerator Start()
        {
            Health health = GetComponent<Health>();
            Level level = GetComponent<Level>();
            while (true)
            {
                yield return new WaitForSeconds(1);
                Debug.Log($"Exp: {level!.ExperiencePoints}, Level: {level.CurrentLevel}, Health: {health!.CurrentHealth}");
            }
        }
    }
}