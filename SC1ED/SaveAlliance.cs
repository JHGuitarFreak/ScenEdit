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
		public static void SaveAlliance ()
		{
			Functions.WriteByte (Vars.allianceStarBase, (byte)(Window.allianceStarBaseCB.Checked ? 1 : 0));

			int i = Vars.allianceShips + 13;
			foreach (object Ships in Window.fleetCompositionAlliance.Controls)
			{
				if (Ships is ComboBox)
				{
					Functions.WriteByte (i, (byte)((Ships as ComboBox).SelectedIndex));
					i--;
				}
			}

			byte allianceBitMask = 0;

			if (Window.firstMoveCombo.SelectedIndex != 0)
				allianceBitMask |= Vars.FirstMove;
			if (!Window.randEventsCheckbox.Checked)
				allianceBitMask |= Vars.RandomEvents;
			if (Window.destroyStarBaseAllianceCB.Checked)
				allianceBitMask |= Vars.DestroyStarBase;
			if (Window.destroyAllColoniesAllianceCB.Checked)
				allianceBitMask |= Vars.DestroyColonies;
			if (Window.destroyAllMinesAllianceCB.Checked)
				allianceBitMask |= Vars.DestroyMines;

			Functions.WriteByte (Vars.scenBitMask, allianceBitMask);

			Functions.WriteShort (Vars.allianceStarBucks, (short)(Window.starBucksAllianceNum.Value));

			byte allianceBuyMask = 0;

			i = 6;
			foreach (object Buy in Window.availForPurchaseAlliance.Controls)
			{
				if (Buy is CheckBox)
				{
					if (!(Buy as CheckBox).Checked)
						allianceBuyMask |= (byte)(1 << i);
					i--;
				}
			}

			Functions.WriteByte (Vars.alliancePurchaseMask, allianceBuyMask);

			Functions.WriteByte (Vars.allianceDeadStars, (byte)(Window.deadAllianceStars.Value));
			Functions.WriteByte (Vars.allianceMineralStars, (byte)(Window.mineralAllianceStars.Value));
			Functions.WriteByte (Vars.allianceLifeStars, (byte)(Window.lifeAllianceStars.Value));
			Functions.WriteByte (Vars.allianceColonyStars, (byte)(Window.colonyAllianceStars.Value));
			Functions.WriteByte (Vars.allianceFortColonyStars, (byte)(Window.fortColonyAllianceStars.Value));
			Functions.WriteByte (Vars.allianceMineStars, (byte)(Window.mineAllianceStars.Value));
			Functions.WriteByte (Vars.allianceFortMineStars, (byte)(Window.fortMineAllianceStars.Value));
		}
	}
}
