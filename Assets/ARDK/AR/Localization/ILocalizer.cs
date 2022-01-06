// Copyright 2021 Niantic, Inc. All Rights Reserved.

using System;
using Niantic.ARDK.Utilities;

namespace Niantic.ARDK.AR.Localization
{
  /// @note This is an experimental feature, and may be changed or removed in a future release.
  ///   This feature is currently not functional or supported.
  public interface ILocalizer:
    IDisposable
  {
    /// Starts an attempt to detect a nearby world coordinate space.
    /// @note A location service must be attached to the session.
    /// @param config
    ///   Localization Configuration
    /// @note This is an experimental feature, and may be changed or removed in a future release.
    ///   This feature is currently not functional or supported.
    void StartLocalization(ILocalizationConfiguration config);

    /// Stops an ongoing process of detecting a world coordinate space.
    /// @param localization
    ///   The attempt to interrupt.
    /// @note This is an experimental feature, and may be changed or removed in a future release.
    ///   This feature is currently not functional or supported.
    void StopLocalization();

    /// Alerts subscribers when the localization process changes state.
    /// @note This is an experimental feature, and may be changed or removed in a future release.
    ///   This feature is currently not functional or supported.
    event ArdkEventHandler<LocalizationProgressArgs> LocalizationProgressUpdated;
  }
}
