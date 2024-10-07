# RESTfulFoundation.Server

A collection of convenience classes to ease in the development of
RESTful WebAPI interfaces ( specifically adding a simple Result object
for Success/Fail operations, and a Pageable ListResult for handling
arrays )

## Getting Started

Installation via nuget

` dotnet add package RESTfulFoundation.Server --version 1.0.0`


## Changes

### 09/30/2024 - 1.0.2
* Added an additional Static convenience method to support the Entity
  property for Error conditions.

### 09/30/2024 - 1.0.1
* Added an optional 'Entity' property to the Result object for instances
  where a single REST request might need to return a single object that 
  potentially results in different entities, or success/fail conditions.
* Added an additional Static convenience method to support the Entity 
  property.