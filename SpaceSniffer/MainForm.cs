
namespace SpaceSniffer
{
    public partial class MainForm : Form
    {
        Thread _workerThread;
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var hardDisk = DriveInfo.GetDrives();
            foreach (var disk in hardDisk) {
                HardDiskComboBox.Items.Add(disk.Name);
            }
        }

        private void startButton_Click(object sender, EventArgs e) {
            var disk = HardDiskComboBox.SelectedItem.ToString();
            _workerThread = new Thread(HardDiskSpaceCalculate);
            _workerThread.Start(disk);
        }

        private void stopButton_Click(object sender, EventArgs e) {
            _workerThread?.Abort();
        }
        private void HardDiskSpaceCalculate(object? obj) {
            var disk = obj?.ToString();
            var dir = new DirectoryInfo(disk);
            var data = DirSize(dir);
            this.BeginInvoke(new Action(() => {

                foreach (var diskSpace in data.SubDirs) {
                    var root = treeView1.Nodes.Add(diskSpace.Name + " " + diskSpace.TotalSizeText);
                    AddTreeNodes(root, diskSpace);
                }

            }));
        }


        public DirectorySpace DirSize(DirectoryInfo d) {
            long size = 0;
            var dirSpace = new DirectorySpace();
            dirSpace.Name = d.Name;
            dirSpace.SubDirs = new List<DirectorySpace>();

            try {
                FileInfo[] fis = d.GetFiles();
                foreach (FileInfo fi in fis) {
                    dirSpace.Size += fi.Length;
                }
                dirSpace.TotalSize = dirSpace.Size;

                DirectoryInfo[] dis = d.GetDirectories();
                foreach (DirectoryInfo di in dis) {

                    var subDir = DirSize(di);
                    dirSpace.TotalSize += subDir.TotalSize;
                    dirSpace.SubDirs.Add(subDir);
                }
            }
            catch (Exception ex) {

            }

            return dirSpace;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            foreach(TreeNode node in e.Node.Nodes) {

                var diskSpace = (DirectorySpace)node.Tag;
                AddTreeNodes(node, diskSpace);
            }
        }

        private void AddTreeNodes(TreeNode parent, DirectorySpace spaceData) {
            foreach (var diskSpace in spaceData.SubDirs) {
                var node = parent.Nodes.Add(diskSpace.Name + " " + diskSpace.TotalSizeText);
                node.Tag = diskSpace;
               
            }
        }
    }
}
