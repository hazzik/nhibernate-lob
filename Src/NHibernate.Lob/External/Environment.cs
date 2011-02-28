﻿using System;

namespace NHibernate.Lob.External
{
	public static class Environment
	{
		public const string ConnectionProviderProperty = "connection.lob.external.provider";
		public const string ConnectionStringProperty = "connection.lob.external.connection_string";
		public const string ConnectionStringNameProperty = "connection.lob.external.connection_string_name";

		public static void GarbageCollect(ISession session)
		{
			throw new NotImplementedException();
		}
	}
}