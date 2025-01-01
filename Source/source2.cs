// Decompiled!
// WARNING: This type of source isn't from .NET 7.0
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using k5NYY7D5cXrEH3EnKv;
using OY9FEOYf4mA5lTsDknl;

internal class sFwOL7x9Vl71usW1KQ
{
	private delegate void XqZQ36JnWv10uFh51oI(object o);

	internal class AuFyeVJo5AC7q2noEI1 : Attribute
	{
		internal class OU7S2SJsvi8tWagbmdx<us1S09Jyl150xSEL4h9>
		{
			public OU7S2SJsvi8tWagbmdx()
			{
				QuXUB4Y4PpfHQMw70oq.c2XPfWaQoI();
				base..ctor();
			}
		}

		public AuFyeVJo5AC7q2noEI1(object P_0)
		{
		}
	}

	internal class M83qbxJC0OyUilQpAJl
	{
		internal static string kXqJErOjl9(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = VOudRP2rn(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = ywFNAYlCT();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint x83HRwJbgXMougjERJl(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr eEw3RvJXil5KWWhsgPi();

	internal struct vtmW59JAUjtHTceG96K
	{
		internal bool KKnJ6pVGVt;

		internal byte[] NucJeBXKWF;
	}

	internal class JPdxOWJLs5IJ7EyD3un
	{
		private BinaryReader aXPYJkViAg;

		public JPdxOWJLs5IJ7EyD3un(Stream P_0)
		{
			aXPYJkViAg = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream vh0ry9Sq2v()
		{
			return aXPYJkViAg.BaseStream;
		}

		internal byte[] UN0JilLL3h(int P_0)
		{
			return aXPYJkViAg.ReadBytes(P_0);
		}

		internal int tLAJk27P8T(byte[] P_0, int P_1, int P_2)
		{
			return aXPYJkViAg.Read(P_0, P_1, P_2);
		}

		internal int PLRJzqTds5()
		{
			return aXPYJkViAg.ReadInt32();
		}

		internal void cqpYUj8kVK()
		{
			aXPYJkViAg.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr lLqh9NYYNrRiQvVFw4k(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr hefNV6YPC3pcof5RytU(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Xy0AKyYjJlW22Ps4c5C(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int fQtQGIYg4UFKhg2tmVb(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr XAACt9YmTKPFC0IrJyu(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int qEXYphY1L0runSva4Pk(IntPtr ptr);

	[Flags]
	private enum Xg3UwGY8YdTOglF80eW
	{

	}

	private static bool pIEJfOCHKk;

	private static bool XrIJ5R5Xn9;

	private static int MmJJt4K9TL;

	private static List<string> siTJv6htVR;

	private static byte[] sxYJx6TTmP;

	private static IntPtr sEfJVYwRkT;

	private static object gicJH6PBJu;

	private static int sNrJQn7Qyx;

	internal static x83HRwJbgXMougjERJl wNIJqpIsdj;

	private static int HquJcsCQYD;

	internal static Hashtable Kb0JItlEpP;

	private static Xy0AKyYjJlW22Ps4c5C MJwJpc2OnD;

	private static fQtQGIYg4UFKhg2tmVb KpmJMO0mXb;

	private static SortedList yVZJ3VE6JZ;

	internal static RSACryptoServiceProvider WtnJ75b1gw;

	private static IntPtr dytJBuw1So;

	private static hefNV6YPC3pcof5RytU q4HJl3lSvk;

	private static XAACt9YmTKPFC0IrJyu O1kJFxQxv8;

	private static int[] dJwJWQdSPB;

	private static bool cQqJudxDxp;

	private static object dUyJZEUv4b;

	private static IntPtr maHJ06Hius;

	private static bool l4KJrL8P4f;

	private static List<int> J7xJSfVUvE;

	private static long N40JK6SAFj;

	internal static x83HRwJbgXMougjERJl LbuJdhm1uT;

	private static uint[] jUZJ4EbXhm;

	private static int MRNJGc08Qr;

	private static long rMuJN57jYW;

	private static byte[] VFfJDH8MKv;

	private static IntPtr NAOJ2LQ8Ro;

	private static bool l8fJ1Vi8GI;

	private static object n7cJ9tWgV8;

	private static lLqh9NYYNrRiQvVFw4k NsKJhhXtQL;

	private static qEXYphY1L0runSva4Pk ujHJatYm47;

	private static Dictionary<int, int> hptJwCQj90;

	internal static Assembly JweJ8PvHD2;

	[AuFyeVJo5AC7q2noEI1(typeof(AuFyeVJo5AC7q2noEI1.OU7S2SJsvi8tWagbmdx<object>[]))]
	private static bool jh7JTTNQss;

	private static bool oZxJR3SNcC;

	private static int J8TJOCamxt;

	static sFwOL7x9Vl71usW1KQ()
	{
		l8fJ1Vi8GI = false;
		JweJ8PvHD2 = typeof(sFwOL7x9Vl71usW1KQ).Assembly;
		jUZJ4EbXhm = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		pIEJfOCHKk = false;
		XrIJ5R5Xn9 = false;
		WtnJ75b1gw = null;
		hptJwCQj90 = null;
		n7cJ9tWgV8 = new object();
		MmJJt4K9TL = 0;
		dUyJZEUv4b = new object();
		siTJv6htVR = null;
		J7xJSfVUvE = null;
		sxYJx6TTmP = new byte[0];
		VFfJDH8MKv = new byte[0];
		NAOJ2LQ8Ro = IntPtr.Zero;
		sEfJVYwRkT = IntPtr.Zero;
		gicJH6PBJu = new string[0];
		dJwJWQdSPB = new int[0];
		MRNJGc08Qr = 1;
		oZxJR3SNcC = false;
		yVZJ3VE6JZ = new SortedList();
		sNrJQn7Qyx = 0;
		rMuJN57jYW = 0L;
		wNIJqpIsdj = null;
		LbuJdhm1uT = null;
		N40JK6SAFj = 0L;
		J8TJOCamxt = 0;
		l4KJrL8P4f = false;
		cQqJudxDxp = false;
		HquJcsCQYD = 0;
		dytJBuw1So = IntPtr.Zero;
		jh7JTTNQss = false;
		Kb0JItlEpP = new Hashtable();
		NsKJhhXtQL = null;
		q4HJl3lSvk = null;
		MJwJpc2OnD = null;
		KpmJMO0mXb = null;
		O1kJFxQxv8 = null;
		ujHJatYm47 = null;
		maHJ06Hius = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void T6vP4OwCiZ()
	{
	}

	internal static byte[] IWH26OVgT(byte[] P_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - P_0.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(P_0.Length + num / 8 + 8);
		ulong num3 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = 0u; num10 < num5 / 16; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0u; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			RkoVQts66(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			RkoVQts66(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			RkoVQts66(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			RkoVQts66(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			RkoVQts66(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			RkoVQts66(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			RkoVQts66(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			RkoVQts66(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			RkoVQts66(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			RkoVQts66(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			RkoVQts66(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			RkoVQts66(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			RkoVQts66(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			RkoVQts66(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			RkoVQts66(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			RkoVQts66(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			sjeHTiQ8b(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			sjeHTiQ8b(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			sjeHTiQ8b(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			sjeHTiQ8b(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			sjeHTiQ8b(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			sjeHTiQ8b(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			sjeHTiQ8b(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			sjeHTiQ8b(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			sjeHTiQ8b(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			sjeHTiQ8b(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			sjeHTiQ8b(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			sjeHTiQ8b(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			sjeHTiQ8b(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			sjeHTiQ8b(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			sjeHTiQ8b(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			sjeHTiQ8b(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			QhQWjLKmD(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			QhQWjLKmD(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			QhQWjLKmD(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			QhQWjLKmD(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			QhQWjLKmD(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			QhQWjLKmD(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			QhQWjLKmD(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			QhQWjLKmD(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			QhQWjLKmD(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			QhQWjLKmD(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			QhQWjLKmD(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			QhQWjLKmD(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			QhQWjLKmD(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			QhQWjLKmD(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			QhQWjLKmD(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			QhQWjLKmD(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			sUCGjdZy8(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			sUCGjdZy8(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			sUCGjdZy8(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			sUCGjdZy8(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			sUCGjdZy8(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			sUCGjdZy8(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			sUCGjdZy8(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			sUCGjdZy8(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			sUCGjdZy8(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			sUCGjdZy8(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			sUCGjdZy8(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			sUCGjdZy8(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			sUCGjdZy8(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			sUCGjdZy8(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			sUCGjdZy8(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			sUCGjdZy8(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	private static void RkoVQts66(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Q7XR90lrR(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + jUZJ4EbXhm[P_6 - 1], P_5);
	}

	private static void sjeHTiQ8b(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Q7XR90lrR(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + jUZJ4EbXhm[P_6 - 1], P_5);
	}

	private static void QhQWjLKmD(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Q7XR90lrR(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + jUZJ4EbXhm[P_6 - 1], P_5);
	}

	private static void sUCGjdZy8(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + Q7XR90lrR(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + jUZJ4EbXhm[P_6 - 1], P_5);
	}

	private static uint Q7XR90lrR(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool e5N3ewjof()
	{
		if (!pIEJfOCHKk)
		{
			FpAqgiSF5();
			pIEJfOCHKk = true;
		}
		return XrIJ5R5Xn9;
	}

	internal sFwOL7x9Vl71usW1KQ()
	{
	}

	private void pbTQjHZyV(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		int num = P_2.Length % 4;
		int num2 = P_2.Length / 4;
		byte[] array = new byte[P_2.Length];
		int num3 = P_0.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= P_2[P_2.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((P_2[num7 + 3] << 24) | (P_2[num7 + 2] << 16) | (P_2[num7 + 1] << 8) | P_2[num7]);
			}
			uint num12 = num4;
			num4 = 0u;
			uint num13 = 2090451219u;
			uint num14 = 1187503562u;
			uint num15 = 1824279204u;
			uint num16 = 539661189u;
			uint num17 = num12;
			num15 = 197111903 * (num15 & 7) - (num15 >> 3);
			num16 = 425425179 * (num16 & 7) + (num16 >> 3);
			num14 = 22843 * num14 - num13;
			num13 ^= num14;
			num13 = 3918 * (num13 & 0xFFFFF) - (num13 >> 20);
			num14 = 3562 * (num14 & 0xFFFFF) + (num14 >> 20);
			num16 = 40697 * num16 - num15;
			if (num15 == 0)
			{
				num15--;
			}
			uint num18 = num16 / num15 + num15;
			num15 = ((num16 + num16) ^ num18) + num16;
			uint num19 = ((num17 >> 9) | (num17 << 23)) ^ num16;
			uint num20 = num19 & 0xF0F0F0F;
			num19 &= 0xF0F0F0F0u;
			num17 = (num19 >> 4) | (num20 << 4);
			num17 ^= num17 << 6;
			num17 += num14;
			num17 ^= num17 << 1;
			num17 += num15;
			num17 ^= num17 >> 11;
			num17 += num17;
			num17 = (((num14 << 18) - num15) ^ num14) - num17;
			num4 = num12 + (uint)(double)num17;
			if (i == num2 - 1 && num > 0)
			{
				uint num21 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num21 & num10) >> num11);
				}
			}
			else
			{
				uint num22 = num4 ^ num6;
				array[num9] = (byte)(num22 & 0xFF);
				array[num9 + 1] = (byte)((num22 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num22 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
			}
		}
		sxYJx6TTmP = array;
	}

	internal static SymmetricAlgorithm ywFNAYlCT()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (e5N3ewjof())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
			catch
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
	}

	internal static void FpAqgiSF5()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			XrIJ5R5Xn9 = true;
			return;
		}
		try
		{
			XrIJ5R5Xn9 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] VOudRP2rn(byte[] P_0)
	{
		if (!e5N3ewjof())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return IWH26OVgT(P_0);
	}

	internal static void np4KcSV4s(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
			P_1.Read(P_3, 0, num);
			l4LOOxa2s(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void l4LOOxa2s(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
	{
		P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
	}

	internal static uint gJyr00RH1(uint P_0, int P_1, long P_2, BinaryReader P_3)
	{
		for (int i = 0; i < P_1; i++)
		{
			P_3.BaseStream.Position = P_2 + (i * 40 + 8);
			uint num = P_3.ReadUInt32();
			uint num2 = P_3.ReadUInt32();
			P_3.ReadUInt32();
			uint num3 = P_3.ReadUInt32();
			if (num2 <= P_0 && P_0 < num2 + num)
			{
				return num3 + P_0 - num2;
			}
		}
		return 0u;
	}

	public static void YlbuhAoou(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (hptJwCQj90 == null)
			{
				lock (n7cJ9tWgV8)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(sFwOL7x9Vl71usW1KQ).Assembly.GetManifestResourceStream("A5MHD151h5ld6pCIRo.tmKDL77AJG0u3Ct6La"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += DTuTywCDl(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFF);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						JPdxOWJLs5IJ7EyD3un jPdxOWJLs5IJ7EyD3un = new JPdxOWJLs5IJ7EyD3un(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = jPdxOWJLs5IJ7EyD3un.PLRJzqTds5();
							int value = jPdxOWJLs5IJ7EyD3un.PLRJzqTds5();
							dictionary.Add(key, value);
						}
						jPdxOWJLs5IJ7EyD3un.cqpYUj8kVK();
					}
					hptJwCQj90 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = hptJwCQj90[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)typeof(sFwOL7x9Vl71usW1KQ).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num13 = parameters.Length + 1;
					Type[] array3 = new Type[num13];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = typeof(object);
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num14 = 0; num14 < num13; num14++)
					{
						switch (num14)
						{
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num14);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Tailcall);
					iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint kZPBpoPeo(uint P_0)
	{
		return (uint)"CCJZLhOxstuPZfOX".Length;
	}

	private static uint DTuTywCDl(uint P_0)
	{
		return 0u;
	}

	internal static void g62I8G6xR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void QVDh3aF1D(Stream P_0, int P_1)
	{
		int num = 38;
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 323:
					array[29] = (byte)num3;
					num2 = 123;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 330;
					}
					continue;
				case 337:
					array[2] = (byte)num3;
					num2 = 198;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 39;
					}
					continue;
				case 28:
					array[31] = 145;
					num2 = 329;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 108;
					}
					continue;
				case 262:
					array3[7] = 165;
					num2 = 237;
					continue;
				case 81:
					num4 = 221 - 73;
					num2 = 76;
					continue;
				case 190:
					array[5] = (byte)num3;
					num2 = 216;
					continue;
				case 215:
					array[19] = (byte)num3;
					num2 = 3;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 12;
					}
					continue;
				case 132:
					num4 = 140 - 32;
					num2 = 60;
					continue;
				case 71:
					array[30] = 98;
					num2 = 311;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 269;
					}
					continue;
				case 258:
					array4[15] = array5[7];
					num2 = 202;
					continue;
				case 54:
					array3[6] = 124;
					num2 = 147;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 328;
					}
					continue;
				case 322:
					num3 = 98 + 43;
					num2 = 120;
					continue;
				case 234:
					array[17] = (byte)num3;
					num2 = 27;
					continue;
				case 191:
					array[24] = 110;
					num2 = 251;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 239;
					}
					continue;
				case 16:
					num3 = 32 + 73;
					num2 = 250;
					continue;
				case 6:
					num3 = 173 + 61;
					num2 = 9;
					continue;
				case 85:
					num4 = 157 - 52;
					num2 = 42;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 13;
					}
					continue;
				case 238:
					num3 = 157 - 33;
					num2 = 236;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 175;
					}
					continue;
				case 310:
					array[13] = 161;
					num = 161;
					break;
				case 83:
					array3 = new byte[16];
					num2 = 162;
					continue;
				case 88:
					array[10] = (byte)num3;
					num2 = 95;
					continue;
				case 199:
					num4 = 69 + 18;
					num2 = 4;
					continue;
				case 221:
					array3[7] = 134;
					num2 = 36;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 271;
					}
					continue;
				case 125:
					array[16] = 217;
					num2 = 256;
					continue;
				case 33:
					num3 = 206 - 68;
					num2 = 289;
					continue;
				case 116:
					num4 = 111 - 53;
					num = 51;
					break;
				case 112:
					num3 = 231 - 77;
					num2 = 35;
					continue;
				case 87:
					num4 = 101 + 106;
					num2 = 193;
					continue;
				case 27:
					num3 = 223 + 29;
					num2 = 292;
					continue;
				case 62:
					array[21] = (byte)num3;
					num2 = 297;
					continue;
				case 330:
					num3 = 47 + 81;
					num2 = 22;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 26;
					}
					continue;
				case 316:
					array3[0] = 218;
					num2 = 65;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 35;
					}
					continue;
				case 107:
					array5 = (byte[])pH0ytcYiwAV3jNtNwdw(gFUWVRYLP2gVsg2PM52(JweJ8PvHD2));
					num2 = 257;
					continue;
				case 151:
					array3[0] = (byte)num4;
					num2 = 40;
					continue;
				case 167:
					array[0] = 84;
					num2 = 68;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 276;
					}
					continue;
				case 143:
					array[16] = (byte)num3;
					num2 = 229;
					continue;
				case 22:
					array[0] = 71;
					num2 = 167;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 20;
					}
					continue;
				case 317:
					num4 = 228 - 76;
					num2 = 208;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 179;
					}
					continue;
				case 205:
					array[15] = 162;
					num2 = 307;
					continue;
				case 32:
					array[25] = 136;
					num2 = 171;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 153;
					}
					continue;
				case 186:
					array[5] = 144;
					num2 = 91;
					continue;
				case 217:
					array6 = array;
					num2 = 83;
					continue;
				case 249:
					array3[12] = (byte)num4;
					num2 = 263;
					continue;
				case 159:
					array2 = sxYJx6TTmP;
					num2 = 66;
					continue;
				case 266:
					if (array5.Length == 0)
					{
						num2 = 115;
						if (uhIxCCYC0jJYDEVlJoQ() == null)
						{
							num2 = 138;
						}
						continue;
					}
					goto case 13;
				case 313:
					array[10] = 199;
					num2 = 68;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 158;
					}
					continue;
				case 264:
					array[20] = (byte)num3;
					num2 = 169;
					continue;
				case 281:
					if (P_1 == -1)
					{
						num2 = 8;
						if (!XrK028YyMVPEfZWwyVR())
						{
							num2 = 4;
						}
						continue;
					}
					goto case 66;
				case 232:
					array3[14] = 145;
					num2 = 23;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 44;
					}
					continue;
				case 155:
					num3 = 198 - 66;
					num2 = 235;
					continue;
				case 38:
				{
					JPdxOWJLs5IJ7EyD3un jPdxOWJLs5IJ7EyD3un = new JPdxOWJLs5IJ7EyD3un(P_0);
					VJ6JKbYbTkhlGImrXw6(MOdbCqYEqI34hQ87CcU(jPdxOWJLs5IJ7EyD3un), 0L);
					array2 = (byte[])OlU1HYYAknIq5adLaM0(jPdxOWJLs5IJ7EyD3un, (int)fhJytWYXvCtsPZnI95i(MOdbCqYEqI34hQ87CcU(jPdxOWJLs5IJ7EyD3un)));
					AcCPQJY6qYcVHjgYOAc(jPdxOWJLs5IJ7EyD3un);
					num = 37;
					break;
				}
				case 259:
					array[9] = (byte)num3;
					num2 = 301;
					continue;
				case 113:
					num3 = 98 + 67;
					num2 = 21;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 19;
					}
					continue;
				case 256:
					num3 = 73 + 83;
					num2 = 143;
					continue;
				case 137:
					array3[12] = (byte)num4;
					num2 = 146;
					continue;
				case 127:
					array3[4] = (byte)num4;
					num2 = 81;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 99;
					}
					continue;
				case 181:
					num4 = 141 - 34;
					num2 = 296;
					continue;
				case 118:
					array[0] = (byte)num3;
					num2 = 110;
					continue;
				case 263:
					array3[13] = 93;
					num2 = 31;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 43;
					}
					continue;
				case 241:
					array[25] = 119;
					num2 = 138;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 274;
					}
					continue;
				case 227:
					array[11] = 242;
					num = 30;
					break;
				case 66:
					if (!rtKw7XP1l94c9EvOlHE(DIEEl7PmAF0F8LRw4f5(JweJ8PvHD2), null))
					{
						num2 = 25;
						continue;
					}
					goto case 203;
				case 273:
					num3 = 74 - 3;
					num2 = 50;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 147;
					}
					continue;
				case 163:
					array[31] = (byte)num3;
					num2 = 217;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 110;
					}
					continue;
				case 188:
					array3[6] = (byte)num4;
					num2 = 275;
					continue;
				case 204:
					array[30] = 150;
					num2 = 71;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 10;
					}
					continue;
				case 135:
					num3 = 178 - 59;
					num2 = 160;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 176;
					}
					continue;
				case 61:
					array3[5] = 85;
					num2 = 19;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 14;
					}
					continue;
				case 197:
					num4 = 223 - 74;
					num2 = 299;
					continue;
				case 277:
					array[12] = 104;
					num2 = 96;
					continue;
				case 139:
					num3 = 69 + 78;
					num2 = 59;
					continue;
				case 311:
					num3 = 171 - 57;
					num2 = 23;
					continue;
				case 56:
					array3[15] = (byte)num4;
					num2 = 199;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 150;
					}
					continue;
				case 105:
					array[14] = 112;
					num2 = 320;
					continue;
				case 114:
					num3 = 186 - 62;
					num2 = 111;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 129;
					}
					continue;
				case 59:
					array[23] = (byte)num3;
					num2 = 228;
					continue;
				case 243:
					array4[7] = array5[3];
					num2 = 131;
					continue;
				case 306:
					array[1] = 27;
					num = 220;
					break;
				case 30:
					num3 = 197 - 65;
					num2 = 204;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 332;
					}
					continue;
				case 138:
				case 202:
				case 335:
					num5 = 0;
					num2 = 0;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 0;
					}
					continue;
				case 165:
					array[18] = 185;
					num2 = 334;
					continue;
				case 9:
					array[16] = (byte)num3;
					num2 = 175;
					continue;
				case 84:
					array[11] = 94;
					num2 = 155;
					continue;
				case 244:
					num3 = 231 + 5;
					num2 = 209;
					continue;
				case 63:
					array[29] = 145;
					num2 = 14;
					continue;
				case 175:
					num3 = 99 + 118;
					num2 = 318;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 91;
					}
					continue;
				case 230:
					array[12] = (byte)num3;
					num2 = 87;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 180;
					}
					continue;
				case 2:
					array[19] = 134;
					num2 = 168;
					continue;
				case 35:
					array[6] = (byte)num3;
					num = 187;
					break;
				case 122:
				{
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					raXbcNPYMu9Y08q8Z1W(cryptoStream, array2, 0, array2.Length);
					oZowh5PPlFILeann5rU(cryptoStream);
					sxYJx6TTmP = (byte[])hHg2BCPjd1Ctkm4uwXI(stream);
					EsHa2nPgTlWkI3RbiJ2(stream);
					EsHa2nPgTlWkI3RbiJ2(cryptoStream);
					num2 = 159;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 84;
					}
					continue;
				}
				case 203:
					MmJJt4K9TL = 80;
					num2 = 140;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 324;
					}
					continue;
				case 253:
					array[10] = (byte)num3;
					num2 = 61;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 84;
					}
					continue;
				case 154:
					num4 = 144 - 48;
					num2 = 284;
					continue;
				case 307:
					num3 = 119 + 96;
					num2 = 55;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 70;
					}
					continue;
				case 68:
					array[26] = 223;
					num2 = 41;
					continue;
				case 169:
					array[20] = 200;
					num2 = 75;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 102;
					}
					continue;
				case 147:
					array[6] = (byte)num3;
					num2 = 141;
					continue;
				case 103:
					array[9] = 145;
					num2 = 272;
					continue;
				case 172:
					num3 = 181 - 60;
					num2 = 215;
					continue;
				case 145:
					array3[3] = 144;
					num2 = 210;
					continue;
				case 334:
					num3 = 106 + 50;
					num2 = 67;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 90;
					}
					continue;
				case 64:
					num3 = 24 + 58;
					num2 = 79;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 23;
					}
					continue;
				case 67:
					num3 = 186 - 62;
					num2 = 60;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 136;
					}
					continue;
				case 26:
					array[29] = (byte)num3;
					num2 = 298;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 157;
					}
					continue;
				case 220:
					num3 = 136 - 45;
					num2 = 295;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 337;
					}
					continue;
				case 193:
					array3[1] = (byte)num4;
					num2 = 122;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 280;
					}
					continue;
				case 216:
					num3 = 178 - 103;
					num2 = 321;
					continue;
				case 278:
					array3[14] = (byte)num4;
					num2 = 232;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 77;
					}
					continue;
				case 148:
					JwFrbDYeho7mnxTJDO6(array4);
					num2 = 107;
					continue;
				case 141:
					array[7] = 55;
					num2 = 294;
					continue;
				case 206:
					array[27] = 54;
					num2 = 12;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 173;
					}
					continue;
				case 308:
					array3[6] = (byte)num4;
					num = 239;
					break;
				case 209:
					array[15] = (byte)num3;
					num2 = 64;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 125;
					}
					continue;
				case 166:
					num3 = 177 - 59;
					num2 = 259;
					continue;
				case 212:
					array[1] = (byte)num3;
					num2 = 340;
					continue;
				case 89:
					num3 = 64 - 4;
					num2 = 233;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 217;
					}
					continue;
				case 12:
					num3 = 201 - 67;
					num2 = 156;
					continue;
				case 157:
					num3 = 35 + 23;
					num2 = 3;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 5;
					}
					continue;
				case 315:
					num5++;
					num2 = 270;
					continue;
				case 104:
					num4 = 158 + 83;
					num = 305;
					break;
				case 286:
					array3[8] = 154;
					num2 = 132;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 118;
					}
					continue;
				case 108:
					array3[11] = 133;
					num2 = 247;
					continue;
				case 293:
					array[7] = (byte)num3;
					num = 194;
					break;
				case 79:
					array[22] = (byte)num3;
					num2 = 285;
					continue;
				case 92:
					array[28] = 99;
					num2 = 115;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 333;
					}
					continue;
				case 23:
					array[30] = (byte)num3;
					num2 = 314;
					continue;
				case 276:
					array[0] = 65;
					num2 = 98;
					continue;
				case 223:
					num4 = 204 - 68;
					num2 = 140;
					continue;
				case 75:
					array3[8] = 125;
					num = 223;
					break;
				case 48:
					array3[9] = (byte)num4;
					num2 = 55;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 104;
					}
					continue;
				case 196:
					array3[11] = 227;
					num2 = 160;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 112;
					}
					continue;
				case 303:
					num3 = 71 + 90;
					num2 = 73;
					continue;
				case 290:
					array3[13] = 82;
					num2 = 12;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 46;
					}
					continue;
				case 130:
					stream = (Stream)EZkfxpPJSIO6qAa0K3O();
					num2 = 75;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 122;
					}
					continue;
				case 198:
					num3 = 241 - 80;
					num2 = 325;
					continue;
				case 179:
					array[23] = (byte)num3;
					num2 = 139;
					continue;
				case 21:
					array[20] = (byte)num3;
					num2 = 111;
					continue;
				case 13:
					array4[1] = array5[0];
					num2 = 16;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 218;
					}
					continue;
				case 90:
					array[18] = (byte)num3;
					num2 = 172;
					continue;
				case 325:
					array[2] = (byte)num3;
					num2 = 238;
					continue;
				case 250:
					array[3] = (byte)num3;
					num2 = 39;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 52;
					}
					continue;
				case 39:
					array[21] = 84;
					num2 = 207;
					continue;
				case 168:
					array[19] = 125;
					num2 = 279;
					continue;
				case 265:
					num3 = 211 - 70;
					num2 = 264;
					continue;
				case 222:
					array3[2] = 88;
					num2 = 144;
					continue;
				case 126:
					num4 = 95 - 19;
					num2 = 29;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 55;
					}
					continue;
				case 11:
					num4 = 81 + 106;
					num2 = 56;
					continue;
				case 236:
					array[2] = (byte)num3;
					num2 = 115;
					continue;
				case 86:
					num3 = 124 - 31;
					num2 = 300;
					continue;
				case 326:
					num3 = 168 - 56;
					num2 = 31;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 5;
					}
					continue;
				case 109:
					array[29] = (byte)num3;
					num2 = 135;
					continue;
				case 340:
					array[1] = 111;
					num2 = 306;
					continue;
				case 150:
					array3[2] = (byte)num4;
					num2 = 291;
					continue;
				case 260:
					num3 = 43 + 42;
					num = 214;
					break;
				case 219:
					array3[10] = (byte)num4;
					num2 = 7;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 1;
					}
					continue;
				case 246:
					num4 = 160 - 53;
					num2 = 137;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 9;
					}
					continue;
				case 292:
					array[17] = (byte)num3;
					num2 = 67;
					continue;
				case 285:
					array[22] = 202;
					num2 = 326;
					continue;
				case 201:
					array4[13] = array5[6];
					num2 = 258;
					continue;
				case 302:
					array[23] = (byte)num3;
					num2 = 72;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 106;
					}
					continue;
				case 72:
					return;
				case 4:
					array3[15] = (byte)num4;
					num2 = 255;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 90;
					}
					continue;
				case 121:
				case 268:
					array6[num5] ^= array4[num5];
					num2 = 315;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 140;
					}
					continue;
				case 49:
					array3[4] = 102;
					num2 = 178;
					continue;
				case 162:
					array3[0] = 120;
					num2 = 282;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 142;
					}
					continue;
				case 228:
					num3 = 2 + 111;
					num2 = 190;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 302;
					}
					continue;
				case 74:
					array[21] = 144;
					num2 = 39;
					continue;
				case 69:
					array3[10] = (byte)num4;
					num = 116;
					break;
				case 271:
					array3[7] = 79;
					num2 = 262;
					continue;
				case 173:
					num3 = 170 - 101;
					num2 = 0;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 1;
					}
					continue;
				case 254:
					array[9] = (byte)num3;
					num = 103;
					break;
				case 117:
					array3[4] = 109;
					num2 = 80;
					continue;
				case 24:
					array[6] = 125;
					num2 = 303;
					continue;
				case 189:
					num4 = 162 - 54;
					num2 = 25;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 69;
					}
					continue;
				case 283:
					num3 = 54 + 123;
					num2 = 195;
					continue;
				case 174:
					array4[11] = array5[5];
					num2 = 201;
					continue;
				case 161:
					array[14] = 103;
					num2 = 322;
					continue;
				case 98:
					num3 = 155 + 89;
					num2 = 61;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 118;
					}
					continue;
				case 305:
					array3[9] = (byte)num4;
					num2 = 240;
					continue;
				case 319:
					array[8] = 113;
					num2 = 89;
					continue;
				case 242:
					array[19] = 134;
					num2 = 0;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 2;
					}
					continue;
				case 295:
					array3[13] = (byte)num4;
					num2 = 134;
					continue;
				case 269:
					num3 = 1 + 75;
					num2 = 20;
					continue;
				case 261:
					array[3] = 126;
					num2 = 142;
					continue;
				case 210:
					num4 = 155 - 51;
					num2 = 177;
					continue;
				case 15:
					array[30] = (byte)num3;
					num2 = 28;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 10;
					}
					continue;
				case 331:
					array[4] = 116;
					num2 = 29;
					continue;
				case 235:
					array[11] = (byte)num3;
					num2 = 115;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 227;
					}
					continue;
				case 50:
					array[26] = 170;
					num2 = 68;
					continue;
				case 60:
					array3[8] = (byte)num4;
					num2 = 213;
					continue;
				case 183:
					array[25] = (byte)num3;
					num2 = 336;
					continue;
				case 101:
					array[6] = (byte)num3;
					num2 = 20;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 24;
					}
					continue;
				case 338:
					array[4] = (byte)num3;
					num2 = 53;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 2;
					}
					continue;
				case 224:
					array3[7] = (byte)num4;
					num2 = 75;
					continue;
				case 160:
					array3[12] = 159;
					num2 = 246;
					continue;
				case 129:
					array[25] = (byte)num3;
					num2 = 45;
					continue;
				case 115:
					array[3] = 115;
					num2 = 261;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 42;
					}
					continue;
				case 252:
					num4 = 40 + 44;
					num2 = 78;
					continue;
				case 128:
					num4 = 7 + 2;
					num2 = 278;
					continue;
				case 339:
					array[28] = 116;
					num2 = 144;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 231;
					}
					continue;
				case 195:
					array[20] = (byte)num3;
					num2 = 101;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 113;
					}
					continue;
				case 144:
					num4 = 176 - 89;
					num2 = 26;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 150;
					}
					continue;
				case 97:
					array3[4] = 100;
					num2 = 100;
					continue;
				case 96:
					num3 = 152 - 97;
					num2 = 230;
					continue;
				case 43:
					num4 = 42 + 92;
					num2 = 226;
					continue;
				case 333:
					array[28] = 99;
					num2 = 339;
					continue;
				case 133:
					num3 = 193 - 95;
					num2 = 163;
					continue;
				case 37:
					array = new byte[32];
					num2 = 21;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 22;
					}
					continue;
				case 280:
					array3[1] = 144;
					num2 = 225;
					continue;
				case 136:
					array[18] = (byte)num3;
					num2 = 165;
					continue;
				case 110:
					array[1] = 72;
					num2 = 8;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 17;
					}
					continue;
				case 31:
					array[23] = (byte)num3;
					num2 = 82;
					continue;
				case 149:
					num4 = 22 + 31;
					num2 = 188;
					continue;
				case 194:
					array[7] = 97;
					num2 = 36;
					continue;
				case 18:
					array3[4] = (byte)num4;
					num2 = 49;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 46;
					}
					continue;
				case 214:
					array[24] = (byte)num3;
					num2 = 191;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 120;
					}
					continue;
				case 229:
					array[16] = 44;
					num2 = 4;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 6;
					}
					continue;
				case 327:
					array[4] = (byte)num3;
					num2 = 62;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 186;
					}
					continue;
				case 80:
					num4 = 41 + 119;
					num2 = 2;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 18;
					}
					continue;
				case 301:
					num3 = 67 + 28;
					num2 = 254;
					continue;
				case 304:
					num4 = 105 + 122;
					num2 = 182;
					continue;
				case 200:
					array[13] = 59;
					num = 310;
					break;
				case 180:
					array[13] = 132;
					num2 = 200;
					continue;
				case 272:
					array[9] = 97;
					num2 = 69;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 313;
					}
					continue;
				case 321:
					array[5] = (byte)num3;
					num2 = 94;
					continue;
				case 284:
					array3[0] = (byte)num4;
					num2 = 147;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 316;
					}
					continue;
				case 237:
					num4 = 68 - 2;
					num2 = 224;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 112;
					}
					continue;
				case 328:
					array3[6] = 97;
					num2 = 221;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 29;
					}
					continue;
				case 34:
					array[14] = 126;
					num2 = 47;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 20;
					}
					continue;
				case 10:
					array3[5] = 88;
					num2 = 77;
					continue;
				case 187:
					num3 = 1 + 60;
					num2 = 309;
					continue;
				case 291:
					array3[3] = 94;
					num = 145;
					break;
				case 156:
					array[19] = (byte)num3;
					num2 = 242;
					continue;
				case 111:
					array[20] = 150;
					num2 = 33;
					continue;
				case 245:
					num3 = 212 - 115;
					num2 = 192;
					continue;
				case 298:
					array[30] = 140;
					num2 = 211;
					continue;
				case 25:
				case 324:
					new sFwOL7x9Vl71usW1KQ().pbTQjHZyV(array6, array4, array2);
					num2 = 72;
					continue;
				case 275:
					num4 = 98 + 76;
					num2 = 308;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 289;
					}
					continue;
				case 184:
					array3[11] = (byte)num4;
					num2 = 196;
					continue;
				case 1:
					array[27] = (byte)num3;
					num2 = 92;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 23;
					}
					continue;
				case 146:
					num4 = 115 + 66;
					num2 = 249;
					continue;
				case 8:
				{
					object obj = rcLiPqYkNlufrGFFHbu();
					GLAeCvYzFfrKAqA6PKO(obj, CipherMode.CBC);
					transform = (ICryptoTransform)zOZmA4PUfF7l7Aqa6oL(obj, array6, array4);
					num2 = 130;
					continue;
				}
				case 309:
					array[6] = (byte)num3;
					num2 = 273;
					continue;
				case 207:
					num3 = 118 + 11;
					num = 62;
					break;
				case 140:
					array3[8] = (byte)num4;
					num2 = 286;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 92;
					}
					continue;
				case 91:
					num3 = 82 + 4;
					num2 = 8;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 190;
					}
					continue;
				case 44:
					array3[14] = 69;
					num2 = 152;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 130;
					}
					continue;
				case 314:
					num3 = 91 + 124;
					num2 = 15;
					continue;
				case 208:
					array3[15] = (byte)num4;
					num2 = 11;
					continue;
				case 218:
					array4[3] = array5[1];
					num2 = 288;
					continue;
				case 57:
					num3 = 40 + 30;
					num2 = 234;
					continue;
				case 51:
					array3[10] = (byte)num4;
					num2 = 108;
					continue;
				case 288:
					array4[5] = array5[2];
					num2 = 243;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 107;
					}
					continue;
				case 76:
					array3[14] = (byte)num4;
					num2 = 128;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 105;
					}
					continue;
				case 99:
					array3[4] = 138;
					num2 = 97;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 35;
					}
					continue;
				case 142:
					array[3] = 2;
					num2 = 16;
					continue;
				case 282:
					num4 = 145 - 48;
					num2 = 151;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 142;
					}
					continue;
				case 131:
					array4[9] = array5[4];
					num2 = 174;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 100;
					}
					continue;
				case 58:
					array3[6] = 98;
					num2 = 38;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 54;
					}
					continue;
				case 182:
					array3[3] = (byte)num4;
					num2 = 18;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 85;
					}
					continue;
				case 257:
					if (array5 == null)
					{
						num2 = 335;
						if (!XrK028YyMVPEfZWwyVR())
						{
							num2 = 238;
						}
						continue;
					}
					goto case 266;
				case 247:
					num4 = 216 - 72;
					num2 = 123;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 45;
					}
					continue;
				case 152:
					array3[14] = 100;
					num2 = 126;
					continue;
				case 299:
					array3[15] = (byte)num4;
					num2 = 317;
					continue;
				case 251:
					array[24] = 106;
					num2 = 157;
					continue;
				case 78:
					array3[11] = (byte)num4;
					num2 = 164;
					continue;
				case 226:
					array3[13] = (byte)num4;
					num2 = 290;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 205;
					}
					continue;
				case 29:
					array[4] = 132;
					num = 267;
					break;
				case 17:
					num3 = 172 - 57;
					num2 = 161;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 212;
					}
					continue;
				case 213:
					array3[9] = 127;
					num2 = 124;
					continue;
				case 123:
					array3[11] = (byte)num4;
					num2 = 252;
					continue;
				case 287:
					array[24] = 100;
					num2 = 193;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 260;
					}
					continue;
				case 40:
					array3[0] = 181;
					num2 = 154;
					continue;
				case 178:
					num4 = 64 + 116;
					num2 = 127;
					continue;
				case 134:
					array3[13] = 155;
					num = 81;
					break;
				case 239:
					array3[6] = 118;
					num = 58;
					break;
				case 279:
					array[19] = 7;
					num2 = 283;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 89;
					}
					continue;
				case 267:
					num3 = 1 + 65;
					num2 = 338;
					continue;
				case 19:
					array3[5] = 140;
					num2 = 170;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 152;
					}
					continue;
				case 52:
					array[3] = 166;
					num2 = 331;
					continue;
				case 65:
					array3[1] = 167;
					num2 = 87;
					continue;
				case 46:
					num4 = 158 - 52;
					num2 = 295;
					continue;
				case 47:
					array[14] = 201;
					num2 = 30;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 105;
					}
					continue;
				case 7:
					array3[10] = 125;
					num2 = 189;
					continue;
				case 36:
					array[8] = 88;
					num = 319;
					break;
				case 248:
					array3[2] = 155;
					num2 = 222;
					continue;
				case 164:
					num4 = 146 - 48;
					num2 = 184;
					continue;
				case 297:
					array[22] = 55;
					num2 = 64;
					continue;
				case 153:
					array4 = array3;
					num2 = 148;
					continue;
				case 42:
					array3[3] = (byte)num4;
					num2 = 181;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 102;
					}
					continue;
				case 3:
					array3[2] = (byte)num4;
					num2 = 248;
					continue;
				case 177:
					array3[3] = (byte)num4;
					num2 = 304;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 50;
					}
					continue;
				case 55:
					array3[14] = (byte)num4;
					num2 = 119;
					continue;
				default:
					if (num5 < array4.Length)
					{
						num2 = 153;
						if (XrK028YyMVPEfZWwyVR())
						{
							num2 = 268;
						}
						continue;
					}
					goto case 281;
				case 274:
					num3 = 243 - 81;
					num2 = 93;
					continue;
				case 124:
					num4 = 127 - 42;
					num2 = 48;
					continue;
				case 45:
					num3 = 79 + 84;
					num = 183;
					break;
				case 14:
					num3 = 79 + 36;
					num2 = 94;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 109;
					}
					continue;
				case 211:
					array[30] = 136;
					num2 = 204;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 194;
					}
					continue;
				case 332:
					array[12] = (byte)num3;
					num2 = 277;
					continue;
				case 95:
					num3 = 207 - 115;
					num2 = 253;
					continue;
				case 312:
					num3 = 189 - 63;
					num2 = 323;
					continue;
				case 225:
					num4 = 102 + 121;
					num2 = 3;
					continue;
				case 231:
					array[28] = 110;
					num2 = 245;
					continue;
				case 5:
					array[24] = (byte)num3;
					num = 86;
					break;
				case 192:
					array[28] = (byte)num3;
					num2 = 63;
					continue;
				case 170:
					array3[5] = 76;
					num2 = 10;
					continue;
				case 82:
					num3 = 6 + 94;
					num2 = 58;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 179;
					}
					continue;
				case 119:
					array3[15] = 133;
					num2 = 197;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 74;
					}
					continue;
				case 93:
					array[25] = (byte)num3;
					num2 = 16;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 32;
					}
					continue;
				case 240:
					num4 = 83 + 119;
					num2 = 219;
					continue;
				case 300:
					array[24] = (byte)num3;
					num2 = 241;
					continue;
				case 318:
					array[17] = (byte)num3;
					num2 = 57;
					continue;
				case 106:
					array[23] = 175;
					num2 = 287;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 274;
					}
					continue;
				case 102:
					array[21] = 166;
					num2 = 74;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 72;
					}
					continue;
				case 185:
					array[25] = (byte)num3;
					num2 = 114;
					continue;
				case 255:
					array3[15] = 253;
					num = 153;
					break;
				case 94:
					num3 = 49 + 47;
					num2 = 101;
					continue;
				case 120:
					array[14] = (byte)num3;
					num2 = 34;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 22;
					}
					continue;
				case 233:
					array[8] = (byte)num3;
					num2 = 166;
					continue;
				case 20:
					array[15] = (byte)num3;
					num2 = 205;
					continue;
				case 158:
					num3 = 149 - 49;
					num2 = 88;
					if (uhIxCCYC0jJYDEVlJoQ() != null)
					{
						num2 = 72;
					}
					continue;
				case 296:
					array3[3] = (byte)num4;
					num2 = 117;
					continue;
				case 100:
					array3[5] = 102;
					num2 = 61;
					continue;
				case 41:
					array[27] = 135;
					num2 = 97;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 206;
					}
					continue;
				case 171:
					num3 = 15 + 106;
					num2 = 185;
					continue;
				case 53:
					num3 = 154 - 30;
					num2 = 327;
					continue;
				case 336:
					array[26] = 153;
					num2 = 50;
					continue;
				case 70:
					array[15] = (byte)num3;
					num2 = 131;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 244;
					}
					continue;
				case 77:
					array3[5] = 16;
					num2 = 149;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 142;
					}
					continue;
				case 289:
					array[20] = (byte)num3;
					num2 = 181;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 265;
					}
					continue;
				case 320:
					array[15] = 88;
					num2 = 12;
					if (uhIxCCYC0jJYDEVlJoQ() == null)
					{
						num2 = 269;
					}
					continue;
				case 329:
					array[31] = 118;
					num = 133;
					break;
				case 294:
					num3 = 94 + 9;
					num2 = 202;
					if (XrK028YyMVPEfZWwyVR())
					{
						num2 = 293;
					}
					continue;
				case 176:
					array[29] = (byte)num3;
					num = 312;
					break;
				case 73:
					array[6] = (byte)num3;
					num2 = 112;
					if (!XrK028YyMVPEfZWwyVR())
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string kQwl2UjLH(int P_0)
	{
		if (sxYJx6TTmP.Length == 0)
		{
			siTJv6htVR = new List<string>();
			J7xJSfVUvE = new List<int>();
			QVDh3aF1D(JweJ8PvHD2.GetManifestResourceStream("TeLlPKJLEvKqnjMwVx.85AxlVYskUePAngV0p"), P_0);
		}
		if (MmJJt4K9TL < 75)
		{
			MethodBase method = new StackFrame(1).GetMethod();
			if (JweJ8PvHD2 != method.DeclaringType.Assembly)
			{
				bool flag = false;
				string name = method.DeclaringType.Assembly.GetName().Name;
				AssemblyName[] referencedAssemblies = JweJ8PvHD2.GetReferencedAssemblies();
				foreach (AssemblyName assemblyName in referencedAssemblies)
				{
					if (name == assemblyName.Name)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					throw new Exception();
				}
			}
			MmJJt4K9TL++;
		}
		lock (dUyJZEUv4b)
		{
			int num = BitConverter.ToInt32(sxYJx6TTmP, P_0);
			if (num < J7xJSfVUvE.Count && J7xJSfVUvE[num] == P_0)
			{
				return siTJv6htVR[num];
			}
			try
			{
				QuXUB4Y4PpfHQMw70oq.c2XPfWaQoI();
				byte[] array = new byte[num];
				Array.Copy(sxYJx6TTmP, P_0 + 4, array, 0, num);
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				siTJv6htVR.Add(@string);
				J7xJSfVUvE.Add(P_0);
				Array.Copy(BitConverter.GetBytes(siTJv6htVR.Count - 1), 0, sxYJx6TTmP, P_0, 4);
				return @string;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string ghPpdIlfT(string P_0)
	{
		"i0ecYuBrpxUwwuFQijAMlD".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int qVrM1EI01()
	{
		return 5;
	}

	private static void LOsFSJKYt()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate n2vaNYBfw(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object oNa09ANHt(object P_0)
	{
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr zv3n9M24n(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr kNboSakpX(IntPtr P_0, string P_1);

	private static IntPtr EddsJdklB(IntPtr P_0, string P_1, uint P_2)
	{
		if (NsKJhhXtQL == null)
		{
			NsKJhhXtQL = (lLqh9NYYNrRiQvVFw4k)Marshal.GetDelegateForFunctionPointer(kNboSakpX(F6BhDkqRs(), "Find ".Trim() + "ResourceA"), typeof(lLqh9NYYNrRiQvVFw4k));
		}
		return NsKJhhXtQL(P_0, P_1, P_2);
	}

	private static IntPtr fZdySVj7V(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (q4HJl3lSvk == null)
		{
			q4HJl3lSvk = (hefNV6YPC3pcof5RytU)Marshal.GetDelegateForFunctionPointer(kNboSakpX(F6BhDkqRs(), "Virtual ".Trim() + "Alloc"), typeof(hefNV6YPC3pcof5RytU));
		}
		return q4HJl3lSvk(P_0, P_1, P_2, P_3);
	}

	private static int EVDCVlanN(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (MJwJpc2OnD == null)
		{
			MJwJpc2OnD = (Xy0AKyYjJlW22Ps4c5C)Marshal.GetDelegateForFunctionPointer(kNboSakpX(F6BhDkqRs(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Xy0AKyYjJlW22Ps4c5C));
		}
		return MJwJpc2OnD(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int KowED5nHo(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (KpmJMO0mXb == null)
		{
			KpmJMO0mXb = (fQtQGIYg4UFKhg2tmVb)Marshal.GetDelegateForFunctionPointer(kNboSakpX(F6BhDkqRs(), "Virtual ".Trim() + "Protect"), typeof(fQtQGIYg4UFKhg2tmVb));
		}
		return KpmJMO0mXb(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr zgabURfAX(uint P_0, int P_1, uint P_2)
	{
		if (O1kJFxQxv8 == null)
		{
			O1kJFxQxv8 = (XAACt9YmTKPFC0IrJyu)Marshal.GetDelegateForFunctionPointer(kNboSakpX(F6BhDkqRs(), "Open ".Trim() + "Process"), typeof(XAACt9YmTKPFC0IrJyu));
		}
		return O1kJFxQxv8(P_0, P_1, P_2);
	}

	private static int wnfXcMLFo(IntPtr P_0)
	{
		if (ujHJatYm47 == null)
		{
			ujHJatYm47 = (qEXYphY1L0runSva4Pk)Marshal.GetDelegateForFunctionPointer(kNboSakpX(F6BhDkqRs(), "Close ".Trim() + "Handle"), typeof(qEXYphY1L0runSva4Pk));
		}
		return ujHJatYm47(P_0);
	}

	[SpecialName]
	private static IntPtr F6BhDkqRs()
	{
		if (maHJ06Hius == IntPtr.Zero)
		{
			maHJ06Hius = zv3n9M24n("kernel ".Trim() + "32.dll");
		}
		return maHJ06Hius;
	}

	private static byte[] d4lA5ow4h(string P_0)
	{
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream Pog6CCoYM()
	{
		return new MemoryStream();
	}

	internal static byte[] d8JerKQhW(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] CvWLKhkfd(byte[] P_0)
	{
		Stream stream = Pog6CCoYM();
		SymmetricAlgorithm symmetricAlgorithm = ywFNAYlCT();
		symmetricAlgorithm.Key = new byte[32]
		{
			101, 143, 171, 200, 46, 48, 72, 168, 131, 42,
			56, 204, 87, 105, 88, 159, 242, 168, 41, 15,
			179, 34, 151, 37, 209, 106, 109, 191, 117, 233,
			135, 201
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			244, 71, 72, 123, 184, 244, 51, 235, 175, 94,
			246, 120, 97, 133, 31, 110
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		byte[] result = d8JerKQhW(stream);
		QuXUB4Y4PpfHQMw70oq.c2XPfWaQoI();
		return result;
	}

	private byte[] idAiMvtXq()
	{
		return null;
	}

	private byte[] ldKkCVy78()
	{
		return null;
	}

	private byte[] C4azJIUan()
	{
		_ = "iuPA2GJMSQnzh1oSRIbA".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] uLeJU1oE5i()
	{
		_ = "RgUe34HBMD0WtdoEyRQ".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] HHqJJqouCA()
	{
		_ = "9MBLGNxdxXANc1KpXOK".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] yBYJYvjURi()
	{
		_ = "RFIbtBvD1gMaJTSET".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] i1hJPc71pn()
	{
		_ = "tlRKkEJjGWbRB8iFtw".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] OIUJjKbUG8()
	{
		_ = "UWcCrKXcFZAte2riIsNE".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] VDOJgSNLsf()
	{
		_ = "Gm6ZTaaXfsqvg7jT".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] MivJmpqDow()
	{
		_ = "VvZlp7rHmRjIN2XeqY".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal static object MOdbCqYEqI34hQ87CcU(object P_0)
	{
		return ((JPdxOWJLs5IJ7EyD3un)P_0).vh0ry9Sq2v();
	}

	internal static void VJ6JKbYbTkhlGImrXw6(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long fhJytWYXvCtsPZnI95i(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object OlU1HYYAknIq5adLaM0(object P_0, int P_1)
	{
		return ((JPdxOWJLs5IJ7EyD3un)P_0).UN0JilLL3h(P_1);
	}

	internal static void AcCPQJY6qYcVHjgYOAc(object P_0)
	{
		((JPdxOWJLs5IJ7EyD3un)P_0).cqpYUj8kVK();
	}

	internal static void JwFrbDYeho7mnxTJDO6(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object gFUWVRYLP2gVsg2PM52(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object pH0ytcYiwAV3jNtNwdw(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object rcLiPqYkNlufrGFFHbu()
	{
		return ywFNAYlCT();
	}

	internal static void GLAeCvYzFfrKAqA6PKO(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object zOZmA4PUfF7l7Aqa6oL(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object EZkfxpPJSIO6qAa0K3O()
	{
		return Pog6CCoYM();
	}

	internal static void raXbcNPYMu9Y08q8Z1W(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void oZowh5PPlFILeann5rU(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object hHg2BCPjd1Ctkm4uwXI(object P_0)
	{
		return d8JerKQhW((Stream)P_0);
	}

	internal static void EsHa2nPgTlWkI3RbiJ2(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object DIEEl7PmAF0F8LRw4f5(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool rtKw7XP1l94c9EvOlHE(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool XrK028YyMVPEfZWwyVR()
	{
		return (object)null == null;
	}

	internal static object uhIxCCYC0jJYDEVlJoQ()
	{
		return null;
	}
}
