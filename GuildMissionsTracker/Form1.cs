namespace GuildMissionsTracker
{
    public partial class Form1 : Form
    {
        // Server name, number of servers
        private Dictionary<string, int> _servers = new Dictionary<string, int> 
        {
            //{ "Rulupee", 1 },
            { "Balenos", 6 },
            { "Valencia", 6 },
            { "Mediah", 6 },
            { "Calpheon", 6 },
            //{ "Arsha", 1 },
            { "Kamasylvia", 6 },
            { "Serendia", 6 }
        };

        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            groupBox_ServerList.AutoSize = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var server in _servers)
            {
                var serverGroupBox = new GroupBox();
                serverGroupBox.Anchor = AnchorStyles.Left;
                serverGroupBox.Dock = DockStyle.Left;
                serverGroupBox.Text = server.Key;

                for(int serverNumber = 0; serverNumber < server.Value; serverNumber++)
                {
                    var serverInfo = $"{server.Key}_{serverNumber + 1}";
                    var button = new Button();
                    
                    button.Text = serverInfo;
                    button.Name = $"button_{serverInfo}";
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;

                    button.Anchor = AnchorStyles.Top;
                    button.Dock = DockStyle.Top;

                    button.Click += (sender, e) =>
                    {
                        var selectedMissionType = groupBox_MissionTypes.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);
                        button.BackColor = ColorForMissionType(button, selectedMissionType == null ? "" : selectedMissionType.Text);
                    };

                    serverGroupBox.Controls.Add(button);
                }

                groupBox_ServerList.Controls.Add(serverGroupBox);
            }
        }

        private Color ColorForMissionType(Button button, string missionType)
        {
            var colourOutcome = new Color();
            if (missionType == "Lifeskill")
                colourOutcome = Color.Green;
            else if (missionType == "PvE")
                colourOutcome = Color.DarkRed;
            else 
                colourOutcome = Color.Black;

            if(button.BackColor != colourOutcome || button.BackColor == Color.Black) // reset colour, could check if mission type is different to current colour 
            {
                return colourOutcome;
            }

            return Color.Black;
        }

        private void button_ResetAllServersList_Click(object sender, EventArgs e)
        {
            var serverGroupBoxes = groupBox_ServerList.Controls.OfType<GroupBox>().ToList();
            foreach (var serverGroupBox in serverGroupBoxes)
            {
                foreach(var button in serverGroupBox.Controls.OfType<Button>())
                {
                    button.BackColor = Color.Black;
                }
            }
        }

        private void groupBox_ServerList_Enter(object sender, EventArgs e)
        {

        }
    }
}