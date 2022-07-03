using DocumentFormat.OpenXml.Office2010.CustomUI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConference
{
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            using (var context = new ConferenceDbContext())
            {
                var conf = from conference in context.Conferences
                           join section in context.Sections on conference.ConferenceId equals section.ConferenceId
                           join performance in context.Performances on section.SectionId equals performance.SectionId
                           join speaker in context.Speakers on performance.SpeakerId equals speaker.SpeakerId
                           select new
                           {
                               ConfName = conference.Name,
                               Build = conference.BuildingName,
                               SectName = section.Name,
                               SectPlace = section.PlaceName,
                               PerformanceName = performance.Theme,
                               SpeakerFio = speaker.Lastname + " " + speaker.Firstname,
                               DateStart = performance.DateTimeStart,
                               Duration = performance.Duration
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

                dataGridView1.DataSource = conf.ToList();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].Width = 200;
                }
            }
        }


        private void comboBoxConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConference.SelectedIndex == -1) 
            {
                labelSection.Visible = false;
                comboBoxSection.Visible = false;
                buttonFind.Visible = false;
            }
            else
            {
                labelSection.Visible = true;
                comboBoxSection.Visible = true;
                buttonFind.Visible = true;
                string conferenceName = comboBoxConference.SelectedValue.ToString();
                using (var context = new ConferenceDbContext())
                {
                    var sectionItems = from conference in context.Conferences
                                       join section in context.Sections on conference.ConferenceId equals section.ConferenceId
                                       where conference.Name == conferenceName
                                       select new
                                       {
                                           section.Name
                                       };

                    comboBoxSection.DataSource = sectionItems.ToList();
                    comboBoxSection.DisplayMember = "Name";
                    comboBoxSection.ValueMember = "Name";
                    comboBoxSection.SelectedIndex = -1;
                }
            }
            
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (comboBoxConference.SelectedIndex != -1) 
            {
                string conferenceName = comboBoxConference.SelectedValue.ToString();
                if (comboBoxSection.SelectedIndex == -1) 
                {
                    using (var context = new ConferenceDbContext())
                    {
                        var sectionItems = from conference in context.Conferences
                                           join section in context.Sections on conference.ConferenceId equals section.ConferenceId
                                           join performance in context.Performances on section.SectionId equals performance.SectionId
                                           join speaker in context.Speakers on performance.SpeakerId equals speaker.SpeakerId
                                           where conference.Name == conferenceName
                                           select new
                                           {
                                               ConfName = conference.Name,
                                               Build = conference.BuildingName,
                                               SectName = section.Name,
                                               SectPlace = section.PlaceName,
                                               PerformanceName = performance.Theme,
                                               SpeakerFio = speaker.Lastname + " " + speaker.Firstname,
                                               DateStart = performance.DateTimeStart,
                                               Duration = performance.Duration
                                           };

                        dataGridView1.DataSource = sectionItems.ToList();
                    }

                }
                else
                {
                    string sectionName = comboBoxSection.SelectedValue.ToString();
                    using (var context = new ConferenceDbContext())
                    {
                        var sectionItems = from conference in context.Conferences
                                           join section in context.Sections on conference.ConferenceId equals section.ConferenceId
                                           join performance in context.Performances on section.SectionId equals performance.SectionId
                                           join speaker in context.Speakers on performance.SpeakerId equals speaker.SpeakerId
                                           where conference.Name == conferenceName && section.Name== sectionName
                                           select new
                                           {
                                               ConfName = conference.Name,
                                               Build = conference.BuildingName,
                                               SectName = section.Name,
                                               SectPlace = section.PlaceName,
                                               PerformanceName = performance.Theme,
                                               SpeakerFio = speaker.Lastname + " " + speaker.Firstname,
                                               DateStart = performance.DateTimeStart,
                                               Duration = performance.Duration
                                           };

                        dataGridView1.DataSource = sectionItems.ToList();
                    }
                }
            }
        }
    }
}
