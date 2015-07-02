using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace XDomainService
{
	public class XDomainService : IXDomainService
	{
		public string DoWork1(string json)
		{
			return json;
		}

		public string DoWork2(string json)
		{
			return json;
		}
	}
}