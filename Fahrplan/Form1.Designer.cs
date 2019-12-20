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
            this.comboBoxVon = new System.Windows.Forms.ComboBox();
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.listBoxVerbindungen = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStationen = new System.Windows.Forms.TabPage();
            this.textBoxZeit = new System.Windows.Forms.TextBox();
            this.MSDNButton = new System.Windows.Forms.Button();
            this.ZeitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAbfahrtsplan = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.EmailButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.listBoxAbfahrtsplan = new System.Windows.Forms.ListBox();
            this.StationsortAnzeigenButton = new System.Windows.Forms.Button();
            this.AbfahrtsplanAnzeigenButton = new System.Windows.Forms.Button();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.StationLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageStationen.SuspendLayout();
            this.tabPageAbfahrtsplan.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerbindungSuchenButton
            // 
            this.VerbindungSuchenButton.Location = new System.Drawing.Point(9, 138);
            this.VerbindungSuchenButton.Name = "VerbindungSuchenButton";
            this.VerbindungSuchenButton.Size = new System.Drawing.Size(241, 33);
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
            this.comboBoxNach.DropDown += new System.EventHandler(this.comboBoxNach_DropDown);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(9, 95);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(241, 22);
            this.dtpDatum.TabIndex = 9;
            this.dtpDatum.Value = new System.DateTime(2019, 12, 18, 13, 12, 47, 0);
            // 
            // listBoxVerbindungen
            // 
            this.listBoxVerbindungen.FormattingEnabled = true;
            this.listBoxVerbindungen.ItemHeight = 16;
            this.listBoxVerbindungen.Location = new System.Drawing.Point(9, 177);
            this.listBoxVerbindungen.Name = "listBoxVerbindungen";
            this.listBoxVerbindungen.Size = new System.Drawing.Size(774, 244);
            this.listBoxVerbindungen.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStationen);
            this.tabControl1.Controls.Add(this.tabPageAbfahrtsplan);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 788);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageStationen
            // 
            this.tabPageStationen.Controls.Add(this.textBoxZeit);
            this.tabPageStationen.Controls.Add(this.MSDNButton);
            this.tabPageStationen.Controls.Add(this.ZeitLabel);
            this.tabPageStationen.Controls.Add(this.label1);
            this.tabPageStationen.Controls.Add(this.comboBoxVon);
            this.tabPageStationen.Controls.Add(this.listBoxVerbindungen);
            this.tabPageStationen.Controls.Add(this.VonLabel);
            this.tabPageStationen.Controls.Add(this.VerbindungSuchenButton);
            this.tabPageStationen.Controls.Add(this.comboBoxNach);
            this.tabPageStationen.Controls.Add(this.dtpDatum);
            this.tabPageStationen.Controls.Add(this.NachLabel);
            this.tabPageStationen.Controls.Add(this.DatumLabel);
            this.tabPageStationen.Location = new System.Drawing.Point(4, 25);
            this.tabPageStationen.Name = "tabPageStationen";
            this.tabPageStationen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStationen.Size = new System.Drawing.Size(1200, 759);
            this.tabPageStationen.TabIndex = 0;
            this.tabPageStationen.Text = "Stationen";
            this.tabPageStationen.UseVisualStyleBackColor = true;
            this.tabPageStationen.Click += new System.EventHandler(this.tabPageStationen_Click);
            // 
            // textBoxZeit
            // 
            this.textBoxZeit.Location = new System.Drawing.Point(334, 95);
            this.textBoxZeit.Name = "textBoxZeit";
            this.textBoxZeit.Size = new System.Drawing.Size(100, 22);
            this.textBoxZeit.TabIndex = 16;
            // 
            // MSDNButton
            // 
            this.MSDNButton.Location = new System.Drawing.Point(327, 138);
            this.MSDNButton.Name = "MSDNButton";
            this.MSDNButton.Size = new System.Drawing.Size(222, 33);
            this.MSDNButton.TabIndex = 13;
            this.MSDNButton.Text = "Microsoft Seite";
            this.MSDNButton.UseVisualStyleBackColor = true;
            this.MSDNButton.Click += new System.EventHandler(this.MSDNButton_Click);
            // 
            // ZeitLabel
            // 
            this.ZeitLabel.AutoSize = true;
            this.ZeitLabel.Location = new System.Drawing.Point(324, 75);
            this.ZeitLabel.Name = "ZeitLabel";
            this.ZeitLabel.Size = new System.Drawing.Size(32, 17);
            this.ZeitLabel.TabIndex = 15;
            this.ZeitLabel.Text = "Zeit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 13;
            // 
            // tabPageAbfahrtsplan
            // 
            this.tabPageAbfahrtsplan.Controls.Add(this.webBrowser1);
            this.tabPageAbfahrtsplan.Controls.Add(this.EmailButton);
            this.tabPageAbfahrtsplan.Controls.Add(this.textBox1);
            this.tabPageAbfahrtsplan.Controls.Add(this.EmailLabel);
            this.tabPageAbfahrtsplan.Controls.Add(this.listBoxAbfahrtsplan);
            this.tabPageAbfahrtsplan.Controls.Add(this.StationsortAnzeigenButton);
            this.tabPageAbfahrtsplan.Controls.Add(this.AbfahrtsplanAnzeigenButton);
            this.tabPageAbfahrtsplan.Controls.Add(this.comboBoxStation);
            this.tabPageAbfahrtsplan.Controls.Add(this.StationLabel);
            this.tabPageAbfahrtsplan.Location = new System.Drawing.Point(4, 25);
            this.tabPageAbfahrtsplan.Name = "tabPageAbfahrtsplan";
            this.tabPageAbfahrtsplan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbfahrtsplan.Size = new System.Drawing.Size(1200, 759);
            this.tabPageAbfahrtsplan.TabIndex = 1;
            this.tabPageAbfahrtsplan.Text = "Abfahrtsplan";
            this.tabPageAbfahrtsplan.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(9, 292);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1185, 461);
            this.webBrowser1.TabIndex = 8;
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(640, 64);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(204, 30);
            this.EmailButton.TabIndex = 7;
            this.EmailButton.Text = "Email senden";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(640, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 6;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(637, 14);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // listBoxAbfahrtsplan
            // 
            this.listBoxAbfahrtsplan.FormattingEnabled = true;
            this.listBoxAbfahrtsplan.ItemHeight = 16;
            this.listBoxAbfahrtsplan.Location = new System.Drawing.Point(9, 64);
            this.listBoxAbfahrtsplan.Name = "listBoxAbfahrtsplan";
            this.listBoxAbfahrtsplan.Size = new System.Drawing.Size(564, 212);
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
            this.StationsortAnzeigenButton.Click += new System.EventHandler(this.StationsortAnzeigenButton_Click);
            // 
            // AbfahrtsplanAnzeigenButton
            // 
            this.AbfahrtsplanAnzeigenButton.Location = new System.Drawing.Point(230, 33);
            this.AbfahrtsplanAnzeigenButton.Name = "AbfahrtsplanAnzeigenButton";
            this.AbfahrtsplanAnzeigenButton.Size = new System.Drawing.Size(161, 25);
            this.AbfahrtsplanAnzeigenButton.TabIndex = 2;
            this.AbfahrtsplanAnzeigenButton.Text = "Abfahrtsplan anzeigen";
            this.AbfahrtsplanAnzeigenButton.UseVisualStyleBackColor = true;
            this.AbfahrtsplanAnzeigenButton.Click += new System.EventHandler(this.AbfahrtsplanAnzeigenButton_Click);
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(9, 34);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(215, 24);
            this.comboBoxStation.TabIndex = 1;
            this.comboBoxStation.DropDown += new System.EventHandler(this.comboBoxStation_DropDown);
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
            this.AcceptButton = this.VerbindungSuchenButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 790);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SBB Fahrplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageStationen.ResumeLayout(false);
            this.tabPageStationen.PerformLayout();
            this.tabPageAbfahrtsplan.ResumeLayout(false);
            this.tabPageAbfahrtsplan.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tabPageStationen_Click(object sender, EventArgs e)
        {

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
        private System.Windows.Forms.ComboBox comboBoxVon;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ListBox listBoxVerbindungen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStationen;
        private System.Windows.Forms.TabPage tabPageAbfahrtsplan;
        private System.Windows.Forms.ListBox listBoxAbfahrtsplan;
        private System.Windows.Forms.Button StationsortAnzeigenButton;
        private System.Windows.Forms.Button AbfahrtsplanAnzeigenButton;
        private System.Windows.Forms.ComboBox comboBoxStation;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label ZeitLabel;
        private System.Windows.Forms.Button MSDNButton;
        private System.Windows.Forms.TextBox textBoxZeit;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

