//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SourceControlFinalAssignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class tbl_userdata
    {
        public int Id { get; set; }
      
        
        
        
        [Required(ErrorMessage = "This filed is required")]
        [MinLength(6, ErrorMessage = "Please enter minimum 6 characters. ")]
        [Display(Name = "Enter your Username")]
        public string Username { get; set; }


        [Required(ErrorMessage = "This filed is required")]
        [EmailAddress(ErrorMessage = "Please enter your email address properly")]
        [Display(Name = "Enter your email address")]
        public string Email { get; set; }



        [Required(ErrorMessage = "This filed is required")]
        [Display(Name = "Enter your password")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Please enter your password with minimum 5 characters")]
        public string Password { get; set; }



        [Required(ErrorMessage = "This filed is required")]
        [Display(Name = "Confirm your password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }



        [Required(ErrorMessage = "This filed is required")]
        [Display(Name = "Enter your Age")]
        [Range(18, 100, ErrorMessage = "Please User age should be between 18 to 100")]
        public string Age { get; set; }




        [Required(ErrorMessage = "This filed is required")]
        [Display(Name = "Enter your mobile number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Please enter valid mobile number")]
        public long Phoneno { get; set; }




        [Required(ErrorMessage = "This filed is required")]
        public string Profile { get; set; }
    }
}
