using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XDomainService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IXDomainService" in both code and config file together.
	[ServiceContract]
	public interface IXDomainService
	{
		[OperationContract]
		string DoWork1(string json);

		[OperationContract]
		string DoWork2(string json);
	}
}
