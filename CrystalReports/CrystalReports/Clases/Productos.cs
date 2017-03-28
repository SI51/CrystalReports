using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrystalReports
{
    [Table("Permisos")]
    public class Productos
    {
        [Key]
        public int pkProducto { get; set; }

        [Required(ErrorMessage = "Requiere el nombre")]
        [StringLength(150)]
        public String sNombreCorto { get; set; }

        [Required(ErrorMessage = "requiere Departamento")]
        [StringLength(150)]
        public String sDepartamento { get; set; }

        [Required(ErrorMessage = "requiere una clasificacion")]
        [StringLength(150)]
        public String sClasificacion { get; set; }

        public Decimal dPrecio { get; set; }

        public Decimal dCosto { get; set; }

        public int iStock { get; set; }

        public Boolean bStatus { get; set; }

        public Productos()
        {

            this.bStatus = true;
        }
        
    
        
    }
}