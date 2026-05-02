using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        List<Equipo> listaEquipos = new List<Equipo>();

        public Form1()
        {
            InitializeComponent();
            CboNivel.SelectedIndex = 0;
        }

        private void MostrarEquipos()
        {
            ListEquipos.Items.Clear();

            foreach (Equipo equipo in listaEquipos)
            {
                ListEquipos.Items.Add(equipo.Codigo + " - " + equipo.Nombre + " - " + equipo.Nivel + " - Torneos: " + equipo.Experiencia);
            }
        }

        private void MostrarJugadoresDeEquipo()
        {
            ListJugadores.Items.Clear();

            if (TxtCodigoEquipoJugador.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código del equipo");
                return;
            }

            int codigo = int.Parse(TxtCodigoEquipoJugador.Text);

            Equipo equipo = listaEquipos.Find(x => x.Codigo == codigo);

            if (equipo == null)
            {
                MessageBox.Show("No existe un equipo con ese código");
                return;
            }

            ListJugadores.Items.Add("Equipo: " + equipo.Nombre);

            foreach (Jugador jugador in equipo.ListaJugadores)
            {
                ListJugadores.Items.Add(jugador.Gamertag + " - " + jugador.Nombre);
            }
        }

        private void LimpiarCajas()
        {
            TxtCodigoEquipo.Clear();
            TxtNombreEquipo.Clear();
            TxtExperiencia.Clear();
            TxtCodigoEquipoJugador.Clear();
            TxtGamertag.Clear();
            TxtNombreJugador.Clear();
            CboNivel.SelectedIndex = 0;
            TxtCodigoEquipo.Focus();
        }

        private void BtnRegistrarEquipo_Click(object sender, EventArgs e)
        {
            if (TxtCodigoEquipo.Text.Trim() == "" || TxtNombreEquipo.Text.Trim() == "" || TxtExperiencia.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar los datos del equipo");
                return;
            }

            int codigo = int.Parse(TxtCodigoEquipo.Text);
            string nombre = TxtNombreEquipo.Text;
            string nivel = CboNivel.Text;
            int experiencia = int.Parse(TxtExperiencia.Text);

            Equipo existenteCodigo = listaEquipos.Find(x => x.Codigo == codigo);

            if (existenteCodigo != null)
            {
                MessageBox.Show("Ya existe un equipo con ese código");
                return;
            }

            Equipo existenteNombre = listaEquipos.Find(x => x.Nombre == nombre);

            if (existenteNombre != null)
            {
                MessageBox.Show("Ya existe un equipo con ese nombre");
                return;
            }

            Equipo nuevo = new Equipo()
            {
                Codigo = codigo,
                Nombre = nombre,
                Nivel = nivel,
                Experiencia = experiencia,
                ListaJugadores = new List<Jugador>()
            };

            listaEquipos.Add(nuevo);

            MessageBox.Show("Equipo registrado correctamente");

            MostrarEquipos();
        }

        private void BtnRegistrarJugador_Click(object sender, EventArgs e)
        {
            if (TxtCodigoEquipoJugador.Text.Trim() == "" || TxtGamertag.Text.Trim() == "" || TxtNombreJugador.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar los datos del jugador");
                return;
            }

            int codigoEquipo = int.Parse(TxtCodigoEquipoJugador.Text);
            string gamertag = TxtGamertag.Text;
            string nombre = TxtNombreJugador.Text;

            Equipo equipo = listaEquipos.Find(x => x.Codigo == codigoEquipo);

            if (equipo == null)
            {
                MessageBox.Show("No existe un equipo con ese código");
                return;
            }

            Jugador existente = equipo.ListaJugadores.Find(x => x.Gamertag == gamertag);

            if (existente != null)
            {
                MessageBox.Show("Ya existe un jugador con ese gamertag en este equipo");
                return;
            }

            Jugador nuevo = new Jugador()
            {
                Gamertag = gamertag,
                Nombre = nombre
            };

            equipo.ListaJugadores.Add(nuevo);

            MessageBox.Show("Jugador registrado correctamente");

            MostrarJugadoresDeEquipo();
        }

        private void BtnMostrarEquipos_Click(object sender, EventArgs e)
        {
            MostrarEquipos();
        }

        private void BtnMostrarJugadores_Click(object sender, EventArgs e)
        {
            MostrarJugadoresDeEquipo();
        }

        private void BtnMayorExperiencia_Click(object sender, EventArgs e)
        {
            ListReportes.Items.Clear();

            if (listaEquipos.Count == 0)
            {
                MessageBox.Show("No hay equipos registrados");
                return;
            }

            int mayor = listaEquipos[0].Experiencia;

            foreach (Equipo equipo in listaEquipos)
            {
                if (equipo.Experiencia > mayor)
                {
                    mayor = equipo.Experiencia;
                }
            }

            ListReportes.Items.Add("Equipos con mayor experiencia:");
            ListReportes.Items.Add("Experiencia: " + mayor + " torneos");

            foreach (Equipo equipo in listaEquipos)
            {
                if (equipo.Experiencia == mayor)
                {
                    ListReportes.Items.Add(equipo.Codigo + " - " + equipo.Nombre + " - " + equipo.Nivel);
                }
            }
        }

        private void BtnSinJugadores_Click(object sender, EventArgs e)
        {
            ListReportes.Items.Clear();

            if (listaEquipos.Count == 0)
            {
                MessageBox.Show("No hay equipos registrados");
                return;
            }

            ListReportes.Items.Add("Equipos sin jugadores registrados:");

            foreach (Equipo equipo in listaEquipos)
            {
                if (equipo.ListaJugadores.Count == 0)
                {
                    ListReportes.Items.Add(equipo.Codigo + " - " + equipo.Nombre + " - " + equipo.Nivel);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
    }

    public class Equipo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Nivel { get; set; }
        public int Experiencia { get; set; }
        public List<Jugador> ListaJugadores { get; set; }
    }

    public class Jugador
    {
        public string Gamertag { get; set; }
        public string Nombre { get; set; }
    }
}
