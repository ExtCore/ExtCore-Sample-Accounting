// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Barebone.ViewModels.Shared
{
  public class StyleSheetsViewModel
  {
    public IEnumerable<StyleSheetViewModel> StyleSheets { get; set; }
  }
}