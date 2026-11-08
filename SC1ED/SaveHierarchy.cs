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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScenEdit
{
	partial class Write
	{
		public static void SaveHierarchy ()
		{
			Functions.WriteByte (Vars.hierarchyStarBase, (byte)(Window.hierarchyStarBaseCB.Checked ? 1 : 0));

			int i = Vars.hierarchyShips + 13;
			foreach (object Ships in Window.fleetCompositionHierarchy.Controls)
			{
				if (Ships is ComboBox)
				{
					Functions.WriteByte (i, (byte)((Ships as ComboBox).SelectedIndex));
					i--;
				}
			}

			byte hierarchyBitMask = 0;

			if (Window.destroyStarBaseHierarchyCB.Checked)
				hierarchyBitMask |= Vars.DestroyStarBase;
			if (Window.destroyAllColoniesHierarchyCB.Checked)
				hierarchyBitMask |= Vars.DestroyColonies;
			if (Window.destroyAllMinesHierarchyCB.Checked)
				hierarchyBitMask |= Vars.DestroyMines;

			Functions.WriteByte (Vars.hierarchyToWinMask, hierarchyBitMask);

			Functions.WriteShort (Vars.hierarchyStarBucks, (short)(Window.starBucksHierarchyNum.Value));

			byte hierarchyBuyMask = 0;

			i = 6;
			foreach (object Buy in Window.availForPurchaseHierarchy.Controls)
			{
				if (Buy is CheckBox)
				{
					if (!(Buy as CheckBox).Checked)
						hierarchyBuyMask |= (byte)(1 << i);
					i--;
				}
			}

			Functions.WriteByte (Vars.hierarchyPurchaseMask, hierarchyBuyMask);

			Functions.WriteByte (Vars.hierarchyDeadStars, (byte)(Window.deadHierarchyStars.Value));
			Functions.WriteByte (Vars.hierarchyMineralStars, (byte)(Window.mineralHierarchyStars.Value));
			Functions.WriteByte (Vars.hierarchyLifeStars, (byte)(Window.lifeHierarchyStars.Value));
			Functions.WriteByte (Vars.hierarchyColonyStars, (byte)(Window.colonyHierarchyStars.Value));
			Functions.WriteByte (Vars.hierarchyFortColonyStars, (byte)(Window.fortColonyHierarchyStars.Value));
			Functions.WriteByte (Vars.hierarchyMineStars, (byte)(Window.mineHierarchyStars.Value));
			Functions.WriteByte (Vars.hierarchyFortMineStars, (byte)(Window.fortMineHierarchyStars.Value));
		}
	}
}