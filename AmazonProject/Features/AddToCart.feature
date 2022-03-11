Feature: AddToCart
	This Feature will verify items are added to the cart 


Scenario: Add items to the cart
	Given user is on HomePage
	And Click on the signin button
	When the user enter email
	| email                      |
	| veldilakshmi1234@gmail.com |
	And click on Continue button
	And enter password
	| password   |
	| 9542407290 |
	And click on login button
	Then User should be login to Amazon application successfully
	When User enter Item in the searchbox
	| Item    |
	| Mobiles |
	And Click on Search icon
	Then item results page Should be displayed
	When user selects Brand type
	| Brand   |
	| Samsung |
	And click on the first result item
	When item page should be dispalyed in the new window
	And verify itemname
	And Price of the item
	And Click on the AddtoCart button
	And Navigate to Cart
	When selected item should be dispalyed in the cart
	Then verify price of the item