using MySql.Data.MySqlClient;

namespace UniversoFrutas
{
    public partial class Form1 : Form
    {

        private Conexion mConexion;
        private String comando="";

        public Form1()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1
               || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, no deje campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                crearConsulta();
                string result = "";
                MySqlDataReader mySqlDataReader = null;
                string consulta = comando;

                if (mConexion.getConexion != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = mConexion.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.HasRows) // Verificar si hay filas devueltas
                    {
                        //MessageBox.Show("SI HAY", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        while (mySqlDataReader.Read())
                        {
                            result += mySqlDataReader.GetString("nombre") + "\n"; // Añade un salto de línea para separar los resultados
                        }

                        MessageBox.Show(result);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    mConexion.CerrarConexion();


                }
                else
                {
                    MessageBox.Show("Error al conectar");
                }

                
            }
        }



        public void crearConsulta()
        {
            String resultado1;
             String resultado2;
             String resultado3;
             String resultado4;
  
              resultado1 = comboBox1.SelectedItem.ToString();
              resultado2 = comboBox2.SelectedItem.ToString();
              resultado3 = comboBox3.SelectedItem.ToString();
              resultado4 = comboBox4.SelectedItem.ToString();

                 comando = "SELECT nombre FROM frutas WHERE frutafuera = '" + resultado1 + "'"
                      + " AND frutadentro = '" + resultado2 + "'"
                      + " AND saborfruta = '" + resultado3 + "'"
                      + " AND huesosemilla = '" + resultado4 + "';";

            //MessageBox.Show(comando, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

      
    }
}
