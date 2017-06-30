// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Incomes.Data.Entities;

namespace Incomes.ViewModels.Incomes
{
  public class CreateViewModelMapper
  {
    public Income Map(CreateViewModel createViewModel)
    {
      return new Income()
      {
        Amount = createViewModel.Amount,
        Description = createViewModel.Description,
        Created = DateTime.Now
      };
    }
  }
}