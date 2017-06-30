// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Expenses.Data.Abstractions;
using Expenses.Data.Entities;
using Expenses.ViewModels.Expenses;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Controllers
{
  public class ExpensesController : Barebone.Controllers.ControllerBase
  {
    public ExpensesController(IStorage storage) : base(storage) { }

    public ActionResult Index()
    {
      return this.View(new IndexViewModelFactory().Create(this.Storage));
    }

    [HttpGet]
    public ActionResult Create()
    {
      return this.View();
    }

    [HttpPost]
    public ActionResult Create(CreateViewModel createViewModel)
    {
      if (this.ModelState.IsValid)
      {
        Expense expense = new CreateViewModelMapper().Map(createViewModel);

        this.Storage.GetRepository<IExpenseRepository>().Create(expense);
        this.Storage.Save();
        return this.RedirectToAction("index");
      }

      return this.View();
    }
  }
}