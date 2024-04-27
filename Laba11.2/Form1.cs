namespace Lab_11._2
{
    public partial class Form1 : Form
        {
        public struct Note
        {
            public string secondName;
            public string firstName;
            public string phoneNumb;
            public DateTime birthDate;

            public override string ToString()
            {
                return $"{secondName} - {firstName} - {phoneNumb} - {birthDate}";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        List<Note> lnote = new List<Note>();
        List<Note> sortedNote = new List<Note>();
        string[] secondNames = { "Иванов", "Петров", "Кукушкин", "Сергеев", "Кузин",
"Куклин", "Данилов", "Васин", "Андреев", "Копытов" };
        string[] firstNames = { "Артем", "Николай", "Григорий", "Ян", "Данил",
"Данила", "Сергей", "Виктор", "Петр", "Андрей", "Константин" };
        string[] firstNumbsOfNumber = { "8913", "8952", "8996", "8995" };
        string[] text;
        List<Note> listOfText = new List<Note>();
        List<string> textList = new List<string>();
        Random rnd = new Random();
        private void GeneratePerson()
        {
            for (int i = 0; i < 10; i++)
            {
                int rndYear = rnd.Next(1995, 2024);
                int rndMonth = rnd.Next(1, 12);
                int rndDay = rnd.Next(1, 31);
                DateTime rData = new DateTime(rndYear, rndMonth, rndDay);
                string dBirth = rData.ToString("dd/MM/yyyy");
                DateTime birthDateT = DateTime.Parse(dBirth);
                string secondNameT = secondNames[rnd.Next(0, 9)];
                string firstNameT = firstNames[rnd.Next(0, 9)];
                string phoneNumbT = (firstNumbsOfNumber[rnd.Next(0, 2)] +
        (rnd.Next(100000, 999999).ToString()));
                Note note = new Note { secondName = secondNameT, firstName = firstNameT, phoneNumb = phoneNumbT, birthDate = birthDateT };
                lnote.Add(note);
            }
        }
        private void ShowGeneric()
        {
            foreach(Note note in lnote)
            {
                listBox1.Items.Add(note);
            }
        }
        private void Sorted()
        {
            lnote = lnote.OrderBy(x => x.secondName).ToList();
            foreach (Note note in lnote)
            {
                listBox2.Items.Add(note);
                sortedNote.Add(note);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string[] text = File.ReadAllLines(file);
                size = text.Length;
                foreach (string line in text)
                {
                    string[] words = line.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                    DateTime birthDateT = DateTime.Parse(words[3]);
                    string secondNameT = words[0];
                    string firstNameT = words[1];
                    string phoneNumbT = words[2];
                    Note note = new Note { secondName = secondNameT, firstName =
firstNameT, phoneNumb = phoneNumbT, birthDate = birthDateT };
                    lnote.Add(note);
                }
            ShowGeneric();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GeneratePerson();
            foreach (Note note in lnote)
            {
                listBox1.Items.Add(note);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            lnote.Clear();
            sortedNote.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Sorted();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int k = 0;
            int txtForSearch = Convert.ToInt32(textBox1.Text);
            listBox2.Items.Clear();
            foreach (Note note in sortedNote)
            {
                if (note.birthDate.Month == txtForSearch)
                {
                    listBox2.Items.Add(note);
                    k++;
                }
            }
            if (k == 0)
            {
                listBox2.Items.Add("Не существует элемента");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int size = -1;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (Note note in lnote)
                {
                    string newType = note.ToString();
                    textList.Add(newType);
                }
                string file = saveFileDialog1.FileName;
                File.WriteAllLines(file,textList);
            }
        }
    }
}