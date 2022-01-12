namespace TransportApp
{
    partial class DepartureList
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxStation = new System.Windows.Forms.TextBox();
            this.lblDepartureStation = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDepartureListBack = new System.Windows.Forms.Button();
            this.StationBoardDataGrid = new System.Windows.Forms.DataGridView();
            this.Abfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationBoardDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(307, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxStation
            // 
            this.tbxStation.Location = new System.Drawing.Point(100, 35);
            this.tbxStation.Name = "tbxStation";
            this.tbxStation.Size = new System.Drawing.Size(173, 23);
            this.tbxStation.TabIndex = 9;
            // 
            // lblDepartureStation
            // 
            this.lblDepartureStation.AutoSize = true;
            this.lblDepartureStation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureStation.Location = new System.Drawing.Point(31, 34);
            this.lblDepartureStation.Name = "lblDepartureStation";
            this.lblDepartureStation.Size = new System.Drawing.Size(63, 20);
            this.lblDepartureStation.TabIndex = 8;
            this.lblDepartureStation.Text = "Station: ";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::TransportApp.Properties.Resources._25694;
            this.btnHome.Location = new System.Drawing.Point(569, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 33);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 15;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(537, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDepartureListBack
            // 
            this.btnDepartureListBack.Location = new System.Drawing.Point(442, 400);
            this.btnDepartureListBack.Name = "btnDepartureListBack";
            this.btnDepartureListBack.Size = new System.Drawing.Size(75, 23);
            this.btnDepartureListBack.TabIndex = 17;
            this.btnDepartureListBack.Text = "Zurück";
            this.btnDepartureListBack.UseVisualStyleBackColor = true;
            this.btnDepartureListBack.Click += new System.EventHandler(this.btnDepartureListBack_Click);
            // 
            // StationBoardDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StationBoardDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StationBoardDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationBoardDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtsstation,
            this.Ankunftsstation,
            this.Verkehrsmittel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StationBoardDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.StationBoardDataGrid.Location = new System.Drawing.Point(22, 93);
            this.StationBoardDataGrid.Name = "StationBoardDataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StationBoardDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StationBoardDataGrid.RowTemplate.Height = 25;
            this.StationBoardDataGrid.Size = new System.Drawing.Size(605, 279);
            this.StationBoardDataGrid.TabIndex = 19;
            // 
            // Abfahrtsstation
            // 
            this.Abfahrtsstation.HeaderText = "Abfahrtsstation";
            this.Abfahrtsstation.Name = "Abfahrtsstation";
            this.Abfahrtsstation.ReadOnly = true;
            this.Abfahrtsstation.Width = 185;
            // 
            // Ankunftsstation
            // 
            this.Ankunftsstation.HeaderText = "Ankunftsstation";
            this.Ankunftsstation.Name = "Ankunftsstation";
            this.Ankunftsstation.ReadOnly = true;
            this.Ankunftsstation.Width = 185;
            // 
            // Verkehrsmittel
            // 
            this.Verkehrsmittel.HeaderText = "Verkehrsmittel";
            this.Verkehrsmittel.Name = "Verkehrsmittel";
            this.Verkehrsmittel.ReadOnly = true;
            this.Verkehrsmittel.Width = 185;
            // 
            // DepartureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.StationBoardDataGrid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDepartureListBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxStation);
            this.Controls.Add(this.lblDepartureStation);
            this.Name = "DepartureList";
            this.Text = "Stationsverbindungen";
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationBoardDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxStation;
        private System.Windows.Forms.Label lblDepartureStation;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDepartureListBack;
        private System.Windows.Forms.DataGridView StationBoardDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verkehrsmittel;
    }
}