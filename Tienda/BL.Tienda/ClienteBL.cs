﻿using System.ComponentModel;
using System.Data.Entity;

namespace BL.Tienda
{
    public class ClienteBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClienteBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();

            return ListaClientes;
        }


        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}



