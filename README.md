MvcAsync
========

MvcAsync is a project that investigates the myriad of ways that you can load data into an HTML page.  This includes both synchronous and asynchronous techniques.

As this is an MVC project I am using techniques such as using razor to inject dynamically created JSON (People/Roles/etc) into the javascript.  This quite handy technique would not be available in pure HTML5 pages.

Goals
-----
* **Minimal Requests:** This means that the data will always come down with the inital page load. The data could either be HTML or JSON.  In the case of JSON it is embedded in the page and then used to construct the HTML on the client.
* **Logic-less Views:** This means that any calculations are done in C# and store in ViewModels.  These ViewModels are then bound to the views (server-side) to produce the initial HTML.
* **Like-for-like comparison:** Every technique should be functionality equivalent .

Project Setup
-------------
- VS2013
- .Net 4.5
- MVC5

Techniques
----------

###HTML
*pros*

- quickest and easiest to implement

*cons*

- Most data sent over wire.
- Entire page has to reload which blocks the user from doing anything else.
- Slowest

###Unobtrusive AJAX
*pros*

- Asynchronous.
- Only HTML that needs to be changed is updated
- Simple to implement

*cons*
- Server sends HTML.  More data sent than needed.

###jQuery
*pros*

*cons*
###Knockout
*pros*

*cons*
###Handlebars
*pros*

*cons*
###Angular
*pros*

*cons*

Summary
-------
todo...
