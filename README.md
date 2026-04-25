# BE Unity Shared

`com.be.unity.shared` is the shared Unity package for Board Enthusiasts Unity apps.

The package is intentionally platform-neutral. It may contain reusable UI Toolkit theme assets, MVVMC contracts, logging abstractions, and lightweight UI helpers, but it must not depend on the Board SDK, Android-only APIs, desktop-only process execution, or app-specific storage.

## Usage

Reference the package from a Unity project manifest:

```json
"com.be.unity.shared": "file:../unity-shared"
```

## Styling

USS in this package must use only properties supported by Unity 6.4:

[Unity 6.4 USS properties](https://docs.unity3d.com/6000.4/Documentation/Manual/UIE-USS-Properties-Reference.html)

