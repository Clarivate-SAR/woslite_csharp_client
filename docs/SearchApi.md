# IO.Swagger.Api.SearchApi

All URIs are relative to *https://api.clarivate.com/api/woslite*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueryQueryIdGet**](SearchApi.md#queryqueryidget) | **GET** /query/{queryId} | Fetch record(s) by query identifier
[**RootGet**](SearchApi.md#rootget) | **GET** / | Submits a user query and returns results

<a name="queryqueryidget"></a>
# **QueryQueryIdGet**
> WosLiteResponse QueryQueryIdGet (int? queryId, int? count, int? firstRecord, string sortField = null)

Fetch record(s) by query identifier

This operation returns record(s) identified by a query identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryQueryIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("X-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-ApiKey", "Bearer");

            var apiInstance = new SearchApi();
            var queryId = 56;  // int? | Retrieve records based on query identifier.
            var count = 56;  // int? | Number of records to return, must be 0-100.
            var firstRecord = 56;  // int? | Specific record, if any within the result set to return. Cannot be less than 1 and greater than 100000.
            var sortField = sortField_example;  // string | Order by field(s). Field name and order by clause separated by '+', use A for ASC and D for DESC, ex: PY+D. Multiple values are separated by comma. If sortField was set on the original query, this parameter should be set as sorting is not a property of the query. (optional) 

            try
            {
                // Fetch record(s) by query identifier
                WosLiteResponse result = apiInstance.QueryQueryIdGet(queryId, count, firstRecord, sortField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.QueryQueryIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryId** | **int?**| Retrieve records based on query identifier. | 
 **count** | **int?**| Number of records to return, must be 0-100. | 
 **firstRecord** | **int?**| Specific record, if any within the result set to return. Cannot be less than 1 and greater than 100000. | 
 **sortField** | **string**| Order by field(s). Field name and order by clause separated by &#x27;+&#x27;, use A for ASC and D for DESC, ex: PY+D. Multiple values are separated by comma. If sortField was set on the original query, this parameter should be set as sorting is not a property of the query. | [optional] 

### Return type

[**WosLiteResponse**](WosLiteResponse.md)

### Authorization

[key](../README.md#key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="rootget"></a>
# **RootGet**
> WosLiteResponse RootGet (string databaseId, string usrQuery, int? count, int? firstRecord, string lang = null, string edition = null, string publishTimeSpan = null, string loadTimeSpan = null, string sortField = null)

Submits a user query and returns results

The search operation submits a search query to the specified database edition and retrieves data. This operation returns a query ID that can be used in subsequent operations to retrieve more records.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RootGetExample
    {
        public void main()
        {
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("X-ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-ApiKey", "Bearer");

            var apiInstance = new SearchApi();
            var databaseId = databaseId_example;  // string | Database to search. Must be a valid database ID, one of the following: BCI/BIOABS/BIOSIS/CCC/DCI/DIIDW/MEDLINE/WOK/WOS/ZOOREC. WOK represents all databases.
            var usrQuery = usrQuery_example;  // string | User query for requesting data, ex: TS=(cadmium). The query parser will return errors for invalid queries.
            var count = 56;  // int? | Number of records to return, must be 0-100.
            var firstRecord = 56;  // int? | Specific record, if any within the result set to return. Cannot be less than 1 and greater than 100000.
            var lang = lang_example;  // string | Language of search. This element can take only one value: en for English. If no language is specified, English is passed by default. (optional) 
            var edition = edition_example;  // string | Edition(s) to be searched. If null, user permissions will be substituted. Must include the name of the collection and edition name separated by '+', ex: WOS+SCI. Multiple editions are separated by ','. Editions available for collection(WOS) - AHCI,CCR,IC,ISSHP,ISTP,SCI,SSCI,BHCI,BSCI and ESCI. (optional) 
            var publishTimeSpan = publishTimeSpan_example;  // string | This element specifies a range of publication dates. If publishTimeSpan is used, the loadTimeSpan parameter must be omitted. If publishTimeSpan and loadTimeSpan are both omitted, then the maximum time span will be inferred from the editions data. Beginning and end dates should be specified in the yyyy-mm-dd format separated by +, ex: 1993-01-01+2009-12-31. (optional) 
            var loadTimeSpan = loadTimeSpan_example;  // string | Load time span (otherwise described as symbolic time span) defines a range of load dates. The load date is the date a record was added to the database. If load date is specified, the publishTimeSpan parameter must be omitted. If both publishTimeSpan and loadTimeSpan are omitted, the maximum publication date will be inferred from the editions data. Any of D/W/M/Y prefixed with a number where D-Day, M-Month, W-Week, Y-Year allowed. Acceptable value range for Day(0-6), Week(1-52), Month(1-12) and Year(0-10), ex: 5D,30W,10M,8Y. (optional) 
            var sortField = sortField_example;  // string | Order by field(s). Field name and order by clause separated by '+', use A for ASC and D for DESC, ex: PY+D. Multiple values are separated by comma. (optional) 

            try
            {
                // Submits a user query and returns results
                WosLiteResponse result = apiInstance.RootGet(databaseId, usrQuery, count, firstRecord, lang, edition, publishTimeSpan, loadTimeSpan, sortField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.RootGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **databaseId** | **string**| Database to search. Must be a valid database ID, one of the following: BCI/BIOABS/BIOSIS/CCC/DCI/DIIDW/MEDLINE/WOK/WOS/ZOOREC. WOK represents all databases. | 
 **usrQuery** | **string**| User query for requesting data, ex: TS&#x3D;(cadmium). The query parser will return errors for invalid queries. | 
 **count** | **int?**| Number of records to return, must be 0-100. | 
 **firstRecord** | **int?**| Specific record, if any within the result set to return. Cannot be less than 1 and greater than 100000. | 
 **lang** | **string**| Language of search. This element can take only one value: en for English. If no language is specified, English is passed by default. | [optional] 
 **edition** | **string**| Edition(s) to be searched. If null, user permissions will be substituted. Must include the name of the collection and edition name separated by &#x27;+&#x27;, ex: WOS+SCI. Multiple editions are separated by &#x27;,&#x27;. Editions available for collection(WOS) - AHCI,CCR,IC,ISSHP,ISTP,SCI,SSCI,BHCI,BSCI and ESCI. | [optional] 
 **publishTimeSpan** | **string**| This element specifies a range of publication dates. If publishTimeSpan is used, the loadTimeSpan parameter must be omitted. If publishTimeSpan and loadTimeSpan are both omitted, then the maximum time span will be inferred from the editions data. Beginning and end dates should be specified in the yyyy-mm-dd format separated by +, ex: 1993-01-01+2009-12-31. | [optional] 
 **loadTimeSpan** | **string**| Load time span (otherwise described as symbolic time span) defines a range of load dates. The load date is the date a record was added to the database. If load date is specified, the publishTimeSpan parameter must be omitted. If both publishTimeSpan and loadTimeSpan are omitted, the maximum publication date will be inferred from the editions data. Any of D/W/M/Y prefixed with a number where D-Day, M-Month, W-Week, Y-Year allowed. Acceptable value range for Day(0-6), Week(1-52), Month(1-12) and Year(0-10), ex: 5D,30W,10M,8Y. | [optional] 
 **sortField** | **string**| Order by field(s). Field name and order by clause separated by &#x27;+&#x27;, use A for ASC and D for DESC, ex: PY+D. Multiple values are separated by comma. | [optional] 

### Return type

[**WosLiteResponse**](WosLiteResponse.md)

### Authorization

[key](../README.md#key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
