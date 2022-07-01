using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketAcademy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.NewStudent s = new Student.NewStudent();
            s.ShowDialog();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.View_Students s = new Student.View_Students();
            s.ShowDialog();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.PettyCash c = new Account.PettyCash();
            c.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void stockItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory.Stock s = new Inventory.Stock();
            s.ShowDialog();
        }

        private void performToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory.Stock_Manipulation s = new Inventory.Stock_Manipulation();
            s.ShowDialog();
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventory.View_Operations vm = new Inventory.View_Operations();
            vm.ShowDialog();
        }

        private void skillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.Skills s = new Student.Skills();
            s.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.View_Users u = new User.View_Users();
            u.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Please backup the database before exit.");
            this.FormClosing -= MainForm_FormClosing;
            Application.Exit();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Match_Info.Add_Scores s = new Match_Info.Add_Scores();
            s.ShowDialog();
        }

        private void viewAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Match_Info.Info i = new Match_Info.Info();
            i.ShowDialog();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dateConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.DateConverter dc = new Utility.DateConverter();
            dc.ShowDialog();
        }

        private void backupDatabaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void nepaliDateUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Nepali_Date_Insertion ins = new Settings.Nepali_Date_Insertion();
            ins.ShowDialog();
        }

        private void billGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CricketAcademy.Account.BillGeneration.BillDetails ds = new Account.BillGeneration.BillDetails();
            ds.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournament.TournamentSetup setup = new Tournament.TournamentSetup();
            setup.ShowDialog();
        }

        private void viewAllToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tournament.AllTournaments all = new Tournament.AllTournaments();
            all.ShowDialog();
        }

        private void addTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournament.Add_Team team = new Tournament.Add_Team();
            team.ShowDialog();
        }

        private void viewTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournament.All_Teams all = new Tournament.All_Teams();
            all.ShowDialog();
        }

        private void matchSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournament.MatchSummary ms = new Tournament.MatchSummary();
            ms.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
