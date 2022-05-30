Feature: MoviesHomeScreen

Verify the videos are listed on the Movies Home Screen and when clicked on a movie it gives us different options to navigate further

@regression
Scenario: Verify the movies are listed on the movies home screen
	Given the Movies application is installed on the device
	When I open the Movie application
	Then the Movies screen should show with a list of movies

@regression
Scenario Outline: Verify navigation options are available and are working when user opens a movie from home screen
	Given I am on the Movies home screen
	When I tap on a <movie> from the list of movies
	And I scroll down the screen
	Then I should see clickable links like <navigation>
	Examples: 
	| movie         | navigation                 |
	| Morbius       | Reviews - Show more        |
	| THE LOST CITY | Recommended - Show more    |
	| Sonic 2       | Similar movies - Show more |

@regression
Scenario Outline: Verify search a movie using search bar
	Given I am on the Movies home screen
	When I tap on the Search bar on top of the screen
	And I enter a <movie> name
	Then I should see a list of movies relevant to the <movie> keyword in search bar
	Examples: 
	| movie         |
	| Morbius       | 
	| THE LOST CITY | 
	| Sonic 2       | 
