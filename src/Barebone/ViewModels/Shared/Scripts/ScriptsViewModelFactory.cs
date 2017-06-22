// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Infrastructure;
using Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Barebone.ViewModels.Shared
{
  public class ScriptsViewModelFactory
  {
    public ScriptsViewModel Create()
    {
      List<Script> scripts = new List<Script>();

      foreach (IExtensionMetadata extensionMetadata in ExtensionManager.GetInstances<IExtensionMetadata>())
        scripts.AddRange(extensionMetadata.Scripts);

      return new ScriptsViewModel()
      {
        Scripts = scripts.OrderBy(s => s.Position).Select(
          s => new ScriptViewModelFactory().Create(s)
        )
      };
    }
  }
}