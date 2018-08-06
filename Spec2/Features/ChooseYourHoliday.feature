Feature: ChooseYourHoliday
	
	In order to Travel in Holidays
	As a Leisure Travel user
	I want to choose a Holiday Collection

Background: HolidayCollections
	Given I am on HomePage
	And I open HolidayCollections
	
@mytag
Scenario Outline: select  Holiday Collection
    Given I am on HolidayCollections 
	And I have ChooseAHolidayCollection
	When I click on ChooseHolidayCollection
	And I click on '<Holiday>'
	
	
	Examples: 
	| Holiday             |
	| Family Holidays     |
	| Honeymoon Holidays  |
	| Opera Holidays      |
	| Rail Holidays       |
	| Ranch Holidays      |
	| River Cruises       |
	| Route 66            |
	| Self Drive Holidays |
	| Short Breaks        |

Scenario: Count Holiday Collection
    Given I am on HolidayCollections 
	And I have ChooseAHolidayCollection
	When I click on ChooseHolidayCollection
	Then I should see '10' HolidayCollection

Scenario: Options of Holiday Collection
    Given I am on HolidayCollections 
	And I have ChooseAHolidayCollection
	When I click on ChooseHolidayCollection
	Then I should see OptionsofHolidayCollection







   
