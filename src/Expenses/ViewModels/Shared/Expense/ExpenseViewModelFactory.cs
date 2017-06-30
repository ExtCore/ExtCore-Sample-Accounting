// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Expenses.Data.Entities;

namespace Expenses.ViewModels.Shared
{
  public class ExpenseViewModelFactory
  {
    public ExpenseViewModel Create(Expense expense)
    {
      return new ExpenseViewModel()
      {
        Amount = expense.Amount,
        Description = expense.Description,
        Created = expense.Created
      };
    }
  }
}