using System;

namespace Fahrplan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.VerbindungSuchenButton = new System.Windows.Forms.Button();
            this.VonLabel = new System.Windows.Forms.Label();
            this.NachLabel = new System.Windows.Forms.Label();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.ZeitLabel = new System.Windows.Forms.Label();
            this.comboBoxVon = new System.Windows.Forms.ComboBox();
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxVerbindungen = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerZeit = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxAbfahrtsplan = new System.Windows.Forms.ListBox();
            this.StationsortAnzeigenButton = new System.Windows.Forms.Button();
            this.AbfahrtsplanAnzeigenButton = new System.Windows.Forms.Button();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.StationLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerbindungSuchenButton
            // 
            this.VerbindungSuchenButton.Location = new System.Drawing.Point(9, 138);
            this.VerbindungSuchenButton.Name = "VerbindungSuchenButton";
            this.VerbindungSuchenButton.Size = new System.Drawing.Size(244, 33);
            this.VerbindungSuchenButton.TabIndex = 2;
            this.VerbindungSuchenButton.Text = "Verbindung suchen";
            this.VerbindungSuchenButton.UseVisualStyleBackColor = true;
            this.VerbindungSuchenButton.Click += new System.EventHandler(this.VerbindungSuchenButton_Click);
            // 
            // VonLabel
            // 
            this.VonLabel.AutoSize = true;
            this.VonLabel.Location = new System.Drawing.Point(6, 14);
            this.VonLabel.Name = "VonLabel";
            this.VonLabel.Size = new System.Drawing.Size(33, 17);
            this.VonLabel.TabIndex = 3;
            this.VonLabel.Text = "Von";
            // 
            // NachLabel
            // 
            this.NachLabel.AutoSize = true;
            this.NachLabel.Location = new System.Drawing.Point(324, 14);
            this.NachLabel.Name = "NachLabel";
            this.NachLabel.Size = new System.Drawing.Size(41, 17);
            this.NachLabel.TabIndex = 4;
            this.NachLabel.Text = "Nach";
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Location = new System.Drawing.Point(6, 75);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(49, 17);
            this.DatumLabel.TabIndex = 5;
            this.DatumLabel.Text = "Datum";
            // 
            // ZeitLabel
            // 
            this.ZeitLabel.AutoSize = true;
            this.ZeitLabel.Location = new System.Drawing.Point(324, 75);
            this.ZeitLabel.Name = "ZeitLabel";
            this.ZeitLabel.Size = new System.Drawing.Size(32, 17);
            this.ZeitLabel.TabIndex = 6;
            this.ZeitLabel.Text = "Zeit";
            // 
            // comboBoxVon
            // 
            this.comboBoxVon.FormattingEnabled = true;
            this.comboBoxVon.Location = new System.Drawing.Point(9, 34);
            this.comboBoxVon.Name = "comboBoxVon";
            this.comboBoxVon.Size = new System.Drawing.Size(241, 24);
            this.comboBoxVon.TabIndex = 7;
            this.comboBoxVon.DropDown += new System.EventHandler(this.comboBoxVon_DropDown);
            // 
            // comboBoxNach
            // 
            this.comboBoxNach.FormattingEnabled = true;
            this.comboBoxNach.Location = new System.Drawing.Point(327, 34);
            this.comboBoxNach.Name = "comboBoxNach";
            this.comboBoxNach.Size = new System.Drawing.Size(222, 24);
            this.comboBoxNach.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 18, 13, 12, 47, 0);
            // 
            // listBoxVerbindungen
            // 
            this.listBoxVerbindungen.FormattingEnabled = true;
            this.listBoxVerbindungen.ItemHeight = 16;
            this.listBoxVerbindungen.Location = new System.Drawing.Point(9, 177);
            this.listBoxVerbindungen.Name = "listBoxVerbindungen";
            this.listBoxVerbindungen.Size = new System.Drawing.Size(540, 228);
            this.listBoxVerbindungen.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 449);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerZeit);
            this.tabPage1.Controls.Add(this.comboBoxVon);
            this.tabPage1.Controls.Add(this.listBoxVerbindungen);
            this.tabPage1.Controls.Add(this.VonLabel);
            this.tabPage1.Controls.Add(this.VerbindungSuchenButton);
            this.tabPage1.Controls.Add(this.comboBoxNach);
            this.tabPage1.Controls.Add(this.ZeitLabel);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.NachLabel);
            this.tabPage1.Controls.Add(this.DatumLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stationen";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateTimePickerZeit
            // 
            this.dateTimePickerZeit.Location = new System.Drawing.Point(327, 95);
            this.dateTimePickerZeit.Name = "dateTimePickerZeit";
            this.dateTimePickerZeit.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerZeit.TabIndex = 12;
            this.dateTimePickerZeit.ValueChanged += new System.EventHandler(this.dateTimePickerZeit_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxAbfahrtsplan);
            this.tabPage2.Controls.Add(this.StationsortAnzeigenButton);
            this.tabPage2.Controls.Add(this.AbfahrtsplanAnzeigenButton);
            this.tabPage2.Controls.Add(this.comboBoxStation);
            this.tabPage2.Controls.Add(this.StationLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtsplan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxAbfahrtsplan
            // 
            this.listBoxAbfahrtsplan.FormattingEnabled = true;
            this.listBoxAbfahrtsplan.ItemHeight = 16;
            this.listBoxAbfahrtsplan.Location = new System.Drawing.Point(9, 64);
            this.listBoxAbfahrtsplan.Name = "listBoxAbfahrtsplan";
            this.listBoxAbfahrtsplan.Size = new System.Drawing.Size(564, 340);
            this.listBoxAbfahrtsplan.TabIndex = 4;
            // 
            // StationsortAnzeigenButton
            // 
            this.StationsortAnzeigenButton.Location = new System.Drawing.Point(397, 33);
            this.StationsortAnzeigenButton.Name = "StationsortAnzeigenButton";
            this.StationsortAnzeigenButton.Size = new System.Drawing.Size(176, 25);
            this.StationsortAnzeigenButton.TabIndex = 3;
            this.StationsortAnzeigenButton.Text = "Stationsort anzeigen";
            this.StationsortAnzeigenButton.UseVisualStyleBackColor = true;
            // 
            // AbfahrtsplanAnzeigenButton
            // 
            this.AbfahrtsplanAnzeigenButton.Location = new System.Drawing.Point(230, 33);
            this.AbfahrtsplanAnzeigenButton.Name = "AbfahrtsplanAnzeigenButton";
            this.AbfahrtsplanAnzeigenButton.Size = new System.Drawing.Size(161, 25);
            this.AbfahrtsplanAnzeigenButton.TabIndex = 2;
            this.AbfahrtsplanAnzeigenButton.Text = "Abfahrtsplan anzeigen";
            this.AbfahrtsplanAnzeigenButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(9, 34);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(215, 24);
            this.comboBoxStation.TabIndex = 1;
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Location = new System.Drawing.Point(6, 14);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(52, 17);
            this.StationLabel.TabIndex = 0;
            this.StationLabel.Text = "Station";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dateTimePickerZeit_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button VerbindungSuchenButton;
        private System.Windows.Forms.Label VonLabel;
        private System.Windows.Forms.Label NachLabel;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.Label ZeitLabel;
        private System.Windows.Forms.ComboBox comboBoxVon;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxVerbindungen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxAbfahrtsplan;
        private System.Windows.Forms.Button StationsortAnzeigenButton;
        private System.Windows.Forms.Button AbfahrtsplanAnzeigenButton;
        private System.Windows.Forms.ComboBox comboBoxStation;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerZeit;
    }
}

