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
namespace ScenEdit
{
    partial class Main
    {
	  /// <summary>
	  /// Required designer variable.
	  /// </summary>
	  private System.ComponentModel.IContainer components = null;

	  /// <summary>
	  /// Clean up any resources being used.
	  /// </summary>
	  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	  protected override void Dispose(bool disposing)
	  {
		if (disposing && (components != null))
		{
		    components.Dispose();
		}
		base.Dispose(disposing);
	  }

	  #region Windows Form Designer generated code

	  /// <summary>
	  /// Required method for Designer support - do not modify
	  /// the contents of this method with the code editor.
	  /// </summary>
	  private void InitializeComponent()
	  {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.randEventsCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstMoveCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.blurbText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.FleetCompositionGB = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.hierarchyStarBaseCB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabArtifacts = new System.Windows.Forms.TabPage();
            this.tabCrew = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Reload = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.tabDevices.SuspendLayout();
            this.FleetCompositionGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMisc);
            this.tabControl1.Controls.Add(this.tabDevices);
            this.tabControl1.Controls.Add(this.tabArtifacts);
            this.tabControl1.Controls.Add(this.tabCrew);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 347);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.descriptionText);
            this.tabMisc.Controls.Add(this.label5);
            this.tabMisc.Controls.Add(this.randEventsCheckbox);
            this.tabMisc.Controls.Add(this.label4);
            this.tabMisc.Controls.Add(this.firstMoveCombo);
            this.tabMisc.Controls.Add(this.label3);
            this.tabMisc.Controls.Add(this.blurbText);
            this.tabMisc.Controls.Add(this.label2);
            this.tabMisc.Controls.Add(this.label1);
            this.tabMisc.Controls.Add(this.titleText);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(590, 321);
            this.tabMisc.TabIndex = 0;
            this.tabMisc.Text = "Descriptions";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(9, 119);
            this.descriptionText.MaxLength = 839;
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(571, 193);
            this.descriptionText.TabIndex = 9;
            this.descriptionText.Text = "No Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // randEventsCheckbox
            // 
            this.randEventsCheckbox.AutoSize = true;
            this.randEventsCheckbox.Location = new System.Drawing.Point(375, 74);
            this.randEventsCheckbox.Name = "randEventsCheckbox";
            this.randEventsCheckbox.Size = new System.Drawing.Size(15, 14);
            this.randEventsCheckbox.TabIndex = 7;
            this.randEventsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Random Events:";
            // 
            // firstMoveCombo
            // 
            this.firstMoveCombo.FormattingEnabled = true;
            this.firstMoveCombo.Location = new System.Drawing.Point(71, 71);
            this.firstMoveCombo.MaxDropDownItems = 2;
            this.firstMoveCombo.Name = "firstMoveCombo";
            this.firstMoveCombo.Size = new System.Drawing.Size(136, 21);
            this.firstMoveCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Move:";
            // 
            // blurbText
            // 
            this.blurbText.Location = new System.Drawing.Point(48, 45);
            this.blurbText.MaxLength = 59;
            this.blurbText.Name = "blurbText";
            this.blurbText.Size = new System.Drawing.Size(532, 20);
            this.blurbText.TabIndex = 3;
            this.blurbText.Text = "No Blurb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blurb:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(48, 19);
            this.titleText.MaxLength = 15;
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(161, 20);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Untitled";
            // 
            // tabDevices
            // 
            this.tabDevices.Controls.Add(this.FleetCompositionGB);
            this.tabDevices.Location = new System.Drawing.Point(4, 22);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Size = new System.Drawing.Size(590, 321);
            this.tabDevices.TabIndex = 2;
            this.tabDevices.Text = "Hierarchy";
            this.tabDevices.UseVisualStyleBackColor = true;
            // 
            // FleetCompositionGB
            // 
            this.FleetCompositionGB.Controls.Add(this.numericUpDown1);
            this.FleetCompositionGB.Controls.Add(this.label7);
            this.FleetCompositionGB.Controls.Add(this.hierarchyStarBaseCB);
            this.FleetCompositionGB.Controls.Add(this.label6);
            this.FleetCompositionGB.Location = new System.Drawing.Point(8, 8);
            this.FleetCompositionGB.Name = "FleetCompositionGB";
            this.FleetCompositionGB.Size = new System.Drawing.Size(267, 200);
            this.FleetCompositionGB.TabIndex = 0;
            this.FleetCompositionGB.TabStop = false;
            this.FleetCompositionGB.Text = "Fleet Composition";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 39);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "StarBucks";
            // 
            // hierarchyStarBaseCB
            // 
            this.hierarchyStarBaseCB.AutoSize = true;
            this.hierarchyStarBaseCB.Location = new System.Drawing.Point(63, 19);
            this.hierarchyStarBaseCB.Name = "hierarchyStarBaseCB";
            this.hierarchyStarBaseCB.Size = new System.Drawing.Size(15, 14);
            this.hierarchyStarBaseCB.TabIndex = 1;
            this.hierarchyStarBaseCB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "StarBase";
            // 
            // tabArtifacts
            // 
            this.tabArtifacts.Location = new System.Drawing.Point(4, 22);
            this.tabArtifacts.Name = "tabArtifacts";
            this.tabArtifacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtifacts.Size = new System.Drawing.Size(590, 321);
            this.tabArtifacts.TabIndex = 3;
            this.tabArtifacts.Text = "Alliance";
            this.tabArtifacts.UseVisualStyleBackColor = true;
            // 
            // tabCrew
            // 
            this.tabCrew.Location = new System.Drawing.Point(4, 22);
            this.tabCrew.Name = "tabCrew";
            this.tabCrew.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrew.Size = new System.Drawing.Size(590, 321);
            this.tabCrew.TabIndex = 4;
            this.tabCrew.Text = "Star Cluster";
            this.tabCrew.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Reload,
            this.Save,
            this.Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Open
            // 
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Open.Size = new System.Drawing.Size(56, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.OpenFile);
            // 
            // Reload
            // 
            this.Reload.Enabled = false;
            this.Reload.Image = ((System.Drawing.Image)(resources.GetObject("Reload.Image")));
            this.Reload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(63, 22);
            this.Reload.Text = "Reload";
            this.Reload.Click += new System.EventHandler(this.ReloadFile);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Enabled = false;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.SaveChanges);
            // 
            // Exit
            // 
            this.Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.ExitProgram);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 374);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Scenario Editor v1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabMisc.ResumeLayout(false);
            this.tabMisc.PerformLayout();
            this.tabDevices.ResumeLayout(false);
            this.FleetCompositionGB.ResumeLayout(false);
            this.FleetCompositionGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

	  }

	  #endregion

	  private System.Windows.Forms.TabControl tabControl1;
	  private System.Windows.Forms.TabPage tabMisc;
	  private System.Windows.Forms.TabPage tabDevices;
	  private System.Windows.Forms.TabPage tabArtifacts;
	  private System.Windows.Forms.TabPage tabCrew;
	  private System.Windows.Forms.ToolStrip toolStrip1;
	  private System.Windows.Forms.ToolStripButton Save;
	  private System.Windows.Forms.ToolStripButton Exit;
	  private System.Windows.Forms.ToolStripButton Reload;
	  private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox blurbText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox firstMoveCombo;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox randEventsCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox FleetCompositionGB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox hierarchyStarBaseCB;
        private System.Windows.Forms.Label label6;
    }
}

