// Decompiled!
// FAILED: Unable to get assembly due Protected
using System;

internal class QuXUB4Y4PpfHQMw70oq
{
	private static bool iDDY5NvWHp;

	internal static void c2XPfWaQoI()
	{
		if (!iDDY5NvWHp)
		{
			iDDY5NvWHp = true;
			if (Math.Abs((DateTime.Now - new DateTime(2024, 12, 30)).Days) >= 14)
			{
				throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
			}
		}
	}
}
