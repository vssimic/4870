﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class aspnet_Applications
{
    public aspnet_Applications()
    {
        this.aspnet_Membership = new HashSet<aspnet_Membership>();
        this.aspnet_Paths = new HashSet<aspnet_Paths>();
        this.aspnet_Roles = new HashSet<aspnet_Roles>();
        this.aspnet_Users = new HashSet<aspnet_Users>();
    }

    public string ApplicationName { get; set; }
    public string LoweredApplicationName { get; set; }
    public System.Guid ApplicationId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<aspnet_Membership> aspnet_Membership { get; set; }
    public virtual ICollection<aspnet_Paths> aspnet_Paths { get; set; }
    public virtual ICollection<aspnet_Roles> aspnet_Roles { get; set; }
    public virtual ICollection<aspnet_Users> aspnet_Users { get; set; }
}

public partial class aspnet_Membership
{
    public System.Guid ApplicationId { get; set; }
    public System.Guid UserId { get; set; }
    public string Password { get; set; }
    public int PasswordFormat { get; set; }
    public string PasswordSalt { get; set; }
    public string MobilePIN { get; set; }
    public string Email { get; set; }
    public string LoweredEmail { get; set; }
    public string PasswordQuestion { get; set; }
    public string PasswordAnswer { get; set; }
    public bool IsApproved { get; set; }
    public bool IsLockedOut { get; set; }
    public System.DateTime CreateDate { get; set; }
    public System.DateTime LastLoginDate { get; set; }
    public System.DateTime LastPasswordChangedDate { get; set; }
    public System.DateTime LastLockoutDate { get; set; }
    public int FailedPasswordAttemptCount { get; set; }
    public System.DateTime FailedPasswordAttemptWindowStart { get; set; }
    public int FailedPasswordAnswerAttemptCount { get; set; }
    public System.DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }
    public string Comment { get; set; }

    public virtual aspnet_Applications aspnet_Applications { get; set; }
    public virtual aspnet_Users aspnet_Users { get; set; }
}

public partial class aspnet_Paths
{
    public aspnet_Paths()
    {
        this.aspnet_PersonalizationPerUser = new HashSet<aspnet_PersonalizationPerUser>();
    }

    public System.Guid ApplicationId { get; set; }
    public System.Guid PathId { get; set; }
    public string Path { get; set; }
    public string LoweredPath { get; set; }

    public virtual aspnet_Applications aspnet_Applications { get; set; }
    public virtual aspnet_PersonalizationAllUsers aspnet_PersonalizationAllUsers { get; set; }
    public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
}

public partial class aspnet_PersonalizationAllUsers
{
    public System.Guid PathId { get; set; }
    public byte[] PageSettings { get; set; }
    public System.DateTime LastUpdatedDate { get; set; }

    public virtual aspnet_Paths aspnet_Paths { get; set; }
}

public partial class aspnet_PersonalizationPerUser
{
    public System.Guid Id { get; set; }
    public Nullable<System.Guid> PathId { get; set; }
    public Nullable<System.Guid> UserId { get; set; }
    public byte[] PageSettings { get; set; }
    public System.DateTime LastUpdatedDate { get; set; }

    public virtual aspnet_Paths aspnet_Paths { get; set; }
    public virtual aspnet_Users aspnet_Users { get; set; }
}

public partial class aspnet_Profile
{
    public System.Guid UserId { get; set; }
    public string PropertyNames { get; set; }
    public string PropertyValuesString { get; set; }
    public byte[] PropertyValuesBinary { get; set; }
    public System.DateTime LastUpdatedDate { get; set; }

    public virtual aspnet_Users aspnet_Users { get; set; }
}

public partial class aspnet_Roles
{
    public aspnet_Roles()
    {
        this.aspnet_Users = new HashSet<aspnet_Users>();
    }

    public System.Guid ApplicationId { get; set; }
    public System.Guid RoleId { get; set; }
    public string RoleName { get; set; }
    public string LoweredRoleName { get; set; }
    public string Description { get; set; }

    public virtual aspnet_Applications aspnet_Applications { get; set; }
    public virtual ICollection<aspnet_Users> aspnet_Users { get; set; }
}

public partial class aspnet_SchemaVersions
{
    public string Feature { get; set; }
    public string CompatibleSchemaVersion { get; set; }
    public bool IsCurrentVersion { get; set; }
}

public partial class aspnet_Users
{
    public aspnet_Users()
    {
        this.aspnet_PersonalizationPerUser = new HashSet<aspnet_PersonalizationPerUser>();
        this.aspnet_Roles = new HashSet<aspnet_Roles>();
    }

    public System.Guid ApplicationId { get; set; }
    public System.Guid UserId { get; set; }
    public string UserName { get; set; }
    public string LoweredUserName { get; set; }
    public string MobileAlias { get; set; }
    public bool IsAnonymous { get; set; }
    public System.DateTime LastActivityDate { get; set; }

    public virtual aspnet_Applications aspnet_Applications { get; set; }
    public virtual aspnet_Membership aspnet_Membership { get; set; }
    public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
    public virtual aspnet_Profile aspnet_Profile { get; set; }
    public virtual ICollection<aspnet_Roles> aspnet_Roles { get; set; }
}

public partial class aspnet_WebEvent_Events
{
    public string EventId { get; set; }
    public System.DateTime EventTimeUtc { get; set; }
    public System.DateTime EventTime { get; set; }
    public string EventType { get; set; }
    public decimal EventSequence { get; set; }
    public decimal EventOccurrence { get; set; }
    public int EventCode { get; set; }
    public int EventDetailCode { get; set; }
    public string Message { get; set; }
    public string ApplicationPath { get; set; }
    public string ApplicationVirtualPath { get; set; }
    public string MachineName { get; set; }
    public string RequestUrl { get; set; }
    public string ExceptionType { get; set; }
    public string Details { get; set; }
}

public partial class Order
{
    public Order()
    {
        this.Toppings = new HashSet<Topping>();
    }

    public int orderId { get; set; }
    public string firstname { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string size { get; set; }
    public Nullable<int> noOfPizzas { get; set; }
    public string delivery { get; set; }
    public System.DateTime orderDate { get; set; }

    public virtual ICollection<Topping> Toppings { get; set; }
}

public partial class Topping
{
    public Topping()
    {
        this.Orders = new HashSet<Order>();
    }

    public int toppingId { get; set; }
    public string name { get; set; }
    public string active { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}

public partial class vw_aspnet_Applications
{
    public string ApplicationName { get; set; }
    public string LoweredApplicationName { get; set; }
    public System.Guid ApplicationId { get; set; }
    public string Description { get; set; }
}

public partial class vw_aspnet_MembershipUsers
{
    public System.Guid UserId { get; set; }
    public int PasswordFormat { get; set; }
    public string MobilePIN { get; set; }
    public string Email { get; set; }
    public string LoweredEmail { get; set; }
    public string PasswordQuestion { get; set; }
    public string PasswordAnswer { get; set; }
    public bool IsApproved { get; set; }
    public bool IsLockedOut { get; set; }
    public System.DateTime CreateDate { get; set; }
    public System.DateTime LastLoginDate { get; set; }
    public System.DateTime LastPasswordChangedDate { get; set; }
    public System.DateTime LastLockoutDate { get; set; }
    public int FailedPasswordAttemptCount { get; set; }
    public System.DateTime FailedPasswordAttemptWindowStart { get; set; }
    public int FailedPasswordAnswerAttemptCount { get; set; }
    public System.DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }
    public string Comment { get; set; }
    public System.Guid ApplicationId { get; set; }
    public string UserName { get; set; }
    public string MobileAlias { get; set; }
    public bool IsAnonymous { get; set; }
    public System.DateTime LastActivityDate { get; set; }
}

public partial class vw_aspnet_Profiles
{
    public System.Guid UserId { get; set; }
    public System.DateTime LastUpdatedDate { get; set; }
    public Nullable<int> DataSize { get; set; }
}

public partial class vw_aspnet_Roles
{
    public System.Guid ApplicationId { get; set; }
    public System.Guid RoleId { get; set; }
    public string RoleName { get; set; }
    public string LoweredRoleName { get; set; }
    public string Description { get; set; }
}

public partial class vw_aspnet_Users
{
    public System.Guid ApplicationId { get; set; }
    public System.Guid UserId { get; set; }
    public string UserName { get; set; }
    public string LoweredUserName { get; set; }
    public string MobileAlias { get; set; }
    public bool IsAnonymous { get; set; }
    public System.DateTime LastActivityDate { get; set; }
}

public partial class vw_aspnet_UsersInRoles
{
    public System.Guid UserId { get; set; }
    public System.Guid RoleId { get; set; }
}

public partial class vw_aspnet_WebPartState_Paths
{
    public System.Guid ApplicationId { get; set; }
    public System.Guid PathId { get; set; }
    public string Path { get; set; }
    public string LoweredPath { get; set; }
}

public partial class vw_aspnet_WebPartState_Shared
{
    public System.Guid PathId { get; set; }
    public Nullable<int> DataSize { get; set; }
    public System.DateTime LastUpdatedDate { get; set; }
}

public partial class vw_aspnet_WebPartState_User
{
    public Nullable<System.Guid> PathId { get; set; }
    public Nullable<System.Guid> UserId { get; set; }
    public Nullable<int> DataSize { get; set; }
    public System.DateTime LastUpdatedDate { get; set; }
}

public partial class aspnet_Membership_GetPassword_Result
{
    public string Column1 { get; set; }
    public Nullable<int> Column2 { get; set; }
}

public partial class aspnet_Membership_GetPasswordWithFormat_Result
{
    public string Column1 { get; set; }
    public Nullable<int> Column2 { get; set; }
    public string Column3 { get; set; }
    public Nullable<int> Column4 { get; set; }
    public Nullable<int> Column5 { get; set; }
    public Nullable<bool> Column6 { get; set; }
    public Nullable<System.DateTime> Column7 { get; set; }
    public Nullable<System.DateTime> Column8 { get; set; }
}

public partial class aspnet_Membership_GetUserByName_Result
{
    public string Email { get; set; }
    public string PasswordQuestion { get; set; }
    public string Comment { get; set; }
    public bool IsApproved { get; set; }
    public System.DateTime CreateDate { get; set; }
    public System.DateTime LastLoginDate { get; set; }
    public System.DateTime LastActivityDate { get; set; }
    public System.DateTime LastPasswordChangedDate { get; set; }
    public System.Guid UserId { get; set; }
    public bool IsLockedOut { get; set; }
    public System.DateTime LastLockoutDate { get; set; }
}

public partial class aspnet_Membership_GetUserByUserId_Result
{
    public string Email { get; set; }
    public string PasswordQuestion { get; set; }
    public string Comment { get; set; }
    public bool IsApproved { get; set; }
    public System.DateTime CreateDate { get; set; }
    public System.DateTime LastLoginDate { get; set; }
    public System.DateTime LastActivityDate { get; set; }
    public System.DateTime LastPasswordChangedDate { get; set; }
    public string UserName { get; set; }
    public bool IsLockedOut { get; set; }
    public System.DateTime LastLockoutDate { get; set; }
}

public partial class aspnet_Profile_GetProperties_Result
{
    public string PropertyNames { get; set; }
    public string PropertyValuesString { get; set; }
    public byte[] PropertyValuesBinary { get; set; }
}

public partial class aspnet_UsersInRoles_RemoveUsersFromRoles_Result
{
    public string Column1 { get; set; }
    public string Name { get; set; }
}
