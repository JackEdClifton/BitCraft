using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RandomTeamPicker {
    public partial class Window : Form {

        public static Random random = new Random();

        public Window() {
            InitializeComponent();
        }

        private void randomize_Click(object sender, EventArgs e) {
            string[] names = System.Text.RegularExpressions.Regex.Split(nameInput.Text, Environment.NewLine);
            List<string> players = new List<string>(names);

            teamBlue.Text = "";
            teamOrange.Text = "";

            // make fair teams
            int totalPlayers = players.Count - (players.Count % 2);
            for (int i = 0; i < totalPlayers; i++) {

                // get random player
                int index = random.Next(0, players.Count);
                string player = players[index];
                players.RemoveAt(index);

                // add to team
                if (i % 2 == 0) { teamBlue.Text += player + Environment.NewLine; }
                else { teamOrange.Text += player + Environment.NewLine; }
            }
            // add extra player to random team
            if (players.Count > 0) {
                int team = random.Next(0, 2);
                if (team == 0) { teamBlue.Text += players[0] + Environment.NewLine; }
                if (team == 1) { teamOrange.Text += players[0] + Environment.NewLine; }
            }
        }

        private void screenshot_Click(object sender, EventArgs e) {
            SendKeys.Send("%{PRTSC}");
        }
    }
}
