using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataPenumpang;

namespace UnitTestTravel
{
    [TestClass]
    public class TravelTest
    {
        Penumpang penumpang = new Penumpang()
        {
            Nama = "Khairun Nisa' Zuqri",
            Nik = "1420993013130004",
            Tujuan = "Semarang",
            Jenis = "Eksekutif"
        };

        [TestMethod]
        public void TestInisial()
        {
            string inisial = penumpang.Inisial();
            string expected = "KNZ";
            Assert.AreEqual(inisial, expected, "Perhitungan Inisial Salah");

        }

        [TestMethod]
        public void TestKodeTujuan()
        {
            string kode = penumpang.KodeTujuan();
            string expected = "SMG";
            Assert.AreEqual(kode, expected, "Perhitungan Kode Tujuan Salah");

        }

        [TestMethod]
        public void TestHarga()
        {
            penumpang.HitungHarga();
            string expected = "Rp100.000,00";
            Assert.AreEqual(penumpang.Harga, expected, "Perhitungan Harga Salah");

        }
    }
}
