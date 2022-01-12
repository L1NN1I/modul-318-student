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
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.btnZurück = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDepartureStation = new System.Windows.Forms.Label();
            this.StationgMapControl = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(713, 415);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(75, 23);
            this.btnSchliessen.TabIndex = 22;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            // 
            // btnZurück
            // 
            this.btnZurück.Location = new System.Drawing.Point(615, 415);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(75, 23);
            this.btnZurück.TabIndex = 21;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransportApp.Properties.Resources._25694;
            this.pictureBox1.Location = new System.Drawing.Point(714, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDepartureStation);
            this.Name = "StationMap";
            this.Text = "Standort auf Karte anzeigen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.Button btnZurück;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDepartureStation;
        private GMap.NET.WindowsForms.GMapControl StationgMapControl;
    }
}