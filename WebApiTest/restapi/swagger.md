# My First Swagger
A simple ASP.NET Core web API 2

## Version: v1

### Terms of service
https://example.com/terms

**Contact information:**  
Eric Perez Villar  
https://www.linkedin.com/in/eric-perez-villar-87aa6746/  
  

**License:** [Use under LICX](https://example.com/license)

### /api/Person

#### GET
##### Summary:

Get the full list of people

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [ [Person](#person) ] |

#### POST
##### Summary:

Insert a new person to the list of people

##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| person | body |  | Yes | [Person](#person) |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [ [Person](#person) ] |

### /api/product

#### GET
##### Summary:

Get the full list of products

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [ [Product](#product) ] |

#### POST
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| product | body |  | Yes | [Product](#product) |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 |  |

### /api/product/code/{codart}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| codart | path |  | Yes | string |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [ [Product](#product) ] |

### /api/product/description/{desart}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| desart | path |  | Yes | string |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [ [Product](#product) ] |

### /api/TodoItems

#### GET
##### Summary:

Get every item from the list

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [ [TodoItemDTO](#todoitemdto) ] |

#### POST
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| todoItemDTO | body |  | Yes | [TodoItemDTO](#todoitemdto) |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [TodoItem](#todoitem) |

### /api/TodoItems/{id}

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | long |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [TodoItemDTO](#todoitemdto) |

#### PUT
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | long |
| todoItemDTO | body |  | Yes | [TodoItemDTO](#todoitemdto) |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | file |

#### DELETE
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes | long |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | file |

### /WeatherForecast

#### GET
##### Summary:

Get all weather forescasts

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | [ [WeatherForecast](#weatherforecast) ] |

#### POST
##### Summary:

Creates a TodoItem.

##### Description:

Note that the key is a GUID and not an integer.
 
    POST /Todo
    {
       "key": "0e7ad584-7788-4ab1-95a6-ca0a5b444cbb",
       "name": "Item1",
       "isComplete": true
    }

##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| item | body |  | Yes | [TodoItem](#todoitem) |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 201 | Returns the newly created item | [TodoItem](#todoitem) |
| 400 | If the item is null | [TodoItem](#todoitem) |

### /WeatherForecast/{id}

#### GET
##### Summary:

Gets a value by ID.

##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path | The id of the value you wish to get. | Yes | integer |

##### Responses

| Code | Description | Schema |
| ---- | ----------- | ------ |
| 200 |  | string |

### Models


#### Person

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| userName | string |  | Yes |
| name | string |  | Yes |
| email | string (email) |  | Yes |
| confirmEmail | string (email) |  | Yes |
| age | integer |  | Yes |

#### Product

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| code | string | Product code | Yes |
| description | string |  | Yes |
| um | string |  | No |
| codStat | string |  | No |
| pcCart | integer |  | Yes |
| netWeight | double |  | Yes |
| state | string |  | No |
| creationDate | date |  | Yes |
| price | double |  | Yes |

#### TodoItemDTO

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| id | long |  | Yes |
| name | string |  | No |
| isComplete | boolean |  | Yes |

#### TodoItem

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| id | long |  | Yes |
| name | string |  | No |
| isComplete | boolean |  | Yes |
| secret | string |  | No |

#### WeatherForecast

| Name | Type | Description | Required |
| ---- | ---- | ----------- | -------- |
| date | dateTime |  | Yes |
| temperatureC | integer |  | Yes |
| temperatureF | integer |  | Yes |
| summary | string |  | No |