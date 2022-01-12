using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportApp
{
    public partial class StationMap : Form
    {

        Transport _transport = new Transport();                                             // Objekt von der Klasse Transport erstellen
        TransportApp.StationExists _stationExists = new TransportApp.StationExists();       // Objekt von eigener Klasse TransportApp erstellen

        public StationMap()
        {
            InitializeComponent();                                                               // Startet den Watcher beim Starten des Forms
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();                              // Objekt von MainMenu erstellen
            this.Close();                                               // Aktuelles Fenster schliessen
            frm.Show();                                                 // MainMenu anzeigen
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();                              // Objekt von MainMenu erstellen
            this.Close();                                               // Aktuelles Fenster schliessen
            frm.Show();                                                 // MainMenu anzeigen
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
