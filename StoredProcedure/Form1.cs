using System.Data;
using System.Data.SqlClient;


namespace StoredProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetButton1());
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-7T0NOLAV;Initial Catalog=TestSP_DB;Integrated Security=True");

        

        private void button1_Click(object sender, EventArgs e, DateTime joindate, double age)
        {
            int empid = int.Parse(textBox1.Text);
            string empname = textBox2.Text, city = comboBox1.Text, contact = textBox4.Text, sex = "";
            joindate = DateTime.Parse(textBox3.Text);
            if (radioButton1.Checked == true) { sex = "Male"; } else { sex = "Female"; }
            con.Open();
            SqlCommand cmd = new SqlCommand("exec InsertEmp_SP '" + empid + "','" + empname + "','" + city + "','" + age + "','" + sex + "','" + joindate + "','" + contact + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted...");
            GetEmpList();


        }

        private void GetEmpList()
        {
            SqlCommand c = new SqlCommand("exec ListEmp_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmpList();
        }
    }
}