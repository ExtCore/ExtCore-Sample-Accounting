// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Expenses.ViewModels.Shared
{
  public class ExpenseViewModel
  {
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
  }
}