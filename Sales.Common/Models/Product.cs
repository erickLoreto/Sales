﻿namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]        
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode =false)]
        public Decimal Price { get; set; }

        [Display(Name ="Image")]
        public string ImagePath { get; set; }

        [Display(Name = "Is Abailable")]
        public bool IsAbailable { get; set; }

        [Display(Name = "Publish On")]
        [DataType(DataType.Date)]
        public DateTime PublishOn { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath))
                {
                    return "noproduct";
                }
                return $"https://salesbackend20181224013657.azurewebsites.net/{this.ImagePath.Substring(1)}";
            }
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
