using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
	public class Service : IService
	{
		public string SayHello()
		{
			return "Hello nice people, what's up?";
		}

		public string GetData(string value)
        {
            return "If your voice travels " + value + " feet, then the influence of your voice will cover " + Int32.Parse(value) * Int32.Parse(value)*3.14 + " sq.ft";
        }

		public HelloObject GetModelObject(string id)
		{ 
			HelloObject obj = new HelloObject();
			if (Int32.Parse(id) > 0) { 
				obj.happyHello = true;	
				obj.helloMessage = "Hello, you have a positive number!";
			}
			else
            {
                obj.happyHello = false;
                obj.helloMessage = "Hello, you have a negative number!";
            }
			return obj;
		}
	}
}