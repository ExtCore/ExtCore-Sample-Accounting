// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using ExtCore.Data.Abstractions;
using Incomes.Data.Abstractions;
using Incomes.ViewModels.Shared;

namespace Incomes.ViewModels.Incomes
{
  public class IndexViewModelFactory
  {
    public IndexViewModel Create(IStorage storage)
    {
      return new IndexViewModel()
      {
        Incomes = storage.GetRepository<IIncomeRepository>().All().Select(
          i => new IncomeViewModelFactory().Create(i)
        )
      };
    }
  }
}