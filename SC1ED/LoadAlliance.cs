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
		public static void LoadAlliance ()
		{
			Window.allianceStarBaseCB.Checked = Functions.ReadByte (Vars.allianceStarBase) == 1;

			int i = Vars.allianceShips + 13;
			foreach (object Ships in Window.fleetCompositionAlliance.Controls)
			{
				if (Ships is ComboBox)
				{
					// Console.Write (string.Format ("{0}\n", (Ships as ComboBox).Name));

					if ((Ships as ComboBox).Items.Count == 0)
					{
						if ((Ships as ComboBox).Name.Contains ("Dist"))
							(Ships as ComboBox).Items.AddRange (Vars.shipDistances);
						else
							(Ships as ComboBox).Items.AddRange (Vars.allianceShipsArray);
					}

					(Ships as ComboBox).SelectedIndex = Functions.ReadByte (i);
					i--;
				}
			}

			int allianceBitMask = Functions.ReadByte (Vars.scenBitMask);

			if (Window.firstMoveCombo.Items.Count == 0)
				Window.firstMoveCombo.Items.AddRange (Vars.firstMove);

			Window.firstMoveCombo.SelectedIndex         = (allianceBitMask & Vars.FirstMove) == 0 ? 0 : 1;
			Window.randEventsCheckbox.Checked           = (allianceBitMask & Vars.RandomEvents) == 0;
			Window.destroyStarBaseAllianceCB.Checked    = (allianceBitMask & Vars.DestroyStarBase) != 0;
			Window.destroyAllColoniesAllianceCB.Checked = (allianceBitMask & Vars.DestroyColonies) != 0;
			Window.destroyAllMinesAllianceCB.Checked    = (allianceBitMask & Vars.DestroyMines) != 0;

			Window.starBucksAllianceNum.Value = Functions.ReadShort (Vars.allianceStarBucks);

			int allianceBuyMask = Functions.ReadByte (Vars.alliancePurchaseMask);

			i = 6;
			foreach (object Buy in Window.availForPurchaseAlliance.Controls)
			{
				if (Buy is CheckBox)
				{
					//Console.Write (string.Format ("{0}\n", (Buy as CheckBox).Name));

					(Buy as CheckBox).Checked = (allianceBuyMask & (1 << i)) == 0;
					i--;
				}
			}

			//i = Vars.allianceFortMineStars;
			//foreach (object Stars in Window.starsInAllianceHemisphere.Controls)
			//{
			//	if (Stars is NumericUpDown)
			//	{
			//		// Console.Write (string.Format ("{0}\n", (Ships as ComboBox).Name));

			//		(Stars as NumericUpDown).Value = Functions.ReadByte (i);
			//		i--;
			//	}
			//}

			Window.deadAllianceStars.Value       = Functions.ReadByte (Vars.allianceDeadStars);
			Window.mineralAllianceStars.Value    = Functions.ReadByte (Vars.allianceMineralStars);
			Window.lifeAllianceStars.Value       = Functions.ReadByte (Vars.allianceLifeStars);
			Window.colonyAllianceStars.Value     = Functions.ReadByte (Vars.allianceColonyStars);
			Window.fortColonyAllianceStars.Value = Functions.ReadByte (Vars.allianceFortColonyStars);
			Window.mineAllianceStars.Value       = Functions.ReadByte (Vars.allianceMineStars);
			Window.fortMineAllianceStars.Value   = Functions.ReadByte (Vars.allianceFortMineStars);
		}
	}
}
