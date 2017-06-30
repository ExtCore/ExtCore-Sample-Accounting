// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Expenses.Data.Abstractions;
using Expenses.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Expenses.Data.EntityFramework.Sqlite
{
  public class ExpenseRepository : RepositoryBase<Expense>, IExpenseRepository
  {
    public Expense WithKey(int id)
    {
      return this.dbSet.FirstOrDefault(e => e.Id == id);
    }

    public IEnumerable<Expense> All()
    {
      return this.dbSet.OrderByDescending(e => e.Created);
    }

    public void Create(Expense expense)
    {
      this.dbSet.Add(expense);
    }

    public void Edit(Expense expense)
    {
      this.storageContext.Entry(expense).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
      this.Delete(this.WithKey(id));
    }

    public void Delete(Expense expense)
    {
      this.dbSet.Remove(expense);
    }

    public decimal Total()
    {
      return this.dbSet.Sum(e => e.Amount);
    }
  }
}