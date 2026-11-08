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
	partial class Read
	{
		public static void LoadHierarchy ()
		{
			Window.hierarchyStarBaseCB.Checked = Functions.ReadByte (Vars.hierarchyStarBase) == 1;

			int i = Vars.hierarchyShips + 13;
			foreach (object Ships in Window.fleetCompositionHierarchy.Controls)
			{
				if (Ships is ComboBox)
				{
					// Console.Write (string.Format ("{0}\n", (Ships as ComboBox).Name));

					if ((Ships as ComboBox).Items.Count == 0)
					{
						if ((Ships as ComboBox).Name.Contains ("Dist"))
							(Ships as ComboBox).Items.AddRange (Vars.shipDistances);
						else
							(Ships as ComboBox).Items.AddRange (Vars.hierarchyShipsArray);
					}

					(Ships as ComboBox).SelectedIndex = Functions.ReadByte (i);
					i--;
				}
			}

			int hierarchyBitMask = Functions.ReadByte (Vars.hierarchyToWinMask);

			if (Window.firstMoveCombo.Items.Count == 0)
				Window.firstMoveCombo.Items.AddRange (Vars.firstMove);

			Window.destroyStarBaseHierarchyCB.Checked    = (hierarchyBitMask & Vars.DestroyStarBase) != 0;
			Window.destroyAllColoniesHierarchyCB.Checked = (hierarchyBitMask & Vars.DestroyColonies) != 0;
			Window.destroyAllMinesHierarchyCB.Checked    = (hierarchyBitMask & Vars.DestroyMines) != 0;

			Window.starBucksHierarchyNum.Value = Functions.ReadShort (Vars.hierarchyStarBucks);

			int hierarchyBuyMask = Functions.ReadByte (Vars.hierarchyPurchaseMask);

			i = 6;
			foreach (object Buy in Window.availForPurchaseHierarchy.Controls)
			{
				if (Buy is CheckBox)
				{
					//Console.Write (string.Format ("{0}\n", (Buy as CheckBox).Name));

					(Buy as CheckBox).Checked = (hierarchyBuyMask & (1 << i)) == 0;
					i--;
				}
			}

			//i = Vars.hierarchyFortMineStars;
			//foreach (object Stars in Window.starsInHierarchyHemisphere.Controls)
			//{
			//	if (Stars is NumericUpDown)
			//	{
			//		// Console.Write (string.Format ("{0}\n", (Ships as ComboBox).Name));

			//		(Stars as NumericUpDown).Value = Functions.ReadByte (i);
			//		i--;
			//	}
			//}

			Window.deadHierarchyStars.Value       = Functions.ReadByte (Vars.hierarchyDeadStars);
			Window.mineralHierarchyStars.Value    = Functions.ReadByte (Vars.hierarchyMineralStars);
			Window.lifeHierarchyStars.Value       = Functions.ReadByte (Vars.hierarchyLifeStars);
			Window.colonyHierarchyStars.Value     = Functions.ReadByte (Vars.hierarchyColonyStars);
			Window.fortColonyHierarchyStars.Value = Functions.ReadByte (Vars.hierarchyFortColonyStars);
			Window.mineHierarchyStars.Value       = Functions.ReadByte (Vars.hierarchyMineStars);
			Window.fortMineHierarchyStars.Value   = Functions.ReadByte (Vars.hierarchyFortMineStars);
		}
	}
}
