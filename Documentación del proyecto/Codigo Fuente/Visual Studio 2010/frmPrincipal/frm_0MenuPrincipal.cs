﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frm_0MenuPrincipal : Form
    {
        public frm_0MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Desea salir del Sistema", "Cierre del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seguridad_Login ventanaLogin = new frm_Seguridad_Login();
            ventanaLogin.ShowDialog();
        }

        private void NuevoTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_NuevoTicket ventanaNuevoTicket = new frm_Ticket_NuevoTicket();
            ventanaNuevoTicket.ShowDialog();
        }

        private void btn_NuevoTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_NuevoTicket ventanaNuevoTicket = new frm_Ticket_NuevoTicket();
            ventanaNuevoTicket.ShowDialog();
        }

        private void CatalogoAsignacionDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoAsignacionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoAsignacionTicket();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void btn_AsignarTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoAsignacionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoAsignacionTicket();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void CatalogoAtencionDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoSeleccionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoSeleccionTicket();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void btn_AtencionTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_CatalogoSeleccionTicket ventanaCatalogoTicket = new frm_Ticket_CatalogoSeleccionTicket();
            ventanaCatalogoTicket.ShowDialog();
        }

        private void BitacoraTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket_BitacoraTicket ventanaBitacoraTicket = new frm_Ticket_BitacoraTicket();
            ventanaBitacoraTicket.ShowDialog();
        }

        private void btn_BitacoraTicket_Click(object sender, EventArgs e)
        {
            frm_Ticket_BitacoraTicket ventanaBitacoraTicket = new frm_Ticket_BitacoraTicket();
            ventanaBitacoraTicket.ShowDialog();
        }

        private void administracionPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionPerfiles ventanaAdministracionPerfiles = new frm_Seguridad_AdministracionPerfiles();
            ventanaAdministracionPerfiles.ShowDialog();
        }

        private void btn_AdministracionPerfiles_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionPerfiles ventanaAdministracionPerfiles = new frm_Seguridad_AdministracionPerfiles();
            ventanaAdministracionPerfiles.ShowDialog();
        }

        private void administracionCuentasUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionCuentasUsuario ventanaAdministracionCuentas = new frm_Seguridad_AdministracionCuentasUsuario();
            ventanaAdministracionCuentas.ShowDialog();
        }

        private void btn_AdministracionCuentasUsuario_Click(object sender, EventArgs e)
        {
            frm_Seguridad_AdministracionCuentasUsuario ventanaAdministracionCuentas = new frm_Seguridad_AdministracionCuentasUsuario();
            ventanaAdministracionCuentas.ShowDialog();
        }

        private void nuevoUsuarioFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seguridad_NuevoUsuarioFinal ventanaNuevoUsuario = new frm_Seguridad_NuevoUsuarioFinal();
            ventanaNuevoUsuario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Seguridad_NuevoUsuarioFinal ventanaNuevoUsuario = new frm_Seguridad_NuevoUsuarioFinal();
            ventanaNuevoUsuario.ShowDialog();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaFactura ventanaNuevaFactura = new frm_CxC_CxP_NuevaFactura();
            ventanaNuevaFactura.ShowDialog();
        }

        private void btn_NuevaFactura_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaFactura ventanaNuevaFactura = new frm_CxC_CxP_NuevaFactura();
            ventanaNuevaFactura.ShowDialog();
        }

        private void envioEstadoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_EnvioEstadosCuenta ventanaEnvioEstadosCuenta = new frm_CxC_CxP_EnvioEstadosCuenta();
            ventanaEnvioEstadosCuenta.ShowDialog();
        }

        private void btn_EnvioEstadosCuenta_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_EnvioEstadosCuenta ventanaEnvioEstadosCuenta = new frm_CxC_CxP_EnvioEstadosCuenta();
            ventanaEnvioEstadosCuenta.ShowDialog();
        }

        private void solicitudOrdenesCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoOrdenesDeCompra ventanaCatalogoOrdenesCompra = new frm_CxC_CxP_CatalogoOrdenesDeCompra();
            ventanaCatalogoOrdenesCompra.ShowDialog();
        }

        private void btn_SolictudOrdenesCompra_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoOrdenesDeCompra ventanaCatalogoOrdenesCompra = new frm_CxC_CxP_CatalogoOrdenesDeCompra();
            ventanaCatalogoOrdenesCompra.ShowDialog();
        }

        private void nuevaOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaOrdenCompra ventanaNuevaOrdenCompra = new frm_CxC_CxP_NuevaOrdenCompra();
            ventanaNuevaOrdenCompra.ShowDialog();
        }

        private void btn_nuevaOrdenCompra_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevaOrdenCompra ventanaNuevaOrdenCompra = new frm_CxC_CxP_NuevaOrdenCompra();
            ventanaNuevaOrdenCompra.ShowDialog();
        }

        private void catalgoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoProveedores ventanaCatalogoProveedores = new frm_CxC_CxP_CatalogoProveedores();
            ventanaCatalogoProveedores.ShowDialog();
        }

        private void btn_CatalogoProveedores_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_CatalogoProveedores ventanaCatalogoProveedores = new frm_CxC_CxP_CatalogoProveedores();
            ventanaCatalogoProveedores.ShowDialog();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevoProveedor ventanaNuevoProveedor = new frm_CxC_CxP_NuevoProveedor();
            ventanaNuevoProveedor.ShowDialog();
        }

        private void btn_NuevoProveedor_Click(object sender, EventArgs e)
        {
            frm_CxC_CxP_NuevoProveedor ventanaNuevoProveedor = new frm_CxC_CxP_NuevoProveedor();
            ventanaNuevoProveedor.ShowDialog();
        }

        private void controlNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlNomina ventanaControlNomina = new frm_RRHH_ControlNomina();
            ventanaControlNomina.ShowDialog();
        }

        private void btn_ControlNomina_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlNomina ventanaControlNomina = new frm_RRHH_ControlNomina();
            ventanaControlNomina.ShowDialog();
        }

        private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevoEmpleado ventanaNuevoEmpleado = new frm_RRHH_NuevoEmpleado();
            ventanaNuevoEmpleado.ShowDialog();
        }

        private void nuevoEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevoEmpleado ventanaNuevoEmpleado = new frm_RRHH_NuevoEmpleado();
            ventanaNuevoEmpleado.ShowDialog();
        }

        private void controlVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlVacaciones ventanaControlVacaciones = new frm_RRHH_ControlVacaciones();
            ventanaControlVacaciones.ShowDialog();
        }

        private void btn_ControlVacaciones_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlVacaciones ventanaControlVacaciones = new frm_RRHH_ControlVacaciones();
            ventanaControlVacaciones.ShowDialog();
        }

        private void solicitudDeVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaSolicitudVacaciones ventanaSolicitudVacaciones = new frm_RRHH_NuevaSolicitudVacaciones();
            ventanaSolicitudVacaciones.ShowDialog();
        }

        private void btn_SolicitudVacaciones_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaSolicitudVacaciones ventanaSolicitudVacaciones = new frm_RRHH_NuevaSolicitudVacaciones();
            ventanaSolicitudVacaciones.ShowDialog();
        }

        private void controlIncapacidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlIncapacidades ventanaControlIncapacidades = new frm_RRHH_ControlIncapacidades();
            ventanaControlIncapacidades.ShowDialog();
        }

        private void btn_ControlIncapacidades_Click(object sender, EventArgs e)
        {
            frm_RRHH_ControlIncapacidades ventanaControlIncapacidades = new frm_RRHH_ControlIncapacidades();
            ventanaControlIncapacidades.ShowDialog();
        }

        private void ingresoDeIncapacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaIncapacidad ventanaIngresoIncapacidad = new frm_RRHH_NuevaIncapacidad();
            ventanaIngresoIncapacidad.ShowDialog();
        }

        private void btn_IngresoIncapacidad_Click(object sender, EventArgs e)
        {
            frm_RRHH_NuevaIncapacidad ventanaIngresoIncapacidad = new frm_RRHH_NuevaIncapacidad();
            ventanaIngresoIncapacidad.ShowDialog();
        }

    }
}
