Feature: Search
	As a customer browsing in the website
	I would like to search for products
	To check if they are sold in the online store

@mytag
Scenario: Successful search
	Given that I am a customer browsing in the website	
	When I search for "blouse"
	Then I will be redirected to the results page

Scenario: Unsuccessful search - product does not exist
	Given that I am a customer browsing in the website	
	When I search for "#@$#@$"
	Then the the message "No results were found for your search" is shown

Scenario: Unsuccessful search - empty search
	Given that I am a customer browsing in the website	
	When I search for ""
	Then the the message "Please enter a search keyword" is shown
