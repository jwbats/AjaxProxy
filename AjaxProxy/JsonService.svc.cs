using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

using AjaxProxy.XDomainServiceReference;

namespace AjaxProxy
{
	[ServiceContract(Namespace = "")]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class JsonService
	{

		#region ================================================== Private Members ==================================================

		private static XDomainServiceClient client;
		private static XDomainServiceClient Client
		{
			get
			{
				if (client == null)
				{
					client = new XDomainServiceClient();
				}

				return client;
			}
		}


		#endregion ================================================== Private Members ==================================================




		#region ================================================== Private Methods ==================================================

		private string InvokeMethod(string method, string json)
		{
			MethodInfo methodInfo = Client.GetType().GetMethod(method);
			
			return methodInfo.Invoke(Client, new object[] { json }) as string;
		}

		#endregion ================================================== Private Methods ==================================================




		#region ================================================== Public Methods ==================================================

		[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		[OperationContract]
		public string ProcessRequest(string method, string json)
		{
			return InvokeMethod(method, json);
		}

		#endregion ================================================== Public Methods ==================================================

	}
}