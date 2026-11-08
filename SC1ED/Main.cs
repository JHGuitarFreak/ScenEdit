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
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Win32;

namespace ScenEdit
{
	public partial class Main : Form
	{
		private string CurrentDir;
		private string CurrentFile = "";
		public static string FileName = "";

		public Main()
		{
			InitializeComponent();
		}

		private void OpenFile(object sender, EventArgs e) {

			System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
			openFileDialog.Title = "Open SCENARIO File";
			openFileDialog.Filter = "SCENARIO File (SCENARIO.*)|SCENARIO.*";
			openFileDialog.InitialDirectory = CurrentDir;

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				CurrentFile = openFileDialog.FileName;
				FileName = Path.GetFileName(CurrentFile);
				this.Text = "Star Control 1 Scenario Editor - " + FileName;
				this.Reload.Enabled = true;
				this.Save.Enabled = true;
				this.tabControl1.Enabled = true;

				Read.Open(CurrentFile, this);
				CurrentDir = CurrentFile;
			}
		}

		private void ReloadFile(object sender, EventArgs e) {
			Read.Open(CurrentFile, this);
		}

		private void SaveChanges(object sender, EventArgs e) {
			Write.Save(CurrentFile, this);
		}

		private void ExitProgram(object sender, EventArgs e) {
			Application.Exit();
		}

		private void HierarchyShip_SelectedIndexChanged (object sender, EventArgs e)
		{
			int totalPoints = 0;

			if (hierarchyShip1CB.SelectedIndex >= 0 &&
				hierarchyShip2CB.SelectedIndex >= 0 &&
				hierarchyShip3CB.SelectedIndex >= 0 &&
				hierarchyShip4CB.SelectedIndex >= 0 &&
				hierarchyShip5CB.SelectedIndex >= 0 &&
				hierarchyShip6CB.SelectedIndex >= 0 &&
				hierarchyShip7CB.SelectedIndex >= 0)
			{
				int index;
				int shipPoints = 0;

				totalPoints =
					Vars.hierarchyShipPoints[hierarchyShip1CB.SelectedIndex] +
					Vars.hierarchyShipPoints[hierarchyShip2CB.SelectedIndex] +
					Vars.hierarchyShipPoints[hierarchyShip3CB.SelectedIndex] +
					Vars.hierarchyShipPoints[hierarchyShip4CB.SelectedIndex] +
					Vars.hierarchyShipPoints[hierarchyShip5CB.SelectedIndex] +
					Vars.hierarchyShipPoints[hierarchyShip6CB.SelectedIndex] +
					Vars.hierarchyShipPoints[hierarchyShip7CB.SelectedIndex];

				index = hierarchyShip1CB.SelectedIndex;
				if (hierarchyShip1CB.SelectedIndex > 0)
					shipPoints = Vars.hierarchyShipPoints[index];
				hierarchyShip1PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = hierarchyShip2CB.SelectedIndex;
				if (hierarchyShip2CB.SelectedIndex > 0)
					shipPoints = Vars.hierarchyShipPoints[index];
				hierarchyShip2PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = hierarchyShip3CB.SelectedIndex;
				if (hierarchyShip3CB.SelectedIndex > 0)
					shipPoints = Vars.hierarchyShipPoints[index];
				hierarchyShip3PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = hierarchyShip4CB.SelectedIndex;
				if (hierarchyShip4CB.SelectedIndex > 0)
					shipPoints = Vars.hierarchyShipPoints[index];
				hierarchyShip4PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = hierarchyShip5CB.SelectedIndex;
				if (hierarchyShip5CB.SelectedIndex > 0)
					shipPoints = Vars.hierarchyShipPoints[index];
				hierarchyShip5PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = hierarchyShip6CB.SelectedIndex;
				if (hierarchyShip6CB.SelectedIndex > 0)
					shipPoints = Vars.hierarchyShipPoints[index];
				hierarchyShip6PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = hierarchyShip7CB.SelectedIndex;
				if (hierarchyShip7CB.SelectedIndex > 0)
					shipPoints = Vars.hierarchyShipPoints[index];
				hierarchyShip7PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;
			}

			hierarchyTotalPointValue.Text = "Total " + totalPoints;
		}

		private void AllianceShip_SelectedIndexChanged (object sender, EventArgs e)
		{
			int totalPoints = 0;

			if (allianceShip1CB.SelectedIndex >= 0 &&
				allianceShip2CB.SelectedIndex >= 0 &&
				allianceShip3CB.SelectedIndex >= 0 &&
				allianceShip4CB.SelectedIndex >= 0 &&
				allianceShip5CB.SelectedIndex >= 0 &&
				allianceShip6CB.SelectedIndex >= 0 &&
				allianceShip7CB.SelectedIndex >= 0)
			{
				int index;
				int shipPoints = 0;

				totalPoints =
					Vars.allianceShipPoints[allianceShip1CB.SelectedIndex] +
					Vars.allianceShipPoints[allianceShip2CB.SelectedIndex] +
					Vars.allianceShipPoints[allianceShip3CB.SelectedIndex] +
					Vars.allianceShipPoints[allianceShip4CB.SelectedIndex] +
					Vars.allianceShipPoints[allianceShip5CB.SelectedIndex] +
					Vars.allianceShipPoints[allianceShip6CB.SelectedIndex] +
					Vars.allianceShipPoints[allianceShip7CB.SelectedIndex];

				index = allianceShip1CB.SelectedIndex;
				if (allianceShip1CB.SelectedIndex > 0)
					shipPoints = Vars.allianceShipPoints[index];
				allianceShip1PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = allianceShip2CB.SelectedIndex;
				if (allianceShip2CB.SelectedIndex > 0)
					shipPoints = Vars.allianceShipPoints[index];
				allianceShip2PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = allianceShip3CB.SelectedIndex;
				if (allianceShip3CB.SelectedIndex > 0)
					shipPoints = Vars.allianceShipPoints[index];
				allianceShip3PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = allianceShip4CB.SelectedIndex;
				if (allianceShip4CB.SelectedIndex > 0)
					shipPoints = Vars.allianceShipPoints[index];
				allianceShip4PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = allianceShip5CB.SelectedIndex;
				if (allianceShip5CB.SelectedIndex > 0)
					shipPoints = Vars.allianceShipPoints[index];
				allianceShip5PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = allianceShip6CB.SelectedIndex;
				if (allianceShip6CB.SelectedIndex > 0)
					shipPoints = Vars.allianceShipPoints[index];
				allianceShip6PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;

				index = allianceShip7CB.SelectedIndex;
				if (allianceShip7CB.SelectedIndex > 0)
					shipPoints = Vars.allianceShipPoints[index];
				allianceShip7PointValue.Text = shipPoints > 0 ? "Value " + shipPoints : " ";
				shipPoints = 0;
			}

			allianceTotalPointValue.Text = "Total " + totalPoints;
		}

		private void HierarchyStars_ValueChanged (object sender, EventArgs e)
		{
			decimal totalPoints = 0;

			if (deadHierarchyStars.Value >= 0 &&
				mineralHierarchyStars.Value >= 0 &&
				lifeHierarchyStars.Value >= 0 &&
				colonyHierarchyStars.Value >= 0 &&
				mineHierarchyStars.Value >= 0 &&
				fortColonyHierarchyStars.Value >= 0 &&
				fortMineHierarchyStars.Value >= 0)
			{
				totalPoints =
					deadHierarchyStars.Value +
					mineralHierarchyStars.Value +
					lifeHierarchyStars.Value +
					colonyHierarchyStars.Value +
					mineHierarchyStars.Value +
					fortColonyHierarchyStars.Value +
					fortMineHierarchyStars.Value;
			}

			hierarchyTotalStars.Text = "" + totalPoints;
		}

		private void AllianceStars_ValueChanged (object sender, EventArgs e)
		{
			decimal totalPoints = 0;

			if (deadAllianceStars.Value >= 0 &&
				mineralAllianceStars.Value >= 0 &&
				lifeAllianceStars.Value >= 0 &&
				colonyAllianceStars.Value >= 0 &&
				mineAllianceStars.Value >= 0 &&
				fortColonyAllianceStars.Value >= 0 &&
				fortMineAllianceStars.Value >= 0)
			{
				totalPoints =
					deadAllianceStars.Value +
					mineralAllianceStars.Value +
					lifeAllianceStars.Value +
					colonyAllianceStars.Value +
					mineAllianceStars.Value +
					fortColonyAllianceStars.Value +
					fortMineAllianceStars.Value;
			}

			allianceTotalStars.Text = "" + totalPoints;
		}

		private void TotalStars_TextChanged (object sender, EventArgs e)
		{
			if (!allianceTotalStars.Text.Contains("Placeholder") &&
				!hierarchyTotalStars.Text.Contains ("Placeholder"))
			{
				int allianceTotal = Int32.Parse(allianceTotalStars.Text);
				int hierarchyTotal = Int32.Parse(hierarchyTotalStars.Text);

				totalStars.Text = "" + (allianceTotal + hierarchyTotal);

			}
		}
	}
}
