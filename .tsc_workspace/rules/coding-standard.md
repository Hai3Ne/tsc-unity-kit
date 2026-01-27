# TSC Coding Rules (Unity 6 Edition)

## 1. Variables & Encapsulation
- **Inspector Variables:** ALWAYS use `[SerializeField] private DataType _variableName;`.
- **No Public Fields:** NEVER expose public fields. Use Properties (`public float Speed => _speed;`) for external access.
- **Null Checks:** Use `if (_variable is null)` for object checks where possible to bypass Unity's lifetime check overhead in hot paths, or standard `== null` when Unity Object lifetime check is actually needed.

## 2. Performance & Optimization
- **Cache Components:** Always cache references in `Awake()`. Use `TryGetComponent(out _)` for safety.
- **Hot Paths:** NEVER call `GetComponent`, `Find`, or `FindWithTag` in `Update()`, `FixedUpdate()`, or `LateUpdate()`.
- **Zero Alloc:** Avoid `new` keyword (instantiation), LINQ, or string concatenation in `Update` loops. Use `StringBuilder` or object pooling.
- **Hashing:** Use `Animator.StringToHash` for animation states instead of passing strings.

## 3. Asynchronous (Unity 6)
- **Primary Tool:** Use `Awaitable` (Native Unity 6) or `UniTask`.
- **Legacy Ban:** Avoid `IEnumerator` (Coroutines) for new logic.
- **Pattern:**
```csharp
private async Awaitable MyRoutineAsync() {
    await Awaitable.WaitForSecondsAsync(1f);
}
```

## 4. Naming Conventions
- **Private Fields:** `_camelCase` (e.g., `_playerHealth`)
- **Public Properties:** `PascalCase` (e.g., `PlayerHealth`)
- **Methods:** `PascalCase` (e.g., `CalculateDamage`)
- **Local Variables:** `camelCase` (e.g., `damageAmount`)
- **Interfaces:** Prefix with I (e.g., `IDamageable`)

## 5. Script Structure (Standard Layout)
Every MonoBehaviour MUST follow this region order:
1.  **Configuration** (`[Header]`, `[SerializeField]`)
2.  **References** (Component dependencies)
3.  **Runtime State** (Private non-serialized variables)
4.  **Unity Lifecycle** (`Awake`, `Start`, `Update`)
5.  **Public API** (External methods)
6.  **Internal Logic** (Private helpers, Event handlers)

## 6. Event Handling
- **Pattern:** Use standard C# `event Action` or `UnityEvent`.
- **Cleanup:** ALWAYS unsubscribe from events in `OnDestroy()` or `OnDisable()` to prevent memory leaks.

## 7. Namespaces
- **Root:** `TwoSleepyCats.[GameName].[Module]`
- **Example:** `TwoSleepyCats.Survival.Player`
