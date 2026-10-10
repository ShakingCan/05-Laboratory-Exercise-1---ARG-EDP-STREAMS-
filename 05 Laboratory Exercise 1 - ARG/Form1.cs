namespace _05_Laboratory_Exercise_1___ARG
{
    public partial class FrmLab1 : Form
    {
        FrmFileName f;
        FrmRegistration r;
        public FrmLab1()
        {
            InitializeComponent();
            f = new FrmFileName();
            f.ShowDialog();
             r= new FrmRegistration();
            r.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {

            String getInput = inputbox.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {

                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);

            }
            MessageBox.Show("Created");
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
