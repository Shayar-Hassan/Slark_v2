﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Slark.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SlarkEntities : DbContext
    {
        public SlarkEntities()
            : base("name=SlarkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<ChatRoom> ChatRooms { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<PrivateMessage> PrivateMessages { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectStatu> ProjectStatus { get; set; }
        public virtual DbSet<Space> Spaces { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<TeamProject> TeamProjects { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<WorkSpace> WorkSpaces { get; set; }
        public virtual DbSet<WsManager> WsManagers { get; set; }
        public virtual DbSet<Wsmember> Wsmembers { get; set; }
    }
}
