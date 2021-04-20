Feature: ForgotPassword
	As a customer who already has a registration, but it's been a long time I don't shop in the virtual store,
	I would like to recover my password in order to be able to log in.


@mytag
Scenario: The password is retrieved with success
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform the email "janedoe@hotmail.com"
	Then the message "A confirmation email has been sent to your address" is shown

Scenario Outline: The password is not retrieved
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform the email "<Email>"
	Then the message "<Message>" is shown
	Examples: 
	| Test case          | Email                    | Message                                               |
	| Unregistered email | unregistered@hotmail.com | There is no account registered for this email address |
	| Invalid email      | invalidemail             | Invalid email address                                 |

