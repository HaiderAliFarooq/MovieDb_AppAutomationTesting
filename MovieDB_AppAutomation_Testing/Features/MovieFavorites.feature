Feature: MovieFavoritesScreen

Searching for a movie from the main screen using search and then navigating to its details page.

@movieFavoritesScreen
Scenario: Verify the favorites feature is working properly by navigating to the favorites screen
#	Given I am on the main movies list screen
	When I open the details page of a movie like "Morbius" and mark the movie as favorite
	And I navigate to favorites screen via menu
	Then I should see the movie "Morbius" listed on the Favorites screen
