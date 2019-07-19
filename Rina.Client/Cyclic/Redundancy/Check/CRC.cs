using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Cyclic.Redundancy.Check
{
	// Token: 0x02000002 RID: 2
	public sealed class CRC : HashAlgorithm
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00002057
		public CRC() : this(3988292384u, uint.MaxValue)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000026BC File Offset: 0x000026BC
		public CRC(uint polynomial, uint seed)
		{
			this.table = CRC.InitializeTable(polynomial);
			this.hash = seed;
			this.seed = seed;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002065 File Offset: 0x00002065
		public override void Initialize()
		{
			this.hash = this.seed;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002073 File Offset: 0x00002073
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			this.hash = CRC.CalculateHash(this.table, this.hash, buffer, start, length);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000026EC File Offset: 0x000026EC
		protected override byte[] HashFinal()
		{
			byte[] array = CRC.UInt32ToBigEndianBytes(~this.hash);
			this.HashValue = array;
			return array;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000208F File Offset: 0x0000208F
		public override int HashSize
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002093 File Offset: 0x00002093
		public static uint Compute(byte[] buffer)
		{
			return CRC.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000209C
		public static uint Compute(uint seed, byte[] buffer)
		{
			return CRC.Compute(3988292384u, seed, buffer);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020AA File Offset: 0x000020AA
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			return ~CRC.CalculateHash(CRC.InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002710 File Offset: 0x00002710
		private static uint[] InitializeTable(uint polynomial)
		{
			if (polynomial == 3988292384u && CRC.defaultTable != null)
			{
				return CRC.defaultTable;
			}
			uint[] array = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1u) == 1u)
					{
						num = (num >> 1 ^ polynomial);
					}
					else
					{
						num >>= 1;
					}
				}
				array[i] = num;
			}
			if (polynomial == 3988292384u)
			{
				CRC.defaultTable = array;
			}
			return array;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002780 File Offset: 0x00002780
		private static uint CalculateHash(uint[] table, uint seed, IList<byte> buffer, int start, int size)
		{
			uint num = seed;
			for (int i = start; i < size - start; i++)
			{
				num = (num >> 8 ^ table[(int)((uint)buffer[i] ^ (num & 255u))]);
			}
			return num;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000027B8 File Offset: 0x000027B8
		private static byte[] UInt32ToBigEndianBytes(uint uint32)
		{
			byte[] bytes = BitConverter.GetBytes(uint32);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x04000001 RID: 1
		public const uint DefaultPolynomial = 3988292384u;

		// Token: 0x04000002 RID: 2
		public const uint DefaultSeed = 4294967295u;

		// Token: 0x04000003 RID: 3
		private static uint[] defaultTable;

		// Token: 0x04000004 RID: 4
		private readonly uint seed;

		// Token: 0x04000005 RID: 5
		private readonly uint[] table;

		// Token: 0x04000006 RID: 6
		private uint hash;
	}
}
