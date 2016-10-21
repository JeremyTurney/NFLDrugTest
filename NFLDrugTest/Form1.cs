using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFLDrugTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//var playerList = new List<string>(new[] { "Von Miller", "Randy Gregory", "Justin Blackmon", "Josh Gordon", "LaRon Landry", "Aldon Smith", "Antonio Gates", "Adam 'Pacman' Jones", "Le'Veon Bell", "Dwayne Bowe", "Aqib Talib", "Matt Prater", "Tamba Hali", "Haloti Ngata", "Da'Quan Bowers", "Nick Boyle" });
			play = new[] { "Von Miller", "Randy Gregory", "Justin Blackmon", "Josh Gordon", "LaRon Landry", "Aldon Smith", "Antonio Gates", "Adam 'Pacman' Jones", "Le'Veon Bell", "Dwayne Bowe", "Aqib Talib", "Matt Prater", "Tamba Hali", "Haloti Ngata", "Da'Quan Bowers", "Nick Boyle" };

		}
		private static string[] play; //= { "Von Miller", "Randy Gregory", "Justin Blackmon", "Josh Gordon", "LaRon Landry", "Aldon Smith", "Antonio Gates", "Adam 'Pacman' Jones", "Le'Veon Bell", "Dwayne Bowe", "Aqib Talib", "Matt Prater", "Tamba Hali", "Haloti Ngata", "Da'Quan Bowers", "Nick Boyle" };

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void NumCandidates_KeyPress(object sender, KeyPressEventArgs e)
		{
			char key = e.KeyChar;

			if (!char.IsDigit(key) && key != 8 && key != 46)
			{
				e.Handled = true;
				MessageBox.Show("Please enter a valid number");
			}
		}

		private void Start_Click(object sender, EventArgs e)
		{
			//int choose = Convert.ToInt32(NumCandidates.Text);
			Random rand = new Random();
			//string[] play = {"Von Miller", "Randy Gregory", "Justin Blackmon", "Josh Gordon", "LaRon Landry", "Aldon Smith", "Antonio Gates", "Adam 'Pacman' Jones", "Le'Veon Bell", "Dwayne Bowe", "Aqib Talib", "Matt Prater", "Tamba Hali", "Haloti Ngata", "Da'Quan Bowers", "Nick Boyle" };
			var playerList = new List<string>(play);
			//String [] play = {"Von Miller", "Randy Gregory", "Justin Blackmon", "Josh Gordon", "LaRon Landry", "Aldon Smith", "Antonio Gates", "Adam 'Pacman' Jones", "Le'Veon Bell", "Dwayne Bowe", "Aqib Talib", "Matt Prater", "Tamba Hali", "Haloti Ngata", "Da'Quan Bowers", "Nick Boyle" };
			//public static List<String> Players = new List<String>();
			var players = new List<string>();
			//int index = rand.Next(playerList.Count);
			int counter = playerList.Count;
			// bool help = false;

			

			int choose = Convert.ToInt32(NumCandidates.Text);

			if (choose <=0)
			{
				MessageBox.Show("Please enter a correct number of candidates");
			}

			else if(choose > counter)
			{
				MessageBox.Show("The number you chose was too big. There are only " + counter + " candidates to choose from");
				choose = counter;
			}

			for (int i = 0; i < choose; i++)
			{
				int index = rand.Next(playerList.Count - 1);
				var player = playerList[index];
				playerList.Remove(player);
				players.Add(player);


			}

			Selections.Text = "";

			foreach (string data in players)
			{
				Selections.Text += data + "\r\n";
			}


		
		//Selections.Text = players;

	}

	private void Reset_Click(object sender, EventArgs e)
	{
			foreach (Control c in Selection.Controls)
			{
				if (c is TextBox)
				{
					c.Text = string.Empty;
				}
			}

			NumCandidates.Text = string.Empty;
		}
	}
}
