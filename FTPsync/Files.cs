/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-02-04
 * Time: 12:44
 * 
 */
using System;

namespace FTPsync
{
	/// <summary>
	/// Description of Files.
	/// </summary>
	public class RemoteFile
	{
		public string fileName;
		public string fullPath;
		public DateTime lastEdited;
		public RemoteFile(){}
	}
	
	public class LocalFile
	{
		public string fileName;
		public string fullPath;
		public DateTime lastEdited;
		public LocalFile() {}
	}
}
