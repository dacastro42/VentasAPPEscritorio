using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasAPPEscritorio.controllers;

namespace VentasAPPEscritorio.views
{
    public partial class FrmCarroMultimedia : Form
    {
        private readonly int _carroId;
        private readonly CarroController carroController = new CarroController();
        public FrmCarroMultimedia()
        {
            InitializeComponent();
        }

        public FrmCarroMultimedia(int carroId, string nombreCarro = "")
        {
            InitializeComponent();
            
            Debug.WriteLine("si llego  :  " + carroId + "nombreC " + nombreCarro);
           // Console.WriteLine("si llego  :  " + carroId + "nombreC " + nombreCarro);

            
            _carroId = carroId;
            Debug.WriteLine("si llegohhhhhhhhhhhhh :  " + _carroId);
            lblCarro.Text = string.IsNullOrWhiteSpace(nombreCarro)
                ? $"Carro ID: {_carroId}"
                : nombreCarro;

            this.Load += FrmCarroMultimedia_Load;
            CargarListadoMultimedia();
        }

        private void FrmCarroMultimedia_Load(object sender, EventArgs e)
        {
            CargarFotoPrincipal();
            // luego: CargarListadoMultimedia();
        }

        private void CargarFotoPrincipal()
        {
            string url = carroController.ObtenerFotoPrincipal(_carroId);

            //MessageBox.Show("URL desde BD:\n" + (url ?? "NULL"));

            if (string.IsNullOrWhiteSpace(url))
            {
                pbPrincipal.Image = null;
                return;
            }

            // normaliza / a \ en Windows
            string urlNorm = url.Replace('/', Path.DirectorySeparatorChar);

            // apunta a raíz del proyecto (no al bin)
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\.."));
            string rutaCompleta = Path.Combine(projectRoot, urlNorm);

            //MessageBox.Show("Ruta completa:\n" + rutaCompleta + "\nExiste?: " + File.Exists(rutaCompleta));

            if (!File.Exists(rutaCompleta))
            {
                pbPrincipal.Image = null;
                return;
            }

            // evita bloqueo de archivo al recargar
            pbPrincipal.Image?.Dispose();
            pbPrincipal.Image = Image.FromFile(rutaCompleta);
            pbPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void CargarListadoMultimedia()
        {
            MessageBox.Show("CarroId recibido: " + _carroId);
            var dt = carroController.ListarMultimediaPorCarro(_carroId);
            dgvMedia.DataSource = dt;
            MessageBox.Show("Filas multimedia: " + dt.Rows.Count);
            dgvMedia.Columns["url_recurso"].Visible = false;
            dgvMedia.Columns["es_principal"].HeaderText = "Principal";
        }

        private void btnAbrirRecurso_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("btnAbrirRecurso clicked");
        }
    }
}
