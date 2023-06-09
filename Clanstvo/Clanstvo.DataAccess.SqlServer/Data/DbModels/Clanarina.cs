﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Clanstvo.DataAccess.SqlServer.Data.DbModels
{ 
    public partial class Clanarina
    {
        [Key]
        public int Id { get; set; }
        public bool Placenost { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Iznos { get; set; }
        public int Godina { get; set; }
        public int ClanId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        [ForeignKey("ClanId")]
        [InverseProperty("Clanarina")]
        public virtual Clan Clan { get; set; }
    }
}