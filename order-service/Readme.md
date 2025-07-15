# prompt

Summary
Create an ordering service following clean architecture and domain driven design. 

1. Layers
    - Ordering.Domain
        - This layer houses the Order and OrderItem entities, imbued with rich business logic and validations, standing proud without external dependencies.
        - Technology: .net core 9 dll

    - Ordering.Application
        - This layer breathes life into our CQRS patterns with MediatR, orchestrating use cases like AddItemToOrder and ProcessOrderPayment with precision.
        - Technology: .net core 9 dll
        - Uses MediatR and implements CQRS pattern
        - Uses Repository pattern to connect to repository
    - Ordering.Infrastructure.Interface
        - Define all repository interface in this project
    - Ordering.Infrastructure
        - It’s here that the application layer’s contracts find their concrete implementations, ensuring seamless database interactions and external communications.
        - Technology: .net core 9 dll
        - Uses Entity Framework Core
        - Connects to a postgressql database called orders
    - Ordering.API
        - This layer serves as the gateway for clients to engage with the Ordering service’s capabilities.
        - Technology: .net core 9 web api
        - Provides REST Api for SubmitOrder, CancelOrder, GetOrders, ModifyOrder, DeleteOrder

2. Add unit tests
    - Use NUnit for tests
    - Use Moq for mocking
3. Add API tests
    - Use reqnroll BDD framework to develop API tests
4. Create a web frontend using angular
    - Create a form to view all orders
        - Provide a button to add orders
        - Provide a button to edit orders
        - Provide a button to cancel orders
    - Add / Edit orders should allow to edit 
        - Add or remove item
    - Item should contain
        - Name
        - Unit price
        - Category
        - Description

