using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            toolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.N;
            InitializeDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenAddStudentForm()
        {
            using (AddStudentForm addForm = new AddStudentForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    students.Add(addForm.Student);
                    RefreshDataGridView();
                }
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            int tt = 1;
            foreach (var student in students)
            {
                dataGridView1.Rows.Add(tt++, student.MaSo, student.Ten, student.Khoa, student.DiemTB);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "TT";
            dataGridView1.Columns[1].Name = "Mã số sinh viên";
            dataGridView1.Columns[2].Name = "Tên sinh viên";
            dataGridView1.Columns[3].Name = "Khoa";
            dataGridView1.Columns[4].Name = "Điểm TB";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            // If search text is empty, display all students
            if (string.IsNullOrEmpty(searchText))
            {
                RefreshDataGridView();
                return;
            }

            var filtered = students.Where(s => s.Ten.ToLower().Contains(searchText)).ToList();

            dataGridView1.Rows.Clear();
            int tt = 1;
            foreach (var student in filtered)
            {
                dataGridView1.Rows.Add(tt++, student.MaSo, student.Ten, student.Khoa, student.DiemTB);
            }
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenAddStudentForm();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenAddStudentForm();
        }
    }
}
