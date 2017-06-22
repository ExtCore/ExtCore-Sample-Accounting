﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Infrastructure
{
  public class MenuItem
  {
    public string Url { get; set; }
    public string Name { get; }
    public int Position { get; }

    public MenuItem(string url, string name, int position)
    {
      this.Url = url;
      this.Name = name;
      this.Position = position;
    }
  }
}