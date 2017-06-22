// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Barebone.ViewModels.Barebone;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Barebone.Controllers
{
  public class BareboneController : ControllerBase
  {
    public BareboneController(IStorage storage) : base(storage) { }

    public ActionResult Index()
    {
      return this.View(new IndexViewModelFactory().Create());
    }
  }
}