﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindWEB.Models
{
    public partial class CustomerCustomerDemo
    {
        [Key]
        [Column("CustomerID")]
        [StringLength(5)]
        public string CustomerId { get; set; }
        [Key]
        [Column("CustomerTypeID")]
        [StringLength(10)]
        public string CustomerTypeId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(Customers.CustomerCustomerDemo))]
        public virtual Customers Customer { get; set; }
        [ForeignKey(nameof(CustomerTypeId))]
        [InverseProperty(nameof(CustomerDemographics.CustomerCustomerDemo))]
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
