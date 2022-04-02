using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Solvtio.Common;
using Solvtio.Models.Model;

namespace Solvtio.Models
{
    [Table("JobResult")]
    public sealed class JobResult
    {
        #region Constructors

        public JobResult()
        {
            CreateBase();
        }
        public JobResult(string jobType, string user)
        {
            CreateBase();

            JobType = jobType;
            User = user;
        }
        public JobResult(JobResult job)
        {
            Id = job.Id;
            JobId = job.JobId;
            ReportId = job.ReportId;
            DateTimeStart = job.DateTimeStart;
            DateTimeEnd = job.DateTimeEnd;
            ReportType = job.ReportType;
            Success = job.Success;
            JobType = job.JobType;
            User = job.User;
        }

        private void CreateBase()
        {
            ReportId = Guid.NewGuid();
            DateTimeStart = DateTime.Now;
            Success = true;
        }

        #endregion

        #region Properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string JobId { get; set; }
        public Guid ReportId { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public byte[] ReportContent { get; set; }
        public string ReportType { get; set; }
        public bool Success { get; set; }
        public string JobType { get; set; }
        public string User { get; set; }
        
        #endregion

        #region Properties ReadOnly

        #endregion

        #region Properties NotMapped

        //[NotMapped]
        //public DateTime? FechaNotificacionDemandaConDiasHabiles { get; set; }

        #endregion

        #region Methods

        #endregion
    }
}
