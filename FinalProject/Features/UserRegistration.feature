Feature: UserRegistration
	As a new custumer I would like to access the Sign in page 
	And be able to register myself in the online store.

@mytag
Scenario: Successful registration
	Given that I am a customer without registration
	When I click Sign in button
	Then I will be redirected to the login page
	When I fill the e-mail text box 
	And I click the Create an Account button
	Then I will be redirected to the registration page
	When I insert all the mandatory data
	And I click Register button
	Then I should be able to finish my registration in the online store

Scenario: Unsuccessful registration
	Given that I am a customer without registration
	When I access the Sign in page
	And I don't fill at least one of the mandatory fields of the registration form
	And I click Register button
	Then a message must be shown saying that all the mandatory fields must be informed