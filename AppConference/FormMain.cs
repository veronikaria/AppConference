namespace AppConference
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            FormSchedule form = new FormSchedule();
            form.ShowDialog();
        }

        private void buttonParticipants_Click(object sender, EventArgs e)
        {
            FormParticipants form = new FormParticipants();
            form.ShowDialog();
        }

        private void buttonEquipments_Click(object sender, EventArgs e)
        {
            FormEquipments form = new FormEquipments();
            form.ShowDialog();
        }
    }
}