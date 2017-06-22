// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Infrastructure
{
  public class StyleSheet
  {
    public string Url { get; set; }
    public int Position { get; }

    public StyleSheet(string url, int position)
    {
      this.Url = url;
      this.Position = position;
    }
  }
}