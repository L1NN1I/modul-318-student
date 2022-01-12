namespace TransportApp
{
    partial class StationMap
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDepartureStation = new System.Windows.Forms.Label();
            this.StationgMapControl = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(615, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::TransportApp.Properties.Resources._25694;
            this.btnHome.Location = new System.Drawing.Point(714, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 33);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 20;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(332, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 23);
            this.textBox1.TabIndex = 18;
            // 
            // lblDepartureStation
            // 
            this.lblDepartureStation.AutoSize = true;
            this.lblDepartureStation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureStation.Location = new System.Drawing.Point(53, 24);
            this.lblDepartureStation.Name = "lblDepartureStation";
            this.lblDepartureStation.Size = new System.Drawing.Size(63, 20);
            this.lblDepartureStation.TabIndex = 17;
            this.lblDepartureStation.Text = "Station: ";
            // 
            // StationgMapControl
            // 
            this.StationgMapControl.Bearing = 0F;
            this.StationgMapControl.CanDragMap = true;
            this.StationgMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.StationgMapControl.GrayScaleMode = false;
            this.StationgMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.StationgMapControl.LevelsKeepInMemory = 5;
            this.StationgMapControl.Location = new System.Drawing.Point(17, 82);
            this.StationgMapControl.MarkersEnabled = true;
            this.StationgMapControl.MaxZoom = 2;
            this.StationgMapControl.MinZoom = 2;
            this.StationgMapControl.MouseWheelZoomEnabled = true;
            this.StationgMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.StationgMapControl.Name = "StationgMapControl";
            this.StationgMapControl.NegativeMode = false;
            this.StationgMapControl.PolygonsEnabled = true;
            this.StationgMapControl.RetryLoadTile = 0;
            this.StationgMapControl.RoutesEnabled = true;
            this.StationgMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.StationgMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.StationgMapControl.ShowTileGridLines = false;
            this.StationgMapControl.Size = new System.Drawing.Size(766, 310);
            this.StationgMapControl.TabIndex = 23;
            this.StationgMapControl.Zoom = 0D;
            // 
            // StationMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StationgMapControl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDepartureStation);
            this.Name = "StationMap";
            this.Text = "Standort auf Karte anzeigen";
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDepartureStation;
        private GMap.NET.WindowsForms.GMapControl StationgMapControl;
    }
}