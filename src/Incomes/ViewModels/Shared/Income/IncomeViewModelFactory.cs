// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Incomes.Data.Entities;

namespace Incomes.ViewModels.Shared
{
  public class IncomeViewModelFactory
  {
    public IncomeViewModel Create(Income income)
    {
      return new IncomeViewModel()
      {
        Amount = income.Amount,
        Description = income.Description,
        Created = income.Created
      };
    }
  }
}