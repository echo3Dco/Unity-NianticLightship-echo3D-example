// Copyright 2021 Niantic, Inc. All Rights Reserved.

namespace Niantic.ARDK.AR.Localization
{
  public static class LocalizationConfigurationFactory
  {
    /// Initializes a new instance of the LocalizationConfiguration class.
    public static ILocalizationConfiguration Create()
    {
      if (NativeAccess.Mode == NativeAccess.ModeType.Native)
        return new _NativeLocalizationConfiguration();

#pragma warning disable 0162
      return new _SerializableLocalizationConfiguration();
#pragma warning restore 0162
    }
  }
}
