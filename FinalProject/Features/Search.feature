Feature: Search
	As a customer browsing in the website
	I would like to search for products
	To check if they are sold in the online store

@mytag
Scenario: Successful search
	Given that I am a customer browsing in the website	
	When I search for "blouse"
	Then I will be redirected to the results page

Scenario Outline: Unsuccessful search 
	Given that I am a customer browsing in the website	
	When I search for "<Product>"
	Then the the message "<Message>" is shown
	Examples: 
	| Test case              | Product | Message                               |
	| Product does not exist | #@$#@$  | No results were found for your search |
	| Empty search           |         | Please enter a search keyword         |

