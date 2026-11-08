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
	}
}
