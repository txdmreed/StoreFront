using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.Data.EF/*.MetaData*/
{
    [MetadataType(typeof(ColorCodeMetaData))]
    public partial class Color {}

        #region ColorCode MetaData
        public class ColorCodeMetaData
        {
            [Required(ErrorMessage = "*Color Code Required*")]
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Color Code Name")]
            public string ColorCode { get; set; }
        }
    #endregion

    [MetadataType(typeof(DivisionMetaData))]
    public partial class Division { }


    #region Division MetaData
    public class DivisionMetaData
        {
            [Required(ErrorMessage = "*Division Name Required*")]
            [StringLength(20, ErrorMessage = "*20 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Division Name")]
            public string DivisionName { get; set; }
        }
    #endregion

    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee { }

    #region Employee MetaData
    public class EmployeeMetaData
        {
            [Required(ErrorMessage = "*Last Name Required*")]
            [StringLength(20, ErrorMessage = "*20 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
            [Required(ErrorMessage = "*First Name Required*")]
            [StringLength(20, ErrorMessage = "*20 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }
            [StringLength(30, ErrorMessage = "*30 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string Title { get; set; }
            [StringLength(25, ErrorMessage = "*25 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string TitleOfCourtesy { get; set; }
            [DisplayFormat(NullDisplayText = "*Not Available*", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Display(Name = "Date Published")]
            public Nullable<System.DateTime> BirthDate { get; set; }
            [DisplayFormat(NullDisplayText = "*Not Available*", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Display(Name = "Date Published")]
            public Nullable<System.DateTime> HireDate { get; set; }
            [StringLength(60, ErrorMessage = "*60 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string Address { get; set; }
            [StringLength(25, ErrorMessage = "*25 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string City { get; set; }
            [StringLength(2, ErrorMessage = "*2 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string State { get; set; }
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string ZipCode { get; set; }
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string PrimaryPhone { get; set; }
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string SecondaryPhone { get; set; }
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            [UIHint("MultilineText")]
            [StringLength(2, ErrorMessage = "*2 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            public string Notes { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            [Display(Name = "Price Index ID")]
            public Nullable<int> DirectReport { get; set; }
        }
    #endregion

    [MetadataType(typeof(PriceIndexMetaData))]
    public partial class PriceIndex { }

    #region PriceIndex MetaData
    public class PriceIndexMetaData
        {
            [Required(ErrorMessage = "*Division Name Required*")]
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Price Index")]
            public string PriceIndex1 { get; set; }
            [StringLength(50, ErrorMessage = "*50 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [UIHint("MultilineText")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string Description { get; set; }
        }
    #endregion

    [MetadataType(typeof(PropertyMetaData))]
    public partial class Property { }


    #region Property MetaData
    public class PropertyMetaData
        {
            [Required(ErrorMessage = "*Product ID# Required*")]
            [Display(Name = "Product ID#")]
            public int ProductID { get; set; }
            [StringLength(20, ErrorMessage = "*25 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Fiber Code")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            public string FiberCode  { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            public Nullable<int> Weight { get; set; }
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            [StringLength(25, ErrorMessage = "*25 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            public string Color { get; set; }
            [Required(ErrorMessage = "*Product Origin Type Required*")]
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Product Origin Type")]
            public string OriginCode { get; set; }

            public bool Baby { get; set; }
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Activity Type")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            public string ActivityType { get; set; }
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "End Product Type")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            public string EndProductType { get; set; }
            [StringLength(10, ErrorMessage = "*10 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            public string Size { get; set; }
        }
    #endregion

    [MetadataType(typeof(ProductBoardMetaData))]
    public partial class ProductBoard { }


    #region ProductBoard MetaData
    public class ProductBoardMetaData
        {
            [Required(ErrorMessage = "*Product Name Required*")]
            [StringLength(50, ErrorMessage = "*50 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Product Name")]
            public string ProductName { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            [Display(Name = "Division ID")]
            public Nullable<int> DivisonID { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            [Display(Name = "Price Index ID")]
            public Nullable<int> PriceIndexID { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            [Display(Name = "Color Code ID")]
            public Nullable<int> ColorCodeID { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*", DataFormatString = "{0:c}")]
            [Display(Name = "Color Code ID")]
            public Nullable<decimal> Price { get; set; }
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Stock Status")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            public string StockStat { get; set; }
            [UIHint("MultilineText")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*")]
            public string Description { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*", DataFormatString = "{0:c}")]
            [Display(Name = "Units Sold")]
            public Nullable<int> UnitsSold { get; set; }
            [Range(0, double.MaxValue, ErrorMessage = "*Value invalid. Must enter value greater than zero.")]
            [DisplayFormat(NullDisplayText = "*Not Available/Applicable*", DataFormatString = "{0:c}")]
            [Display(Name = "Vendor ID")]
            public Nullable<int> VendorID { get; set; }
        }
    #endregion

    [MetadataType(typeof(VendorMetaData))]
    public partial class Vendor { }

    #region Vendor MetaData
    public class VendorMetaData
        {
         
            [Required(ErrorMessage = "*Company Name Required*")]
            [StringLength(30, ErrorMessage = "*30 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [Display(Name = "Company Name")]
            public string VendorCompanyName { get; set; }
            [StringLength(25, ErrorMessage = "*25 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            [Display(Name = "Company Contact Name")]
            public string VendorContactName { get; set; }
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            [Display(Name = "Contact Title")]
            public string VendorContactTitle { get; set; }
            [StringLength(15, ErrorMessage = "*15 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            public string VendorPhoneNo { get; set; }
            [StringLength(50, ErrorMessage = "*50 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            [Display(Name = "Address")]
            public string VendorAddress { get; set; }
            [StringLength(50, ErrorMessage = "*50 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            [Display(Name = "City")]
            public string VendorCity { get; set; }
            [StringLength(2, ErrorMessage = "*2 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            [Display(Name = "State")]
            public string VendorState { get; set; }
            [StringLength(10, ErrorMessage = "*10 character max limit reached. Please, contact your system administrator for assistance if more character spaces are needed.")]
            [DisplayFormat(NullDisplayText = "*Not Available*")]
            [Display(Name = "Zip Code")]
            public string VendorZipCode { get; set; }
            [Display(Name = "Local Artisan")]
            public bool HomeVendorLocal { get; set; }
        }



    
}
#endregion