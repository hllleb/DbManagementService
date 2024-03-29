﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MvcClient.Infrastructure;

namespace MvcClient.Models
{
    /// <summary>
    /// Represent a work time.
    /// </summary>
    public class WorkTimeDataModel
    {
        /// <summary>
        /// Gets the identifier of the work time object.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets the identifier of the task.
        /// </summary>
        [DisplayName("Task")]
        [Required]
        public int? TaskId { get; set; }

        /// <summary>
        /// Gets the identifier of the 
        /// </summary>
        [DisplayName("Employee")]
        [Required]
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the date when the employee worked on the task.
        /// </summary>
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required]
        public DateTime WorkDate { get; set; }

        /// <summary>
        /// Gets or sets the time when the employee started working on the task.
        /// </summary>
        [DisplayName("Start time")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        [DataType(DataType.Time)]
        [StartTime(nameof(StopTime))]
        [Required]
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the employee stopped working on the task.
        /// </summary>
        [DisplayName("Stop time")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        [DataType(DataType.Time)]
        [StopTime(nameof(StartTime))]
        [Required]
        public TimeSpan StopTime { get; set; }
    }
}
