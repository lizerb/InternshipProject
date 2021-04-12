Feature: ForgotPassword
	As a customer who already has a registration, but it's been a long time I don't shop in the virtual store,
	I would like to recover my password in order to be able to log in.


@mytag
Scenario: The password is retrieved with success
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform my registered email
	Then the message "A confirmation email has been sent to your address" is shown

Scenario: The password is not retrieved - unregistered email
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform an email that is not registered in the website
	Then the message "There is no account registered for this email address" is shown

Scenario: The password is not retrieved - invalid email
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform an invalid email
	Then the message "Invalid email address" is shown	
