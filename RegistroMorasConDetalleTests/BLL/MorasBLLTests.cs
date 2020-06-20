using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroMorasConDetalle.BLL;
using RegistroMorasConDetalle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroMorasConDetalle.BLL.Tests
{
    [TestClass()]
    public class MorasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Moras mora = new Moras();

            mora.MoraId = 0;
            mora.Fecha = DateTime.Now;
            mora.Detalle.Add(new MorasDetalle
            {
                MoraId = 1,
                PrestamoId = 1,
                Valor = 10
            });

            paso = MorasBLL.Guardar(mora);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Moras mora = new Moras();

            mora.MoraId = 1;
            mora.Fecha = DateTime.Now;
            mora.Detalle.Add(new MorasDetalle
            {
                MoraId = 1,
                PrestamoId = 1,
                Valor = 50
            });

            paso = MorasBLL.Modificar(mora);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = MorasBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Moras mora = new Moras();
            mora = MorasBLL.Buscar(1);

            Assert.IsNotNull(mora);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool existe = false;
            existe = MorasBLL.Existe(1);

            Assert.AreEqual(existe, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
        }
    }
}