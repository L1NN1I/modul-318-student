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
//using System.Device.Location;


namespace TransportApp
{
    public partial class StationMap : Form
    {
        //GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();                         // Objekt für Standortbestimmung erzeugen
        Transport _transport = new Transport();                                             // Objekt von der Klasse Transport erstellen
        TransportApp.StationExists _stationExists = new TransportApp.StationExists();       // Objekt von eigener Klasse TransportApp erstellen

        //private double x = 0.0;                                                             // Globale variable für Breiten- und Längengrad
        //private double y = 0.0;
        public StationMap()
        {
            InitializeComponent();                                                               // Startet den Watcher beim Starten des Forms
        }

        private void StationMap_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
