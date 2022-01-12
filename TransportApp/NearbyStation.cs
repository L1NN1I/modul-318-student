using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class NearbyStation : Form
    {
        Transport _transport = new Transport();                                                         // Objekte von Klassen erzeugen
        Connections _connections = new Connections(); 

        string _location1 = IpAufruf.GetUserLocationyByIp("85.1.157.112");
        string _coordinates1 = IpAufruf.GetUserCoordinatesByIp("85.1.157.112");
        //string _location2 = IpAufruf.GetUserLocationyByIp("85.3.28.31");
        //string _coordinates2 = IpAufruf.GetUserCoordinatesByIp("85.3.28.31");



        private string _home = "Buttisholz, Dorf";                                             // Mein Standort der Firma, damit ich nur "Take Me Home" klicken muss

        public NearbyStation()
        {
            InitializeComponent();
        }

        private void btnNearbyStationBack_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();                              // Objekt von MainMenu erstellen
            this.Close();                                               // Aktuelles Fenster schliessen
            frm.Show();                                                 // MainMenu anzeigen
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();                              // Objekt von MainMenu erstellen
            this.Close();                                               // Aktuelles Fenster schliessen
            frm.Show();                                                 // MainMenu anzeigen
        }

        private void btnSearchForStations_Click(object sender, EventArgs e)
        {
            NearbyStationdataGridView.Rows.Clear();
            ConnectionSelectiondataGridView.Rows.Clear();
            ITransport transport = new Transport();
            try
            {
                Station station = transport.GetStations(_location1).StationList.ElementAt(0);
                Console.WriteLine(station);
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }
        private void FillDataGridView(Stations stations)
        {
            ITransport transport = new Transport();

            foreach (Station station in stations.StationList)
            {
                NearbyStationdataGridView.Rows.Add(_coordinates1, station.Name, station.Distance + " m");
            }

            string yourGps = stations.StationList.First().Name.ToString();                              // DataGrid mit den Stationen füllen
            NearbyStationdataGridView.Rows.Clear();
            foreach (Station station in stations.StationList)
            {
                NearbyStationdataGridView.Rows.Add(yourGps, station.Name, station.Distance + " m");
            }
        }

        private void btnTakeMeHome_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
                var connection = transport.GetConnections(_location1, _home);
                foreach (Connection conn in connection.ConnectionList)
                {
                    int addRow = ConnectionSelectiondataGridView.Rows.Add();
                    ConnectionSelectiondataGridView.Rows[addRow].Cells[0].Value = conn.From.Platform;
                    ConnectionSelectiondataGridView.Rows[addRow].Cells[1].Value = conn.From.Station.Name;
                    ConnectionSelectiondataGridView.Rows[addRow].Cells[2].Value = conn.To.Station.Name;
                    ConnectionSelectiondataGridView.Rows[addRow].Cells[3].Value = conn.From.Departure;
                    ConnectionSelectiondataGridView.Rows[addRow].Cells[4].Value = conn.To.Arrival;
                    ConnectionSelectiondataGridView.Rows[addRow].Cells[5].Value = conn.Duration;
                    ConnectionSelectiondataGridView.Rows[addRow].Cells[6].Value = conn.From.Delay + " Minute(n)";
            }
        }

        private void FillDataGridViewConnections()
        {
            ConnectionSelectiondataGridView.Rows.Clear();       //Datagrid leeren
            int i = 0;

            foreach (Connection connection in _connections.ConnectionList)
            {
                DateTime DateDeparture = Convert.ToDateTime(connection.From.Departure);                 //Datagrid mit den Verbindungen befüllen   
                DateTime DateArrival = Convert.ToDateTime(connection.To.Arrival);
                string xCoordinate = connection.From.Station.Coordinate.ToString();
                string Platform = "";
                if (connection.From.Platform != null)
                {
                    Platform = connection.From.Platform.ToString();
                }
                else
                {
                    Platform = "Keine Angabe";
                }
                if (connection.From.Delay == null)
                {
                    connection.From.Delay = 0;
                }

                if (i <= 4)
                {
                    ConnectionSelectiondataGridView.Rows.Add(
                    Platform,
                    connection.From.Station.Name,
                    connection.To.Station.Name,
                    DateDeparture,
                    DateArrival,
                    connection.Duration.Substring(startIndex: 3, length: 5),
                    connection.From.Delay + " Minute");

                    i++;
                }

            }
        }
    }
}
