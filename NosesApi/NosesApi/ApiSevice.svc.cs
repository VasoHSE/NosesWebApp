﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace NosesApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ApiService 
    {
        /* [WebGet(UriTemplate = "conference/{id}", BodyStyle = WebMessageBodyStyle.WrappedResponse,
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json)]
         [OperationContract]*/
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

        /* [WebInvoke(UriTemplate = "conference", Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse,
    RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
    [OperationContract]*/

    }
}
