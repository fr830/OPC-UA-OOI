﻿
namespace UAOOI.Networking.SemanticData.Common
{

  /// <summary>
  /// Enum HandlerState - represents states of an configurable object. 
  /// </summary>
  public enum HandlerState
  {

    /// <summary>
    /// The handler is not configured and cannot be enabled.
    /// </summary>
    NoConfiguration,
    /// <summary>
    /// The handler is configured but currently disabled.
    /// </summary>
    Disabled,
    /// <summary>
    /// The handler is operational.
    /// </summary>
    Operational,
    /// <summary>
    /// The handler is in an error state, i.e. cannot change the state to Operational. Similar to NoConfiguration state but after an error occurs.
    /// </summary>
    Error

  }
}
