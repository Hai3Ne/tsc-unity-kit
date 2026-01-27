# TSC Unity Kit

**Two Sleepy Cats Studio** | *Lazy but Smart*

![Unity 6](https://img.shields.io/badge/Unity-6_LTS-000000?style=for-the-badge&logo=unity)
![Claude Code](https://img.shields.io/badge/Claude_Code-CLI-d97757?style=for-the-badge&logo=anthropic)
![Antigravity](https://img.shields.io/badge/Antigravity-Agent-4285F4?style=for-the-badge&logo=google)
![Status](https://img.shields.io/badge/Status-Active-success?style=for-the-badge)

## Overview
The **TSC Unity Kit** is a standardized development framework designed for rapid, stable, and clean game development. It leverages AI Agents to automate repetitive tasks while enforcing strict architectural patterns.

---

## 🤖 AI Agent Setup
This kit is built to be driven by AI. Choose your preferred environment:

### Option A: Claude Code (CLI)
*Recommended for command-line users.*

1.  **Prerequisites:**
    -   Node.js v20+ installed.
2.  **Installation:**
    ```bash
    npm install -g @anthropic-ai/claude-code
    ```
3.  **Authentication:**
    ```bash
    claude login
    ```
4.  **Running:**
    Navigate to the project root and run:
    ```bash
    claude
    ```
5.  **Verification:**
    Type `$init` to verify the kit is loaded.

### Option B: Antigravity (IDE Integration)
*Recommended for Cursor/VSCode users.*

1.  **Configuration:**
    -   Ensure `.claude/config.json` is present in the root.
    -   Antigravity will automatically detect the **Skills** defined in config.
2.  **Usage:**
    -   Simply type natural language commands or use shortcuts defined in `CLAUDE.md`.
3.  **Verification:**
    -   Ask the agent: *"Run $init to check system status."*

---

## 🛠️ Quick Start
1.  **Clone the Repository:**
    ```bash
    git clone https://github.com/Hai3Ne/tsc-unity-kit.git
    ```
2.  **Open Project:** Launch **Unity 6 Hub** and add the cloned folder.
3.  **Initialize Agent:**
    - Run command `$init` to sync the AI Architect context.


## ⚡ Command Reference
See `CLAUDE.md` for the full list.
- `$code [Feature]`: Generate standard MonoBehaviour.
- `$check`: Audit code against Iron Rules.
- `$docs [Topic]`: Search documentation.

---

## ⚖️ License
This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

For third-party software attribution, please see [THIRD_PARTY_NOTICES.md](THIRD_PARTY_NOTICES.md).

---
*© Two Sleepy Cats Studio. All rights reserved.*
