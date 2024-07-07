using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
	[ServiceContract]
	public interface IService
	{
		// this file defines the URL that will be used in the REST service. 
		// 1) simple string response
		[OperationContract]
		[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "SayHello/")]
		string SayHello();

        // 2) URL that accepts a parameter number
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetData/{value}/")]
        string GetData(string value);

		// 3) a URL that will return a full object to the browser in the JSON-formatted text
		[OperationContract]
		[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetModelObject/{id}/")]
		HelloObject GetModelObject(string id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
	public class CompositeType
	{

	}
}
