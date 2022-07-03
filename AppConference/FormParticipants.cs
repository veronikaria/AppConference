using System.Data;

namespace AppConference
{
    public partial class FormParticipants : Form
    {
        public FormParticipants()
        {
            InitializeComponent();
        }

        private void comboBoxConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConference.SelectedIndex != -1)
                buttonFind.Visible = true;
            else
                buttonFind.Visible = false;
        }

        private void FormParticipants_Load(object sender, EventArgs e)
        {
            using (var context = new ConferenceDbContext())
            {
                var speakers = from speaker in context.Speakers
                               select new
                               {
                                   Id = speaker.SpeakerId,
                                   FIO = speaker.Lastname + " " + speaker.Firstname + " " + speaker.Middlename,
                                   speaker.Work,
                                   speaker.Degree,
                                   speaker.PostName,
                                   speaker.Biography
                               };

                var confItems = from conference in context.Conferences
                                select new
                                {
                                    conference.Name
                                };

                comboBoxConference.DataSource = confItems.ToList();
                comboBoxConference.DisplayMember = "Name";
                comboBoxConference.ValueMember = "Name";
                comboBoxConference.SelectedIndex = -1;

                dataGridView1.DataSource = speakers.ToList();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (i == 0)
                        dataGridView1.Columns[i].Width = 50;
                    else
                        dataGridView1.Columns[i].Width = 200;
                }
            }

            toolStripItem1.Text = "Детальніше";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);
            ContextMenuStrip strip = new ContextMenuStrip();
            int index = dataGridView1.ColumnCount - 1;
            dataGridView1.Columns[index].ContextMenuStrip = strip;
            dataGridView1.Columns[index].ContextMenuStrip.Items.Add(toolStripItem1);
        }

        ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();

        private void toolStripItem1_Click(object sender, EventArgs args)
        {
            int indexRow = dataGridView1.SelectedCells[0].RowIndex;
            MessageBox.Show(dataGridView1.Rows[indexRow].Cells[5].Value.ToString());
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (comboBoxConference.SelectedIndex != -1)
            {
                string conferenceName = comboBoxConference.SelectedValue.ToString();
                using (var context = new ConferenceDbContext())
                {
                    var speakers = from conference in context.Conferences
                                   join section in context.Sections on conference.ConferenceId equals section.ConferenceId
                                   join performance in context.Performances on section.SectionId equals performance.SectionId
                                   join speaker in context.Speakers on performance.SpeakerId equals speaker.SpeakerId
                                   where conference.Name == conferenceName
                                   select new
                                   {
                                       Id = speaker.SpeakerId,
                                       FIO = speaker.Lastname + " " + speaker.Firstname + " " + speaker.Middlename,
                                       speaker.Work,
                                       speaker.Degree,
                                       speaker.PostName,
                                       speaker.Biography
                                   };
                    dataGridView1.DataSource = speakers.Distinct().ToList();

                }
            }
        }
    }
}
