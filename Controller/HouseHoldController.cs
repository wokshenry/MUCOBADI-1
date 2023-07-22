using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using MUCOBADI.Models;
using StackExchange.Redis;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Syncfusion.XlsIO.Implementation.XmlSerialization;

namespace MUCOBADI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseHoldController : ControllerBase
    {
        private readonly MUCOBADIContext db;
        public HouseHoldController(MUCOBADIContext db)
        {
            this.db = db;
        }
        // GET: api/Default
        [HttpGet]
        public async Task<object> Get(int? code)
        {
            var data = db.BeneficiaryIdentificationRegister.AsQueryable();
            var queryString = Request.Query;
            string grid = queryString["ej2grid"];
            string sort = queryString["$orderby"];   //sorting      
            string filter = queryString["$filter"];
            string select = queryString["$select"];
            string auto = queryString["$inlineCount"];

            if (queryString.Keys.Contains("DistrictId"))
            {
                StringValues DistrictString;
                string searchDistricts = (queryString.TryGetValue("DistrictId", out DistrictString)) ? Convert.ToString(DistrictString[0]) : "";
                if (!string.IsNullOrEmpty(searchDistricts))
                {
                    var a = searchDistricts.Split(",");
                    if (a.Length > 0)
                    {
                        data = data.Where(o => o.DistrictId != null && a.Any(x => x == o.DistrictId.ToString()));
                    }

                }
            }
            if (queryString.Keys.Contains("SubcountyId"))
            {
                StringValues SubcountyString;
                string searchSubcounty = (queryString.TryGetValue("SubcountyId", out SubcountyString)) ? Convert.ToString(SubcountyString[0]) : "";
                if (!string.IsNullOrEmpty(searchSubcounty))
                {
                    var a = searchSubcounty.Split(",");
                    if (a.Length > 0)
                    {
                        data = data.Where(o => o.SubcountyId != null && a.Any(x => x == o.SubcountyId.ToString()));
                    }

                }
            }
            if (queryString.Keys.Contains("ParishId"))
            {
                StringValues ParishString;
                string searchParish = (queryString.TryGetValue("ParishId", out ParishString)) ? Convert.ToString(ParishString[0]) : "";
                if (!string.IsNullOrEmpty(searchParish))
                {
                    var a = searchParish.Split(",");
                    if (a.Length > 0)
                    {
                        data = data.Where(o => o.ParishId != null && a.Any(x => x == o.ParishId.ToString()));
                    }

                }
            }
            if (queryString.Keys.Contains("VillageId"))
            {
                StringValues VillageString;
                string searchVillage = (queryString.TryGetValue("VillageId", out VillageString)) ? Convert.ToString(VillageString[0]) : "";
                if (!string.IsNullOrEmpty(searchVillage))
                {
                    var a = searchVillage.Split(",");
                    if (a.Length > 0)
                    {
                        data = data.Where(o => o.VillageId != null && a.Any(x => x == o.VillageId.ToString()));
                    }

                }
            }

            if (filter != null) // to handle filter opertaion
            {
                if (filter.Contains("substring"))//searching 
                {
                    var key = filter.Split(new string[] { "'" }, StringSplitOptions.None)[1];
                    data = data.Where(fil => fil.HouseHoldCode.Contains(key.ToUpper())
                                            || fil.GivenName.Contains(key)
                                            || fil.Surname.Contains(key));
                }
                else
                {
                    var newfiltersplits = filter.Replace("(","").Replace(")", "").Replace("'", "");
                    var filtersplits = newfiltersplits.Split("or");
                    //"eq"
                    string filterfield = "";
                    string filtervalue = "";
                    if (filtersplits.Any())
                    {
                        foreach (var item in filtersplits)
                        {
                            var a = item.Split(' ');
                            if(a.Length >=3 && !string.IsNullOrEmpty(a[2]))
                            {
                                if (!string.IsNullOrEmpty(a[0]))
                                {
                                    filterfield = a[0];
                                    if (string.IsNullOrEmpty(filtervalue))
                                    {
                                        filtervalue = a[2];
                                    }
                                    else
                                    {
                                        filtervalue += "," + a[2]; 
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(filtervalue))
                                    {
                                        filtervalue = a[3];
                                    }
                                    else
                                    {
                                        filtervalue += "," + a[3]; 
                                    }
                                }
                                
                            }
                        }
                    }
                    //var filterfield = filtersplits[1];
                    //var filtervalue = filtersplits[3];

                    //if (filtersplits.Length == 7)
                    //{
                    //    if (filtersplits[2] == "tolower")
                    //    {
                    //        filterfield = filter.Split('(', ')', '\'')[3];
                    //        filtervalue = filter.Split('(', ')', '\'')[5];
                    //    }
                    //}
                    var _filtervalue = filtervalue.Split(',');
                    switch (filterfield)
                    {
                        case "DistrictId":
                            data = (from cust in data
                                    where cust.DistrictId != null && _filtervalue.Any(x => x == cust.DistrictId.ToString())
                                    select cust);
                            break;
                        case "SubcountyId":
                            
                            data = (from cust in data
                                    where cust.SubcountyId != null && _filtervalue.Any(x => x == cust.SubcountyId.ToString())
                                    select cust);
                            break;
                        case "HouseHoldCode":
                            data = (from cust in data
                                    where cust.HouseHoldCode != null && _filtervalue.Any(x=> x == cust.HouseHoldCode)
                                    select cust);
                            break;
                        //case "Freight":
                        //    data = (from cust in data
                        //            where cust.EmployeeID.ToString() == filtervalue.ToString()
                        //            select cust);
                        //    break;
                    }
                }
            }
            if (sort != null) //Sorting 
            {
                var sortfield = sort.Split(',');
                for (var i = sortfield.Length; i > 0; i--)
                {
                    var sortColumn = sortfield[i - 1].Split(" ");
                    var sorttype = sortColumn[0];
                    if (sortColumn.Length == 2)
                    {
                        switch (sorttype)
                        {
                            case "DistrictId":
                                data = data.OrderByDescending(x => x.DistrictId);
                                break;
                            case "SubcountyId":
                                data = data.OrderByDescending(x => x.SubcountyId);
                                break;
                            case "HouseHoldCode":
                                data = data.OrderByDescending(x => x.HouseHoldCode);
                                break;
                        }
                    }
                    else
                    {
                        switch (sorttype)
                        {
                            case "DistrictId":
                                data = data.OrderBy(x => x.DistrictId);
                                break;
                            case "SubcountyId":
                                data = data.OrderBy(x => x.SubcountyId);
                                break;
                            case "HouseHoldCode":
                                data = data.OrderBy(x => x.HouseHoldCode);
                                break;
                        }
                    }
                }
            }
            
            if (queryString.Keys.Contains("$inlinecount"))
            {
                if (select != null)
                {
                    return new { Items = data, Count = data.Count() };
                }
                else
                {
                    StringValues Skip;
                    StringValues Take;
                    int skip = (queryString.TryGetValue("$skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
                    int top = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : data.Count();
                    var count = data.Count();
                    return new { Items = data.Skip(skip).Take(top).Include(o => o.HouseHoldMembers), Count = count };
                }
                    
            }
            else
            {
                if (select != null)
                {
                    return new { Items = data, Count = data.Count() };
                }
                else
                {
                    return new { Items = data, Count = data.Count() };
                }
                
            }
        }
        //// POST: api/Default
        [HttpPost]
        public async Task<object> Post([FromBody] BeneficiaryIdentificationRegister value)
        {
            var exists = db.BeneficiaryIdentificationRegister.FirstOrDefault(o => o.HouseHoldId == value.HouseHoldId);
            if (exists == null)
            {
                int id = 1;
                var last = db.BeneficiaryIdentificationRegister.OrderBy(o => o.HouseHoldId).LastOrDefault();
                if (last != null)
                {
                    id = (last.HouseHoldId + 1);
                }
                value.HouseHoldId = id;
                if (!value.HouseHoldCode.Contains("-"))
                {
                    string householdCode = value.HouseHoldCode.Substring(0, 2) + "-" + value.HouseHoldCode.Substring(2, 2) + "-" + value.HouseHoldCode.Substring(4, 4);
                    value.HouseHoldCode = householdCode;
                }
                //value.AddedBy = _userManagement.GetStaffName();
                //value.AddedDate = DateTime.Now;
                BeneficiaryIdentificationRegister m = new BeneficiaryIdentificationRegister();
                m.HouseHoldId = value.HouseHoldId;
                m.HouseHoldCode = value.HouseHoldCode;
                m.DateofIdentification = value.DateofIdentification;
                m.IdentificationId = value.IdentificationId;
                m.OtherIdentificationSource = value.OtherIdentificationSource;
                m.Surname = value.Surname;
                m.GivenName = value.GivenName;
                m.GenderId = value.GenderId;
                m.DoB = value.DoB;
                m.Age = value.Age;
                m.KnownRiskFactorId = value.KnownRiskFactorId;
                m.DistrictId = value.DistrictId;
                m.SubcountyId = value.SubcountyId;
                m.ParishId = value.ParishId;
                m.VillageId = value.VillageId;
                m.HivstatusId = value.HivstatusId;
                m.FacilityId = value.FacilityId;
                m.RegimenCategoryId = value.RegimenCategoryId;
                m.RegimenId = value.RegimenId;
                m.DispensingModelId = value.DispensingModelId;
                m.CurrentlyonArt = value.CurrentlyonArt;
                m.Cohort = value.Cohort;
                m.Artnumber = value.Artnumber;
                m.Copies = value.Copies;
                m.ViralLoadSuppressedId = value.ViralLoadSuppressedId;
                m.SourceDocumentId = value.SourceDocumentId;
                m.OtherSourceDocument = value.OtherSourceDocument;
                m.SourceDocumentUrl = value.SourceDocumentUrl;
                m.SourceDocumentExt = value.SourceDocumentExt;
                m.DateAdded = value.DateAdded;
                m.AddedBy = value.AddedBy;
                m.TelephoneContact = value.TelephoneContact;
                m.VirallaodDate = value.VirallaodDate;
                m.OvcVlrId = value.OvcVlrId;

                db.BeneficiaryIdentificationRegister.Add(m);
                await db.SaveChangesAsync();
            }

            if (value.HouseHoldMembers != null && value.HouseHoldMembers.Count > 0)
            {
                foreach (var item in value.HouseHoldMembers)
                {
                    item.HouseHoldId = value.HouseHoldId;
                    var _exist = await db.HouseHoldMembers.FirstOrDefaultAsync(o => o.HouseHoldMemberId == item.HouseHoldMemberId);
                    if (_exist != null)
                    {
                        if (!item.HouseHoldMemberCode.Contains("-"))
                        {
                            string householdCode = item.HouseHoldMemberCode.Substring(0, 2) + "-" + item.HouseHoldMemberCode.Substring(2, 2) + "-" + item.HouseHoldMemberCode.Substring(4, 4);
                            string householdMemberCode = householdCode + "-" + item.HouseHoldMemberCode.Substring((item.HouseHoldMemberCode.Length - 2), 2);
                            item.HouseHoldMemberCode = householdMemberCode;
                        }
                        db.Entry(_exist).CurrentValues.SetValues(item);
                        db.Entry(_exist).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        int id = 1;
                        var last = await db.HouseHoldMembers.OrderBy(o => o.HouseHoldMemberId).LastOrDefaultAsync();
                        if (last != null)
                        {
                            id = (last.HouseHoldMemberId + 1);
                        }
                        item.HouseHoldMemberId = id;
                        if (!item.HouseHoldMemberCode.Contains("-"))
                        {
                            string householdCode = item.HouseHoldMemberCode.Substring(0, 2) + "-" + item.HouseHoldMemberCode.Substring(2, 2) + "-" + item.HouseHoldMemberCode.Substring(4, 4);
                            string householdMemberCode = householdCode + "-" + item.HouseHoldMemberCode.Substring((item.HouseHoldMemberCode.Length - 2), 2);
                            item.HouseHoldMemberCode = householdMemberCode;
                        }
                        //value.AddedBy = _userManagement.GetStaffName();
                        //value.AddedDate = DateTime.Now;
                        db.HouseHoldMembers.Add(item);
                        await db.SaveChangesAsync();
                    }
                }
            }
            return value;
        }

        //// PUT: api/Default/5
        [HttpPut]
        public async Task<object> Put([FromBody] BeneficiaryIdentificationRegister value)
        {
            var exist = db.BeneficiaryIdentificationRegister.FirstOrDefault(o => o.HouseHoldId == value.HouseHoldId);
            if (exist != null)
            {
                if (!value.HouseHoldCode.Contains("-"))
                {
                    string householdCode = value.HouseHoldCode.Substring(0, 2) + "-" + value.HouseHoldCode.Substring(2, 2) + "-" + value.HouseHoldCode.Substring(4, 4);
                    value.HouseHoldCode = householdCode;
                }
                db.Entry(exist).CurrentValues.SetValues(value);
                db.Entry(exist).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            if (value.HouseHoldMembers != null && value.HouseHoldMembers.Count > 0)
            {
                foreach (var item in value.HouseHoldMembers)
                {
                    var _exist = await db.HouseHoldMembers.FirstOrDefaultAsync(o => o.HouseHoldMemberId == item.HouseHoldMemberId);
                    if (_exist != null)
                    {
                        if (!item.HouseHoldMemberCode.Contains("-"))
                        {
                            string householdCode = item.HouseHoldMemberCode.Substring(0, 2) + "-" + item.HouseHoldMemberCode.Substring(2, 2) + "-" + item.HouseHoldMemberCode.Substring(4, 4);
                            string householdMemberCode = householdCode + "-" + item.HouseHoldMemberCode.Substring((item.HouseHoldMemberCode.Length - 2), 2);
                            item.HouseHoldMemberCode = householdMemberCode;
                        }
                        item.HouseHoldId = value.HouseHoldId;
                        db.Entry(_exist).CurrentValues.SetValues(item);
                        db.Entry(_exist).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        int id = 1;
                        var last = await db.HouseHoldMembers.OrderBy(o => o.HouseHoldMemberId).LastOrDefaultAsync();
                        if (last != null)
                        {
                            id = (last.HouseHoldMemberId + 1);
                        }
                        item.HouseHoldMemberId = id;
                        item.HouseHoldId = value.HouseHoldId;
                        if (!item.HouseHoldMemberCode.Contains("-"))
                        {
                            string householdCode = item.HouseHoldMemberCode.Substring(0, 2) + "-" + item.HouseHoldMemberCode.Substring(2, 2) + "-" + item.HouseHoldMemberCode.Substring(4, 4);
                            string householdMemberCode = householdCode + "-" + item.HouseHoldMemberCode.Substring((item.HouseHoldMemberCode.Length - 2), 2);
                            item.HouseHoldMemberCode = householdMemberCode;
                        }
                        //value.AddedBy = _userManagement.GetStaffName();
                        //value.AddedDate = DateTime.Now;
                        db.HouseHoldMembers.Add(item);
                        await db.SaveChangesAsync();
                    }
                }
            }
            return value;
        }
        //// DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete([FromBody] int HouseHoldId)
        {
            var Household = db.BeneficiaryIdentificationRegister.FirstOrDefault(o=> o.HouseHoldId== HouseHoldId);
            if(Household != null)
            {
                var members = db.HouseHoldMembers.Where(o => o.HouseHoldId == HouseHoldId).ToList();
                if (members.Count > 0)
                {
                    db.HouseHoldMembers.RemoveRange(members);
                    db.SaveChanges();
                }
                db.BeneficiaryIdentificationRegister.Remove(Household);
                db.SaveChanges();
            }
            
        }
    }
}
