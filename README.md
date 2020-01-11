# ShoppingListAPI
> In development.

ShoppingListAPI is simple API which allows you to create your own shopping list. It is created with C# in MVC model.
When server is turned on, clients can add their items to list.


# API requests
``` POST /api/ListItems ```

Creating new item on the list.

<br>
Example JSON

``` { "name": "Apples", "quantity": 5, "isComplete": false } ```

where

**name** - string containing your item name,

**quantity** - integer containing item's quantity,

**isComplete** - true, if you had already bought this or false, if you hadn't.

<br><br>

``` PUT /api/ListItems ```
Editing existing item.

<br>
Example JSON

``` { "listItemId": 1, "name": "Apples", "quantity": 5, "isComplete": true } ```

where

**listItemID** - ID assigned to this item,

**name** - string containing your item name,

**quantity** - integer containing item's quantity,

**isComplete** - true, if you had already bought this or false, if you hadn't.

**Attention: in order to edit your item it is necessary to send whole object, not only edited field.**

<br><br>

``` GET /api/ListItems ```

RETURNS: all items from the shopping list as JSON.

<br><br>

``` GET /api/ListItems/[id] ```

RETURNS: gets one item selected by provided ID as JSON.

Example of usage:
```GET /api/ListItems/7 ```

and output JSON:
{ "listItemId": 7, "name": "Banana", "quantity": 1, "isComplete": false }

<br><br>

``` DELETE /api/ListItems/[id] ```

Deletes item selected by provided ID.

Example of usage:
``` DELETE /api/ListItems/5 ```

