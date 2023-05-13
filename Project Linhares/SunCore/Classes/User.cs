using System;

namespace SunCore.Classes
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual int IdEmployee { get; set; }
        /// <summary>
        /// 1: Administrador
        /// 2: Comum
        /// </summary>
        public virtual int AccessType { get; set; }
        /// <summary>
        /// 1: Quilômetros
        /// 2: Hectares
        /// 3: Milhas
        /// </summary>
        public virtual int Unity { get; set; } 
        public virtual string Password { get; set; } //Max: 100
        public virtual DateTime LastLogin { get; set; }
        public virtual DateTime FirstLogin { get; set; }
        
    }
}
