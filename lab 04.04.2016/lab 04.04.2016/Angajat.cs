//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab_04._04._2016
{
    using System;
    using System.Collections.Generic;
    
    public partial class Angajat
    {
        public int Marca { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public Nullable<int> Salariu { get; set; }
        public Nullable<int> CodDep { get; set; }
        public Nullable<System.DateTime> DataAngajare { get; set; }
    
        public virtual Departament Departament { get; set; }
    }
}
