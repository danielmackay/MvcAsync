MvcAsync
========

MvcAsync is a project that investigates the myriad of ways that you can load data into an HTML page.  This includes both synchronous and asynchronous techniques.

As this is an MVC project I am using techniques such as using razor to inject dynamically created JSON (People/Roles/etc) into the javascript.  This quite handy technique would not be available in pure HTML5 pages.

Goals
-----
* **Minimal Requests:** This means that the data will always come down with the inital page load. The data could either be HTML or JSON.  In the case of JSON it is embedded in the page and then used to construct the HTML on the client.
* **Logic-less Views:** This means that any calculations are done in C# or JS and store in ViewModels.  These ViewModels are then bound to the views (server-side) to produce the initial HTML.
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
- Couples presentation with data.  Restricts data from being re-used

###Unobtrusive AJAX with jQuery
*pros*

- Only JSON data sent over the wire
- Easy to implement
- Good for simple scenarios

*cons*

- Dynamically constructed HTML does not scale well for complicated markup.

###jQuery
*pros*

- Only JSON data sent over the wire
- Not tied to MVC architecture as much (although razor helpers are still used)

*cons*
- Heavy javascript needed
- Dynamically constructed HTML does not scale well for complicated markup.

###Handlebars
*pros*

- Only JSON data sent over the wire
- Clean seperation of data and presentation
- Can be used for client-side and server-side rendering.
- Re-usable separate templates

*cons*
- Heavy javascript needed.  Most out of any technique.
- No support for event handling
- Extra compilation step needed

###Knockout
*pros*

- Only JSON data sent over the wire
- Clean seperation of data and presentation
- Mature library with great documentation, tutorials, and examples
- Support for events
- Re-usable seperate templates

*cons*
- Heavy javascript required.

###Angular
*pros*

- Only JSON data sent over the wire
- Clean seperation of data and presentation
- Support for events
- Re-usable directives
- Built-in MVC framework

*cons*

- Heavy javascript requried
- Steep learning curve
- Issues with using jQuery for ajax calls.  Need to use $http instead.

Summary
-------
After implementing all the techniques, it is easy to see that they all have their strengths and weaknesses.  Synchronous HTML
is the easiest and quickest to implement, but offers the worst performance.  Unobtrusive AJAX gives you a lot without much effort.
Asynchronous loading of the page replacing only the markup that has been modified.  No javascript is required.  jQuery with unobtrusive AJAX
is only a little more work and you can deal with raw JSON which is the most efficent way to update pages.  However, this will not work well
for complicated markup and it not reusable.  jQuery and standard ajax, requires more work and does not bring much to the party.  Handlebars
is the first templating/data-binding language looked at, but this requires heavy javascript and does not provided any event handling.
Knockout is a data-binding framework with a clean seperation of data and presentation which is easy to use.  Angular is an MVC framework that
provides more than just data-binding.  This is the best for large scale javascript applications, but has a steep learning curve.

In summary, if you had a slider to control easy and speed of development vs efficiency and scalability for the better techniques above it would look something like:

1. Synchronous HTML
2. Unobtrusive AJAX
3. Unobtrusive AJAX with jQuery for the JSON
4. Knockout
5. Angular
