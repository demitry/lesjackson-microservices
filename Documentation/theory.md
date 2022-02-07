### Models vs. DTOs

1:28 DTOs - external representations of our internal models.

You don't want to expose your internal models to external consumers
1) Data privacy
2) Contractual Coupling 
    If you change the model - you will break contract

=> Abstract internal data from external data

Read Dto - consumer gets
Create Dto - we expect

PlatformCreateDto 
- we don't require the id (for insert) 
- But we are using data annotations (for validation).

We will use Automapper to map them.

### Synchronous Messaging
For service-to-service you can use synchronous communication.
We will use asynchronous communication later.

* Request/Response Cycle
* Requester will "wait" for response
* Externally facing services usually synchronous (http requests)
* Synchronous Services usually need to "know" about each other
    Synchronous request to the endpoint.
* 2 forms of synchronous messaging:
    * Http
    * Grpc

Q: Wait! What if I mark controllers http actions as Async?
Does it making an async messaging?

A: **No!**
* From messging perspective this method is still synchronous.
* The client still has to wait for a response.
* Async in this context (the C# language) means that
    - **the action will not wait** for a long running operation
    - will not wait, 
    - will not hold this thread, 
    - will return thread back to the thread pool.
* When operation finishes it will re-acquire a thread and complete,
    and respond back to the requestor
* So Async here is about thread exhaustion 
    - the requestor still has to wait
    - the call is synchronous

