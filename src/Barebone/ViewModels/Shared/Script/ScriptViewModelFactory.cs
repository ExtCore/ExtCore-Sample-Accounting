// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Infrastructure;

namespace Barebone.ViewModels.Shared
{
  public class ScriptViewModelFactory
  {
    public ScriptViewModel Create(Script script)
    {
      return new ScriptViewModel()
      {
        Url = script.Url
      };
    }
  }
}