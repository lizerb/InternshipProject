Feature: FilterProducts
	As a user of the virtual store,
	When I access the women category 
	I want to be able to apply filters and change the way the products are shown. 		

@mytag
Scenario: Go to Women category page
	Given that I am a user at Home page
	When I choose Women category
	Then I will be redirected to the Women category page
 
# the following scenarios don't pass because the website loads indefinitely
Scenario Outline: Filter products
	Given that I am a user at Women category page
	When I choose to filter by "<Filter>"
	Then I will see "<Message>" at results page
	Examples: 
	| Test case       | Filter                | Message              |
	| By category     | Tops category         | There are 2 products |
	| By size         | S size                | There are 7 products |
	| By color        | Green color           | There is 1 product   |
	| By composition  | Cotton composition    | There are 3 products |
	| By style        | Girly style           | There are 3 products |
	| By property     | Midi dress property   | There is 1 product   |
	| By availability | In stock availability | There are 7 products |
	| By manufacturer | Fashion manufacturer  | There are 7 products |
	| By condition    | New condition         | There are 7 products |
