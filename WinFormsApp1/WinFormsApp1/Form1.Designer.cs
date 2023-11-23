namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nombre = new Label();
            lbl_edad = new Label();
            bt1_guardar = new Button();
            cbx_masculino = new CheckBox();
            cbx_Femenino = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbl_genero = new Label();
            bps_progreso = new ProgressBar();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AccessibleName = "lbl_nombre";
            lbl_nombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(51, 43);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(98, 32);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre:";
            lbl_nombre.Click += label1_Click;
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_edad.Location = new Point(79, 95);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(60, 28);
            lbl_edad.TabIndex = 1;
            lbl_edad.Text = "Edad:";
            // 
            // bt1_guardar
            // 
            bt1_guardar.Location = new Point(218, 274);
            bt1_guardar.Name = "bt1_guardar";
            bt1_guardar.Size = new Size(109, 32);
            bt1_guardar.TabIndex = 2;
            bt1_guardar.Text = "Guardar";
            bt1_guardar.UseVisualStyleBackColor = true;
            bt1_guardar.Click += bt1_guardar_Click;
            // 
            // cbx_masculino
            // 
            cbx_masculino.AutoSize = true;
            cbx_masculino.Location = new Point(160, 181);
            cbx_masculino.Name = "cbx_masculino";
            cbx_masculino.Size = new Size(81, 19);
            cbx_masculino.TabIndex = 3;
            cbx_masculino.Text = "Masculino";
            cbx_masculino.UseVisualStyleBackColor = true;
            // 
            // cbx_Femenino
            // 
            cbx_Femenino.AutoSize = true;
            cbx_Femenino.Location = new Point(291, 181);
            cbx_Femenino.Name = "cbx_Femenino";
            cbx_Femenino.Size = new Size(79, 19);
            cbx_Femenino.TabIndex = 4;
            cbx_Femenino.Text = "Femenino";
            cbx_Femenino.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 23);
            textBox2.TabIndex = 6;
            // 
            // lbl_genero
            // 
            lbl_genero.AccessibleName = "lbl_nombre";
            lbl_genero.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_genero.Location = new Point(41, 171);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(98, 32);
            lbl_genero.TabIndex = 7;
            lbl_genero.Text = "Género";
            lbl_genero.Click += label1_Click_1;
            // 
            // bps_progreso
            // 
            bps_progreso.Location = new Point(137, 321);
            bps_progreso.Name = "bps_progreso";
            bps_progreso.Size = new Size(282, 23);
            bps_progreso.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 401);
            Controls.Add(bps_progreso);
            Controls.Add(lbl_genero);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cbx_Femenino);
            Controls.Add(cbx_masculino);
            Controls.Add(bt1_guardar);
            Controls.Add(lbl_edad);
            Controls.Add(lbl_nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Label lbl_edad;
        private Button bt1_guardar;
        private CheckBox cbx_masculino;
        private CheckBox cbx_Femenino;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbl_genero;
        private ProgressBar bps_progreso;
    }
}