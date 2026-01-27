# TSC Unity Kit

**Two Sleepy Cats Studio** | *Lazy but Smart*

![Unity 6](https://img.shields.io/badge/Unity-6_LTS-000000?style=for-the-badge&logo=unity)
![Status](https://img.shields.io/badge/Status-Active-success?style=for-the-badge)

## Overview
The **TSC Unity Kit** is a standardized development framework designed for rapid, stable, and clean game development using **Unity 6**. It enforces strict architectural patterns to ensure scalability and maintainability.

### Philosophy
- **Efficient:** Write once, reuse forever.
- **Stable:** Zero-crash mentality. Strict null safety.
- **Clean:** Readable, strictly formatted C# code.


## Setup
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Hai3Ne/tsc-unity-kit.git
   ```
2. **Open Project:** Launch **Unity 6 Hub** and add the cloned folder.
3. **Initialize Agent:**
   - Verify `.claude/config.json` exists.
   - Run command `$Init` to sync the AI Architect.

## Quick Start (AI Agent)
This project is optimized for AI-assisted development.
1. **Initialize:** `tsc-unity-kit` skill loaded.
2. **Command:** Use `CLAUDE.md` for shortcuts.
   - `$Code`: Generate standard MonoBehaviours.
   - `$Check`: Validate against `.tsc_workspace/rules/coding-standard.md`.

## Coding Standards
Adherence to `coding-standard.md` is **mandatory**.
- **No Public Fields:** All serialized data must be `private` with `[SerializeField]`.
- **No Coroutines:** Use `async/await` (`Awaitable`).
- **Safety First:** No `GetComponent` in `Update`.

---
*© Two Sleepy Cats Studio. All rights reserved.*
