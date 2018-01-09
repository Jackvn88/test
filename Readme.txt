This solution is comprised of several projects and you will be able to run this using Visual Studio 2013 Express, available from https://www.visualstudio.com/products/visual-studio-community-vs


UnitTests
====================
Use the Test menu to run the unit tests. Most of them will fail, that's where you come in. Without modifying the unit tests themselves, try to make as many of the tests pass as you can.
Feel free to use whatever features of the .net framework you like. Unless the unit test name tells you not to.


WebForms
====================
There is a contact form but it's rather incomplete. Your mission, should you choose to accept it, is to complete the work around this form. There are several tasks:
 - Make the email address a required field.
 - Validate that the email address contains an @ somewhere in the middle.
 - Add the message field, this should be a multiline text box.
 - Handle the clicking of the send button on the server:
	* Hide the contact form panel
	* Show the feedback panel
	* If the name entered is "Tom Bombadil", the feedback panel should read "Thanks for contacting us, Tom Bombadil, we'll get back to you soon."


MVC
====================
There is a similar flow as in the WebForms project, and it's also incomplete. Luckily you're going to save the day. There are several tasks:
 - Make the email address a required field.
 - Validate that the email address contains an @ somewhere in the middle.
 - Add the message field, this should be a multiline text box.
 - Handle the clicking of the send button on the server:
	* Check the data is valid
	* Make the input name available to the Thanks action
	* Redirect to the Thanks action
	* If the name entered is "Thorin Oakenshield son of Thrain", the Thanks page should read "Thanks for contacting us, Thorin Oakenshield son of Thrain, we'll get back to you soon".