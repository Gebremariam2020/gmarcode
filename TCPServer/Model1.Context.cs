﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCPServer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GroupChatAppDBEntities : DbContext
    {
        public GroupChatAppDBEntities()
            : base("name=GroupChatAppDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Message_Table> Message_Table { get; set; }
        public virtual DbSet<Sending_Message_Collection_Table> Sending_Message_Collection_Table { get; set; }
        public virtual DbSet<User_Table> User_Table { get; set; }
    }
}
