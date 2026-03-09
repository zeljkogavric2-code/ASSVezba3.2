
# Legacy Order System (Architecture Refactoring Exercise)

This project intentionally contains architectural problems.

Approximate size: 20+ classes.

Features:
- Create order
- Add items
- Calculate total
- Save to JSON
- Email notification

Problems students should detect:
- UI depends on services
- Services depend on infrastructure
- No dependency inversion
- No application layer separation
- Static helpers
- Tight coupling

Goal:
Refactor into architecture:

Presentation
Application
Domain
Infrastructure
