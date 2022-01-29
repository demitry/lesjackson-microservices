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

We will use Automapper to map.

