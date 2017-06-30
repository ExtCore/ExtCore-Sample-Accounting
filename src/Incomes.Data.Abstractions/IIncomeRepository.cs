// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using ExtCore.Data.Abstractions;
using Incomes.Data.Entities;

namespace Incomes.Data.Abstractions
{
  public interface IIncomeRepository : IRepository
  {
    Income WithKey(int id);
    IEnumerable<Income> All();
    void Create(Income income);
    void Edit(Income income);
    void Delete(int id);
    void Delete(Income income);
    decimal Total();
  }
}