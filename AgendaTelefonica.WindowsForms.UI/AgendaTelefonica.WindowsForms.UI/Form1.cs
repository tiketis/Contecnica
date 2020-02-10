using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgendaTelefonica.WindowsForms.UI
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-CUMQCS9\\SQLEXPRESS;Initial Catalog=contecnica;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dados;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
            carregar_Lista();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" & txt_Telefone.Text != "")
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO lista(nome, telefone) VALUES ('"+txt_Nome.Text+"', '"+txt_Telefone.Text+"')";
                comando.ExecuteNonQuery();
                conexao.Close();

                carregar_Lista();

                txt_Nome.Text = "";
                txt_Telefone.Text = "";
            }
        }

        private void carregar_Lista()
        {
            lst_Nome.Items.Clear();
            lst_Telefone.Items.Clear();

            conexao.Open();
            comando.CommandText = "SELECT * FROM lista";
            dados = comando.ExecuteReader();

            if (dados.HasRows)
            {
                while(dados.Read())
                {
                    lst_Nome.Items.Add(dados [0].ToString());
                    lst_Telefone.Items.Add(dados [1].ToString());
                }
            }
            conexao.Close();
        }

        private void lst_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;

            if(list.SelectedIndex != -1)
            {
                lst_Nome.SelectedIndex = list.SelectedIndex;
                lst_Telefone.SelectedIndex = list.SelectedIndex;

                txt_Nome.Text = lst_Nome.SelectedItem.ToString();
                txt_Telefone.Text = lst_Telefone.SelectedItem.ToString();
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" & txt_Telefone.Text != "")
            {
                conexao.Open();
                comando.CommandText = "DELETE FROM lista WHERE nome ='"+txt_Nome.Text+"' AND telefone ='"+txt_Telefone.Text+"'";
                comando.ExecuteNonQuery();
                conexao.Close();

                carregar_Lista();

                txt_Nome.Text = "";
                txt_Telefone.Text = "";
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" & txt_Telefone.Text != "")
            {
                conexao.Open();
                comando.CommandText = "UPDATE lista SET nome ='"+txt_Nome.Text+"' , telefone ='"+txt_Telefone.Text+"' WHERE nome = '"+lst_Nome.SelectedItem.ToString()+"' AND telefone = '"+lst_Telefone.SelectedItem.ToString()+"'";                
                comando.ExecuteNonQuery();
                conexao.Close();

                carregar_Lista();

                txt_Nome.Text = "";
                txt_Telefone.Text = "";
            }
        }
    }
}
