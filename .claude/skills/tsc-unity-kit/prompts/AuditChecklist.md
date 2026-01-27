# TSC Code Audit Checklist

## 1. Encapsulation & Data
- [ ] **No Public Fields**: ALL serialized fields must be `[SerializeField] private`.
- [ ] **Properties**: Public access must use C# Properties (`=>`).

## 2. Unity 6 Architecture
- [ ] **Async/Await**: Uses `Awaitable` or `UniTask`. NO `IEnumerator` / `Coroutine`.
- [ ] **Component Caching**: `GetComponent` is called in `Awake/Start`, NEVER in `Update`.
- [ ] **Safety**: Uses `TryGetComponent` where dependencies are not guaranteed.

## 3. Performance (Hot Paths)
- [ ] **Zero Alloc**: No `new` keywords in `Update`.
- [ ] **String Ops**: No string concatenation (`+`) in `Update`.
- [ ] **Loops**: No LINQ in `Update`.

## 4. Structure & Naming
- [ ] **Regions**: Follows `Config -> References -> State -> Lifecycle -> API`.
- [ ] **Naming**: `_camelCase` for private, `PascalCase` for public.
