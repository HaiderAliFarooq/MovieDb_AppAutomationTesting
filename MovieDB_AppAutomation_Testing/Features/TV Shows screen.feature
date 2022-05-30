Feature: TVShowScreen

Verify the TV shows are listed on the TV shows screen and when clicked on a show it gives us different options to navigate further

@regression @TV_Show
Scenario: Verify the TV shows are listed on the movies home screen
	Given I am on the Movies home screen
	When user taps on the burger menu on the top left of the Movies home screen
	And I click on the TV shows option from flyer menu
	Then the TV shows screen should showup with a list of TV shows

@regression @TV_Show
Scenario Outline: Verify navigation options are available and are working when user opens a movie from home screen
	Given I am on the Movies home screen
	When I tap on a <movie> from the list of movies
	And I scroll down the screen
	Then I should see clickable links like <navigation>
	Examples: 
	| show            | navigation                 |
	| Pantanal        | Reviews - Show more        |
	| Stranger Things | Recommended - Show more    |
	| The Flash       | Similar movies - Show more |

@regression @Details_screen
Scenario: View Details of a TV Show under search
	Given I am on the TV show screen
	When I tap on a show from list of TV shows
	And I tap the Show details link
	Then I should see the Details of TV show on the Details screen