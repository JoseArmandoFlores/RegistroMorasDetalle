﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroMorasConDetalle.BLL;
using RegistroMorasConDetalle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroMorasConDetalle.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Prestamos Prestamo = new Prestamos();

            Prestamo.PrestamoId = 0;
            Prestamo.Fecha = DateTime.Now;
            Prestamo.Persona = "Jose";
            Prestamo.Concepto = "Compra de vehiculo";
            Prestamo.Monto = 60000;

            paso = PrestamosBLL.Guardar(Prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Prestamos Prestamo = new Prestamos();

            Prestamo.PrestamoId = 1;
            Prestamo.Fecha = DateTime.Now;
            Prestamo.Persona = "Jose";
            Prestamo.Concepto = "Compra de vehiculo";
            Prestamo.Monto = 90000;

            paso = PrestamosBLL.Modificar(Prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = PrestamosBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Prestamos prestamo = PrestamosBLL.Buscar(1);
            bool paso = false;

            if (prestamo != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PrestamosBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }
    }
}