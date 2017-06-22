// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Infrastructure
{
  public interface IExtensionMetadata
  {
    IEnumerable<StyleSheet> StyleSheets { get; }
    IEnumerable<Script> Scripts { get; }
    IEnumerable<MenuItem> MenuItems { get; }
  }
}