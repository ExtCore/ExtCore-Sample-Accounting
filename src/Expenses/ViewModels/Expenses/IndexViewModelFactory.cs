// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using Expenses.Data.Abstractions;
using Expenses.ViewModels.Shared;
using ExtCore.Data.Abstractions;

namespace Expenses.ViewModels.Expenses
{
  public class IndexViewModelFactory
  {
    public IndexViewModel Create(IStorage storage)
    {
      return new IndexViewModel()
      {
        Expenses = storage.GetRepository<IExpenseRepository>().All().Select(
          e => new ExpenseViewModelFactory().Create(e)
        )
      };
    }
  }
}