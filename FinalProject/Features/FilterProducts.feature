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
Scenario: Filter products by category
	Given that I am a user at Women category page
	When I choose to filter by "Tops category"
	Then I will see "There are 2 products" at results page

Scenario: Filter products by size
	Given that I am a user at Women category page
	When I choose to filter by "S size"
	Then I will see "There are 7 products" at results page

Scenario: Filter products by color
	Given that I am a user at Women category page
	When I choose to filter by "Green color"
	Then I will see "There is 1 product" at results page

Scenario: Filter products by composition
	Given that I am a user at Women category page
	When I choose to filter by "Cotton composition"
	Then I will see "There are 3 products" at results page

Scenario: Filter products by style
	Given that I am a user at Women category page
	When I choose to filter by "Girly style"
	Then I will see "There are 3 products" at results page

Scenario: Filter products by property
	Given that I am a user at Women category page
	When I choose to filter by "Midi dress property"
	Then I will see "There is 1 product" at results page

Scenario: Filter products by availability
	Given that I am a user at Women category page
	When I choose to filter by "In stock availability"
	Then I will see "There are 7 products" at results page

Scenario: Filter products by manufacturer
	Given that I am a user at Women category page
	When I choose to filter by "Fashion manufacturer"
	Then I will see "There are 7 products" at results page

Scenario: Filter products by condition
	Given that I am a user at Women category page
	When I choose to filter by "New condition"
	Then I will see "There are 7 products" at results page
