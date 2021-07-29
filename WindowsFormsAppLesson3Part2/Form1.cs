using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson3Part2
{
    public partial class Anket : Form
    {
        List<Human> humans = new List<Human>();
        public Anket()
        {
            InitializeComponent();
        }


        private void Deserializer(string text, List<Human> humans)
        {
            var deserializer = new JsonSerializer();
            using (var sr = new StreamReader($"{text}"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    deserializer.Deserialize<Human>(jr);
                }
                foreach (var item in humans)
                {
                    if (FileNameTxtBox.Text.Split('.')[0] == item.Name)
                    {
                        NameTxtBox.Text = item.Name;
                        SurnameTxtBox.Text = item.Surname;
                        MailTxtBox.Text = item.Mail;
                        PhoneNumberTxtBox.Text = item.PhoneNumber;
                        dateTimePicker1.Value = item.date;
                    }
                }
            }
        }

        private void SerializerHuman(string text, Human human)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{text}"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;


                    if (human.Name == FileNameTxtBox.Text.Split('.')[0])
                    {
                        serializer.Serialize(jw, human);
                    }
                    human.FileName = $"{text}";

                }

            }

        }

        private void Serializer(string text, List<Human> humans)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{text}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    foreach (var item in humans)
                    {

                        if (item.Name == FileNameTxtBox.Text.Split('.')[0])
                        {
                            serializer.Serialize(jw, item);
                        }
                        item.FileName = $"{text}.json";
                    }
                }

            }

        }

        private void Empty()
        {
            NameTxtBox.Text = String.Empty;
            SurnameTxtBox.Text = String.Empty;
            MailTxtBox.Text = String.Empty;
            PhoneNumberTxtBox.Text = String.Empty;
        }

        private void EmptyFileNameTxtBox()
        {
            FileNameTxtBox.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var temp = AddBtn.Location;
            AddBtn.Location = new Point(ChangedBtn.Location.X, ChangedBtn.Location.Y);
            ChangedBtn.Location = temp;

            var human = new Human
            {
                Name = NameTxtBox.Text,
                Surname = SurnameTxtBox.Text,
                Mail = MailTxtBox.Text,
                PhoneNumber = PhoneNumberTxtBox.Text,
                date = dateTimePicker1.Value
            };
            humans.Add(human);

            NamesListBox.Items.Add(human);

            NamesListBox.DisplayMember = "Name";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            Serializer(NameTxtBox.Text, humans);
            //EmptyFileNameTxtBox();
            Empty();
            LoadBtn.Enabled = true;
        }

        private void NamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileNameTxtBox.Text = $"{NameTxtBox.Text}.json";
            LoadBtn.Click += LoadBtn_Click;
            CurrentUser = $"{NameTxtBox.Text}.json";
        }
        public string CurrentUser { get; set; }
        public string NewUser { get; set; }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Deserializer(FileNameTxtBox.Text, humans);
            ChangedBtn.Enabled = true;

            ChangedBtn.Click += ChangedBtn_Click;
        }

        private void ChangedBtn_Click(object sender, EventArgs e)
        {
            var human = new Human
            {
                FileName = FileNameTxtBox.Text,
                Name = NameTxtBox.Text,
                Surname = SurnameTxtBox.Text,
                Mail = MailTxtBox.Text,
                PhoneNumber = PhoneNumberTxtBox.Text,
                date = dateTimePicker1.Value
            };

            SerializerHuman(human.FileName, human);
            foreach (var item in humans)
            {
                if (human.FileName == item.FileName)
                {
                    human.Name = item.Name;
                    human.Surname = item.Surname;
                    human.Mail = item.Mail;
                    human.PhoneNumber = item.PhoneNumber;
                    human.date = item.date;
                }
            }
        }

        private void MailLbl_Click(object sender, EventArgs e)
        {

        }











        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    List<string> names = new List<string>
        //    {
        //        "Elxan","Tural","Cavid","Murad","Fidan","Anara"
        //    };
        //    checkedListBox1.Items.AddRange(names.ToArray());
        //    comboBox1.DataSource = names;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    foreach (var item in checkedListBox1.CheckedItems)
        //    {
        //        builder.Append($"\n{item as string}");
        //    }
        //    label1.Text = builder.ToString();
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var item = comboBox1.SelectedItem as string;
        //    label1.Text = item;
        //}
    }
}