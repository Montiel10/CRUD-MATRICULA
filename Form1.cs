using CRUD_MATRICULA.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MATRICULA
{
    public partial class Form1 : Form
    {
        public string SQL_INSERT { get; private set; }
        public string SQL_Insert { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            dtGRIDViewEstudiantes.DataSource = Index();
        }

        public DataTable Index()
        {
            Conexion.Conectar();

            DataTable datatable = new DataTable();
            string sql = "SELECT *  FROM Estudiantes";
            SqlCommand cmd = new SqlCommandr(sql, Conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(datatable);

            return datatable;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //insert
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();

            string SQL_Insert = "INSERT INTO Estudiantes(Cod_Estudiante, Matricula, Nombres, Apellidos, Grado, Celular, Cod_Pago) VALUES(@Cod_Estudiante, @Matricula, @Nombres, @Apellido, @Grado, @Celular, @Cod_Pago)";


            SqlCommand command1 = new SqlCommand(SQL_Insert, Conexion.Conectar());
            command1.Parameters.AddWithValue("@Nombres", textBoxNombres.Text);
            command1.Parameters.AddWithValue("@Apellidos", textBoxApellidos.Text);
            command1.Parameters.AddWithValue("@Cod_Estudiante", textBoxCod_Estudiante.Text);
            command1.Parameters.AddWithValue("@Matricula", textBoxMatricula.Text);

            command1.ExecuteNonQuery();


            MessageBox.Show("Correctamente Insertados");

            dtGRIDViewEstudiantes.DataSource = Index();

        }
    }
}
