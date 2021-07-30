using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwForm
{
    public partial class Form1 : Form
    {
        public class Info
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime DateOfBirth { get; set; }
            public bool Gender { get; set; }
            public string Mail { get; set; }
            public string WorkingAddress { get; set; }
            public string ForeignLanguages { get; set; }
            public string ProgrammingLanguages { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var info = new Info
            {
                Name = tb_name.Text,
                Surname = tb_surname.Text,
                DateOfBirth = dateTimePicker1.Value,
                Gender = btn_gender_male.Checked,
                Mail = tb_mail.Text,
                WorkingAddress = tb_address.Text,
            };
            string jsonString = JsonSerializer.Serialize(info);
            MessageBox.Show(jsonString);
        }
    }
}
