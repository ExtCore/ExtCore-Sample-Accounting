// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace Expenses.ViewModels.Expenses
{
  public class CreateViewModel
  {
    [Display(Name = "Amount")]
    [Required]
    public decimal Amount { get; set; }

    [Display(Name = "Description")]
    [Required]
    public string Description { get; set; }
  }
}