namespace TransportApp
{
    partial class NearbyStation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchForStations = new System.Windows.Forms.Button();
            this.btnTakeMeHome = new System.Windows.Forms.Button();
            this.NearbyStationdataGridView = new System.Windows.Forms.DataGridView();
            this.deinStandort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionSelectiondataGridView = new System.Windows.Forms.DataGridView();
            this.btnMail = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNearbyStationBack = new System.Windows.Forms.Button();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NearbyStationdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSelectiondataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchForStations
            // 
            this.btnSearchForStations.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchForStations.Location = new System.Drawing.Point(24, 12);
            this.btnSearchForStations.Name = "btnSearchForStations";
            this.btnSearchForStations.Size = new System.Drawing.Size(172, 43);
            this.btnSearchForStations.TabIndex = 0;
            this.btnSearchForStations.Text = "Suchen nach Stationen";
            this.btnSearchForStations.UseVisualStyleBackColor = false;
            this.btnSearchForStations.Click += new System.EventHandler(this.btnSearchForStations_Click);
            // 
            // btnTakeMeHome
            // 
            this.btnTakeMeHome.BackColor = System.Drawing.Color.OliveDrab;
            this.btnTakeMeHome.Location = new System.Drawing.Point(220, 12);
            this.btnTakeMeHome.Name = "btnTakeMeHome";
            this.btnTakeMeHome.Size = new System.Drawing.Size(172, 43);
            this.btnTakeMeHome.TabIndex = 1;
            this.btnTakeMeHome.Text = "Take Me Home";
            this.btnTakeMeHome.UseVisualStyleBackColor = false;
            this.btnTakeMeHome.Click += new System.EventHandler(this.btnTakeMeHome_Click);
            // 
            // NearbyStationdataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NearbyStationdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NearbyStationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NearbyStationdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deinStandort,
            this.Ankunftsstation,
            this.Verkehrsmittel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NearbyStationdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.NearbyStationdataGridView.Location = new System.Drawing.Point(24, 75);
            this.NearbyStationdataGridView.Name = "NearbyStationdataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NearbyStationdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.NearbyStationdataGridView.RowTemplate.Height = 25;
            this.NearbyStationdataGridView.Size = new System.Drawing.Size(743, 162);
            this.NearbyStationdataGridView.TabIndex = 20;
            // 
            // deinStandort
            // 
            this.deinStandort.HeaderText = "Dein Standort";
            this.deinStandort.Name = "deinStandort";
            this.deinStandort.ReadOnly = true;
            this.deinStandort.Width = 233;
            // 
            // Ankunftsstation
            // 
            this.Ankunftsstation.HeaderText = "Stationsname";
            this.Ankunftsstation.Name = "Ankunftsstation";
            this.Ankunftsstation.ReadOnly = true;
            this.Ankunftsstation.Width = 233;
            // 
            // Verkehrsmittel
            // 
            this.Verkehrsmittel.HeaderText = "Entfernung";
            this.Verkehrsmittel.Name = "Verkehrsmittel";
            this.Verkehrsmittel.ReadOnly = true;
            this.Verkehrsmittel.Width = 233;
            // 
            // ConnectionSelectiondataGridView
            // 
            this.ConnectionSelectiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionSelectiondataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Platform,
            this.Abfahrtsstation,
            this.Endstation,
            this.Abfahrtszeit,
            this.Ankunftszeit,
            this.Dauer,
            this.Verspätung});
            this.ConnectionSelectiondataGridView.Location = new System.Drawing.Point(24, 255);
            this.ConnectionSelectiondataGridView.Name = "ConnectionSelectiondataGridView";
            this.ConnectionSelectiondataGridView.RowTemplate.Height = 25;
            this.ConnectionSelectiondataGridView.Size = new System.Drawing.Size(743, 213);
            this.ConnectionSelectiondataGridView.TabIndex = 21;
            // 
            // btnMail
            // 
            this.btnMail.Image = global::TransportApp.Properties.Resources._666162;
            this.btnMail.Location = new System.Drawing.Point(694, 22);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(33, 33);
            this.btnMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMail.TabIndex = 23;
            this.btnMail.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::TransportApp.Properties.Resources._25694;
            this.btnHome.Location = new System.Drawing.Point(744, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 33);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 22;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(692, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNearbyStationBack
            // 
            this.btnNearbyStationBack.Location = new System.Drawing.Point(597, 487);
            this.btnNearbyStationBack.Name = "btnNearbyStationBack";
            this.btnNearbyStationBack.Size = new System.Drawing.Size(75, 23);
            this.btnNearbyStationBack.TabIndex = 24;
            this.btnNearbyStationBack.Text = "Zurück";
            this.btnNearbyStationBack.UseVisualStyleBackColor = true;
            this.btnNearbyStationBack.Click += new System.EventHandler(this.btnNearbyStationBack_Click);
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.Width = 70;
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
            this.Dauer.Width = 70;
            // 
            // Verspätung
            // 
            this.Verspätung.HeaderText = "Verspätung";
            this.Verspätung.Name = "Verspätung";
            // 
            // NearbyStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 522);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNearbyStationBack);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.ConnectionSelectiondataGridView);
            this.Controls.Add(this.NearbyStationdataGridView);
            this.Controls.Add(this.btnTakeMeHome);
            this.Controls.Add(this.btnSearchForStations);
            this.Name = "NearbyStation";
            this.Text = "Nahe Stationen";
            ((System.ComponentModel.ISupportInitialize)(this.NearbyStationdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionSelectiondataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchForStations;
        private System.Windows.Forms.Button btnTakeMeHome;
        private System.Windows.Forms.DataGridView NearbyStationdataGridView;
        private System.Windows.Forms.DataGridView ConnectionSelectiondataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
        private System.Windows.Forms.PictureBox btnMail;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn deinStandort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verkehrsmittel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNearbyStationBack;
    }
}