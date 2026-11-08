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
	partial class Write
	{
		public static FileStream Stream;
		public static Main Window;
		public static int Num;
		public static byte[] FileBuffer;

		public static void Save(string FileName, Main WindowRef)
		{

			Stream = new FileStream(FileName, FileMode.OpenOrCreate);
			int FileSize = (int)Stream.Length;  // get file length
			FileBuffer = new byte[FileSize];    // create buffer
			Window = WindowRef;

			Functions.WriteString (Vars.scenTitle, Window.titleText.Text, 16);
			Functions.WriteString (Vars.scenBlurb, Window.blurbText.Text, 60);
			Functions.WriteString (Vars.scenDesc, Window.descText.Text, 840);

			SaveAlliance ();
			SaveHierarchy ();

			Stream.Close();
			Stream.Dispose();
		}
	}
}
