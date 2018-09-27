﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team5BLibraryManagementSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SA47Team05BESNETLMSEntities : DbContext
    {
        public SA47Team05BESNETLMSEntities()
            : base("name=SA47Team05BESNETLMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Booksdetail> Booksdetails { get; set; }
        public virtual DbSet<Loandetail> Loandetails { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Returndetail> Returndetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewBooksListing> ViewBooksListings { get; set; }
        public virtual DbSet<ViewAllLoanedBook> ViewAllLoanedBooks { get; set; }
    
        public virtual ObjectResult<BookListByAvailability_Result> BookListByAvailability(string status)
        {
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BookListByAvailability_Result>("BookListByAvailability", statusParameter);
        }
    
        public virtual ObjectResult<MembersPastExpiry_Result> MembersPastExpiry()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MembersPastExpiry_Result>("MembersPastExpiry");
        }
    
        public virtual ObjectResult<MembersBeforeExpiry_Result> MembersBeforeExpiry()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MembersBeforeExpiry_Result>("MembersBeforeExpiry");
        }
    }
}
