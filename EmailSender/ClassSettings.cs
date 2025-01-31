//////////////////////////////////////////////////////////////////////
/////
/////  An open source project developped by a man
/////  Copyright (C) 2005  Vincent Magiya
/////
/////  This program is free software; you can redistribute it and/or modify
/////  it under the terms of the GNU General Public License as published by
/////  the Free Software Foundation; either version 2 of the License, or
/////  (at your option) any later version.
/////
/////  This program is distributed in the hope that it will be useful,
/////  but WITHOUT ANY WARRANTY; without even the implied warranty of
/////  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/////  GNU General Public License for more details.
/////
/////  You should have received a copy of the GNU General Public License
/////  along with this program; if not, write to the Free Software
/////  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
/////
/////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Net;

namespace EmailSender
{
	/// <summary>
	/// Summary description for ClassSettings.
	/// </summary>
	/// 
	[StructLayout(LayoutKind.Sequential)]
	[XmlRoot("Settings")]
	public class ClassSettings
	{
		[XmlElement("CheckDuplicate")] public bool _chkDuplicate = true;
		[XmlElement("IfRetryFail")] public bool _ifRetryFail = false;
		[XmlElement("RetryFail")] public int _retryFail = 60;
		[XmlElement("IfLimitPerConn")] public bool _ifLimitPerConn = false;
		[XmlElement("LimitPerConn")] public int _limitPerConn = 5;
		[XmlElement("PerConnDelay")] public int _perConnDelay = 2;
		[XmlElement("MaxThreads")] public int _maxThreads = 1;
		[XmlElement("IfSendDirect")] public bool _ifSendDirect = true;
		[XmlElement("IfSendMAPI")] public bool _ifSendviaMAPI = false;
		[XmlElement("IfSMTP")] public bool _ifSMTP = false;
		[XmlElement("IfReplaceDup")] public bool _ifReplaceDup = true;
		[XmlElement("IfNoImportDup")] public bool _ifNoImportDup = false;
		[XmlElement("IfCreateDup")] public bool _ifCreateDup = false;
		[XmlElement("IfAutoSave")] public bool _ifAutoSave = false;
		[XmlElement("AutoSaveInterval")] public int _autoSaveInterval = 120;

		[XmlElement("EmailBlackList", typeof(string))]
		public ArrayList emailBlackList = new ArrayList();

		[XmlElement("NoSendList", typeof(string))]
		public ArrayList noSendList = new ArrayList();

		[XmlElement("NameBlackList", typeof(string))]
		public ArrayList nameBlackList = new ArrayList();

		[XmlElement("DomainBlackList", typeof(string))]
		public ArrayList domainBlackList = new ArrayList();

		[XmlElement("DNS", typeof(string))]
		public ArrayList DNS = new ArrayList();
		
		private ArrayList _lstSMTPServers = new ArrayList();

		#region SMTPServers Element
		[XmlElement("SMTPServers")]
		public SMTPServer[] SMTPServers
		{
			get
			{
				SMTPServer[] sMTPServers = new SMTPServer[_lstSMTPServers.Count];
				_lstSMTPServers.CopyTo(sMTPServers);
				return sMTPServers;
			}
			set
			{
				if(value==null) return;
				SMTPServer[] sMTPServers = (SMTPServer[]) value;
				_lstSMTPServers.Clear();
				foreach(SMTPServer server in sMTPServers)
				{
					_lstSMTPServers.Add(server);
				}
			}
		}
		public int SMTPServerCount()
		{
			return _lstSMTPServers.Count;
		}
		public int SMTPAddServer(SMTPServer server)
		{
			return _lstSMTPServers.Add(server);
		}
		public void SMTPClearServers()
		{
			_lstSMTPServers.Clear();
		}
		#endregion

		public ClassSettings()
		{
            IPConfig ipconfig = new IPConfig();
            foreach (IPAddress ip in ipconfig.DnsServers)
            {
                DNS.Add(ip.ToString());
            }
//			emailBlackList.Add("webmaster@sohu.com");
//			emailBlackList.Add("webmaster@21cn.com");
//			emailBlackList.Add("webmaster@china.com");
//			emailBlackList.Add("263@263.net.cn");
//			emailBlackList.Add("163vip@163.net");
//			nameBlackList.Add("abuse");
//			nameBlackList.Add("yourname");
//			nameBlackList.Add("Postmaster");
//			nameBlackList.Add("spam");
//			nameBlackList.Add("hostmaster");
//			nameBlackList.Add("sos");
//			domainBlackList.Add("163.net");
//			domainBlackList.Add("263.net");
//			domainBlackList.Add("21cn.com");
//			domainBlackList.Add("sohu.com");
		}
	}

	public class SMTPServer
	{
		[XmlElement("HostID")] public int HostID = 0;
		[XmlElement("Host")] public string Host = "";
		[XmlElement("Port")] public int Port = 25;
		[XmlElement("IfAuth")] public bool IfAuth = false;
		[XmlElement("UserID")] public string UserID = "";
		[XmlElement("Password")] public string Password = "";
		[XmlElement("IfLimit")] public bool IfLimit = false;
		[XmlElement("NrPerSession")] public int NrPerSession = 0;
		[XmlElement("IfSpecifySender")] public bool IfSpecifySender = false;
		[XmlElement("SenderEmail")] public string SenderEmail = "";
		[XmlElement("SenderName")] public string SenderName = "";
		[XmlElement("ReplyEmail")] public string ReplyEmail = "";
		[XmlElement("Enabled")] public bool Enabled = true;

		public SMTPServer()
		{
		}
	}
}
