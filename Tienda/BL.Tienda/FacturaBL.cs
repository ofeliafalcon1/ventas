﻿using System;
using System.ComponentModel;
using System.Data.Entity;

namespace BL.Tienda
{
    public class FacturaBL
    {
        Contexto _contexto;

        public BindingList<Factura> ListaFacturas { get; set; }

        public FacturaBL()
        {
            _contexto = new Contexto();
        }

        public BindingList<Factura> ObtenerFacturas()
        {
            _contexto.Facturas.Include("FacturasDetalles").Load();
            ListaFacturas = _contexto.Facturas.Local.ToBindingList();

            return ListaFacturas;
        }

        public void AgregarFactura()
        {
            var nuevaFactura = new Factura();
            _contexto.Facturas.Add(nuevaFactura);
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarFactura(Factura factura)
        {
            var resultado = new Validar(factura);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        private Resultado Validar(Factura factura)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            return resultado;
        }
    }

    public class Factura
        {
            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }
            public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
            public double Subtotal { get; set; }
            public double Impuesto { get; set; }
            public double Total { get; set; }
            public bool Activo { get; set; }

            public Factura()
            {
                Fecha = DateTime.Now;
                FacturaDetalle = new BindingList<FacturaDetalle>();
                Activo = true;
            }
        }

        public class FacturaDetalle
        {
            public int Id { get; set; }
            public int ProductoId { get; set; }
            public Producto Producto { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Total { get; set; }

            public FacturaDetalle()
            {
                Cantidad = 1;
            }
        }
    }

