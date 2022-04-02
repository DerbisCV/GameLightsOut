using System;
using System.Security.Principal;

namespace Solvtio.Models.Common
{
    //public interface IAuditable
    //{
    //    DateTime CreatedDate { get; set; }
    //    DateTime UpdatedDate { get; set; }
    //    string CreatedBy { get; set; }
    //    string UpdatedBy { get; set; }

    //    bool IsNew { get; }
    //}

    //public abstract class Auditable : IAuditable
    //{
    //    public DateTime CreatedDate { get; set; }
    //    public DateTime UpdatedDate { get; set; }
    //    public string CreatedBy { get; set; }
    //    public string UpdatedBy { get; set; }

    //    public abstract bool IsNew { get; }

    //    public void RefreshAuditable(IAuditable modelBase)
    //    {
    //        if (IsNew)
    //        {
    //            CreatedDate = DateTime.Now;
    //            CreatedBy = modelBase.CreatedBy;
    //        }
    //        UpdatedDate = DateTime.Now;
    //        UpdatedBy = modelBase.UpdatedBy;
    //    }
    //}

    //public interface IAuditableMin
    //{
    //    DateTime UpdatedDate { get; set; }
    //    string UpdatedBy { get; set; }
    //}

    //public abstract class AuditableMin : IAuditableMin
    //{
    //    public DateTime UpdatedDate { get; set; }
    //    public string UpdatedBy { get; set; }


    //    public void RefreshAuditable(IAuditableMin modelBase)
    //    {
    //        UpdatedDate = DateTime.Now;
    //        UpdatedBy = modelBase.UpdatedBy;
    //    }
    //}

    //public interface IExpedienteChild
    //{
    //    int IdExpediente { get; set; }
    //}

    //public static class IAuditableExtension
    //{
    //    public static void Audit(this IAuditable auditable, IPrincipal user)
    //    {
    //        if (auditable == null) return;
    //        Audit(auditable, auditable.IsNew, user?.Identity?.Name);
    //    }

    //    public static void Audit(this IAuditableMin auditable, IPrincipal user)
    //    {
    //        if (auditable == null) return;

    //        auditable.UpdatedDate = DateTime.UtcNow;
    //        auditable.UpdatedBy = user?.Identity?.Name;
    //    }
    //    public static void Audit(this IAuditableMin auditable)
    //    {
    //        if (auditable == null) return;
    //        auditable.UpdatedDate = DateTime.Now;
    //    }

    //    public static void Audit(this IAuditable auditable, bool createNew, IPrincipal user)
    //    {
    //        Audit(auditable, createNew, user?.Identity?.Name);
    //    }
    //    public static void Audit(this IAuditable auditable, bool createNew, string byUser)
    //    {
    //        if (auditable == null) return;

    //        if (createNew)
    //        {
    //            auditable.CreatedDate = DateTime.UtcNow;
    //            auditable.CreatedBy = byUser;
    //        }

    //        auditable.UpdatedDate = DateTime.UtcNow;
    //        auditable.UpdatedBy = byUser;
    //    }
    //    public static void Audit(this IAuditable auditable, bool createNew)
    //    {
    //        if (auditable == null) return;

    //        if (createNew)
    //            auditable.CreatedDate = DateTime.UtcNow;

    //        auditable.UpdatedDate = DateTime.UtcNow;
    //    }

    //}
}
