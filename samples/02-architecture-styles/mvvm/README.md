# Architecture Style Sample: MVVM

This sample focuses only on MVVM markers.

## Why This Style Sample Exists

MVVM is a small but common structural style, and a focused sample keeps the model-view-viewmodel split obvious.

## What You Learn

Covered markers:

- `[Model]`
- `[ViewModel]`
- `[View]`

## Code Walkthrough

- `MvvmSample.cs` keeps the MVVM roles in one minimal example
- the sample exists to show marker intent, not a full UI application
- the three role markers are intentionally kept close together for quick learning

## Try Next

1. Add a second `ViewModel` and bind it to the same `Model`.
2. Add another `View` and keep the view-specific role explicit.
3. Compare this sample with the heavier structural styles in Block 02.
