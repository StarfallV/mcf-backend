using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace mcf_backend.Models
{
    public class TrBpkb
    {
        public int Id { get; set; }

        public string? agreement_number { get; set; }

        public string? bpkb_no { get; set; }

        public string? branch_id { get; set; }

        public DateTime? bpkb_date { get; set; }
        public string? faktur_no { get; set; }
        public DateTime? faktur_date { get; set; }
        public string? location_id { get; set; }
        public string? police_no { get; set; }
        public DateTime? bpkb_date_in { get; set; }
    }
}