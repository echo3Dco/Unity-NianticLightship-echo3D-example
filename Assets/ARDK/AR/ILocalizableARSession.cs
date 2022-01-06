using Niantic.ARDK.AR;
using Niantic.ARDK.AR.Localization;

namespace Niantic.ARDK.AR
{
  /// An AR session that includes an ILocalizer
  /// @note This is an experimental feature, and may be changed or removed in a future release.
  ///   This feature is currently not functional or supported.
  public interface ILocalizableARSession : 
    IARSession
  {
    /// Get the localizer associated with this session
    /// @note This is an experimental feature, and may be changed or removed in a future release.
    ///   This feature is currently not functional or supported.
    ILocalizer Localizer { get; }
  }
}
