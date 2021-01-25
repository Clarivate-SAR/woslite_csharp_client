# IO.Swagger.Api.IntegrationApi

All URIs are relative to *https://api.clarivate.com/api/woslite*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IdUniqueIdGet**](IntegrationApi.md#iduniqueidget) | **GET** /id/{uniqueId} | Find record(s) by specific id

<a name="iduniqueidget"></a>
# **IdUniqueIdGet**
> WosLiteResponse IdUniqueIdGet (string databaseId, string uniqueId, int? count, int? firstRecord, string lang = null, string sortField = null)

Find record(s) by specific id

This operation returns a record identified by a unique identifier. You may specify multiple identifiers in a single request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IdUniqueIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("X-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-ApiKey", "Bearer");

            var apiInstance = new IntegrationApi();
            var databaseId = databaseId_example;  // string | Database to search. Must be a valid database ID, one of the following: BCI/BIOABS/BIOSIS/CCC/DCI/DIIDW/MEDLINE/WOK/WOS/ZOOREC. WOK represents all databases.
            var uniqueId = uniqueId_example;  // string | Primary item(s) id to be searched, ex: WOS:000270372400005. Cannot be null or an empty string. Multiple values are separated by comma.
            var count = 56;  // int? | Number of records to return, must be 0-100.
            var firstRecord = 56;  // int? | Specific record, if any within the result set to return. Cannot be less than 1 and greater than 100000.
            var lang = lang_example;  // string | Language of search. This element can take only one value: en for English. If no language is specified, English is passed by default. (optional) 
            var sortField = sortField_example;  // string | Order by field(s). Field name and order by clause separated by '+', use A for ASC and D for DESC, ex: PY+D. Multiple values are separated by comma. (optional) 

            try
            {
                // Find record(s) by specific id
                WosLiteResponse result = apiInstance.IdUniqueIdGet(databaseId, uniqueId, count, firstRecord, lang, sortField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.IdUniqueIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **databaseId** | **string**| Database to search. Must be a valid database ID, one of the following: BCI/BIOABS/BIOSIS/CCC/DCI/DIIDW/MEDLINE/WOK/WOS/ZOOREC. WOK represents all databases. | 
 **uniqueId** | **string**| Primary item(s) id to be searched, ex: WOS:000270372400005. Cannot be null or an empty string. Multiple values are separated by comma. | 
 **count** | **int?**| Number of records to return, must be 0-100. | 
 **firstRecord** | **int?**| Specific record, if any within the result set to return. Cannot be less than 1 and greater than 100000. | 
 **lang** | **string**| Language of search. This element can take only one value: en for English. If no language is specified, English is passed by default. | [optional] 
 **sortField** | **string**| Order by field(s). Field name and order by clause separated by &#x27;+&#x27;, use A for ASC and D for DESC, ex: PY+D. Multiple values are separated by comma. | [optional] 

### Return type

[**WosLiteResponse**](WosLiteResponse.md)

### Authorization

[key](../README.md#key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
