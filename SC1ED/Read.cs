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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ScenEdit
{
	partial class Read
	{
		public static FileStream Stream;
		public static Main Window;
		public static byte[] FileBuffer;

		public static void Open(string FileName, Main window)
		{
			if (!File.Exists(FileName))
			{
				MessageBox.Show("Could not find path: " + FileName);
				return;
			}

			Stream = new FileStream(FileName, FileMode.Open);
			int FileSize = (int)Stream.Length;  // get file length
			FileBuffer = new byte[FileSize];    // create buffer
			Window = window;

			LoadIt ();

			Stream.Close();
			Stream.Dispose();
		}
	}
}
