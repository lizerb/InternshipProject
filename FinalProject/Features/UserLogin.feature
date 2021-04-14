Feature: UserLogin
	As a customer that already has an account in the website, 
	I want to access the Sign In page and be able to log in during my online shopping.	


@mytag
Scenario: Successful login
	Given that I am a customer who already has an account
	When I access the Sign In page  
	And I inform the email "janedoe@hotmail.com" and the password "12345"
	Then I will be redirected to the My Account page	

Scenario: Unsuccessful login - wrong password
	Given that I am a customer who already has an account
	When I access the Sign In page 
	And I inform the email "janedoe@hotmail.com" and the password "123456"
	Then the the message "Authentication failed" is shown
	
Scenario: Unsuccessful login - wrong email
	Given that I am a customer who already has an account
	When I access the Sign In page 
	And I inform the email "unregistered@hotmail.com" and the password "12345"
	Then the the message "Authentication failed" is shown	
	
Scenario: Unsuccessful login - without register information
	Given that I am a customer who already has an account
	When I access the Sign In page  
	And I try to log in without register information 
	Then the the message "An email address required" is shown	

Scenario: Unsuccessful login - invalid email
	Given that I am a customer who already has an account
	When I access the Sign In page 
	And I inform the email "invalidemail" and the password "12345"
	Then the the message "Invalid email address" is shown
	
	