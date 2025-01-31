using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;

namespace EmailSender
{
	/// 
	/// Summary description for IPConfig.
	/// 
	public class IPConfig
	{
		private string hostName;
		private string domainName;
        private IPAddressCollection dnsServers;

        public IPConfig()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in nics)
            {
                if ((ni.OperationalStatus == OperationalStatus.Up) && (ni.NetworkInterfaceType!=NetworkInterfaceType.Loopback))
                {
                    dnsServers = ni.GetIPProperties().DnsAddresses;
                }
            }

        }
		

		private IPAddress GetIP(string ipString)
		{
			if ( ipString == null || ipString == "" )
				return null;

			try
			{
				return IPAddress.Parse(ipString);
			}
			catch
			{
				return null;
			}
		}

		public string HostName
		{
			get { return this.hostName; }
		}

		public string DomainName
		{
			get { return this.domainName; }
		}

        public IPAddressCollection DnsServers
		{
			get { return this.dnsServers; }
		}
	}
}
