﻿using System;
using System.Collections.Generic;

namespace uTinyRipper
{
	public static class IDictionaryIOExtensions
	{
		public static void Read(this IDictionary<int, int> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				int key = reader.ReadInt32();
				int value = reader.ReadInt32();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<uint, string> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				uint key = reader.ReadUInt32();
				string value = reader.ReadString();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, byte> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				byte value = reader.ReadByte();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, short> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				short value = reader.ReadInt16();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, ushort> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				ushort value = reader.ReadUInt16();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, int> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				int value = reader.ReadInt32();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, uint> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				uint value = reader.ReadUInt32();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, long> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				long value = reader.ReadInt64();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, ulong> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				ulong value = reader.ReadUInt64();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, float> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				float value = reader.ReadSingle();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<string, string> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				string key = reader.ReadString();
				string value = reader.ReadString();
				_this.Add(key, value);
			}
		}

		public static void Read(this IDictionary<Tuple<char, char>, float> _this, EndianReader reader)
		{
			int count = reader.ReadInt32();
			for (int i = 0; i < count; i++)
			{
				Tuple<char, char> key = reader.ReadTupleCharChar();
				float value = reader.ReadSingle();
				_this.Add(key, value);
			}
		}
	}
}
