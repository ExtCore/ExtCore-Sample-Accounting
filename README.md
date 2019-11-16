# ExtCore Framework 5.0.0 Advanced Sample Accounting Web Application

[![Join the chat at https://gitter.im/ExtCore/ExtCore](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/ExtCore/ExtCore?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

## Introduction

[ExtCore](https://github.com/ExtCore/ExtCore) is free, open source and cross-platform framework for creating
modular and extendable web applications based on ASP.NET Core. It is built using the best and the most modern
tools and languages (Visual Studio 2019, C# etc). Join our team!

This is the ExtCore framework advanced sample accounting web application:

![Advanced sample accounting web application](http://sikorsky.pro/images/github/extcore-sample-accounting/1.png)

It contains 4 extensions: barebone (defines the generic system UI etc.), incomes, expenses, and balance.
It uses SQLite database to store all the information. UI is built from the parts too.

## Getting Started

* rebuild the solution;
* copy the extensions DLL files into the Extensions folder of the main web application (this folder doesn’t exist by default,
so you need to create it in the web application root or specify another location in the config.json file; also you may just
add direct dependencies to the main web application project instead, but it is not so interesting);
* run the main web application.

## More Information

### Other Samples

* [Full-featured ExtCore 5.0.0 framework sample web application](https://github.com/ExtCore/ExtCore-Sample);
* [ExtCore framework 5.0.0 sample simplest web application](https://github.com/ExtCore/ExtCore-Sample-Simplest);
* [ExtCore framework 5.0.0 sample MVC web application](https://github.com/ExtCore/ExtCore-Sample-Mvc);
* [ExtCore framework 5.0.0 sample web application that uses file storage](https://github.com/ExtCore/ExtCore-Sample-FileStorage);
* [ExtCore framework 5.0.0 sample web application that uses a database](https://github.com/ExtCore/ExtCore-Sample-Data);
* [ExtCore framework 5.0.0 sample web application that uses Identity](https://github.com/ExtCore/ExtCore-Sample-Identity);
* [ExtCore framework 5.0.0 sample web application with modular UI](https://github.com/ExtCore/ExtCore-Sample-Modular-Ui);
* [ExtCore framework 5.0.0 advanced sample web application with modular UI](https://github.com/ExtCore/ExtCore-Sample-Modular-Ui-Adv);
* [ExtCore framework 5.0.0 sample web application that registers a service inside the extension](https://github.com/ExtCore/ExtCore-Sample-Service);
* [ExtCore framework 5.0.0 sample web application that uses the events](https://github.com/ExtCore/ExtCore-Sample-Events);
* [ExtCore framework 5.0.0 sample API web application](https://github.com/ExtCore/ExtCore-Sample-Api).

You can also download our [ready to use full-featured sample](http://extcore.net/files/ExtCore-Sample-5.0.0.zip).
It contains everything you need to run ExtCore-based web application from Visual Studio 2019, including SQLite
database with the test data.

### Tutorials

We have written [several tutorials](http://docs.extcore.net/en/latest/getting_started/index.html)
to help you start developing your ExtCore-based web applications.

### Real Projects

Please take a look at [Platformus](https://github.com/Platformus/Platformus) on GitHub. It is CMS
built on ExtCore framework with more than 10 extensions and 80 projects.

## Links

Sources on GitHub: https://github.com/ExtCore/ExtCore

Website: http://extcore.net/

Docs: http://docs.extcore.net/

Author: http://sikorsky.pro/