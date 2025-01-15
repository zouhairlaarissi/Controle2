using Microsoft.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;




namespace Controle2
{
    public partial class Form1 : Form
    {

        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr;
        private DataTable dt = new DataTable();
        private DataTable dt2 = new DataTable();
        private DataTable dt3 = new DataTable();

        private string conn = "Data Source=DESKTOP-0744EKU;Initial Catalog=CONTROLE2;Integrated Security=True;Trusted_connection=true;TrustServerCertificate=true";



        private void Afficher()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    if (dt.Rows.Count > 0)
                    {
                        dt.Clear();
                    }
                    con.Open();
                    string query = "select    E.MATRICULE,     E.NOM,     E.PRENOM,     D.NOM_DEPARETEMENT  from     EMPLOYES E  join     DEPARTEMENTS D   on    D.ID_DEPARTEMENT = E.DEPARTEMENT ";
                    cmd = new SqlCommand(query, con);
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    dr.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Remplir_combo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    if (dt2.Rows.Count > 0)
                    {
                        dt2.Clear();
                    }
                    cmd = new SqlCommand("select ID_DEPARTEMENT,NOM_DEPARETEMENT from DEPARTEMENTS ", con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    dt2.Load(dr);
                    comboBox1.DisplayMember = "NOM_DEPARETEMENT";
                    comboBox1.ValueMember = "ID_DEPARTEMENT";
                    comboBox1.DataSource = dt2;
                    dr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Ajouter()
        {
            if (txtnom.Text == "" || txtprenom.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO EMPLOYES VALUES('" + txtnom.Text + "','" + txtprenom.Text + "','" + comboBox1.SelectedValue + "')", con);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Employé ajouté avec succès");
                Afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Modifier()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez choisir l'employé à modifier");
                return;
            }

            try
            {
                int ligne_choisie = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE EMPLOYES SET NOM='" + txtnom.Text + "',PRENOM='" + txtprenom.Text + "',DEPARTEMENT='" + comboBox1.SelectedValue + "' WHERE MATRICULE='" + ligne_choisie + "'", con);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Employé modifié avec succès");
                Afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Supprimer()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez choisir l'employé à supprimer");
                return;
            }
            try
            {
                int ligne_choisie = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM EMPLOYES WHERE MATRICULE='" + ligne_choisie + "'", con);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Employé supprimé avec succès");
                Afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Chercher()
        {
            if (txtchercher.Text == "")
            {
                MessageBox.Show("Veuillez saisir le nom de l'employé à chercher");
                return;
            }
            try
            {
                if (dt3.Rows.Count > 0)
                {
                    dt3.Clear();
                }
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    cmd = new SqlCommand("select    E.MATRICULE,     E.NOM,     E.PRENOM,     D.NOM_DEPARETEMENT  from     EMPLOYES E  join     DEPARTEMENTS D   on    D.ID_DEPARTEMENT = E.DEPARTEMENT where E.MATRICULE ='" + Convert.ToInt32(txtchercher.Text) + "'", con);
                    dr = cmd.ExecuteReader();
                    dt3.Load(dr);
                    dataGridView1.DataSource = dt3;
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Exporter_json()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Aucun employé à exporter");
                return;
            }
            try
            {
                string json = JsonConvert.SerializeObject(dt);
                File.WriteAllText("C:\\Users\\ZORO\\json\\employes.json", json);
                MessageBox.Show("Exportation réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Afficher();
            Remplir_combo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chercher();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exporter_json();
        }
    }
}
