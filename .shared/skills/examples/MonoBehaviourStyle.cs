using UnityEngine;

namespace TwoSleepyCats.Game.Examples
{
    // Canonical TSC example for a simple Unity 6 MonoBehaviour.
    [RequireComponent(typeof(Rigidbody))]
    public class MonoBehaviourStyle : MonoBehaviour
    {
        #region Configuration
        [Header("Settings")]
        [SerializeField] private float _moveSpeed = 5f;
        #endregion

        #region References
        [Header("Dependencies")]
        [SerializeField] private Rigidbody _rigidbody;
        #endregion

        #region Runtime State
        private bool _isInitialized;
        public float MoveSpeed => _moveSpeed;
        #endregion

        #region Unity Lifecycle
        private void Awake()
        {
            if (_rigidbody == null && !TryGetComponent(out _rigidbody))
            {
                Debug.LogError($"[TSC-FATAL] Missing Rigidbody on {name}");
                enabled = false;
                return;
            }

            _isInitialized = true;
        }

        private void Update()
        {
            if (!_isInitialized)
            {
                return;
            }
        }
        #endregion

        #region Internal Logic
        private async Awaitable CooldownAsync()
        {
            await Awaitable.WaitForSecondsAsync(1f);
        }
        #endregion
    }
}
