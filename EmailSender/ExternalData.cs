//*************************************************************
//
//  An open source project developped by a man
//  Copyright (C) 2005  Vincent Magiya
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
//****************************************************************************

using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;


namespace EmailSender
{
	/// <summary>
	/// Summary description for ExternalData.
	/// </summary>
	/// 
	[StructLayout(LayoutKind.Sequential)]
	[XmlRoot("ExternalData")]
	public class ExternalData
	{
		private ArrayList _lstAddress;
		
		public ExternalData()
		{
			_lstAddress = new ArrayList();
		}

		#region Address Element
		[XmlElement("Addresses")]
		public ExtAddress[] Addresses
		{
			get
			{
				ExtAddress[] addresses = new ExtAddress[_lstAddress.Count];
				_lstAddress.CopyTo(addresses);
				return addresses;
			}
			set
			{
				if(value==null) return;
				ExtAddress[] addresses = (ExtAddress[]) value;
				_lstAddress.Clear();
				foreach(ExtAddress addr in addresses)
				{
					_lstAddress.Add(addr);
				}
			}
		}
		public int AddAddress(ExtAddress addr)
		{
			return _lstAddress.Add(addr);
		}
		#endregion

	}

	public class ExtAddress
	{
		[XmlElement("Email")] public string _email;
		[XmlElement("Name")] public string _name;
		[XmlElement("Company")] public string _company;
		[XmlElement("Memo")] public string _memo;

		public ExtAddress() 
		{
		}
		public ExtAddress(string pEmail, string pName, string pCompany, string pMemo)
		{
			_email = pEmail;
			_name = pName;
			_company = pCompany;
			_memo = pMemo;
		}
	}
}
