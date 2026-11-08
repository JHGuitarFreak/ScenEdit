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
using System.Collections.Generic;
using System.Linq;

namespace ScenEdit
{
	partial class Read
	{
		public static void LoadIt()
		{
			Stream.Seek(Vars.scenTitle, SeekOrigin.Begin);
			Stream.Read(FileBuffer, 0, 16);
			Window.titleText.Text = Encoding.UTF8.GetString(FileBuffer);

			Stream.Seek(Vars.scenBlurb, SeekOrigin.Begin);
			Stream.Read(FileBuffer, 0, 60);
			Window.blurbText.Text = Encoding.UTF8.GetString(FileBuffer);



			Stream.Seek(Vars.scenDesc, SeekOrigin.Begin);
			Stream.Read(FileBuffer, 0, 840);
			Window.descText.Text = Encoding.UTF8.GetString(FileBuffer);
		}
	}
}
