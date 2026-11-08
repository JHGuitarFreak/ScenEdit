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
		public const int scenTitle                = 0x00; // 16 bytes
		public const int scenBlurb                = 0x10; // 60 bytes
		public const int allianceStarBase         = 0x4C; // 1 byte
		public const int allianceShips            = 0x4D; // To 0x53 (7 bytes)
		public const int alliancePlacements       = 0x54; // To 0x5A (7 bytes)
		public const int scenBitMask              = 0x5B; // 1 byte
		public const int allianceStarBucks        = 0x5C; // 2 bytes
		public const int alliancePurchaseMask     = 0x5E; // 1 byte
		public const int allianceDeadStars        = 0x5F; // 1 byte
		public const int allianceMineralStars     = 0x60; // 1 byte
		public const int allianceLifeStars        = 0x61; // 1 byte
		public const int allianceColonyStars      = 0x62; // 1 byte
		public const int allianceFortColonyStars  = 0x63; // 1 byte
		public const int allianceMineStars        = 0x64; // 1 byte
		public const int allianceFortMineStars    = 0x65; // 1 byte

		
		public const int hierarchyStarBase        = 0x66; // 1 byte
		public const int hierarchyShips           = 0x67; // To 0x6D (7 bytes)
		public const int hierarchyPlacements      = 0x6E; // To 0x74 (7 bytes)
		public const int hierarchyToWinMask       = 0x75; // 1 byte
		public const int hierarchyStarBucks       = 0x76; // 2 bytes
		public const int hierarchyPurchaseMask    = 0x78; // 1 byte
		public const int hierarchyDeadStars       = 0x79; // 1 byte
		public const int hierarchyMineralStars    = 0x7A; // 1 byte
		public const int hierarchyLifeStars       = 0x7B; // 1 byte
		public const int hierarchyColonyStars     = 0x7C; // 1 byte
		public const int hierarchyMineStars       = 0x7D; // 1 byte
		public const int hierarchyFortColonyStars = 0x7E; // 1 byte
		public const int hierarchyFortMineStars   = 0x7F; // 1 byte

		public const int scenDesc                 = 0x80; // 840 bytes

		public const int DestroyStarBase = (1 << 0);
		public const int DestroyColonies = (1 << 1);
		public const int DestroyMines    = (1 << 2);
		public const int FirstMove       = (1 << 3);
		public const int RandomEvents    = (1 << 4); // 0 means Yes

		public const int BuyShip1 = (1 << 0); // 0 means Yes
		public const int BuyShip2 = (1 << 1); // 0 means Yes
		public const int BuyShip3 = (1 << 2); // 0 means Yes
		public const int BuyShip4 = (1 << 3); // 0 means Yes
		public const int BuyShip5 = (1 << 4); // 0 means Yes
		public const int BuyShip6 = (1 << 5); // 0 means Yes
		public const int BuyShip7 = (1 << 6); // 0 means Yes

		public static string[] firstMove = { "Alliance", "Hierarchy" };
		public static string[] shipDistances = { "Near", "Intermediate", "Far", "Anywhere" };
		public static string[] hierarchyShipsArray = { "- None -", "Ur-Quan", "Mycon", "Spathi", "Androsynth", "VUX", "Ilwrath", "Umgah" };
		public static int[] hierarchyShipPoints = { 0, 30, 23, 18, 15, 12, 10, 7 };
		public static string[] allianceShipsArray = { "- None -", "Chenjesu", "Yehat", "Mmrnmhrm", "Arilou", "Syreen", "Earthling", "Shofixti" };
		public static int[] allianceShipPoints = { 0, 26, 23, 19, 16, 12, 9, 5 };
	}
}
