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
    public partial class DepartureList : Form
    {
        private ITransport _transport = new Transport();                                          // Instanz der Transport Klasse erstellen
        TransportApp.StationExists _stationExists = new TransportApp.StationExists();             // Von eigener Klasse ein Objekt stationexists erzeugen

        public DepartureList()
        {
            InitializeComponent();
            try
            {
                //stationBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                //stationBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();      // Objekt von MainMenu erstellen:
            frm.Show();                         // MainMenu anzeigen
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FillDataGridView(StationBoardRoot stationBoardRoot)
        {
            StationBoardDataGrid.Rows.Clear();
            foreach (StationBoard stationBoard in stationBoardRoot.Entries)                         // Die erhaltenen Stationen ins DataGridView füllen
            {
                StationBoardDataGrid.Rows.Add(
                    stationBox.Text,
                    stationBoard.To,
                    stationBoard.Name
                );
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
          {
              MainMenu frm = new MainMenu();                          // Objekt von MainMenu erstellen:
              frm.Show();                                             // MainMenu anzeigen
              this.Hide();
          }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (stationBox.Text != "")                                                        // Validation der Station
                {
                    if (_stationExists.Station(stationBox.Text))
                    {
                        StationBoardRoot stationBoardRoot = new StationBoardRoot();                       // Wert der eingegebener Station der Funktion "GetStationBoard" übergeben
                        stationBoardRoot = _transport.GetStationBoard(stationBox.Text, "");
                        FillDataGridView(stationBoardRoot);
                    }
                    else
                    {
                        MessageBox.Show("Station existiert nicht");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte das Feld 'Station' ausfüllen");
                }
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (stationBox.Text != "")                                                        // Validation der Station
                {
                    if (_stationExists.Station(stationBox.Text))
                    {
                        StationBoardRoot stationBoardRoot = new StationBoardRoot();                       // Wert der eingegebener Station der Funktion "GetStationBoard" übergeben
                        stationBoardRoot = _transport.GetStationBoard(stationBox.Text, "");
                        FillDataGridView(stationBoardRoot);
                    }
                    else
                    {
                        MessageBox.Show("Station existiert nicht");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte das Feld 'Station' ausfüllen");
                }
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
