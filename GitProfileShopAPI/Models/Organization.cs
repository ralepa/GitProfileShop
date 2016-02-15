using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitProfileShopAPI.Models
{
    /// <summary>
    /// Classe que representa uma organização
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Id da organização
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Desenvolvedores da organização
        /// </summary>
        public List<Developer> Developers { get; set; }
    }
}