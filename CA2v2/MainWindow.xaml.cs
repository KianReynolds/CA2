using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA2v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    ///https://github.com/KianReynolds/CA2
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SortTeamsANdDisplay();

            Player player = new Player();

            player.ResultRecord = "WWDDL";
            int ratings = player.Calculate();

            
            Stars(ratings);

        }

        private void SortTeamsANdDisplay()
        {
            List<Team> teams = GetTeams();
            teams.Sort();
            teams.Reverse();

            lbxTeams.ItemsSource = teams;
        }

        public List<Team> GetTeams()
        {
            Team t1 = new Team() { Name = "France" };
            Team t2 = new Team() { Name = "Italy" };
            Team t3 = new Team() { Name = "Spain" };

            List<Team> teams = new List<Team>() { t1, t2, t3 };

            //French players
            Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
            Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

            //Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

            //Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };

            t1.Players.Add(p1);
            t1.Players.Add(p2);
            t1.Players.Add(p3);

            t2.Players.Add(p4);
            t2.Players.Add(p5);
            t2.Players.Add(p6);

            t3.Players.Add(p7);
            t3.Players.Add(p8);
            t3.Players.Add(p9);

            return teams;
            
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check what team has been selected

            Team selectedTeam = lbxTeams.SelectedItem as Team;

            //make sure it's not null
            if(selectedTeam != null)
            {
                //diplay the players from that team
                lbxPlayers.ItemsSource = selectedTeam.Players;
            }



        }

        

        private void btnWin_Click(object sender, RoutedEventArgs e)
        {
            UpdateWin('W');
        }

        private void UpdateWin(char newLetter)
        {
            Player playerChosen = lbxPlayers.SelectedItem as Player;
            if (playerChosen != null)
            {
                string newCount = playerChosen.ResultRecord.Substring(1) + newLetter;
                playerChosen.ResultRecord = newCount;

                Team teamChosen = lbxTeams.SelectedItem as Team;
                if (teamChosen != null)
                {
                    lbxPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = teamChosen.Players;
                    lbxPlayers.SelectedItem = playerChosen;

                    List<Team> teams = lbxTeams.ItemsSource as List<Team>;
                    teams.Sort();
                    teams.Reverse();
                    lbxTeams.ItemsSource = null;
                    lbxTeams.ItemsSource = teams;
                    lbxTeams.SelectedItem = teamChosen;


                }
            }
        }



        private void Stars(int rating)
        {
            imgStar1.Source = new BitmapImage(new Uri("/Images/staroutline.png", UriKind.Relative));
            imgStar2.Source = new BitmapImage(new Uri("/Images/staroutline.png", UriKind.Relative));
            imgStar3.Source = new BitmapImage(new Uri("/Images/staroutline.png", UriKind.Relative));

            if(rating >  0)
            {
                imgStar1.Source = new BitmapImage(new Uri("/Images/starsolid.png", UriKind.Relative));
            }
            if (rating > 5)
            {
                imgStar2.Source = new BitmapImage(new Uri("/Images/starsolid.png", UriKind.Relative));
            }
            if (rating > 10)
            {
                imgStar3.Source = new BitmapImage(new Uri("/Images/starsolid.png", UriKind.Relative));
            }

        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            UpdateDraw('D');
        }

        private void UpdateDraw(char newLetter)
        {
            Player playerChosen = lbxPlayers.SelectedItem as Player;
            if (playerChosen != null)
            {
                string newCount = playerChosen.ResultRecord.Substring(1) + newLetter;
                playerChosen.ResultRecord = newCount;

                Team teamChosen = lbxTeams.SelectedItem as Team;
                if (teamChosen != null)
                {
                    lbxPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = teamChosen.Players;
                    lbxPlayers.SelectedItem = playerChosen;

                    List<Team> teams = lbxTeams.ItemsSource as List<Team>;
                    teams.Sort();
                    teams.Reverse();
                    lbxTeams.ItemsSource = null;
                    lbxTeams.ItemsSource = teams;
                    lbxTeams.SelectedItem = teamChosen;


                }
            }
        }

        private void btnLoss1_Click(object sender, RoutedEventArgs e)
        {
            UpdateLoss('L');
        }

        private void UpdateLoss(char newLetter)
        {
            Player playerChosen = lbxPlayers.SelectedItem as Player;
            if (playerChosen != null)
            {
                string newCount = playerChosen.ResultRecord.Substring(1) + newLetter;
                playerChosen.ResultRecord = newCount;

                Team teamChosen = lbxTeams.SelectedItem as Team;
                if (teamChosen != null)
                {
                    lbxPlayers.ItemsSource = null;
                    lbxPlayers.ItemsSource = teamChosen.Players;
                    lbxPlayers.SelectedItem = playerChosen;

                    List<Team> teams = lbxTeams.ItemsSource as List<Team>;
                    teams.Sort();
                    teams.Reverse();
                    lbxTeams.ItemsSource = null;
                    lbxTeams.ItemsSource = teams;
                    lbxTeams.SelectedItem = teamChosen;


                }
            }
        }
    }
}
