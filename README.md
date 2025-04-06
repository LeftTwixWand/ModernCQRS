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

```mermaid
flowchart TD
    %% Start with client call
    Start([Client]) -->|"mediator.Send(command)"| MediatR[MediatR]
    
    %% Simple flow through layers
    MediatR --> Pipeline
    
    subgraph Pipeline [Request Pipeline]
        direction TB
        PreProc[Pre-Processors Layer] --> Decorators1[Decorators Layer]
        Decorators1 --> Handler[Request Handler]
        Handler --> Decorators2[Decorators Layer]
        Decorators2 --> PostProc[Post-Processors Layer]
    end
    
    Pipeline --> Response([Response])
    
    %% Cross-mode optimized styling (works well in both light and dark themes)
    classDef client fill:#4D7EA8,stroke:#2C4D6E,stroke-width:2px,color:white,font-weight:bold
    classDef pipeline fill:#6B7FD7,stroke:#3B4AA0,stroke-width:2px,color:white
    classDef layer fill:#9683EC,stroke:#644CB5,stroke-width:1px,color:white
    classDef handler fill:#50B9A0,stroke:#2E6B5E,stroke-width:2px,color:white,font-weight:bold
    classDef structure fill:#E6777E,stroke:#B24248,stroke-width:1px,color:white
    
    class Start,Response client
    class Pipeline,MediatR pipeline
    class PreProc,Decorators1,Decorators2,PostProc layer
    class Handler handler
    class RequestStructure,HandlerStructure,IRequest,IIdentReq,CmdQuery,IReqHandler,ICmdHandler,IQryHandler structure
```

```mermaid
flowchart TD
    
    %% Simplified hierarchy on the side
    subgraph RequestStructure [Request Hierarchy]
        direction TB
        IRequest[MediatR.IRequest] --> IIdentReq[IIdentifiableRequest]
        IIdentReq --> CmdQuery[CommandBase/QueryBase]
    end
    
    %% Simplified handler hierarchy
    subgraph HandlerStructure [Handler Hierarchy]
        direction TB
        IReqHandler[MediatR.IRequestHandler] --> ICmdHandler[ICommandHandler]
        IReqHandler --> IQryHandler[IQueryHandler]
    end
    
    %% Cross-mode optimized styling (works well in both light and dark themes)
    classDef client fill:#4D7EA8,stroke:#2C4D6E,stroke-width:2px,color:white,font-weight:bold
    classDef pipeline fill:#6B7FD7,stroke:#3B4AA0,stroke-width:2px,color:white
    classDef layer fill:#9683EC,stroke:#644CB5,stroke-width:1px,color:white
    classDef handler fill:#50B9A0,stroke:#2E6B5E,stroke-width:2px,color:white,font-weight:bold
    classDef structure fill:#E6777E,stroke:#B24248,stroke-width:1px,color:white
    
    class Start,Response client
    class Pipeline,MediatR pipeline
    class PreProc,Decorators1,Decorators2,PostProc layer
    class Handler handler
    class RequestStructure,HandlerStructure,IRequest,IIdentReq,CmdQuery,IReqHandler,ICmdHandler,IQryHandler structure
```
