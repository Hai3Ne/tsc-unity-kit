# TSC Code Audit Checklist

## 1. Encapsulation & Data
- [ ] **No Public Fields**: ALL serialized fields must be `[SerializeField] private`.
- [ ] **Properties**: Public access must use C# Properties (`=>`).

## 2. Unity 6 Architecture
- [ ] **Async/Await**: Uses `Awaitable`. NO `IEnumerator` / `Coroutine`.
- [ ] **Component Caching**: `GetComponent` is called in `Awake/Start`, NEVER in `Update`.
- [ ] **Safety**: Uses `TryGetComponent` where dependencies are not guaranteed.

## 3. Performance (Hot Paths)
- [ ] **Zero Alloc**: No `new` keywords in `Update`.
- [ ] **String Ops**: No string concatenation (`+`) in `Update`.
- [ ] **Loops**: No LINQ in `Update`.

## 4. Structure & Naming
- [ ] **Regions**: Follows `Config -> References -> State -> Lifecycle -> API -> Internal`.
- [ ] **Naming**: `_camelCase` for private, `PascalCase` for public.

## 5. Agent Quality
- [ ] **Scope**: The change stays within the requested outcome.
- [ ] **Simplicity**: No unnecessary abstractions or premature extension points were added.
- [ ] **Verification**: The result has a clear success check or supporting evidence.
