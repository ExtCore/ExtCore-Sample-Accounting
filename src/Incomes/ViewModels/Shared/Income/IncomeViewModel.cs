// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Incomes.ViewModels.Shared
{
  public class IncomeViewModel
  {
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
  }
}