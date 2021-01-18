# Location Finder
This is an application that finds nearby loaction by varius parameters such as category and radius. Application is using two APIs Foursquare and GooglePlaces for finding nearby places.

### Tehnologies
* C#
* ASP.NET MVC
* Bootstrap

### Requirements
* Visual Studio 2012 or higher

### Instructions
* Download and unzip project
* Clean and rebuild solution
* To run application properly you need to setup **api_key** for GooglePlaces or **client_id** and **client_secret** for Foursquare
  * GooglePlaces - in project `LocationFinderLibrary` in namespace `BL/API/Places/GooglePlaces` in class `GooglePlacesApi.cs` change variable value of `private const string ApiKey` from `API_KEY` to your api key
  * Foursquare - in project `LocationFinderLibrary` in namespace `BL/API/Places/Foursquare` in class `FoursquarePlacesApi.cs` change variable value of `private const string ClientID` from `CLIENT_ID` to your client id and variable value of `private const string ClientSecret` from `CLIENT_SECRET` to your client secret  