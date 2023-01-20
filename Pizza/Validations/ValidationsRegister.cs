using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizza.Validations.Models
{
    public partial class VUser
    {
        [Display(Name = "รหัส")]
        [Required(ErrorMessage = "การุณาป้อนข้อมูล")]
        public int User_ID { get; set; }


        [Display(Name = "ชื่อผู้ใช้")]
        [Required(ErrorMessage = "การุณาป้อนข้อมูล")]
        public string User_Name { get; set; }


        [Display(Name = "รหัสผ่านผู้ใช้")]
        [Required(ErrorMessage = "การุณาป้อนข้อมูล")]
        public string User_Password { get; set; }


        [Display(Name = "คำนำหน้าชื่อ")]
        public string User_TitleID { get; set; }


        [Display(Name = "ที่อยู่ผู้ใช้")]
        [Required(ErrorMessage = "การุณาป้อนข้อมูล")]
        public string User_Address { get; set; }


        [Display(Name = "เบอร์มือถือผู้ใช้")]
        [Required(ErrorMessage = "การุณาป้อนข้อมูล")]
        public string User_Phone { get; set; }
    }
    [MetadataType(typeof(VUser))]
    public partial class Users { }
    /////////////////////////////////////////////////////////////////////////////////////////////////
}