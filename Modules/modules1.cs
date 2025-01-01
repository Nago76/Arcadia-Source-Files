// Decompiled!
// FAILED: Unable decompile assembly
using System;

internal class <Module>
{
	internal static void m8DD28989F517E4C()
	{
		int days = (DateTime.Now - new DateTime(2024, 12, 30)).Days;
		if (days > 14 || days <= -14)
		{
			throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
		}
	}

	static <Module>()
	{
		m8DD28989F517E4C();
	}
}
