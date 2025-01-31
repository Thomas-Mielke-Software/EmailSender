using System;

namespace LumiSoft.Net.SMTP.Client
{
	/// <summary>
	/// This class holds smtp error info.
	/// </summary>
	public class SMTP_Error
	{
		private SMTP_ErrorType m_ErrorType      = SMTP_ErrorType.UnKnown;
		private string[]       m_AffectedEmails = null;
		private string         m_ErrorText      = "";
		private string m_jobID = "";

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <param name="errorType"></param>
		/// <param name="affectedEmails"></param>
		/// <param name="errorText"></param>
		/// <param name="jobID"></param>
		public SMTP_Error(SMTP_ErrorType errorType,string[] affectedEmails,string errorText,string jobID)
		{	
			m_ErrorType      = errorType;
			m_AffectedEmails = affectedEmails;
			m_ErrorText      = errorText;
			m_jobID = jobID;
		}


		#region Properties Implementation

		/// <summary>
		/// Gets SMTP error type.
		/// </summary>
		public SMTP_ErrorType ErrorType
		{
			get{ return m_ErrorType; }
		}

		/// <summary>
		/// Gets list of email addresses which are affected by this error.
		/// </summary>
		public string[] AffectedEmails
		{
			get{ return m_AffectedEmails; }
		}

		/// <summary>
		/// Gets additional error text.
		/// </summary>
		public string ErrorText
		{
			get{ return m_ErrorText; }
		}
		public string JobID
		{
			get{ return m_jobID; }
		}
		#endregion

	}
}
