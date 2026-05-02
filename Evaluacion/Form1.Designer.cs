namespace Evaluacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label LblCodigoEquipo;
        private System.Windows.Forms.Label LblNombreEquipo;
        private System.Windows.Forms.Label LblNivel;
        private System.Windows.Forms.Label LblExperiencia;
        private System.Windows.Forms.TextBox TxtCodigoEquipo;
        private System.Windows.Forms.TextBox TxtNombreEquipo;
        private System.Windows.Forms.ComboBox CboNivel;
        private System.Windows.Forms.TextBox TxtExperiencia;

        private System.Windows.Forms.Label LblCodigoEquipoJugador;
        private System.Windows.Forms.Label LblGamertag;
        private System.Windows.Forms.Label LblNombreJugador;
        private System.Windows.Forms.TextBox TxtCodigoEquipoJugador;
        private System.Windows.Forms.TextBox TxtGamertag;
        private System.Windows.Forms.TextBox TxtNombreJugador;

        private System.Windows.Forms.Button BtnRegistrarEquipo;
        private System.Windows.Forms.Button BtnRegistrarJugador;
        private System.Windows.Forms.Button BtnMostrarEquipos;
        private System.Windows.Forms.Button BtnMostrarJugadores;
        private System.Windows.Forms.Button BtnMayorExperiencia;
        private System.Windows.Forms.Button BtnSinJugadores;
        private System.Windows.Forms.Button BtnLimpiar;

        private System.Windows.Forms.ListBox ListEquipos;
        private System.Windows.Forms.ListBox ListJugadores;
        private System.Windows.Forms.ListBox ListReportes;

        private System.Windows.Forms.Label LblEquipos;
        private System.Windows.Forms.Label LblJugadores;
        private System.Windows.Forms.Label LblReportes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.LblCodigoEquipo = new System.Windows.Forms.Label();
            this.LblNombreEquipo = new System.Windows.Forms.Label();
            this.LblNivel = new System.Windows.Forms.Label();
            this.LblExperiencia = new System.Windows.Forms.Label();
            this.TxtCodigoEquipo = new System.Windows.Forms.TextBox();
            this.TxtNombreEquipo = new System.Windows.Forms.TextBox();
            this.CboNivel = new System.Windows.Forms.ComboBox();
            this.TxtExperiencia = new System.Windows.Forms.TextBox();

            this.LblCodigoEquipoJugador = new System.Windows.Forms.Label();
            this.LblGamertag = new System.Windows.Forms.Label();
            this.LblNombreJugador = new System.Windows.Forms.Label();
            this.TxtCodigoEquipoJugador = new System.Windows.Forms.TextBox();
            this.TxtGamertag = new System.Windows.Forms.TextBox();
            this.TxtNombreJugador = new System.Windows.Forms.TextBox();

            this.BtnRegistrarEquipo = new System.Windows.Forms.Button();
            this.BtnRegistrarJugador = new System.Windows.Forms.Button();
            this.BtnMostrarEquipos = new System.Windows.Forms.Button();
            this.BtnMostrarJugadores = new System.Windows.Forms.Button();
            this.BtnMayorExperiencia = new System.Windows.Forms.Button();
            this.BtnSinJugadores = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();

            this.ListEquipos = new System.Windows.Forms.ListBox();
            this.ListJugadores = new System.Windows.Forms.ListBox();
            this.ListReportes = new System.Windows.Forms.ListBox();

            this.LblEquipos = new System.Windows.Forms.Label();
            this.LblJugadores = new System.Windows.Forms.Label();
            this.LblReportes = new System.Windows.Forms.Label();

            this.SuspendLayout();

            this.LblCodigoEquipo.AutoSize = true;
            this.LblCodigoEquipo.Location = new System.Drawing.Point(30, 30);
            this.LblCodigoEquipo.Name = "LblCodigoEquipo";
            this.LblCodigoEquipo.Size = new System.Drawing.Size(101, 15);
            this.LblCodigoEquipo.Text = "Código de equipo";

            this.TxtCodigoEquipo.Location = new System.Drawing.Point(150, 27);
            this.TxtCodigoEquipo.Name = "TxtCodigoEquipo";
            this.TxtCodigoEquipo.Size = new System.Drawing.Size(150, 23);

            this.LblNombreEquipo.AutoSize = true;
            this.LblNombreEquipo.Location = new System.Drawing.Point(30, 65);
            this.LblNombreEquipo.Name = "LblNombreEquipo";
            this.LblNombreEquipo.Size = new System.Drawing.Size(111, 15);
            this.LblNombreEquipo.Text = "Nombre de equipo";

            this.TxtNombreEquipo.Location = new System.Drawing.Point(150, 62);
            this.TxtNombreEquipo.Name = "TxtNombreEquipo";
            this.TxtNombreEquipo.Size = new System.Drawing.Size(150, 23);

            this.LblNivel.AutoSize = true;
            this.LblNivel.Location = new System.Drawing.Point(30, 100);
            this.LblNivel.Name = "LblNivel";
            this.LblNivel.Size = new System.Drawing.Size(35, 15);
            this.LblNivel.Text = "Nivel";

            this.CboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboNivel.FormattingEnabled = true;
            this.CboNivel.Items.AddRange(new object[] {
            "Amateur",
            "Experto",
            "Profesional"});
            this.CboNivel.Location = new System.Drawing.Point(150, 97);
            this.CboNivel.Name = "CboNivel";
            this.CboNivel.Size = new System.Drawing.Size(150, 23);

            this.LblExperiencia.AutoSize = true;
            this.LblExperiencia.Location = new System.Drawing.Point(30, 135);
            this.LblExperiencia.Name = "LblExperiencia";
            this.LblExperiencia.Size = new System.Drawing.Size(68, 15);
            this.LblExperiencia.Text = "Experiencia";

            this.TxtExperiencia.Location = new System.Drawing.Point(150, 132);
            this.TxtExperiencia.Name = "TxtExperiencia";
            this.TxtExperiencia.Size = new System.Drawing.Size(150, 23);

            this.LblCodigoEquipoJugador.AutoSize = true;
            this.LblCodigoEquipoJugador.Location = new System.Drawing.Point(30, 210);
            this.LblCodigoEquipoJugador.Name = "LblCodigoEquipoJugador";
            this.LblCodigoEquipoJugador.Size = new System.Drawing.Size(101, 15);
            this.LblCodigoEquipoJugador.Text = "Código de equipo";

            this.TxtCodigoEquipoJugador.Location = new System.Drawing.Point(150, 207);
            this.TxtCodigoEquipoJugador.Name = "TxtCodigoEquipoJugador";
            this.TxtCodigoEquipoJugador.Size = new System.Drawing.Size(150, 23);

            this.LblGamertag.AutoSize = true;
            this.LblGamertag.Location = new System.Drawing.Point(30, 245);
            this.LblGamertag.Name = "LblGamertag";
            this.LblGamertag.Size = new System.Drawing.Size(61, 15);
            this.LblGamertag.Text = "Gamertag";

            this.TxtGamertag.Location = new System.Drawing.Point(150, 242);
            this.TxtGamertag.Name = "TxtGamertag";
            this.TxtGamertag.Size = new System.Drawing.Size(150, 23);

            this.LblNombreJugador.AutoSize = true;
            this.LblNombreJugador.Location = new System.Drawing.Point(30, 280);
            this.LblNombreJugador.Name = "LblNombreJugador";
            this.LblNombreJugador.Size = new System.Drawing.Size(115, 15);
            this.LblNombreJugador.Text = "Nombre de jugador";

            this.TxtNombreJugador.Location = new System.Drawing.Point(150, 277);
            this.TxtNombreJugador.Name = "TxtNombreJugador";
            this.TxtNombreJugador.Size = new System.Drawing.Size(150, 23);

            this.LblEquipos.AutoSize = true;
            this.LblEquipos.Location = new System.Drawing.Point(350, 30);
            this.LblEquipos.Name = "LblEquipos";
            this.LblEquipos.Size = new System.Drawing.Size(49, 15);
            this.LblEquipos.Text = "Equipos";

            this.ListEquipos.FormattingEnabled = true;
            this.ListEquipos.ItemHeight = 15;
            this.ListEquipos.Location = new System.Drawing.Point(350, 50);
            this.ListEquipos.Name = "ListEquipos";
            this.ListEquipos.Size = new System.Drawing.Size(470, 124);

            this.LblJugadores.AutoSize = true;
            this.LblJugadores.Location = new System.Drawing.Point(350, 190);
            this.LblJugadores.Name = "LblJugadores";
            this.LblJugadores.Size = new System.Drawing.Size(61, 15);
            this.LblJugadores.Text = "Jugadores";

            this.ListJugadores.FormattingEnabled = true;
            this.ListJugadores.ItemHeight = 15;
            this.ListJugadores.Location = new System.Drawing.Point(350, 210);
            this.ListJugadores.Name = "ListJugadores";
            this.ListJugadores.Size = new System.Drawing.Size(470, 124);

            this.LblReportes.AutoSize = true;
            this.LblReportes.Location = new System.Drawing.Point(350, 350);
            this.LblReportes.Name = "LblReportes";
            this.LblReportes.Size = new System.Drawing.Size(53, 15);
            this.LblReportes.Text = "Reportes";

            this.ListReportes.FormattingEnabled = true;
            this.ListReportes.ItemHeight = 15;
            this.ListReportes.Location = new System.Drawing.Point(350, 370);
            this.ListReportes.Name = "ListReportes";
            this.ListReportes.Size = new System.Drawing.Size(470, 124);

            this.BtnRegistrarEquipo.Location = new System.Drawing.Point(30, 340);
            this.BtnRegistrarEquipo.Name = "BtnRegistrarEquipo";
            this.BtnRegistrarEquipo.Size = new System.Drawing.Size(140, 30);
            this.BtnRegistrarEquipo.Text = "Registrar equipo";
            this.BtnRegistrarEquipo.UseVisualStyleBackColor = true;
            this.BtnRegistrarEquipo.Click += new System.EventHandler(this.BtnRegistrarEquipo_Click);

            this.BtnRegistrarJugador.Location = new System.Drawing.Point(180, 340);
            this.BtnRegistrarJugador.Name = "BtnRegistrarJugador";
            this.BtnRegistrarJugador.Size = new System.Drawing.Size(140, 30);
            this.BtnRegistrarJugador.Text = "Registrar jugador";
            this.BtnRegistrarJugador.UseVisualStyleBackColor = true;
            this.BtnRegistrarJugador.Click += new System.EventHandler(this.BtnRegistrarJugador_Click);

            this.BtnMostrarEquipos.Location = new System.Drawing.Point(30, 390);
            this.BtnMostrarEquipos.Name = "BtnMostrarEquipos";
            this.BtnMostrarEquipos.Size = new System.Drawing.Size(140, 30);
            this.BtnMostrarEquipos.Text = "Mostrar equipos";
            this.BtnMostrarEquipos.UseVisualStyleBackColor = true;
            this.BtnMostrarEquipos.Click += new System.EventHandler(this.BtnMostrarEquipos_Click);

            this.BtnMostrarJugadores.Location = new System.Drawing.Point(180, 390);
            this.BtnMostrarJugadores.Name = "BtnMostrarJugadores";
            this.BtnMostrarJugadores.Size = new System.Drawing.Size(140, 30);
            this.BtnMostrarJugadores.Text = "Mostrar jugadores";
            this.BtnMostrarJugadores.UseVisualStyleBackColor = true;
            this.BtnMostrarJugadores.Click += new System.EventHandler(this.BtnMostrarJugadores_Click);

            this.BtnMayorExperiencia.Location = new System.Drawing.Point(30, 440);
            this.BtnMayorExperiencia.Name = "BtnMayorExperiencia";
            this.BtnMayorExperiencia.Size = new System.Drawing.Size(140, 30);
            this.BtnMayorExperiencia.Text = "Mayor experiencia";
            this.BtnMayorExperiencia.UseVisualStyleBackColor = true;
            this.BtnMayorExperiencia.Click += new System.EventHandler(this.BtnMayorExperiencia_Click);

            this.BtnSinJugadores.Location = new System.Drawing.Point(180, 440);
            this.BtnSinJugadores.Name = "BtnSinJugadores";
            this.BtnSinJugadores.Size = new System.Drawing.Size(140, 30);
            this.BtnSinJugadores.Text = "Sin jugadores";
            this.BtnSinJugadores.UseVisualStyleBackColor = true;
            this.BtnSinJugadores.Click += new System.EventHandler(this.BtnSinJugadores_Click);

            this.BtnLimpiar.Location = new System.Drawing.Point(30, 490);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(290, 30);
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 560);
            this.Controls.Add(this.LblCodigoEquipo);
            this.Controls.Add(this.TxtCodigoEquipo);
            this.Controls.Add(this.LblNombreEquipo);
            this.Controls.Add(this.TxtNombreEquipo);
            this.Controls.Add(this.LblNivel);
            this.Controls.Add(this.CboNivel);
            this.Controls.Add(this.LblExperiencia);
            this.Controls.Add(this.TxtExperiencia);

            this.Controls.Add(this.LblCodigoEquipoJugador);
            this.Controls.Add(this.TxtCodigoEquipoJugador);
            this.Controls.Add(this.LblGamertag);
            this.Controls.Add(this.TxtGamertag);
            this.Controls.Add(this.LblNombreJugador);
            this.Controls.Add(this.TxtNombreJugador);

            this.Controls.Add(this.BtnRegistrarEquipo);
            this.Controls.Add(this.BtnRegistrarJugador);
            this.Controls.Add(this.BtnMostrarEquipos);
            this.Controls.Add(this.BtnMostrarJugadores);
            this.Controls.Add(this.BtnMayorExperiencia);
            this.Controls.Add(this.BtnSinJugadores);
            this.Controls.Add(this.BtnLimpiar);

            this.Controls.Add(this.LblEquipos);
            this.Controls.Add(this.ListEquipos);
            this.Controls.Add(this.LblJugadores);
            this.Controls.Add(this.ListJugadores);
            this.Controls.Add(this.LblReportes);
            this.Controls.Add(this.ListReportes);

            this.Name = "Form1";
            this.Text = "Liga Profesional de eSports";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
