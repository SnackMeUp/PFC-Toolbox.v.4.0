﻿using System.Configuration;
using System.Web;
using System.Web.Http;
using DataTables;
using PFC_Toolbox.v._4._0.Models;

namespace PFC_Toolbox.v._4._0.Controllers
{
    public class ProductUpdatesController : ApiController
    {


        [Route("api/ProductMaintenance")]
        [HttpGet]
        [HttpPost]
        public IHttpActionResult ProductMaintenance()
        {
            var request = HttpContext.Current.Request;

            using (var db = new Database("sqlserver", ConfigurationManager.ConnectionStrings["ToolboxConnection"].ConnectionString))
            {
                var response = new Editor(db, "ProductUpdates", "productupdateID")
                    .Model<ProductUpdatesModel>()
                    .Field(new Field("ProductUpdates.productupdateID")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.productstatusID")
                    .Options(new Options()
                    .Table("ProductUpdateStatuses")
                    .Value("productstatusID")
                    .Label("productupdatestatus"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("Status.productupdatestatus")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.requesttypeID")
                    .Options(new Options()
                    .Table("RequestTypes")
                    .Value("requesttypeID")
                    .Label("requestname"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("RequestTypes.requestname")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.locationID")
                    .Options(new Options()
                    .Table("Locations")
                    .Value("locationID")
                    .Label("locationName"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("Locations.locationname")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.F01")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.ismettlerrequired")
                    )
                    .Field(new Field("ProductUpdates.price_tab_f30")
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F27")
                    .Options(new Options()
                    .Table("SMSVendors")
                    .Value("F27")
                    .Label("F334"))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F26")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.PRICE_TAB_F49")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F19")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F38")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.promotprstartdate")
                    .Validator(Validation.DateFormat("M/d/yyyy"))
                    .GetFormatter(Format.DateTime("M/d/yyyy HH:mm:s", "M/d/yyyy"))
                    .SetFormatter(Format.DateTime("M/d/yyyy", "M/d/yyyy HH:mm:s"))
                    )
                    .Field(new Field("ProductUpdates.promotprenddate")
                    .Validator(Validation.DateFormat("M/d/yyyy"))
                    .GetFormatter(Format.DateTime("M/d/yyyy HH:mm:s", "M/d/yyyy"))
                    .SetFormatter(Format.DateTime("M/d/yyyy", "M/d/yyyy HH:mm:s"))
                    )
                    .Field(new Field("ProductUpdates.promotprprice")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.labelID")
                    .Options(new Options()
                    .Table("LabelSizes")
                    .Value("labelID")
                    .Label("labelsizes"))
                    )
                    .Field(new Field("ProductUpdates.LabelSizes")
                    )
                    .Field(new Field("ProductUpdates.signID")
                    .Options(new Options()
                    .Table("SignSizes")
                    .Value("signID")
                    .Label("signsizes"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F155")
                    .Options(new Options()
                    .Table("Brands")
                    .Value("Brand")
                    .Label("Brand"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F29")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F22")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F255")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F04")
                    .Options(new Options()
                    .Table("SMSSubdepartments")
                    .Value("F04")
                    .Label("F1022"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F17")
                    .Options(new Options()
                    .Table("SMSCategories")
                    .Value("F17")
                    .Label("F1023"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F18")
                    .Options(new Options()
                    .Table("SMSReports")
                    .Value("F18")
                    .Label("F1024"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F16")
                    .Options(new Options()
                    .Table("SMSFamilies")
                    .Value("F16")
                    .Label("F1040"))
                    )
                    .Field(new Field("ProductUpdates.LIKE_TAB_F122")
                    .Options(new Options()
                    .Table("SMSLikes")
                    .Value("F122")
                    .Label("F2790"))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F79")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F82")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F81")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F150")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F83")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F178")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F171")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.AdditionalRequestNotes")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ScalePLU")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ScaleItemTypeID")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.TareNetWeight")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.PRICE_TAB_F31")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ShelfLife")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.IngredientList")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.createdby")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.datecreated")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.completeddate")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.completedby")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.lastupdatedon")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.lastupdatedby")
                    .SetFormatter(Format.IfEmpty(null))
                    )

                    // Joined tables
                    .LeftJoin("Locations", "Locations.locationID", "=", "ProductUpdates.locationID"
                    )
                    .LeftJoin("RequestTypes", "RequestTypes.requesttypeID", "=", "ProductUpdates.requesttypeID"
                    )
                    .LeftJoin("ProductUpdateStatuses as Status", "Status.productstatusID", "=", "ProductUpdates.productstatusID"
                    )
                    .LeftJoin("LabelSizes as Labels", "Labels.labelID", "=", "ProductUpdates.labelID"
                    )
                    .LeftJoin("SignSizes as Signs", "Signs.signID", "=", "ProductUpdates.signID"
                    )
                    .LeftJoin("Brands", "Brands.Brand", "=", "ProductUpdates.OBJ_TAB_F155"
                    )
                    .LeftJoin("SMSSubdepartments", "SMSSubdepartments.F04", "=", "ProductUpdates.POS_TAB_F04"
                    )
                    .LeftJoin("SMSCategories", "SMSCategories.F17", "=", "ProductUpdates.OBJ_TAB_F17"
                    )
                    .LeftJoin("SMSReports", "SMSReports.F18", "=", "ProductUpdates.OBJ_TAB_F18"
                    )
                    .LeftJoin("SMSLikes", "SMSLikes.F122", "=", "ProductUpdates.LIKE_TAB_F122"
                    )
                    .LeftJoin("SMSFamilies", "SMSFamilies.F16", "=", "ProductUpdates.OBJ_TAB_F16"
                    )
                    .LeftJoin("SMSVendors", "SMSVendors.F27", "=", "ProductUpdates.COST_TAB_F27"
                    )
                    .Where(q => q.Where("ProductUpdateID", "(SELECT TOP 1000 ProductUpdateID FROM ProductUpdates ORDER BY ProductUpdateID DESC)", "IN", false))

                    .Process(request)
                    .Data();

                return Json(response);
            }
        }

        [Route("api/NewProducts")]
        [HttpGet]
        [HttpPost]
        public IHttpActionResult NewProducts()
        {
            var request = HttpContext.Current.Request;

            using (var db = new Database("sqlserver", ConfigurationManager.ConnectionStrings["ToolboxConnection"].ConnectionString))
            {
                var response = new Editor(db, "ProductUpdates", "productupdateID")
                    .Model<ProductUpdatesModel>()
                    .Field(new Field("ProductUpdates.productupdateID")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.productstatusID")
                    .Options(new Options()
                    .Table("ProductUpdateStatuses")
                    .Value("productstatusID")
                    .Label("productupdatestatus"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("Status.productupdatestatus")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.requesttypeID")
                    .Options(new Options()
                    .Table("RequestTypes")
                    .Value("requesttypeID")
                    .Label("requestname"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("RequestTypes.requestname")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.locationID")
                    .Options(new Options()
                    .Table("Locations")
                    .Value("locationID")
                    .Label("locationName"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("Locations.locationname")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.F01")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.ismettlerrequired")
                    )
                    .Field(new Field("ProductUpdates.price_tab_f30")
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F27")
                    .Options(new Options()
                    .Table("SMSVendors")
                    .Value("F27")
                    .Label("F334"))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F26")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.PRICE_TAB_F49")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F19")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F38")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.promotprstartdate")
                    .Validator(Validation.DateFormat("M/d/yyyy"))
                    .GetFormatter(Format.DateTime("M/d/yyyy HH:mm:s", "M/d/yyyy"))
                    .SetFormatter(Format.DateTime("M/d/yyyy", "M/d/yyyy HH:mm:s"))
                    )
                    .Field(new Field("ProductUpdates.promotprenddate")
                    .Validator(Validation.DateFormat("M/d/yyyy"))
                    .GetFormatter(Format.DateTime("M/d/yyyy HH:mm:s", "M/d/yyyy"))
                    .SetFormatter(Format.DateTime("M/d/yyyy", "M/d/yyyy HH:mm:s"))
                    )
                    .Field(new Field("ProductUpdates.promotprprice")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.labelID")
                    .Options(new Options()
                    .Table("LabelSizes")
                    .Value("labelID")
                    .Label("labelsizes"))
                    )
                    .Field(new Field("ProductUpdates.LabelSizes")
                    )
                    .Field(new Field("ProductUpdates.signID")
                    .Options(new Options()
                    .Table("SignSizes")
                    .Value("signID")
                    .Label("signsizes"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F155")
                    .Options(new Options()
                    .Table("Brands")
                    .Value("Brand")
                    .Label("Brand"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F29")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F22")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F255")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F04")
                    .Options(new Options()
                    .Table("SMSSubdepartments")
                    .Value("F04")
                    .Label("F1022"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F17")
                    .Options(new Options()
                    .Table("SMSCategories")
                    .Value("F17")
                    .Label("F1023"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F18")
                    .Options(new Options()
                    .Table("SMSReports")
                    .Value("F18")
                    .Label("F1024"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F16")
                    .Options(new Options()
                    .Table("SMSFamilies")
                    .Value("F16")
                    .Label("F1040"))
                    )
                    .Field(new Field("ProductUpdates.LIKE_TAB_F122")
                    .Options(new Options()
                    .Table("SMSLikes")
                    .Value("F122")
                    .Label("F2790"))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F79")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F82")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F81")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F150")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F83")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F178")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F171")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.AdditionalRequestNotes")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ScalePLU")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ScaleItemTypeID")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.TareNetWeight")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.PRICE_TAB_F31")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ShelfLife")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.IngredientList")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.createdby")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.datecreated")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.completeddate")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.completedby")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.lastupdatedon")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.lastupdatedby")
                    .SetFormatter(Format.IfEmpty(null))
                    )

                    // Joined tables
                    .LeftJoin("Locations", "Locations.locationID", "=", "ProductUpdates.locationID"
                    )
                    .LeftJoin("RequestTypes", "RequestTypes.requesttypeID", "=", "ProductUpdates.requesttypeID"
                    )
                    .LeftJoin("ProductUpdateStatuses as Status", "Status.productstatusID", "=", "ProductUpdates.productstatusID"
                    )
                    .LeftJoin("LabelSizes as Labels", "Labels.labelID", "=", "ProductUpdates.labelID"
                    )
                    .LeftJoin("SignSizes as Signs", "Signs.signID", "=", "ProductUpdates.signID"
                    )
                    .LeftJoin("Brands", "Brands.Brand", "=", "ProductUpdates.OBJ_TAB_F155"
                    )
                    .LeftJoin("SMSSubdepartments", "SMSSubdepartments.F04", "=", "ProductUpdates.POS_TAB_F04"
                    )
                    .LeftJoin("SMSCategories", "SMSCategories.F17", "=", "ProductUpdates.OBJ_TAB_F17"
                    )
                    .LeftJoin("SMSReports", "SMSReports.F18", "=", "ProductUpdates.OBJ_TAB_F18"
                    )
                    .LeftJoin("SMSLikes", "SMSLikes.F122", "=", "ProductUpdates.LIKE_TAB_F122"
                    )
                    .LeftJoin("SMSFamilies", "SMSFamilies.F16", "=", "ProductUpdates.OBJ_TAB_F16"
                    )
                    .LeftJoin("SMSVendors", "SMSVendors.F27", "=", "ProductUpdates.COST_TAB_F27"
                    )
                    // Selects only new product requests
                    .Where(q => q.Where("ProductUpdates.requesttypeID", '6', "="))
                    .Process(request)
                    .Data();

                return Json(response);
            }
        }

        [Route("api/ProductUpdates")]
        [HttpGet]
        [HttpPost]
        public IHttpActionResult UpdateRequests()
        {
            var request = HttpContext.Current.Request;

            using (var db = new Database("sqlserver", ConfigurationManager.ConnectionStrings["ToolboxConnection"].ConnectionString))
            {
                var response = new Editor(db, "ProductUpdates", "productupdateID")
                    .Model<ProductUpdatesModel>()
                    .Field(new Field("ProductUpdates.productupdateID")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.productstatusID")
                    .Options(new Options()
                    .Table("ProductUpdateStatuses")
                    .Value("productstatusID")
                    .Label("productupdatestatus"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("Status.productupdatestatus")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.requesttypeID")
                    .Options(new Options()
                    .Table("RequestTypes")
                    .Value("requesttypeID")
                    .Label("requestname"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("RequestTypes.requestname")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.locationID")
                    .Options(new Options()
                    .Table("Locations")
                    .Value("locationID")
                    .Label("locationName"))
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("Locations.locationname")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.F01")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.ismettlerrequired")
                    )
                    .Field(new Field("ProductUpdates.price_tab_f30")
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F27")
                    .Options(new Options()
                    .Table("SMSVendors")
                    .Value("F27")
                    .Label("F334"))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F26")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.PRICE_TAB_F49")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F19")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F38")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.promotprstartdate")
                    .Validator(Validation.DateFormat("M/d/yyyy"))
                    .GetFormatter(Format.DateTime("M/d/yyyy HH:mm:s", "M/d/yyyy"))
                    .SetFormatter(Format.DateTime("M/d/yyyy", "M/d/yyyy HH:mm:s"))
                    )
                    .Field(new Field("ProductUpdates.promotprenddate")
                    .Validator(Validation.DateFormat("M/d/yyyy"))
                    .GetFormatter(Format.DateTime("M/d/yyyy HH:mm:s", "M/d/yyyy"))
                    .SetFormatter(Format.DateTime("M/d/yyyy", "M/d/yyyy HH:mm:s"))
                    )
                    .Field(new Field("ProductUpdates.promotprprice")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.labelID")
                    .Options(new Options()
                    .Table("LabelSizes")
                    .Value("labelID")
                    .Label("labelsizes"))
                    )
                    .Field(new Field("ProductUpdates.LabelSizes")
                    )
                    .Field(new Field("ProductUpdates.signID")
                    .Options(new Options()
                    .Table("SignSizes")
                    .Value("signID")
                    .Label("signsizes"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F155")
                    .Options(new Options()
                    .Table("Brands")
                    .Value("Brand")
                    .Label("Brand"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F29")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F22")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F255")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F04")
                    .Options(new Options()
                    .Table("SMSSubdepartments")
                    .Value("F04")
                    .Label("F1022"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F17")
                    .Options(new Options()
                    .Table("SMSCategories")
                    .Value("F17")
                    .Label("F1023"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F18")
                    .Options(new Options()
                    .Table("SMSReports")
                    .Value("F18")
                    .Label("F1024"))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F16")
                    .Options(new Options()
                    .Table("SMSFamilies")
                    .Value("F16")
                    .Label("F1040"))
                    )
                    .Field(new Field("ProductUpdates.LIKE_TAB_F122")
                    .Options(new Options()
                    .Table("SMSLikes")
                    .Value("F122")
                    .Label("F2790"))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F79")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F82")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F81")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F150")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F83")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F178")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F171")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.AdditionalRequestNotes")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ScalePLU")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ScaleItemTypeID")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.TareNetWeight")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.PRICE_TAB_F31")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.ShelfLife")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.IngredientList")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.createdby")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.datecreated")
                    .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.completeddate")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.completedby")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.lastupdatedon")
                    .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.lastupdatedby")
                    .SetFormatter(Format.IfEmpty(null))
                    )

                    // Joined tables
                    .LeftJoin("Locations", "Locations.locationID", "=", "ProductUpdates.locationID"
                    )
                    .LeftJoin("RequestTypes", "RequestTypes.requesttypeID", "=", "ProductUpdates.requesttypeID"
                    )
                    .LeftJoin("ProductUpdateStatuses as Status", "Status.productstatusID", "=", "ProductUpdates.productstatusID"
                    )
                    .LeftJoin("LabelSizes as Labels", "Labels.labelID", "=", "ProductUpdates.labelID"
                    )
                    .LeftJoin("SignSizes as Signs", "Signs.signID", "=", "ProductUpdates.signID"
                    )
                    .LeftJoin("Brands", "Brands.Brand", "=", "ProductUpdates.OBJ_TAB_F155"
                    )
                    .LeftJoin("SMSSubdepartments", "SMSSubdepartments.F04", "=", "ProductUpdates.POS_TAB_F04"
                    )
                    .LeftJoin("SMSCategories", "SMSCategories.F17", "=", "ProductUpdates.OBJ_TAB_F17"
                    )
                    .LeftJoin("SMSReports", "SMSReports.F18", "=", "ProductUpdates.OBJ_TAB_F18"
                    )
                    .LeftJoin("SMSLikes", "SMSLikes.F122", "=", "ProductUpdates.LIKE_TAB_F122"
                    )
                    .LeftJoin("SMSFamilies", "SMSFamilies.F16", "=", "ProductUpdates.OBJ_TAB_F16"
                    )
                    .LeftJoin("SMSVendors", "SMSVendors.F27", "=", "ProductUpdates.COST_TAB_F27"
                    )
                    
                    // Selects all but new product requests
                    .Where(q => q.Where("ProductUpdates.requesttypeID", '6', "<>"))
                    .Where(q => q.Where("ProductUpdateID", "(SELECT TOP 1000 ProductUpdateID FROM ProductUpdates ORDER BY ProductUpdateID DESC)", "IN", false))
                    .Process(request)
                    .Data();

                return Json(response);
            }
        }
    }
}