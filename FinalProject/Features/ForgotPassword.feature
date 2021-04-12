Feature: ForgotPassword
	As a customer who already has a registration, but it's been a long time I don't shop in the virtual store,
	I would like to recover my password in order to be able to log in.


@mytag
Scenario: The email is registered in the website
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform my registered email
	Then a message informing <message> is shown

Scenario: The email is not registered in the website
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform an email that is not registered in the website
	Then a message informing <message> is shown

Scenario: The email is invalid
	Given that I am a customer who has a registration
	And I am at the login page
	When I click in forgot my password
	And I inform an invalid email
	Then a message informing <message> is shown

	Examples:
	| message                                               |
	| A confirmation email has been sent to your address    |
	| There is no account registered for this email address |
	| Invalid email address                                 |	

#1 O e-mail está registrado no sistema do site - A confirmation email has been sent to your address: janedoe@hotmail.com
#2 O e-mail não existe no sistema do site - There is no account registered for this email address.
#3 Preecher o campo com um valor inválido - Invalid email address.

#Dado que sou um cliente que tem cadastro
#E que estou na tela de login
#Quando eu esqueco minha senha
#E informo meu e-mail de cadastro
#Então me é enviado um email de confirmação 

#Dado que sou um cliente que tem cadastro
#Quando eu esqueco minha senha
#E informo um email que não existe no sistema do site
#Então aparece uma mensagem informando que não há conta vinculada com aquele email

#Dado que sou um cliente que tem cadastro
#Quando eu esqueco minha senha
#E informo um email invalido
#Então aparece uma mensagem informando que o email é inválido
