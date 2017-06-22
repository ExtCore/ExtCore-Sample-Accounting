// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Incomes.ViewModels.Shared;

namespace Incomes.ViewModels.Incomes
{
  public class IndexViewModel
  {
    public IEnumerable<IncomeViewModel> Incomes { get; set; }
  }
}