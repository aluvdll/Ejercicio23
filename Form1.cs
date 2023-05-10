using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            if (txtBox_Elemento != null && radioButton1.Checked)
            {
                string nuevoElemento = txtBox_Elemento.Text;
                lst_Box_Elementos.Items.Add(nuevoElemento);
                CuentaElemListBox();
            }
            if (txtBox_Elemento != null && radioButton2.Checked)
            {
                string nuevoElemento = txtBox_Elemento.Text;
                comboBox_Elementos.Items.Add(nuevoElemento);
                CuentaElemComboBox();

            }

            if (txtBox_Elemento != null && radioButton3.Checked)
            {
                string nuevoElemento = txtBox_Elemento.Text;
                checkListBox_Elementos.Items.Add(nuevoElemento);
                CuentaChekedList();
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                lst_Box_Elementos.Items.Remove(lst_Box_Elementos.SelectedItem);
                CuentaElemListBox();
            }
            if (radioButton2.Checked)
            {
                comboBox_Elementos.Items.Remove(comboBox_Elementos.SelectedItem);
                CuentaElemComboBox();

            }
            if (radioButton3.Checked)
            {
                checkListBox_Elementos.Items.Remove(checkListBox_Elementos.SelectedItem);
                CuentaChekedList();
            }

        }



        private void lst_Box_Elementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void comboBox_Elementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void checkListBox_Elementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void btn_Mostrar_Seleccion_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (lst_Box_Elementos.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    BorrarListasMostrar();
                    lstBox_Selec_Unic.Items.Add(Convert.ToString(lst_Box_Elementos.SelectedItem));
                }
            }

            if (radioButton2.Checked)
                {
                    if (comboBox_Elementos.SelectedItem == null)
                    {
                        
                        return;
                    }
                    else
                    {
                        BorrarListasMostrar();
                        lstBox_Selec_Unic.Items.Add(Convert.ToString(comboBox_Elementos.SelectedItem));
                        
                    }
            }
                
            if (radioButton3.Checked)
            {
               if(checkListBox_Elementos.CheckedItems == null)
                {
                    MessageBox.Show("DEVUELVE UN RETURN");
                    return;
                }
                else
                {
                    BorrarListasMostrar();
                    //  for (int x = 0; x < checkListBox_Elementos.Items.Count; x++)
                    // { 
                    //     {
                    //       listBox_Multiseleccion.Items.Add(Convert.ToString(checkListBox_Elementos.SelectedIndex));
                    // }
                    //   };
                    foreach (var item in checkListBox_Elementos.CheckedItems)
                    {
                        listBox_Multiseleccion.Items.Add(item.ToString());
                    }
                }
                
            }
            
        }
        private void BorrarListasMostrar()
        {
                lstBox_Selec_Unic.Items.Clear();
                listBox_Multiseleccion.Items.Clear();
        }

        private void CuentaElemListBox()
        {
            lbl_Contador_ListBox.Text = Convert.ToString(lst_Box_Elementos.Items.Count);
        }

        private void CuentaElemComboBox()
        {
            lbl_Contador_ComboBox.Text = Convert.ToString(comboBox_Elementos.Items.Count);
        }

        private void CuentaChekedList()
        {
            lbl_Contador_CheckedListBox.Text = Convert.ToString(checkListBox_Elementos.Items.Count);

        }
    }
}
