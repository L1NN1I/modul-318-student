
namespace TransportApp
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainMenuSearchConnection = new System.Windows.Forms.Button();
            this.btnMainMenuNavigation = new System.Windows.Forms.Button();
            this.btnDepartureList = new System.Windows.Forms.Button();
            this.btnMainMenuNearbyStations = new System.Windows.Forms.Button();
            this.btnMainMenuAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Was wollen Sie machen?";
            // 
            // btnMainMenuSearchConnection
            // 
            this.btnMainMenuSearchConnection.Location = new System.Drawing.Point(83, 97);
            this.btnMainMenuSearchConnection.Name = "btnMainMenuSearchConnection";
            this.btnMainMenuSearchConnection.Size = new System.Drawing.Size(245, 45);
            this.btnMainMenuSearchConnection.TabIndex = 1;
            this.btnMainMenuSearchConnection.Text = "Verbindung Suchen";
            this.btnMainMenuSearchConnection.UseVisualStyleBackColor = true;
            this.btnMainMenuSearchConnection.Click += new System.EventHandler(this.btnMainMenuSearchConnection_Click);
            // 
            // btnMainMenuNavigation
            // 
            this.btnMainMenuNavigation.Location = new System.Drawing.Point(83, 161);
            this.btnMainMenuNavigation.Name = "btnMainMenuNavigation";
            this.btnMainMenuNavigation.Size = new System.Drawing.Size(245, 45);
            this.btnMainMenuNavigation.TabIndex = 2;
            this.btnMainMenuNavigation.Text = "Navigation";
            this.btnMainMenuNavigation.UseVisualStyleBackColor = true;
            this.btnMainMenuNavigation.Click += new System.EventHandler(this.btnMainMenuNavigation_Click);
            // 
            // btnDepartureList
            // 
            this.btnDepartureList.Location = new System.Drawing.Point(83, 227);
            this.btnDepartureList.Name = "btnDepartureList";
            this.btnDepartureList.Size = new System.Drawing.Size(245, 45);
            this.btnDepartureList.TabIndex = 3;
            this.btnDepartureList.Text = "Abfahrtstafel";
            this.btnDepartureList.UseVisualStyleBackColor = true;
            this.btnDepartureList.Click += new System.EventHandler(this.btnDepartureList_Click);
            // 
            // btnMainMenuNearbyStations
            // 
            this.btnMainMenuNearbyStations.Location = new System.Drawing.Point(83, 289);
            this.btnMainMenuNearbyStations.Name = "btnMainMenuNearbyStations";
            this.btnMainMenuNearbyStations.Size = new System.Drawing.Size(245, 45);
            this.btnMainMenuNearbyStations.TabIndex = 4;
            this.btnMainMenuNearbyStations.Text = "Nahe Stationen";
            this.btnMainMenuNearbyStations.UseVisualStyleBackColor = true;
            this.btnMainMenuNearbyStations.Click += new System.EventHandler(this.btnMainMenuNearbyStations_Click);
            // 
            // btnMainMenuAbort
            // 
            this.btnMainMenuAbort.Location = new System.Drawing.Point(155, 353);
            this.btnMainMenuAbort.Name = "btnMainMenuAbort";
            this.btnMainMenuAbort.Size = new System.Drawing.Size(98, 35);
            this.btnMainMenuAbort.TabIndex = 5;
            this.btnMainMenuAbort.Text = "Abbrechen";
            this.btnMainMenuAbort.UseVisualStyleBackColor = true;
            this.btnMainMenuAbort.Click += new System.EventHandler(this.btnMainMenuAbort_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 445);
            this.Controls.Add(this.btnMainMenuAbort);
            this.Controls.Add(this.btnMainMenuNearbyStations);
            this.Controls.Add(this.btnDepartureList);
            this.Controls.Add(this.btnMainMenuNavigation);
            this.Controls.Add(this.btnMainMenuSearchConnection);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Hauptmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainMenuSearchConnection;
        private System.Windows.Forms.Button btnMainMenuNavigation;
        private System.Windows.Forms.Button btnDepartureList;
        private System.Windows.Forms.Button btnMainMenuNearbyStations;
        private System.Windows.Forms.Button btnMainMenuAbort;
    }
}

