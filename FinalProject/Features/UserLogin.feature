Feature: UserLogin
	As a customer that already has an account in the website, 
	I want to access the Sign In page and be able to log in during my online shopping.	


@mytag
Scenario: Successful login
	Given that I am a customer who already has an account
	When I access the Sign In page  
	And I inform the email and the password "janedoe@hotmail.com" "12345"
	Then I will be redirected to the My Account page	

Scenario Outline: Unsuccessful login 
	Given that I am a customer who already has an account
	When I access the Sign In page 
	And I inform the email and the password "<Email>" "<Password>"
	Then the the message "<Message>" is shown
	Examples: 
	| Test case                    | Email                    | Password | Message                   |
	| Wrong password               | janedoe@hotmail.com      | 123456   | Authentication failed     |
	| Wrong email                  | unregistered@hotmail.com | 12345    | Authentication failed     |
	| Without register information |                          |          | An email address required |
	| Invalid email                | invalidemail             | 12345    | Invalid email address     |

	