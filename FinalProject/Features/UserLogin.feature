Feature: UserLogin
	As a customer that already has an account in the online store, I want to 
	access the Sign In page and be able to log in during my online shopping.	


@mytag
Scenario: Successful login
	Given that I am a customer who already has an account
	When I click in the Sign in button at Home page
	And I fill in the e-mail field with a registered e-mail
	And I fill in the password field with the correct password
	And I click in the Sign in button at Login page
	Then I will be redirected to the My Account page

Scenario: Unsuccessful login - wrong password
	Given that I am a customer who already has an account
	When I click in the Sign in button at Home page
	And I fill in the e-mail field with a registered e-mail
	And I fill in the password field with an incorrect password
	And I click in the Sign in button at Login page
	Then an error message must be shown 

Scenario: Unsuccessful login - wrong email
	Given that I am a customer who already has an account
	When I click in the Sign in button at Home page
	And I fill in the e-mail field with an unregistered e-mail
	And I fill in the password field with the correct password
	And I click in the Sign in button at Login page
	Then an error message must be shown
	//there is 1 error authentication failed
Scenario: Unsuccessful login - without register information
	Given that I am a customer who already has an account	
	When I click in the Sign in button at Home page 
	And I click in the Sign in button at Login page
	Then an error message must be shown