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
using System.Collections.Generic;

namespace ScenEdit
{
	class Vars
	{
		public byte HexCode { get; private set; }
		public string Text { get; private set; }

		public const byte scenTitle = 0x00;
		public const byte scenBlurb = 0x10;
		public const byte scenDesc  = 0x80;

		public static string[] firstMove = { "Alliance", "Hierarchy" };
		public static string[] shipDistances = { "Near", "Intermediate", "Far", "Anywhere" };
		public static string[] hierarchyShips = { "- None -", "Ur-Quan", "Mycon", "Spathi", "Androsynth", "VUX", "Ilwrath", "Umgah" };
		public static int[] hierarchyShipPoints = { 0, 30, 23, 18, 15, 12, 10, 7 };
		public static string[] allianceShips = { "- None -", "Chenjesu", "Yehat", "Mmrnmhrm", "Arilou", "Syreen", "Earthling", "Shofixti" };
		public static int[] allianceShipPoints = { 0, 26, 23, 19, 16, 12, 9, 5 };
	}
}
