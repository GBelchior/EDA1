using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paint;
using System.Drawing;

namespace Teste
{
    [TestClass]
    public class TestesColorir
    {
        private frmPrincipal form1;
        private Pintor pintor;

        private void InitTests()
        {
            form1 = new frmPrincipal();
            pintor = new Pintor();
        }

        [TestMethod]
        public void TestaFila()
        {
            Fila f = new Fila(10);
            Assert.AreEqual(true, f.Empty());
            f.Insert("A");
            Assert.AreEqual(false, f.Empty());
            f.Insert("B");
            f.Insert("C");
            string x = f.Remove().ToString();
            Assert.AreEqual("A", x);
            x = f.Remove().ToString();
            Assert.AreEqual("B", x);
        }

        [TestMethod]
        public void Colorir1()
        {
            InitTests();
            int res = pintor.Colorir(261, 313, Color.FromArgb(255, 0, 0), form1.Image);
            Assert.AreEqual(res, 18863);
        }
        [TestMethod]
        public void Colorir2()
        {
            InitTests();
            int res = pintor.Colorir(92, 84, Color.FromArgb(255, 0, 0), form1.Image);
            Assert.AreEqual(res, 857);
        }
        [TestMethod]
        public void ColorirBordas()
        {
            InitTests();
            int res = pintor.Colorir(468, 67, Color.FromArgb(255, 0, 0), form1.Image);
            Assert.AreEqual(res, 108539);
            
        }
        [TestMethod]
        public void ColorirMesmaCor()
        {
            InitTests();
            int res = pintor.Colorir(421, 285, Color.FromArgb(0, 0, 0), form1.Image);
            Assert.AreEqual(res, 0);
        }



    }
}
