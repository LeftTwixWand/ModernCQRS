## This repository shows, how to implement CQRS architecture approach, using [Autofac](https://github.com/autofac/Autofac) and [MediatR](https://github.com/jbogard/MediatR) libraries.

The main purpose is to create a simple app with clear CQRS requests processing behavior.

This repository demonstrates how to:
 - Set up the **MediatR**
 - Create custom **Commands** / **Queries** and its handlers
 - Add **decorators** for all types of request handlers
 - Add **decorators** only for Command or Query handlers
 - Use **pipelines** (**MediatR** Behaviours like request Pre Processors and Post Processors)

The sample app output:

![Output](https://user-images.githubusercontent.com/50652041/221921311-cffbd848-5e7a-4841-9f30-99dd5aa8b24c.png)

### The architecture [OBSOLETE - needs to be updated to MediatR 12.0]
![CQRS](https://user-images.githubusercontent.com/50652041/152162222-4a38f4aa-7a93-4d51-907a-a5b0b5cca518.jpg)
