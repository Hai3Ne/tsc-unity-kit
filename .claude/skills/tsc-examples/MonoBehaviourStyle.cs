using UnityEngine;
using System;

namespace TwoSleepyCats.Game.Examples
{
    // [Reference: Agentskills.io Example]
    // This file demonstrates the "Iron Rules" of TSC Unity Kit.
    [RequireComponent(typeof(Rigidbody))]
    public class MonoBehaviourStyle : MonoBehaviour
    {
        #region Configuration
        [Header("Settings")]
        // RULE: No public fields. Use [SerializeField] private.
        [SerializeField] private float _moveSpeed = 5f;
        #endregion

        #region References
        [Header("Dependencies")]
        // RULE: Explicit dependencies.
        [SerializeField] private Rigidbody _rb;
        #endregion

        #region Runtime State
        // RULE: Private state variables underscore _camelCase.
        private bool _isInitialized;
        public float MoveSpeed => _moveSpeed; // Public Access via Property
        #endregion

        #region Unity Lifecycle
        private void Awake()
        {
            // RULE: Cache components in Awake. Use TryGetComponent for safety.
            if (_rb == null && !TryGetComponent(out _rb))
            {
                Debug.LogError($"[TSC-FATAL] Missing RB on {name}");
                enabled = false;
                return;
            }
            _isInitialized = true;
        }

        private void Update()
        {
            if (!_isInitialized) return;
            // RULE: No Allocations (new) in Update.
            // RULE: No GetComponent in Update.
        }
        #endregion

        #region Internal Logic
        // RULE: Use Awaitable (Unity 6) instead of Coroutine.
        private async Awaitable CooldownAsync()
        {
            await Awaitable.WaitForSecondsAsync(1f);
        }
        #endregion
    }
}
