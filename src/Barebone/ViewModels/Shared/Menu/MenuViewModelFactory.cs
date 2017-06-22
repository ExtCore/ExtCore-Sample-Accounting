// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Infrastructure;
using Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Barebone.ViewModels.Shared
{
  public class MenuViewModelFactory
  {
    public MenuViewModel Create()
    {
      List<MenuItem> menuItems = new List<MenuItem>();

      foreach (IExtensionMetadata extensionMetadata in ExtensionManager.GetInstances<IExtensionMetadata>())
        menuItems.AddRange(extensionMetadata.MenuItems);

      return new MenuViewModel()
      {
        MenuItems = menuItems.OrderBy(mi => mi.Position).Select(
          mi => new MenuItemViewModelFactory().Create(mi)
        )
      };
    }
  }
}