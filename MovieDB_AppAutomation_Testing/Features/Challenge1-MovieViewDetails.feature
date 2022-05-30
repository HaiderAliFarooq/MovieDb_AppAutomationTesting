Feature: MovieViewDetails

Searching for a movie from the main screen using search and then navigating to its details page.

@movieDetails
Scenario: View Details of a Movie
	Given I am on the main movies list screen
	When I search for a movie whose name starts with "News"
	And I select the second option from the result list of movies in search box
	And I tap the Show details link
	Then I should see the overview of the movie on details page
