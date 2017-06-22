// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Barebone.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Barebone.ViewComponents
{
  public class StyleSheetsViewComponent : ViewComponent
  {
    public async Task<IViewComponentResult> InvokeAsync()
    {
      return this.View(new StyleSheetsViewModelFactory().Create());
    }
  }
}