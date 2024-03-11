using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices;

        public class account
        {
                [Key]
                public int? id_user { get; set; }
                public string? fio { get; set; }
                public string? n_phone { get; set; }
                public string? address { get; set;}
                public string? payment { get; set;}
                public string? email { get; set;}
                public string? login { get; set;}
                public string? password { get; set;}
                public string? type_user { get; set;}
                public static account? currentUser { get; set; }
        }
        

        public class products
        {
                [Key]
                public int? id_product { get; set; }
                public string? category { get; set;}
                public string? name_product { get;set;}
                public string? kolichestvo { get; set;}
                public string? price { get; set;}
                public int? contract { get; set;}
                public int? id_action { get; set;}   
                public byte[]? image { get; set;}
                public static products? currentList { get; set; }
        }

