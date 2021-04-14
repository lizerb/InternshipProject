Feature: UserRegistration
	As a new custumer I would like to access the Sign in page 
	And be able to register myself in the virtual store.

@mytag
Scenario: Successful registration
	Given that I am a customer without registration
	When I try to create a new account
	And I fill all the registration form
	Then I will be redirected to the My Account page	

Scenario: Unsuccessful registration
	Given that I am a customer without registration
	When I try to create a new account
	But I do not fill all the registration form
	Then the the message "There is 1 error" is shown
	