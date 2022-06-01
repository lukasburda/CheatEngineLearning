using System.Diagnostics;
using Memory.Win64;
using Memory.Utils;

namespace CELearningLvl2
{
    public partial class MainWindow : Form
    {
        private static readonly int[] PLAYER_HEALTH_OFFSETS = { 0x7C0, 0x28, 0x60 };
        private static readonly int[] ENEMY_ONE_HEALTH_OFFSETS = { };
        private static readonly int[] ENEMY_TWO_HEALTH_OFFSETS = { 0x7C0, 0x38, 0x60 };

        private MemoryHelper64 memory;
        private ulong baseAddress;

        private ulong playerHealthAddress;
        private ulong enemyTwoHealthAddress;

        public MainWindow()
        {
            Process[] processes = Process.GetProcessesByName("gtutorial-x86_64");
            if (processes == null | processes.Length == 0)
            {
                MessageBox.Show("gtutorial-x86_64 is not running", "Start up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            this.memory = new MemoryHelper64(processes.FirstOrDefault());
            this.baseAddress = memory.GetBaseAddress(0x3CCD20);

            this.playerHealthAddress = MemoryUtils.OffsetCalculator(memory, baseAddress, PLAYER_HEALTH_OFFSETS);
            this.enemyTwoHealthAddress = MemoryUtils.OffsetCalculator(memory, baseAddress, ENEMY_TWO_HEALTH_OFFSETS);

            InitializeComponent();
            refreshTimer.Start();
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            healthAmountLabel.Text = memory.ReadMemory<int>(playerHealthAddress).ToString();
            EnemyTwoHealthLabel.Text = memory.ReadMemory<int>(enemyTwoHealthAddress).ToString();
        }

        private void hpUpdater_Tick(object sender, EventArgs e)
        {
            memory.WriteMemory<int>(playerHealthAddress, Int32.Parse(hpTextBox.Text));
        }

        private void hpSetButton_Click(object sender, EventArgs e)
        {
            memory.WriteMemory<int>(playerHealthAddress, Int32.Parse(hpTextBox.Text));
        }

        private void hpContinuousSet_Click(object sender, EventArgs e)
        {
            if (!hpUpdater.Enabled)
            {
                hpUpdater.Start();
                hpContinuousSet.Text = "Stop setting";
            }
            else
            {
                hpUpdater.Stop();
                hpContinuousSet.Text = "Set continuously";
            }
        }

        private void enemyOneSetButton_Click(object sender, EventArgs e)
        {

        }

        private void enemyTwoSetButton_Click(object sender, EventArgs e)
        {
            memory.WriteMemory<int>(enemyTwoHealthAddress, Int32.Parse(enemyTwoHpTextBox.Text));
        }
    }
}