﻿using System.Collections.Generic;
using Lob.NHibernate.Compression;

namespace Lob.NHibernate.Type
{
	/// <summary>
	/// ExternalBlobType with Gzip enabled by default (for use in Castle ActiveRecord)
	/// </summary>
	public class GzipExternalBlobType : ExternalBlobType
	{
		public override void SetParameterValues(IDictionary<string, string> parameters)
		{
			base.SetParameterValues(parameters);
			if (Compression == null) Compression = new GZipCompressor();
		}
	}
}