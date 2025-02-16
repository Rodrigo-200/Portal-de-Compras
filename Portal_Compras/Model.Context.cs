﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal_Compras
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntitiesBarEscola : DbContext
    {
        public EntitiesBarEscola()
            : base("name=EntitiesBarEscola")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BUY_PRODUCTS> BUY_PRODUCTS { get; set; }
        public virtual DbSet<BUYS> BUYS { get; set; }
        public virtual DbSet<CART> CART { get; set; }
        public virtual DbSet<CART_ITEMS> CART_ITEMS { get; set; }
        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<Favorite_Product> Favorite_Product { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<TYPE> TYPE { get; set; }
    
        public virtual int ApplyDiscounts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ApplyDiscounts");
        }
    
        public virtual ObjectResult<GET_PRODUCTS_Result> GET_PRODUCTS(Nullable<int> id_product)
        {
            var id_productParameter = id_product.HasValue ?
                new ObjectParameter("id_product", id_product) :
                new ObjectParameter("id_product", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_PRODUCTS_Result>("GET_PRODUCTS", id_productParameter);
        }
    
        public virtual ObjectResult<Login_Validation_Result> Login_Validation(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Login_Validation_Result>("Login_Validation", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<GetFilteredProducts_Result> GetFilteredProducts(string searchText, Nullable<bool> searchDesc, Nullable<bool> searchOnlyFavs, Nullable<int> client_ID)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var searchDescParameter = searchDesc.HasValue ?
                new ObjectParameter("SearchDesc", searchDesc) :
                new ObjectParameter("SearchDesc", typeof(bool));
    
            var searchOnlyFavsParameter = searchOnlyFavs.HasValue ?
                new ObjectParameter("SearchOnlyFavs", searchOnlyFavs) :
                new ObjectParameter("SearchOnlyFavs", typeof(bool));
    
            var client_IDParameter = client_ID.HasValue ?
                new ObjectParameter("Client_ID", client_ID) :
                new ObjectParameter("Client_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFilteredProducts_Result>("GetFilteredProducts", searchTextParameter, searchDescParameter, searchOnlyFavsParameter, client_IDParameter);
        }
    }
}
