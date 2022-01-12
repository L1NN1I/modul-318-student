
namespace TransportApp
{
    partial class SearchConnection
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
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.tbxDeparture = new System.Windows.Forms.TextBox();
            this.lblDepartureStation = new System.Windows.Forms.Label();
            this.lblArrivalStation = new System.Windows.Forms.Label();
            this.grpConnectionSearch = new System.Windows.Forms.GroupBox();
            this.cbxArrival = new System.Windows.Forms.ComboBox();
            this.cbxDeparture = new System.Windows.Forms.ComboBox();
            this.autoCompleteCheckBox = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.PictureBox();
            this.btnMail = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.SearchdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxArrival = new System.Windows.Forms.TextBox();
            this.searchConnectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchConnectionBack = new System.Windows.Forms.Button();
            this.btnSearchConnectionClose = new System.Windows.Forms.Button();
            this.grpConnectionSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchConnectionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(443, 110);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(153, 35);
            this.btnSearchConnection.TabIndex = 7;
            this.btnSearchConnection.Text = "Verbindungen suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // tbxDeparture
            // 
            this.tbxDeparture.Location = new System.Drawing.Point(7, 52);
            this.tbxDeparture.Name = "tbxDeparture";
            this.tbxDeparture.Size = new System.Drawing.Size(130, 23);
            this.tbxDeparture.TabIndex = 1;
            this.tbxDeparture.TextChanged += new System.EventHandler(this.tbxDeparture_TextChanged);
            // 
            // lblDepartureStation
            // 
            this.lblDepartureStation.AutoSize = true;
            this.lblDepartureStation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureStation.Location = new System.Drawing.Point(6, 19);
            this.lblDepartureStation.Name = "lblDepartureStation";
            this.lblDepartureStation.Size = new System.Drawing.Size(110, 20);
            this.lblDepartureStation.TabIndex = 4;
            this.lblDepartureStation.Text = "Abfahrtsstation";
            // 
            // lblArrivalStation
            // 
            this.lblArrivalStation.AutoSize = true;
            this.lblArrivalStation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrivalStation.Location = new System.Drawing.Point(232, 19);
            this.lblArrivalStation.Name = "lblArrivalStation";
            this.lblArrivalStation.Size = new System.Drawing.Size(79, 20);
            this.lblArrivalStation.TabIndex = 5;
            this.lblArrivalStation.Text = "Endstation";
            // 
            // grpConnectionSearch
            // 
            this.grpConnectionSearch.Controls.Add(this.cbxArrival);
            this.grpConnectionSearch.Controls.Add(this.cbxDeparture);
            this.grpConnectionSearch.Controls.Add(this.autoCompleteCheckBox);
            this.grpConnectionSearch.Controls.Add(this.btnChange);
            this.grpConnectionSearch.Controls.Add(this.btnMail);
            this.grpConnectionSearch.Controls.Add(this.btnHome);
            this.grpConnectionSearch.Controls.Add(this.SearchdateTimePicker);
            this.grpConnectionSearch.Controls.Add(this.numericUpDownMinutes);
            this.grpConnectionSearch.Controls.Add(this.numericUpDownHours);
            this.grpConnectionSearch.Controls.Add(this.label1);
            this.grpConnectionSearch.Controls.Add(this.btnSearchConnection);
            this.grpConnectionSearch.Controls.Add(this.tbxArrival);
            this.grpConnectionSearch.Controls.Add(this.lblDepartureStation);
            this.grpConnectionSearch.Controls.Add(this.lblArrivalStation);
            this.grpConnectionSearch.Controls.Add(this.tbxDeparture);
            this.grpConnectionSearch.Location = new System.Drawing.Point(12, 12);
            this.grpConnectionSearch.Name = "grpConnectionSearch";
            this.grpConnectionSearch.Size = new System.Drawing.Size(750, 159);
            this.grpConnectionSearch.TabIndex = 6;
            this.grpConnectionSearch.TabStop = false;
            this.grpConnectionSearch.Text = "Verbindungen Suchen";
            // 
            // cbxArrival
            // 
            this.cbxArrival.FormattingEnabled = true;
            this.cbxArrival.Location = new System.Drawing.Point(232, 81);
            this.cbxArrival.Name = "cbxArrival";
            this.cbxArrival.Size = new System.Drawing.Size(121, 23);
            this.cbxArrival.TabIndex = 17;
            // 
            // cbxDeparture
            // 
            this.cbxDeparture.FormattingEnabled = true;
            this.cbxDeparture.Location = new System.Drawing.Point(6, 81);
            this.cbxDeparture.Name = "cbxDeparture";
            this.cbxDeparture.Size = new System.Drawing.Size(121, 23);
            this.cbxDeparture.TabIndex = 16;
            // 
            // autoCompleteCheckBox
            // 
            this.autoCompleteCheckBox.AutoSize = true;
            this.autoCompleteCheckBox.Location = new System.Drawing.Point(443, 52);
            this.autoCompleteCheckBox.Name = "autoCompleteCheckBox";
            this.autoCompleteCheckBox.Size = new System.Drawing.Size(75, 19);
            this.autoCompleteCheckBox.TabIndex = 3;
            this.autoCompleteCheckBox.Text = "Suchhilfe";
            this.autoCompleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Image = global::TransportApp.Properties.Resources._59417;
            this.btnChange.Location = new System.Drawing.Point(165, 42);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(33, 33);
            this.btnChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChange.TabIndex = 15;
            this.btnChange.TabStop = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMail
            // 
            this.btnMail.Image = global::TransportApp.Properties.Resources._666162;
            this.btnMail.Location = new System.Drawing.Point(661, 19);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(33, 33);
            this.btnMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMail.TabIndex = 14;
            this.btnMail.TabStop = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::TransportApp.Properties.Resources._25694;
            this.btnHome.Location = new System.Drawing.Point(711, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 33);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 13;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // SearchdateTimePicker
            // 
            this.SearchdateTimePicker.Location = new System.Drawing.Point(216, 118);
            this.SearchdateTimePicker.Name = "SearchdateTimePicker";
            this.SearchdateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.SearchdateTimePicker.TabIndex = 6;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(151, 118);
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(47, 23);
            this.numericUpDownMinutes.TabIndex = 5;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(97, 118);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(47, 23);
            this.numericUpDownHours.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Abfahrtszeit: ";
            // 
            // tbxArrival
            // 
            this.tbxArrival.Location = new System.Drawing.Point(232, 52);
            this.tbxArrival.Name = "tbxArrival";
            this.tbxArrival.Size = new System.Drawing.Size(130, 23);
            this.tbxArrival.TabIndex = 2;
            this.tbxArrival.TextChanged += new System.EventHandler(this.tbxArrival_TextChanged);
            // 
            // searchConnectionsDataGridView
            // 
            this.searchConnectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchConnectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Platform,
            this.Abfahrtsstation,
            this.Endstation,
            this.Abfahrtszeit,
            this.Ankunftszeit,
            this.Dauer,
            this.Verspätung});
            this.searchConnectionsDataGridView.Location = new System.Drawing.Point(19, 191);
            this.searchConnectionsDataGridView.Name = "searchConnectionsDataGridView";
            this.searchConnectionsDataGridView.RowTemplate.Height = 25;
            this.searchConnectionsDataGridView.Size = new System.Drawing.Size(743, 213);
            this.searchConnectionsDataGridView.TabIndex = 7;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.Width = 60;
            // 
            // Abfahrtsstation
            // 
            this.Abfahrtsstation.HeaderText = "Abfahrtsstation";
            this.Abfahrtsstation.Name = "Abfahrtsstation";
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.Name = "Endstation";
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.Width = 130;
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.HeaderText = "Ankunftszeit";
            this.Ankunftszeit.Name = "Ankunftszeit";
            this.Ankunftszeit.Width = 130;
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.Name = "Dauer";
            this.Dauer.Width = 80;
            // 
            // Verspätung
            // 
            this.Verspätung.HeaderText = "Verspätung";
            this.Verspätung.Name = "Verspätung";
            // 
            // btnSearchConnectionBack
            // 
            this.btnSearchConnectionBack.Location = new System.Drawing.Point(592, 415);
            this.btnSearchConnectionBack.Name = "btnSearchConnectionBack";
            this.btnSearchConnectionBack.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConnectionBack.TabIndex = 8;
            this.btnSearchConnectionBack.Text = "Zurück";
            this.btnSearchConnectionBack.UseVisualStyleBackColor = true;
            this.btnSearchConnectionBack.Click += new System.EventHandler(this.btnSearchConnectionBack_Click);
            // 
            // btnSearchConnectionClose
            // 
            this.btnSearchConnectionClose.Location = new System.Drawing.Point(687, 415);
            this.btnSearchConnectionClose.Name = "btnSearchConnectionClose";
            this.btnSearchConnectionClose.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConnectionClose.TabIndex = 9;
            this.btnSearchConnectionClose.Text = "Schliessen";
            this.btnSearchConnectionClose.UseVisualStyleBackColor = true;
            this.btnSearchConnectionClose.Click += new System.EventHandler(this.btnSearchConnectionClose_Click);
            // 
            // SearchConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchConnectionClose);
            this.Controls.Add(this.btnSearchConnectionBack);
            this.Controls.Add(this.searchConnectionsDataGridView);
            this.Controls.Add(this.grpConnectionSearch);
            this.Name = "SearchConnection";
            this.Text = "Verbindungen";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.grpConnectionSearch.ResumeLayout(false);
            this.grpConnectionSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchConnectionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.TextBox tbxDeparture;
        private System.Windows.Forms.Label lblDepartureStation;
        private System.Windows.Forms.Label lblArrivalStation;
        private System.Windows.Forms.GroupBox grpConnectionSearch;
        private System.Windows.Forms.TextBox tbxArrival;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SearchdateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.DataGridView searchConnectionsDataGridView;
        private System.Windows.Forms.PictureBox btnMail;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnChange;
        private System.Windows.Forms.CheckBox autoCompleteCheckBox;
        private System.Windows.Forms.Button btnSearchConnectionBack;
        private System.Windows.Forms.Button btnSearchConnectionClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
        private System.Windows.Forms.ComboBox cbxArrival;
        private System.Windows.Forms.ComboBox cbxDeparture;
    }
}