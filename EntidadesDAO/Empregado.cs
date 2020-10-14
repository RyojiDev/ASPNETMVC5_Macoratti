namespace EntidadesDAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empregados")]
    public partial class Empregado
    {
        public int EmpregadoId { get; set; }

        public int DepartamentoId { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string SobreNome { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}
