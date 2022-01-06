// Copyright 2021 Niantic, Inc. All Rights Reserved.

using Niantic.ARDK.Utilities;

namespace Niantic.ARDK.AR.Localization
{
  /// @note This is an experimental feature, and may be changed or removed in a future release.
  ///   This feature is currently not functional or supported.
  public struct LocalizationProgressArgs:
    IArdkEventArgs
  {
    public LocalizationProgressArgs
    (
      LocalizationState state,
      LocalizationFailureReason failureReason,
      float confidence,
      ARWorldCoordinateSpace worldCoordinateSpace
    )
      : this()
    {
      State = state;
      FailureReason = failureReason;
      Confidence = confidence;
      WorldCoordinateSpace = worldCoordinateSpace;
    }

    /// What the current state of the localization process is.
    public LocalizationState State { get; }

    /// The reason why the localization process failed, if State is Failed. None if otherwise.
    public LocalizationFailureReason FailureReason { get; }

    /// How confident ARDK is about the Transform value.
    /// Changes to this value will be broadcast by the WorldCoordinateSpaceUpdated event.
    /// Ranges from 0.0 to 1.0. However, this confidence is not linear.
    /// @note For now, this value can be ignored, as the native algorithm is only surfacing "good"
    ///   localizations, and not "limited" ones.
    public float Confidence { get; }

    /// The coordinate space detected by the localization process.
    /// Only non-null when State is Localized.
    public ARWorldCoordinateSpace WorldCoordinateSpace { get; }
  }
}
