// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Expenses.Data.Entities;
using ExtCore.Data.Abstractions;

namespace Expenses.Data.Abstractions
{
  public interface IExpenseRepository : IRepository
  {
    Expense WithKey(int id);
    IEnumerable<Expense> All();
    void Create(Expense expense);
    void Edit(Expense expense);
    void Delete(int id);
    void Delete(Expense expense);
    decimal Total();
  }
}