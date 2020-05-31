using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace 停车场收费管理系统
{

    public partial class Inquire : Form
    {
        public Inquire()
        {
            InitializeComponent();
        }

        static String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=parkingsystem;";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == ""  || textBox1.Text == "")
            {
                MessageBox.Show("请填写完整!");
            }
            else
            {
                if(comboBox1.Text == "姓名")
                {
                    try
                    {
                        dataGridView1.Rows.Clear();
                        aa = 0;

                        conn.Open();
                        string sql = "select * from vip where name like @para1 order by cardnumber";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("para1","%" + textBox1.Text + "%");

                        MySqlDataReader reader = cmd.ExecuteReader();

                        Queue queue = new Queue();

                        while (reader.Read())
                        {
                            queue.Enqueue(new vip(reader.GetString("cardnumber"), reader.GetString("carnumber"), reader.GetString("name"), reader.GetString("phone"), reader.GetFloat("money"), Convert.ToDateTime(reader.GetMySqlDateTime("time"))));
                        }

                        while (queue.Count != 0)
                        {
                            Gaa((vip)queue.Dequeue());
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                else 
                {
                    try
                    {
                        dataGridView1.Rows.Clear();
                        aa = 0;

                        conn.Open();
                        string sql = "select * from vip where cardnumber like @para1 order by cardnumber";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("para1", "%" + textBox1.Text + "%");

                        MySqlDataReader reader = cmd.ExecuteReader();

                        Queue queue = new Queue();

                        while (reader.Read())
                        {
                            queue.Enqueue(new vip(reader.GetString("cardnumber"), reader.GetString("carnumber"), reader.GetString("name"), reader.GetString("phone"), reader.GetFloat("money"), Convert.ToDateTime(reader.GetMySqlDateTime("time"))));
                        }

                        while (queue.Count != 0)
                        {
                            Gaa((vip)queue.Dequeue());
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }

        private int aa = 0;
        private void Gaa(vip data)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[aa].Cells[0].Value = data.Cardnumber;
            dataGridView1.Rows[aa].Cells[1].Value = data.Carnumber;
            dataGridView1.Rows[aa].Cells[2].Value = data.Name;
            dataGridView1.Rows[aa].Cells[3].Value = data.Phone;
            dataGridView1.Rows[aa].Cells[5].Value = data.Money;
            dataGridView1.Rows[aa].Cells[4].Value = data.Time;
            aa++;
        }
    }
}
