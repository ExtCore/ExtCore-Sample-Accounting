// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Expenses.ViewModels.Shared;

namespace Expenses.ViewModels.Expenses
{
  public class IndexViewModel
  {
    public IEnumerable<ExpenseViewModel> Expenses { get; set; }
  }
}