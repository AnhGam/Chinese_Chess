namespace CoTuong
{
    public partial class ModeSelectForm : Form
    {
        private Form? _parentForm;
        public ModeSelectForm()
        {
            InitializeComponent();
        }

        public ModeSelectForm(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ModeBack_Click(object sender, EventArgs e)
        {
            _parentForm?.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameForm gForm = new GameForm();
            gForm.Show();
            this.Close();
        }
    }
}
