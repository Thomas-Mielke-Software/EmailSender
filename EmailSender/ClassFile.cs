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
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;

namespace EmailSender
{
    /// <summary>
    /// Summary description for ClassFile.
    /// </summary>
    /// 
    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
        public IntPtr hIcon;
        public IntPtr iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    };

    public class Win32
    {
        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0;    // 'Large icon
        public const uint SHGFI_SMALLICON = 0x1;    // 'Small icon

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath,
            uint dwFileAttributes,
            ref SHFILEINFO psfi,
            uint cbSizeFileInfo,
            uint uFlags);
    }

    [XmlRoot("Fields")]
    public class ClassFile
    {
        //[XmlAttribute("FromEmail")] public string _fromEmail = "";
        [XmlElement("FromEmail")]
        public string FromEmail = "";
        [XmlElement("FromName")]
        public string FromName = "";
        [XmlElement("Reply")]
        public string Reply = "";
        [XmlElement("Priority")]
        public int Priority = 1;
        [XmlElement("Encoding")]
        public string Encoding = "UTF8";
        [XmlElement("Format")]
        public string Format = "text/plain";
        [XmlElement("Subject")]
        public string Subject = "";
        [XmlElement("Body")]
        public string Body = "Dear <=Name>,\r\n\r\n\r\n\r\nRegards,\r\n<=FromName>\r\n<=FromEmail>\r\n<=Time>";

        private List<Address> _lstAddress;
        private List<Attachment> _lstAttach;

        public ClassFile()
        {
            _lstAddress = new List<Address>();
            _lstAttach = new List<Attachment>();
        }

        public void ClearAttach()
        {
            _lstAttach.Clear();
        }

        public void ClearAddress()
        {
            _lstAddress.Clear();
        }



        #region Address Element
        [XmlElement("Addresses")]
        public Address[] Addresses
        {
            get
            {
                Address[] addresses = new Address[_lstAddress.Count];
                _lstAddress.CopyTo(addresses);
                return addresses;
            }
            set
            {
                if (value == null) return;
                Address[] addresses = (Address[])value;
                _lstAddress.Clear();
                foreach (Address addr in addresses)
                {
                    _lstAddress.Add(addr);
                }
            }
        }
        public void AddAddress(Address addr)
        {
            _lstAddress.Add(addr);
        }
        #endregion
        #region Attachment Element
        [XmlElement("Attachment")]
        public Attachment[] Attachments
        {
            get
            {
                Attachment[] attachments = new Attachment[_lstAttach.Count];
                _lstAttach.CopyTo(attachments);
                return attachments;
            }
            set
            {
                if (value == null) return;
                Attachment[] attachments = (Attachment[])value;
                _lstAttach.Clear();
                foreach (Attachment att in attachments)
                {
                    _lstAttach.Add(att);
                }
            }
        }
        public void AddAttach(Attachment att)
        {
            _lstAttach.Add(att);
        }
        #endregion
    }

    public class Address
    {
        [XmlElement("Index")]
        public int Index;
        [XmlElement("Email")]
        public string Email;
        [XmlElement("Name")]
        public string Name;
        [XmlElement("Company")]
        public string Company;
        [XmlElement("Status")]
        public string Status;
        [XmlElement("Memo")]
        public string Memo;
        [XmlElement("Carrier")]
        public string Carrier;
        [XmlElement("Checked")]
        public bool Checked;
        [XmlElement("Image")]
        public int Image;

        public Address()
        {
        }
        public Address(int pIndex,string pEmail, string pName, string pCompany, string pStatus, string pMemo, string pCarrier, bool pChecked, int image)
        {
            Index = pIndex;
            Email = pEmail;
            Name = pName;
            Company = pCompany;
            Status = pStatus;
            Memo = pMemo;
            Checked = pChecked;
            Image = image;
            Carrier = pCarrier;
        }
    }
    public class Attachment
    {
        [XmlElement("File")]
        public string _file;

        public Attachment()
        {
        }
        public Attachment(string pFile)
        {
            _file = pFile;
        }
    }
}