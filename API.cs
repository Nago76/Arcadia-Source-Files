// SulfurDeX Decompiler
// Successfully Decompiled [ 0.65 sec ]

// Author : Dev

// Bypass Protection [ Enabled ]
// nullable [ Disabled ]


using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k5NYY7D5cXrEH3EnKv;

public static class API
{
	private static bool i0Z9c8A9F;

	public static void Attach()
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0xFE0A21C ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_32913cd6da8a46f2aa550983dacb7f14),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			};
			Process.Start(startInfo);
		}
		catch (Exception ex)
		{
			MessageBox.Show(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x3D02605 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_650f52efed4247c6aad1603809fb611d) + ex.Message, sFwOL7x9Vl71usW1KQ.kQwl2UjLH(--338794240 ^ 0x33DC7B66 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_607d4234880747b19314e453c84e7710), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	public static async Task SendScript(string script)
	{
		await CL7wsrGUP(script);
	}

	private static async Task CL7wsrGUP(string P_0)
	{
		using NamedPipeClientStream pipeClient = new NamedPipeClientStream(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0xFE0A386 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_32913cd6da8a46f2aa550983dacb7f14), sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x2D0F2DB7 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_6dd86eee9fb94fbf9582ae212edef434), PipeDirection.Out);
		try
		{
			await pipeClient.ConnectAsync();
			byte[] scriptBytes = Encoding.UTF8.GetBytes(P_0);
			await pipeClient.WriteAsync(scriptBytes, 0, scriptBytes.Length);
			pipeClient.Close();
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			MessageBox.Show(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x6BA962F2 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_bd2ba6130bf249feb8ae775b86560a9b) + ex2.Message, sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x10AC65A ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_3de98433bf8445ec82facbe588158646), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	public static bool IsRobloxOpen()
	{
		return Process.GetProcessesByName(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0xAE330C ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_92b7d97c1f8d4195b3787554edf73462)).Length != 0;
	}

	public static void KillRoblox()
	{
		Process[] processesByName = Process.GetProcessesByName(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(-1129290561 ^ -1135555456 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_f288b4e445da42cd9b365e0856aa03c4));
		if (processesByName.Length != 0)
		{
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		else
		{
			MessageBox.Show(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x15AB3F9A ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_92a6027b1b184fa992de8e5512eea135), sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x2D6E1FF9 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_2f84ac80f0aa40598429b972fcbf1337), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	public static string GetCurrentDirectory()
	{
		return AppDomain.CurrentDomain.BaseDirectory;
	}

	public static void SetConfig(string name, string version, string injectionMessage)
	{
		string text = Path.Combine(GetCurrentDirectory(), sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x42A75B21 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_6ed9ba52fc114f94958acc78f3335c30));
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string text2 = Path.Combine(text, sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x21B4C70E ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_a81082651f7e4722878aafc90dcb6275));
	}

	public static void SetAutoInject(bool value)
	{
		i0Z9c8A9F = value;
		if (i0Z9c8A9F)
		{
			Attach();
		}
	}

	public static void KillInjector()
	{
		Process[] processesByName = Process.GetProcessesByName(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x3915DF2E ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_232b45899b3e47c994963e47ae1787ca));
		if (processesByName.Length != 0)
		{
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
			MessageBox.Show(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(-1479565220 ^ -1232874688 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_c80d409369df4de3aafb32f76ca0861f), sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x55DD70DD ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_946da345c6884b97be785b04eedfecc8), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
			MessageBox.Show(sFwOL7x9Vl71usW1KQ.kQwl2UjLH(--713450793 ^ 0x53B54F36 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_50da79d8e3d3402da8134fd7936368b0), sFwOL7x9Vl71usW1KQ.kQwl2UjLH(0x3D02775 ^ <Module>{5764ecce-a675-4b76-8dca-9e4e07884260}.m_cb40eaa70ae9444991b8fbce8b3f9507.m_650f52efed4247c6aad1603809fb611d), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
}
