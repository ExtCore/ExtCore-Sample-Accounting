// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using Incomes.Data.Abstractions;
using Incomes.Data.Entities;
using Incomes.ViewModels.Incomes;
using Microsoft.AspNetCore.Mvc;

namespace Incomes.Controllers
{
  public class IncomesController : Barebone.Controllers.ControllerBase
  {
    public IncomesController(IStorage storage) : base(storage) { }

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
        Income income = new CreateViewModelMapper().Map(createViewModel);

        this.Storage.GetRepository<IIncomeRepository>().Create(income);
        this.Storage.Save();
        return this.RedirectToAction("index");
      }

      return this.View();
    }
  }
}