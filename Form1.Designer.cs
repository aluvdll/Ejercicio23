namespace Ejercicio23
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Elemento = new System.Windows.Forms.TextBox();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lst_Box_Elementos = new System.Windows.Forms.ListBox();
            this.comboBox_Elementos = new System.Windows.Forms.ComboBox();
            this.checkListBox_Elementos = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Contador_CheckedListBox = new System.Windows.Forms.Label();
            this.lbl_Contador_ListBox = new System.Windows.Forms.Label();
            this.lbl_Contador_ComboBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_multiseleccion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Multiseleccion = new System.Windows.Forms.ListBox();
            this.btn_Mostrar_Seleccion = new System.Windows.Forms.Button();
            this.lstBox_Selec_Unic = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de componentes";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(297, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(149, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "CheckedListBox";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "ComboBox";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ListBox";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento";
            // 
            // txtBox_Elemento
            // 
            this.txtBox_Elemento.Location = new System.Drawing.Point(596, 9);
            this.txtBox_Elemento.Name = "txtBox_Elemento";
            this.txtBox_Elemento.Size = new System.Drawing.Size(182, 26);
            this.txtBox_Elemento.TabIndex = 2;
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.Location = new System.Drawing.Point(563, 41);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(101, 36);
            this.btn_Añadir.TabIndex = 3;
            this.btn_Añadir.Text = "Añadir";
            this.btn_Añadir.UseVisualStyleBackColor = true;
            this.btn_Añadir.Click += new System.EventHandler(this.btn_Añadir_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(681, 44);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(100, 34);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lst_Box_Elementos
            // 
            this.lst_Box_Elementos.FormattingEnabled = true;
            this.lst_Box_Elementos.ItemHeight = 20;
            this.lst_Box_Elementos.Location = new System.Drawing.Point(24, 84);
            this.lst_Box_Elementos.Name = "lst_Box_Elementos";
            this.lst_Box_Elementos.Size = new System.Drawing.Size(215, 184);
            this.lst_Box_Elementos.TabIndex = 5;
            this.lst_Box_Elementos.Click += new System.EventHandler(this.lst_Box_Elementos_SelectedIndexChanged);
            this.lst_Box_Elementos.SelectedIndexChanged += new System.EventHandler(this.lst_Box_Elementos_SelectedIndexChanged);
            // 
            // comboBox_Elementos
            // 
            this.comboBox_Elementos.FormattingEnabled = true;
            this.comboBox_Elementos.Location = new System.Drawing.Point(299, 84);
            this.comboBox_Elementos.Name = "comboBox_Elementos";
            this.comboBox_Elementos.Size = new System.Drawing.Size(215, 28);
            this.comboBox_Elementos.TabIndex = 6;
            this.comboBox_Elementos.Click += new System.EventHandler(this.comboBox_Elementos_SelectedIndexChanged);
            // 
            // checkListBox_Elementos
            // 
            this.checkListBox_Elementos.FormattingEnabled = true;
            this.checkListBox_Elementos.Location = new System.Drawing.Point(563, 84);
            this.checkListBox_Elementos.Name = "checkListBox_Elementos";
            this.checkListBox_Elementos.Size = new System.Drawing.Size(215, 188);
            this.checkListBox_Elementos.TabIndex = 7;
            this.checkListBox_Elementos.Click += new System.EventHandler(this.checkListBox_Elementos_SelectedIndexChanged);
            this.checkListBox_Elementos.SelectedIndexChanged += new System.EventHandler(this.checkListBox_Elementos_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Contador_CheckedListBox);
            this.panel1.Controls.Add(this.lbl_Contador_ListBox);
            this.panel1.Controls.Add(this.lbl_Contador_ComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 42);
            this.panel1.TabIndex = 8;
            // 
            // lbl_Contador_CheckedListBox
            // 
            this.lbl_Contador_CheckedListBox.AutoSize = true;
            this.lbl_Contador_CheckedListBox.Location = new System.Drawing.Point(729, 9);
            this.lbl_Contador_CheckedListBox.Name = "lbl_Contador_CheckedListBox";
            this.lbl_Contador_CheckedListBox.Size = new System.Drawing.Size(18, 20);
            this.lbl_Contador_CheckedListBox.TabIndex = 11;
            this.lbl_Contador_CheckedListBox.Text = "0";
            // 
            // lbl_Contador_ListBox
            // 
            this.lbl_Contador_ListBox.AutoSize = true;
            this.lbl_Contador_ListBox.Location = new System.Drawing.Point(195, 9);
            this.lbl_Contador_ListBox.Name = "lbl_Contador_ListBox";
            this.lbl_Contador_ListBox.Size = new System.Drawing.Size(18, 20);
            this.lbl_Contador_ListBox.TabIndex = 10;
            this.lbl_Contador_ListBox.Text = "0";
            // 
            // lbl_Contador_ComboBox
            // 
            this.lbl_Contador_ComboBox.AutoSize = true;
            this.lbl_Contador_ComboBox.Location = new System.Drawing.Point(470, 9);
            this.lbl_Contador_ComboBox.Name = "lbl_Contador_ComboBox";
            this.lbl_Contador_ComboBox.Size = new System.Drawing.Size(18, 20);
            this.lbl_Contador_ComboBox.TabIndex = 9;
            this.lbl_Contador_ComboBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elementos:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.lstBox_Selec_Unic);
            this.panel2.Controls.Add(this.lbl_multiseleccion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listBox_Multiseleccion);
            this.panel2.Controls.Add(this.btn_Mostrar_Seleccion);
            this.panel2.Location = new System.Drawing.Point(24, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 173);
            this.panel2.TabIndex = 12;
            // 
            // lbl_multiseleccion
            // 
            this.lbl_multiseleccion.AutoSize = true;
            this.lbl_multiseleccion.Location = new System.Drawing.Point(535, 6);
            this.lbl_multiseleccion.Name = "lbl_multiseleccion";
            this.lbl_multiseleccion.Size = new System.Drawing.Size(108, 20);
            this.lbl_multiseleccion.TabIndex = 4;
            this.lbl_multiseleccion.Text = "Multiselección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccion única:";
            // 
            // listBox_Multiseleccion
            // 
            this.listBox_Multiseleccion.FormattingEnabled = true;
            this.listBox_Multiseleccion.ItemHeight = 20;
            this.listBox_Multiseleccion.Location = new System.Drawing.Point(539, 31);
            this.listBox_Multiseleccion.Name = "listBox_Multiseleccion";
            this.listBox_Multiseleccion.ScrollAlwaysVisible = true;
            this.listBox_Multiseleccion.Size = new System.Drawing.Size(210, 124);
            this.listBox_Multiseleccion.TabIndex = 2;
            // 
            // btn_Mostrar_Seleccion
            // 
            this.btn_Mostrar_Seleccion.Location = new System.Drawing.Point(3, 31);
            this.btn_Mostrar_Seleccion.Name = "btn_Mostrar_Seleccion";
            this.btn_Mostrar_Seleccion.Size = new System.Drawing.Size(212, 49);
            this.btn_Mostrar_Seleccion.TabIndex = 0;
            this.btn_Mostrar_Seleccion.Text = "Mostrar Seleccionado/s";
            this.btn_Mostrar_Seleccion.UseVisualStyleBackColor = true;
            this.btn_Mostrar_Seleccion.Click += new System.EventHandler(this.btn_Mostrar_Seleccion_Click);
            // 
            // lstBox_Selec_Unic
            // 
            this.lstBox_Selec_Unic.FormattingEnabled = true;
            this.lstBox_Selec_Unic.ItemHeight = 20;
            this.lstBox_Selec_Unic.Location = new System.Drawing.Point(275, 31);
            this.lstBox_Selec_Unic.Name = "lstBox_Selec_Unic";
            this.lstBox_Selec_Unic.Size = new System.Drawing.Size(215, 104);
            this.lstBox_Selec_Unic.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(786, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkListBox_Elementos);
            this.Controls.Add(this.comboBox_Elementos);
            this.Controls.Add(this.lst_Box_Elementos);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Añadir);
            this.Controls.Add(this.txtBox_Elemento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Trabajando con Listas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Elemento;
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ListBox lst_Box_Elementos;
        private System.Windows.Forms.ComboBox comboBox_Elementos;
        private System.Windows.Forms.CheckedListBox checkListBox_Elementos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Contador_CheckedListBox;
        private System.Windows.Forms.Label lbl_Contador_ListBox;
        private System.Windows.Forms.Label lbl_Contador_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox_Multiseleccion;
        private System.Windows.Forms.Button btn_Mostrar_Seleccion;
        private System.Windows.Forms.Label lbl_multiseleccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBox_Selec_Unic;
    }
}

