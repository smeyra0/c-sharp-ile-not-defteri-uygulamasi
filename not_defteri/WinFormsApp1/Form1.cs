namespace WinFormsApp1
{
    public partial class Form1 : Form


    {
        private List<Note> notes = new List<Note>();


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox2.Text;
            string tag = textBox3.Text;
            string text = textBox1.Text;

            Note note = new Note(title, tag, text);
            notes.Add(note);

            UpdateListBox();
            ClearFields();



        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (Note mynote in notes)


            {


                string title = note.Title.Replace("listBox1", "");
                listBox1.Items.Add(note.Title);
            }
        }


        private void ClearFields()
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
        }




        public class Note
        {
            public string Title { get; set; }
            public string Tag { get; set; }
            public string Text { get; set; }

            public Note(string title, string tag, string text)
            {
                Title = title;
                Tag = tag;
                Text = text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                textBox2.Text = notes[selectedIndex].Title;
                textBox3.Text = notes[selectedIndex].Tag;
                textBox1.Text = notes[selectedIndex].Text;
            }

        }
    }

}