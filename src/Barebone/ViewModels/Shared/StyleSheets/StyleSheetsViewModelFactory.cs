// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Infrastructure;
using Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Barebone.ViewModels.Shared
{
  public class StyleSheetsViewModelFactory
  {
    public StyleSheetsViewModel Create()
    {
      List<StyleSheet> styleSheets = new List<StyleSheet>();

      foreach (IExtensionMetadata extensionMetadata in ExtensionManager.GetInstances<IExtensionMetadata>())
        styleSheets.AddRange(extensionMetadata.StyleSheets);

      return new StyleSheetsViewModel()
      {
        StyleSheets = styleSheets.OrderBy(ss => ss.Position).Select(
          ss => new StyleSheetViewModelFactory().Create(ss)
        )
      };
    }
  }
}