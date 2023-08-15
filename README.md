# AzureMapsCreator
A simple GUI PoC for Azure Maps Creator built with Blazor and Fluent UI

## How to run locally?

### Prerequisites
1. [Make an Azure Maps account](https://docs.microsoft.com/en-us/azure/azure-maps/quick-demo-map-app#create-an-azure-maps-account).
2. [Obtain a primary subscription key](https://docs.microsoft.com/en-us/azure/azure-maps/quick-demo-map-app.md#get-the-primary-key-for-your-account), also known as the primary key or the subscription key.
3. [Create a Creator resource](https://docs.microsoft.com/en-us/azure/azure-maps/how-to-manage-creator.md).
4. Download the [Sample Drawing package](https://github.com/Azure-Samples/am-creator-indoor-data-examples/blob/master/Sample%20-%20Contoso%20Drawing%20Package.zip).
5. You will need to be able to compile with .NET 6 Preview 5 (at the moment). Please ensure this version is installed on your machine. If a newer version is released, follow the steps to upgrade in the announcement blog post.

### Set up your environment
 
{
    "AzureMaps": {
      "SubscriptionKey": "<Your subscription key>",
      "Geography": "<eu or us>"
    }
}

### Wayfinding - Get Path

The Wayfinding Service API is part of Creator, and adheres to the Open Geospatial Consortium standard and uses indoor maps data from the routeset to calculate the best path between two locations within the same facility.

The Azure Maps Creator wayfinding service allows you to navigate from place to place anywhere within your indoor map. The service utilizes stairs and elevators to navigate between floors and provides guidance to help you navigate around physical obstructions

The Wayfinding service enables us to provide our customers with the shortest path between two points within a facility. Once we have imported our indoor map data and created our dataset, we can use that to create a routeset. The routeset provides the data required to generate paths between two points. The wayfinding service takes into account things such as the minimum width of openings and may optionally exclude elevators or stairs when navigating between levels as a result.

Get the shortest path between two points in the facility.

### Request
GET https://us.atlas.microsoft.com/wayfinding/path?api-version=2022-09-01-preview&routesetId=[routeset-Id]&facilityId=[facility-Id]&fromPoint=47.652882287901065,-122.13400410050512&fromLevel=-1&toPoint=47.652870534630466,-122.13382884389553&toLevel=0

