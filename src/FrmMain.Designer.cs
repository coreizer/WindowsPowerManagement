#region License Information (GPL v3)

/**
 * Copyright (C) 2017-2024 coreizer
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

#endregion

namespace Windows_Power_Management
{
   partial class FrmMain
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
         this.buttonLogOff = new System.Windows.Forms.Button();
         this.buttonSleep = new System.Windows.Forms.Button();
         this.buttonShutdown = new System.Windows.Forms.Button();
         this.buttonReboot = new System.Windows.Forms.Button();
         this.checkBoxForce = new System.Windows.Forms.CheckBox();
         this.SuspendLayout();
         // 
         // buttonLogOff
         // 
         this.buttonLogOff.Location = new System.Drawing.Point(18, 18);
         this.buttonLogOff.Name = "buttonLogOff";
         this.buttonLogOff.Size = new System.Drawing.Size(121, 40);
         this.buttonLogOff.TabIndex = 0;
         this.buttonLogOff.Text = "スリープ";
         this.buttonLogOff.UseVisualStyleBackColor = true;
         this.buttonLogOff.Click += new System.EventHandler(this.buttonLogOff_Click);
         // 
         // buttonSleep
         // 
         this.buttonSleep.Location = new System.Drawing.Point(145, 18);
         this.buttonSleep.Name = "buttonSleep";
         this.buttonSleep.Size = new System.Drawing.Size(121, 40);
         this.buttonSleep.TabIndex = 1;
         this.buttonSleep.Text = "休止モード";
         this.buttonSleep.UseVisualStyleBackColor = true;
         this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
         // 
         // buttonShutdown
         // 
         this.buttonShutdown.Location = new System.Drawing.Point(272, 18);
         this.buttonShutdown.Name = "buttonShutdown";
         this.buttonShutdown.Size = new System.Drawing.Size(121, 40);
         this.buttonShutdown.TabIndex = 2;
         this.buttonShutdown.Text = "シャフトダウン";
         this.buttonShutdown.UseVisualStyleBackColor = true;
         this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
         // 
         // buttonReboot
         // 
         this.buttonReboot.Location = new System.Drawing.Point(399, 18);
         this.buttonReboot.Name = "buttonReboot";
         this.buttonReboot.Size = new System.Drawing.Size(121, 40);
         this.buttonReboot.TabIndex = 3;
         this.buttonReboot.Text = "再起動";
         this.buttonReboot.UseVisualStyleBackColor = true;
         this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
         // 
         // checkBoxForce
         // 
         this.checkBoxForce.AutoSize = true;
         this.checkBoxForce.Location = new System.Drawing.Point(231, 79);
         this.checkBoxForce.Name = "checkBoxForce";
         this.checkBoxForce.Size = new System.Drawing.Size(75, 19);
         this.checkBoxForce.TabIndex = 4;
         this.checkBoxForce.Text = "強制モード";
         this.checkBoxForce.UseVisualStyleBackColor = true;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(539, 116);
         this.Controls.Add(this.checkBoxForce);
         this.Controls.Add(this.buttonReboot);
         this.Controls.Add(this.buttonShutdown);
         this.Controls.Add(this.buttonSleep);
         this.Controls.Add(this.buttonLogOff);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmMain";
         this.Padding = new System.Windows.Forms.Padding(15);
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Windows Power Management - Testing";
         this.ResumeLayout(false);
         this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonLogOff;
    private System.Windows.Forms.Button buttonSleep;
    private System.Windows.Forms.Button buttonShutdown;
    private System.Windows.Forms.Button buttonReboot;
      private System.Windows.Forms.CheckBox checkBoxForce;
   }
}

