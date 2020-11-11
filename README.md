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
