# buen_parche
Proyecto "El Buen Parche"
Welcome to the buen_parche wiki!


- Se manejará una sola rama de desarrollo, la rama main, para hacer cambios hacer una nueva rama basada en main y subir por medio de PR (La rama main está con protección).

- El proyecto está creado con un template de Clean Architecture, así que se debe tener en cuenta lo siguiente:

Domain
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

Application
This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

Infrastructure
This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

WebUI
This layer is a single page application based on Angular 10 and ASP.NET Core 5. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only Startup.cs should reference Infrastructure.

- https://github.com/jasontaylordev/CleanArchitecture -
