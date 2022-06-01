using System.Diagnostics;
using Memory.Win64;
using Memory.Utils;

namespace CELearningLvl1
{
    public partial class MainWindow : Form
    {
        private static readonly String PROCESS_NAME = "gtutorial-x86_64";
        private static readonly int[] ENEMY_HEALTH_OFFSETS = { 0x7C0, 0x30, 0x70 };

        private MemoryHelper64 memory;
        
        private ulong baseAddress;
        private ulong enemyHealthAddress;

        public MainWindow()
        {
            Process[] processes = Process.GetProcessesByName(PROCESS_NAME);
            if (processes == null | processes.Length == 0)
            {
                MessageBox.Show(PROCESS_NAME + " is not running", "Start up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            this.memory = new MemoryHelper64(processes.FirstOrDefault());
            this.baseAddress = memory.GetBaseAddress(0x3CCD20);
            this.enemyHealthAddress = MemoryUtils.OffsetCalculator(memory, baseAddress, ENEMY_HEALTH_OFFSETS);

            InitializeComponent();
        }

        private void enemyHpSetButton_Click(object sender, EventArgs e)
        {
            memory.WriteMemory<int>(enemyHealthAddress, 1);
        }
    }
}