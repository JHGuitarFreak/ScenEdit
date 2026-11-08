/*ScenEdit: Star Control 1 Scenario Editor

Copyright (C) 2026 JHGuitarFreak

This program is free software: you can redistribute it and/or modify  
it under the terms of the GNU General Public License as published by  
the Free Software Foundation, version 3.

This program is distributed in the hope that it will be useful, but 
WITHOUT ANY WARRANTY; without even the implied warranty of 
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU 
General Public License for more details.

You should have received a copy of the GNU General Public License 
along with this program. If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScenEdit
{
	internal class Functions
	{
		// Read

		public static byte[] ReadByteArray(int offset, int array_length)
		{
			Read.Stream.Seek(offset, SeekOrigin.Begin);
			Read.Stream.Read(Read.FileBuffer, 0, array_length);

			return Read.FileBuffer;
		}
		public static byte ReadByte(int offset)
		{
			return ReadByteArray(offset, 1)[0];
		}

		public static sbyte ReadSByte(int offset)
		{
			return (sbyte)ReadByteArray(offset, 1)[0];
		}

		public static ushort ReadUShort(int offset)
		{
			return BitConverter.ToUInt16(ReadByteArray(offset, 2), 0);
		}

		public static short ReadShort(int offset)
		{
			return BitConverter.ToInt16(ReadByteArray(offset, 2), 0);
		}

		public static uint ReadUInt(int offset)
		{
			return BitConverter.ToUInt32(ReadByteArray(offset, 4), 0);
		}

		public static int ReadInt(int offset)
		{
			return BitConverter.ToInt32(ReadByteArray(offset, 4), 0);
		}

		public static string ReadStr(int offset, int count)
		{
			byte[] temp = ReadByteArray(offset, count);
			temp[count] = 0; // Properly terminate the string

			return Encoding.Default.GetString(temp);
		}

		// Write

		public static void WriteSByteArray(int offset, int i, int array_length)
		{
			Write.Stream.Seek(offset, SeekOrigin.Begin);
			Write.FileBuffer = BitConverter.GetBytes(i);
			Write.Stream.Write(Write.FileBuffer, 0, array_length);
		}

		public static void WriteByteArray(int offset, uint i, int array_length)
		{
			Write.Stream.Seek(offset, SeekOrigin.Begin);
			Write.FileBuffer = BitConverter.GetBytes(i);
			Write.Stream.Write(Write.FileBuffer, 0, array_length);
		}

		public static void WriteByte(int offset, byte b)
		{
			WriteByteArray(offset, b, 1);
		}

		public static void WriteShort(int offset, short s)
		{
			WriteSByteArray(offset, s, 2);
		}

		public static void WriteInt(int offset, int i)
		{
			WriteSByteArray(offset, i, 4);
		}

		public static byte[] StringToByteArray(string String, int MaxLength)
		{
			char[] charArr = String.ToCharArray();
			byte[] bytes = new byte[MaxLength];
			for (int i = 0; i < MaxLength; i++)
			{
				if (i < charArr.Length)
					bytes[i] = Convert.ToByte(charArr[i]);
				else
					bytes[i] = 0;
			}
			return bytes;
		}

		public static void WriteString(int offset, string String, int ByteLength)
		{
			Write.Stream.Seek(offset, SeekOrigin.Begin);
			Write.FileBuffer = StringToByteArray(String, ByteLength);
			Write.Stream.Write(Write.FileBuffer, 0, ByteLength);
		}
	}
}
