using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamlanyilvan
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";
            conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                //-- Terv szetint halad
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //-- Váratlan hiba történik
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!!");
                Environment.Exit(0);
            }
            finally
            {
                //-- Hiba és terv szerint esetén is lefut
                conn.Close();
            }
        }

        private void szamla_update()
        {
            listBox_szamlak.Items.Clear();
            cmd.CommandText = "SELECT `id`,`tulajdonosNeve`,`egyenleg`,`nyitasdatum` FROM `szamlak` WHERE 1;";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Szamla uj = new Szamla(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetInt32("egyenleg"), dr.GetDateTime("nyitasdatum"));
                    listBox_szamlak.Items.Add(uj);
                }

            }
            conn.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (nincsenek_adatok())
            {
                return;
            }
            //--Kiírjuk adatbázisba
            cmd.CommandText = "INSERT INTO `szamlak` (`id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES (NULL, @tulajdonosNeve, @egyenleg, @nyitasdatum)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tulajdonosNeve", textBox_tulajnev.Text);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDown_egyenleg.Value.ToString());
            cmd.Parameters.AddWithValue("@nyitasdatum", dateTimePicker_nyitas.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBox_tulajnev.Text = "";
                    numericUpDown_egyenleg.Value = numericUpDown_egyenleg.Minimum;
                    dateTimePicker_nyitas.ResetText();
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Sikertelen!");
            }
            conn.Close();
            szamla_update();
        }

        private bool nincsenek_adatok()
        {
            if (string.IsNullOrEmpty(textBox_tulajnev.Text))
            {
                MessageBox.Show("Adjon meg tulajdonos nevet!");
                textBox_tulajnev.Focus();
                return true;
            }
            if (numericUpDown_egyenleg.Value < 0)
            {
                MessageBox.Show("Érvénytelen egyenleg");
                numericUpDown_egyenleg.Value = 0;
                numericUpDown_egyenleg.Focus();
                return true;
            }
            return false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (listBox_szamlak.SelectedIndex<0)
            {
                return;
            }
            //-- A felhasználó kijelöl egy elemet a listából
            cmd.CommandText = "UPDATE `szamlak` SET `tulajdonosNeve` = @tulajdonosNeve, `egyenleg` = @egyenleg, `nyitasdatum`= @nyitasdatum WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id);
            cmd.Parameters.AddWithValue("@tulajdonosNeve", textBox_tulajnev);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDown_egyenleg.Value.ToString());
            cmd.Parameters.AddWithValue("@nyitasdatum", dateTimePicker_nyitas.Value.ToString("yyyy-MM-dd"));
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("A módosítás sikeres volt!");
                conn.Close();
                textBox_tulajnev.Text = "";
                numericUpDown_egyenleg.Value = 0;
                dateTimePicker_nyitas.ResetText();
                szamla_update();
            }
            else
            {
                MessageBox.Show("Az adatok módosítása sikertelen volt!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox_szamlak.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `szamlak` WHERE `id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                textBox_id.Text = "";
                textBox_tulajnev.Text = "";
                numericUpDown_egyenleg.Value = 0;
                dateTimePicker_nyitas.ResetText();
                szamla_update();
            }
            else
            {
                MessageBox.Show("Az adatok törlése sikertelen volt!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void listBox_szamlak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_szamlak.SelectedIndex < 0)
            {
                return;
            }
            //-- A felhasználó kijelöl egy elemet a listában
            Szamla kivalasztottszamla = (Szamla)listBox_szamlak.SelectedItem;
            textBox_id.Text = kivalasztottszamla.Id.ToString();
            textBox_tulajnev.Text = kivalasztottszamla.Tulajnev;
            numericUpDown_egyenleg.Value = kivalasztottszamla.Egyenleg;
            dateTimePicker_nyitas.Value = kivalasztottszamla.Datum;
        }
    }
}
