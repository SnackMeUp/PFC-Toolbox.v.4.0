﻿using System;
using System.Collections.Generic;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using DataTables;
using PFC_Toolbox.v._4._0.Extensions;
using PFC_Toolbox.v._4._0.Models;

namespace PFC_Toolbox.v._4._0.Controllers
{
    public class ProductUpdatesController : ApiController
    {
        [Route("api/ProductUpdates")]
        [HttpGet]
        [HttpPost]
        public IHttpActionResult ProductUpdates()
        {
            var request = HttpContext.Current.Request;
            var settings = Properties.Settings.Default;
            
            using (var db1 = new Database(settings.DbType, settings.DbConnection1))
            {
                var response = new Editor(db1, "ProductUpdates", "productupdateID")
                    .Model<ProductUpdatesModel>()
                    .Field(new Field("ProductUpdates.productupdateID")
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
                    .Field(new Field("ProductUpdates.F01")
                        .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.ismettlerrequired")
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
                    .Field(new Field("ProductUpdates.OBJ_TAB_F255")
                        .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.OBJ_TAB_F22")
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
                    )
                    .Field(new Field("ProductUpdates.LIKE_TAB_F122")
                        .SetFormatter(Format.IfEmpty(null))
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F79")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F80")
                    )
                    .Field(new Field("ProductUpdates.POS_TAB_F81")
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
                    .Field(new Field("ProductUpdates.signID")
                        .Options(new Options()
                            .Table("SignSizes")
                            .Value("signID")
                            .Label("signsizes"))
                    )
                    .Field(new Field("ProductUpdates.price_tab_f30")
                    )
                    .Field(new Field("ProductUpdates.createdby")
                        .Validator(Validation.NotEmpty())
                    )
                    .Field(new Field("ProductUpdates.datecreated")
                        .Set(Field.SetType.Create))
                    .Field(new Field("ProductUpdates.lastupdatedon")
                        .Set(Field.SetType.Edit))
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
                    .Field(new Field("ProductUpdates.COST_TAB_F27")
                        .Options(new Options()
                            .Table("SMSVendors")
                            .Value("F27")
                            .Label("F334"))
                    )
                    .Field(new Field("ProductUpdates.COST_TAB_F26")
                        .SetFormatter( Format.IfEmpty(null))
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
                    .LeftJoin("SMSVendors", "SMSVendors.F27", "=", "ProductUpdates.COST_TAB_F27"
                    )
                     .Process(request)
                    .Data();
                 
                return Json(response);
            }
        }
    }
}