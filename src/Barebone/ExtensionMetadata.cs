// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Infrastructure;

namespace Barebone
{
  public class ExtensionMetadata : IExtensionMetadata
  {
    public IEnumerable<StyleSheet> StyleSheets
    {
      get
      {
        return new StyleSheet[]
        {
          new StyleSheet("//fonts.googleapis.com/css?family=Open+Sans", 100),
          new StyleSheet("/Styles.barebone.css", 200)
        };
      }
    }

    public IEnumerable<Script> Scripts
    {
      get
      {
        return new Script[]
        {
          new Script("//ajax.aspnetcdn.com/ajax/jquery/jquery-1.11.3.min.js", 100),
          new Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.14.0/jquery.validate.min.js", 200),
          new Script("//ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js", 300),
          new Script("/Scripts.barebone.js", 400)
        };
      }
    }

    public IEnumerable<MenuItem> MenuItems => new MenuItem[] { };
  }
}