// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Expenses.Data.Abstractions;
using ExtCore.Data.Abstractions;
using Incomes.Data.Abstractions;

namespace Balance.ViewModels.Balance
{
  public class IndexViewModelFactory
  {
    public IndexViewModel Create(IStorage storage)
    {
      return new IndexViewModel()
      {
        Total = storage.GetRepository<IIncomeRepository>().Total() - storage.GetRepository<IExpenseRepository>().Total()
      };
    }
  }
}