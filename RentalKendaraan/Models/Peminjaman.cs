using System;
using System.Collections.Generic;

namespace RentalKendaraan_001.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public Jaminan BiayaNavigation { get; set; }
        public Kendaraan IdCustomer1 { get; set; }
        public Customer IdCustomerNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
