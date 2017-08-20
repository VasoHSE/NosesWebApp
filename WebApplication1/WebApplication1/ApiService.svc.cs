using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace NosesApi
{

    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ApiService
    {

        [WebGet(UriTemplate = "seeddb", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        public string Seed()
        {
            // var woc = WebOperationContext.Current.IncomingRequest;
            //   var authheader = woc.Headers["Authorization"];
            //try
            //{
            //new Repository().Seed();
            return "susses";
            //}
            //catch (Exception e)
            //{
            //  return  e.Message;
            //}
        }
        // Add more operations here and mark them with [OperationContract]
    }
}
