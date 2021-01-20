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
* To run application properly you need to setup **Api Key** for GooglePlaces or **Client Id** and **Client Secret** for Foursquare:
  * GooglePlaces - in project `LocationFinderLibrary` in namespace `BLL/API/Places/GooglePlaces` in class `GooglePlacesApi.cs` change variable value of `private const string ApiKey` from `API_KEY` to your **Api Key**
  * Foursquare - in project `LocationFinderLibrary` in namespace `BLL/API/Places/Foursquare` in class `FoursquarePlacesApi.cs` change two variables values:
    * `private const string ClientId` from value `CLIENT_ID` to your **Client Id**
	* `private const string ClientSecret` from value `CLIENT_SECRET` to your **Client Secret**