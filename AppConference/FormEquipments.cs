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
    public partial class FormEquipments : Form
    {
        public FormEquipments()
        {
            InitializeComponent();
        }

        private void FormEquipments_Load(object sender, EventArgs e)
        {
            using (var context = new ConferenceDbContext())
            {
                var res = context.Conferences.Join(context.Sections, c => c.ConferenceId, 
                    s => s.ConferenceId, (c,s) => new {c.ConferenceId, s.SectionId, s.PlaceName})
                    .Join(context.Performances, s=>s.SectionId, p=>p.SectionId, (s,p) => new 
                    {
                        s.PlaceName, p.PerformanceId, p.DateTimeStart, p.Equipment
                    }).SelectMany(p=>p.Equipment, (per, equi) =>  new
                    {
                        per.PlaceName,
                        EquipmentName = equi.Name, 
                        per.DateTimeStart
                    });

                dataGridView1.DataSource = res.ToList();

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].Width = 250;
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string val1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string val2 = dateTimePicker2.Value.ToString("HH:mm:ss");
            DateTime dateTime = DateTime.Parse(val1 + " " + val2);
            using (var context = new ConferenceDbContext())
            {
                var res = context.Conferences.Join(context.Sections, c => c.ConferenceId,
                    s => s.ConferenceId, (c, s) => new { c.ConferenceId, s.SectionId, s.PlaceName })
                    .Join(context.Performances, s => s.SectionId, p => p.SectionId, (s, p) => new
                    {
                        s.PlaceName,
                        p.PerformanceId,
                        p.DateTimeStart,
                        p.Equipment
                    }).SelectMany(p => p.Equipment, (per, equi) => new
                    {
                        per.PlaceName,
                        EquipmentName = equi.Name,
                        per.DateTimeStart
                    }).Where(x=>x.DateTimeStart == dateTime);

                dataGridView1.DataSource = res.ToList();

            }
        }
    }
}
