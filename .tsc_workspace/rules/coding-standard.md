# TSC Iron Rules (Token Optimized)

1.  **Encapsulation:**
    -   `[SerializeField] private Type _field;` (Mandatory).
    -   `public float Property => _field;` (Access).
    -   NO `public` fields.

2.  **Unity 6 Architecture:**
    -   Use `Awaitable` (Native). NO `IEnumerator`.
    -   Cache all Components in `Awake()`.
    -   NO `GetComponent/Find` in `Update()`.

3.  **Style:**
    -   Region Order: Config -> Refs -> State -> Lifecycle -> API -> Internal.
    -   Naming: `_private`, `Public`, `local`.

4.  **Safety:**
    -   Use `TryGetComponent(out _)` for dependencies.
    -   Unsubscribe events in `OnDestroy`.
