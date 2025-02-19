﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Membership.Entities
{
    [Table("Subscription")]
    public class Subscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(2048)]
        public string Description { get; set; }
        [MaxLength(20)]
        [DisplayName("Registration Code")]
        public string RegistrationCode { get; set; }
    }
}