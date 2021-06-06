﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gear_Store
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GearStoreEntities : DbContext
    {
        public GearStoreEntities()
            : base("name=GearStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order_Items> Order_Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    
        public virtual int DeleteBrand(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBrand", idParameter);
        }
    
        public virtual int DeleteCategory(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCategory", idParameter);
        }
    
        public virtual int DeleteCustomer(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCustomer", idParameter);
        }
    
        public virtual int DeleteOrder(string orid)
        {
            var oridParameter = orid != null ?
                new ObjectParameter("orid", orid) :
                new ObjectParameter("orid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteOrder", oridParameter);
        }
    
        public virtual int DeleteOrder_Item(string orid, string proid)
        {
            var oridParameter = orid != null ?
                new ObjectParameter("orid", orid) :
                new ObjectParameter("orid", typeof(string));
    
            var proidParameter = proid != null ?
                new ObjectParameter("proid", proid) :
                new ObjectParameter("proid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteOrder_Item", oridParameter, proidParameter);
        }
    
        public virtual int DeleteProduct(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProduct", idParameter);
        }
    
        public virtual int DeleteStaff(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStaff", idParameter);
        }
    
        public virtual int DeleteSupplier(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSupplier", idParameter);
        }
    
        public virtual int Insert_Order(string cus_id, Nullable<byte> or_status, Nullable<System.DateTime> or_date, Nullable<int> number_of_items, Nullable<decimal> total_amount, string staff_id)
        {
            var cus_idParameter = cus_id != null ?
                new ObjectParameter("cus_id", cus_id) :
                new ObjectParameter("cus_id", typeof(string));
    
            var or_statusParameter = or_status.HasValue ?
                new ObjectParameter("or_status", or_status) :
                new ObjectParameter("or_status", typeof(byte));
    
            var or_dateParameter = or_date.HasValue ?
                new ObjectParameter("or_date", or_date) :
                new ObjectParameter("or_date", typeof(System.DateTime));
    
            var number_of_itemsParameter = number_of_items.HasValue ?
                new ObjectParameter("number_of_items", number_of_items) :
                new ObjectParameter("number_of_items", typeof(int));
    
            var total_amountParameter = total_amount.HasValue ?
                new ObjectParameter("total_amount", total_amount) :
                new ObjectParameter("total_amount", typeof(decimal));
    
            var staff_idParameter = staff_id != null ?
                new ObjectParameter("staff_id", staff_id) :
                new ObjectParameter("staff_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Order", cus_idParameter, or_statusParameter, or_dateParameter, number_of_itemsParameter, total_amountParameter, staff_idParameter);
        }
    
        public virtual int InsertBrand(string brname)
        {
            var brnameParameter = brname != null ?
                new ObjectParameter("brname", brname) :
                new ObjectParameter("brname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBrand", brnameParameter);
        }
    
        public virtual int InsertCategory(string catname)
        {
            var catnameParameter = catname != null ?
                new ObjectParameter("catname", catname) :
                new ObjectParameter("catname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCategory", catnameParameter);
        }
    
        public virtual int InsertCustomer(string fname, string lname, string phone, string email, string street, string city, string state, string zipcode)
        {
            var fnameParameter = fname != null ?
                new ObjectParameter("fname", fname) :
                new ObjectParameter("fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("lname", lname) :
                new ObjectParameter("lname", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var streetParameter = street != null ?
                new ObjectParameter("street", street) :
                new ObjectParameter("street", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var zipcodeParameter = zipcode != null ?
                new ObjectParameter("zipcode", zipcode) :
                new ObjectParameter("zipcode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCustomer", fnameParameter, lnameParameter, phoneParameter, emailParameter, streetParameter, cityParameter, stateParameter, zipcodeParameter);
        }
    
        public virtual int InsertOrder_Item(string orid, string pro_id, Nullable<int> quantity, Nullable<decimal> price, Nullable<decimal> discount)
        {
            var oridParameter = orid != null ?
                new ObjectParameter("orid", orid) :
                new ObjectParameter("orid", typeof(string));
    
            var pro_idParameter = pro_id != null ?
                new ObjectParameter("pro_id", pro_id) :
                new ObjectParameter("pro_id", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("discount", discount) :
                new ObjectParameter("discount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertOrder_Item", oridParameter, pro_idParameter, quantityParameter, priceParameter, discountParameter);
        }
    
        public virtual int InsertProduct(string pro_name, string brand_id, string cat_id, string sup_id, Nullable<decimal> price, Nullable<int> status, string dpt, byte[] pro_image)
        {
            var pro_nameParameter = pro_name != null ?
                new ObjectParameter("pro_name", pro_name) :
                new ObjectParameter("pro_name", typeof(string));
    
            var brand_idParameter = brand_id != null ?
                new ObjectParameter("brand_id", brand_id) :
                new ObjectParameter("brand_id", typeof(string));
    
            var cat_idParameter = cat_id != null ?
                new ObjectParameter("cat_id", cat_id) :
                new ObjectParameter("cat_id", typeof(string));
    
            var sup_idParameter = sup_id != null ?
                new ObjectParameter("sup_id", sup_id) :
                new ObjectParameter("sup_id", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var dptParameter = dpt != null ?
                new ObjectParameter("dpt", dpt) :
                new ObjectParameter("dpt", typeof(string));
    
            var pro_imageParameter = pro_image != null ?
                new ObjectParameter("pro_image", pro_image) :
                new ObjectParameter("pro_image", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProduct", pro_nameParameter, brand_idParameter, cat_idParameter, sup_idParameter, priceParameter, statusParameter, dptParameter, pro_imageParameter);
        }
    
        public virtual int InsertStaff(string pass, string users_name, Nullable<System.DateTime> birthday, string addr, Nullable<decimal> salary, string email, string phone)
        {
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var users_nameParameter = users_name != null ?
                new ObjectParameter("users_name", users_name) :
                new ObjectParameter("users_name", typeof(string));
    
            var birthdayParameter = birthday.HasValue ?
                new ObjectParameter("birthday", birthday) :
                new ObjectParameter("birthday", typeof(System.DateTime));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(decimal));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertStaff", passParameter, users_nameParameter, birthdayParameter, addrParameter, salaryParameter, emailParameter, phoneParameter);
        }
    
        public virtual int InsertSupplier(string sup_name, string phone, string email, string street, string city, string state, string zipcode)
        {
            var sup_nameParameter = sup_name != null ?
                new ObjectParameter("sup_name", sup_name) :
                new ObjectParameter("sup_name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var streetParameter = street != null ?
                new ObjectParameter("street", street) :
                new ObjectParameter("street", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var zipcodeParameter = zipcode != null ?
                new ObjectParameter("zipcode", zipcode) :
                new ObjectParameter("zipcode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertSupplier", sup_nameParameter, phoneParameter, emailParameter, streetParameter, cityParameter, stateParameter, zipcodeParameter);
        }
    
        public virtual int UpdateBrand(string id, string brname)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var brnameParameter = brname != null ?
                new ObjectParameter("brname", brname) :
                new ObjectParameter("brname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBrand", idParameter, brnameParameter);
        }
    
        public virtual int UpdateCategory(string id, string catname)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var catnameParameter = catname != null ?
                new ObjectParameter("catname", catname) :
                new ObjectParameter("catname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCategory", idParameter, catnameParameter);
        }
    
        public virtual int UpdateCustomer(string id, string fname, string lname, string phone, string email, string street, string city, string state, string zipcode)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var fnameParameter = fname != null ?
                new ObjectParameter("fname", fname) :
                new ObjectParameter("fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("lname", lname) :
                new ObjectParameter("lname", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var streetParameter = street != null ?
                new ObjectParameter("street", street) :
                new ObjectParameter("street", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var zipcodeParameter = zipcode != null ?
                new ObjectParameter("zipcode", zipcode) :
                new ObjectParameter("zipcode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCustomer", idParameter, fnameParameter, lnameParameter, phoneParameter, emailParameter, streetParameter, cityParameter, stateParameter, zipcodeParameter);
        }
    
        public virtual int UpdateOrder(string id, string cus_id, Nullable<byte> or_status, Nullable<System.DateTime> or_date, Nullable<int> number_of_items, Nullable<decimal> total_amount, string staff_id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var cus_idParameter = cus_id != null ?
                new ObjectParameter("cus_id", cus_id) :
                new ObjectParameter("cus_id", typeof(string));
    
            var or_statusParameter = or_status.HasValue ?
                new ObjectParameter("or_status", or_status) :
                new ObjectParameter("or_status", typeof(byte));
    
            var or_dateParameter = or_date.HasValue ?
                new ObjectParameter("or_date", or_date) :
                new ObjectParameter("or_date", typeof(System.DateTime));
    
            var number_of_itemsParameter = number_of_items.HasValue ?
                new ObjectParameter("number_of_items", number_of_items) :
                new ObjectParameter("number_of_items", typeof(int));
    
            var total_amountParameter = total_amount.HasValue ?
                new ObjectParameter("total_amount", total_amount) :
                new ObjectParameter("total_amount", typeof(decimal));
    
            var staff_idParameter = staff_id != null ?
                new ObjectParameter("staff_id", staff_id) :
                new ObjectParameter("staff_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateOrder", idParameter, cus_idParameter, or_statusParameter, or_dateParameter, number_of_itemsParameter, total_amountParameter, staff_idParameter);
        }
    
        public virtual int UpdateProduct(string id, string pro_name, string brand_id, string cat_id, string sup_id, Nullable<decimal> price, Nullable<int> status, string dpt, byte[] pro_image)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var pro_nameParameter = pro_name != null ?
                new ObjectParameter("pro_name", pro_name) :
                new ObjectParameter("pro_name", typeof(string));
    
            var brand_idParameter = brand_id != null ?
                new ObjectParameter("brand_id", brand_id) :
                new ObjectParameter("brand_id", typeof(string));
    
            var cat_idParameter = cat_id != null ?
                new ObjectParameter("cat_id", cat_id) :
                new ObjectParameter("cat_id", typeof(string));
    
            var sup_idParameter = sup_id != null ?
                new ObjectParameter("sup_id", sup_id) :
                new ObjectParameter("sup_id", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var dptParameter = dpt != null ?
                new ObjectParameter("dpt", dpt) :
                new ObjectParameter("dpt", typeof(string));
    
            var pro_imageParameter = pro_image != null ?
                new ObjectParameter("pro_image", pro_image) :
                new ObjectParameter("pro_image", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateProduct", idParameter, pro_nameParameter, brand_idParameter, cat_idParameter, sup_idParameter, priceParameter, statusParameter, dptParameter, pro_imageParameter);
        }
    
        public virtual int UpdateStaff(string id, string pass, string users_name, Nullable<System.DateTime> birthday, string addr, Nullable<decimal> salary, string email, string phone)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var users_nameParameter = users_name != null ?
                new ObjectParameter("users_name", users_name) :
                new ObjectParameter("users_name", typeof(string));
    
            var birthdayParameter = birthday.HasValue ?
                new ObjectParameter("birthday", birthday) :
                new ObjectParameter("birthday", typeof(System.DateTime));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(decimal));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStaff", idParameter, passParameter, users_nameParameter, birthdayParameter, addrParameter, salaryParameter, emailParameter, phoneParameter);
        }
    
        public virtual int UpdateSupplier(string id, string sup_name, string phone, string email, string street, string city, string state, string zipcode)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var sup_nameParameter = sup_name != null ?
                new ObjectParameter("sup_name", sup_name) :
                new ObjectParameter("sup_name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var streetParameter = street != null ?
                new ObjectParameter("street", street) :
                new ObjectParameter("street", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var zipcodeParameter = zipcode != null ?
                new ObjectParameter("zipcode", zipcode) :
                new ObjectParameter("zipcode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSupplier", idParameter, sup_nameParameter, phoneParameter, emailParameter, streetParameter, cityParameter, stateParameter, zipcodeParameter);
        }
    }
}
