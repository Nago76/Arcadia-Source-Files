// Decompiled!

using System;
using System.Reflection;
using jnoO9QZGYtNbvO7vZ8;
using OY9FEOYf4mA5lTsDknl;

internal class Db6XHstkZXtZgE6PeZ
{
	internal delegate void Hw6PvsStAuCoxTh9fi(object o);

	internal static Module vHbvgLLLx;

	internal static void VTkP8ltgGo(int typemdt)
	{
		Type type = vHbvgLLLx.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)vHbvgLLLx.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Db6XHstkZXtZgE6PeZ()
	{
		QuXUB4Y4PpfHQMw70oq.c2XPfWaQoI();
		base..ctor();
	}

	static Db6XHstkZXtZgE6PeZ()
	{
		QuXUB4Y4PpfHQMw70oq.c2XPfWaQoI();
		vHbvgLLLx = typeof(Db6XHstkZXtZgE6PeZ).Assembly.ManifestModule;
	}
}
