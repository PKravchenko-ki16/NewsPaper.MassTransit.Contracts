# NewsPaper.MassTransit.Contracts
 
This ASP.NET Core 3.1 module is responsible for storing DTO Models, Exception Models, Requests Models, Responses Models.
(extends to atomic microservices as a local nuget package)

## Naming conventions

**All properties must be marked with the public access modifier.**

**Exception**: must inherit from the base interface IBaseException and not contain "Exception" in the name.

**Models**: must be inherited from the base abstract class DtoBase, and contain "Dto" at the end of the name.

**Requests**: must contain "RequestDto" at the end of the name.

**Responses**: must contain "ResponsesDto" at the end of the name.

## Module structure

- Base
- Exception
  - Base
  - Articles
  - Author
  - Editor
  - User
  - Operation
- Models
  - Articles
  - Author
  - Editor
  - User
- Requests
  - Articles
  - Author
  - Editor
  - User
  - Operation
- Responses
  - Articles
  - Author
  - Editor
  - User
  - Operation

## Links to project repositories
- :white_check_mark:[NewsPaper Review](https://github.com/PKravchenko-ki16/NewsPaper)
- :white_check_mark:[NewsPaper.MassTransit.Configuration](https://github.com/PKravchenko-ki16/NewsPaper.MassTransit.Configuration)
- :white_check_mark:NewsPaper.MassTransit.Contracts
- :white_check_mark:[NewsPaper.IdentityServer](https://github.com/PKravchenko-ki16/NewsPaper.IdentityServer)
- :white_check_mark:[Newspaper.GateWay](https://github.com/PKravchenko-ki16/Newspaper.GateWay)
- :white_check_mark:[NewsPaper.Accounts](https://github.com/PKravchenko-ki16/NewsPaper.Accounts)
- :white_check_mark:[NewsPaper.Articles](https://github.com/PKravchenko-ki16/NewsPaper.Articles)
- :white_check_mark:[NewsPaper.GatewayClientApi](https://github.com/PKravchenko-ki16/NewsPaper.GatewayClientApi)
- :white_check_mark:[NewsPaper.Client.Mvc](https://github.com/PKravchenko-ki16/NewsPaper.Client.Mvc)
