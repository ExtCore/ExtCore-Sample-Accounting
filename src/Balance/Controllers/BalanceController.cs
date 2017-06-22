// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Balance.ViewModels.Balance;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Balance.Controllers
{
  public class BalanceController : Barebone.Controllers.ControllerBase
  {
    public BalanceController(IStorage storage) : base(storage) { }

    public ActionResult Index()
    {
      return this.View(new IndexViewModelFactory().Create(this.Storage));
    }
  }
}