// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Expenses.Data.Entities;

namespace Expenses.ViewModels.Expenses
{
  public class CreateViewModelMapper
  {
    public Expense Map(CreateViewModel createViewModel)
    {
      return new Expense()
      {
        Amount = createViewModel.Amount,
        Description = createViewModel.Description,
        Created = DateTime.Now
      };
    }
  }
}