﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Cheques
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        #region Funcionalidades del formulario

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0,0,0));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AccountPage>();
            button1.BackColor = Color.FromArgb(82, 97, 48);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BeneficiaryPage>();
            button2.BackColor = Color.FromArgb(82, 97, 48);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CheckPage>();
            button3.BackColor = Color.FromArgb(82, 97, 48);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
            button4.BackColor = Color.FromArgb(82,97,48);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion 

        //Metodo para abrir Formularios dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form,new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//busca en la colección el formulario
            //si el formulario no existe
            if (formulario == null)
            {
                formulario= new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(closedForm);
            }
            else
            {
                formulario.BringToFront();
            }

        }
        private void closedForm(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms["AccountPage"] == null)
            {
                button1.BackColor = Color.FromArgb(128, 151, 75);
                
            }
            if (Application.OpenForms["BeneficiaryPages"] == null)
            {
                button2.BackColor = Color.FromArgb(128, 151, 75);
                
            }
            if (Application.OpenForms["CheckPage"] == null)
            {
                button3.BackColor = Color.FromArgb(128, 151, 75);
                
            }
            if (Application.OpenForms["Form4"] == null)
            {
                button4.BackColor = Color.FromArgb(128, 151, 75);
                 
            }
        }
        private void btnCerrarOtrosFormularios_Click(object sender, EventArgs e)
        {
            // Recorre todos los formularios abiertos en la aplicación
            foreach (Form form in Application.OpenForms)
            {
                // Si el formulario no es el actual y no es el formulario principal de la aplicación
                if (form != this && form.Name != "frmPrincipal")
                {
                    // Cierra el formulario
                    form.Close();
                }
            }
        }

    }
}