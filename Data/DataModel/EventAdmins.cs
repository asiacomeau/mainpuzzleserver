﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCore.DataModel
{
    public class EventAdmins
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Foreign key - event table
        /// </summary
        [ForeignKey("Event.ID")]
        public virtual EventOwners Event { get; set; }

        /// <summary>
        /// Foreign key - user table
        /// </summary>
        [ForeignKey("User.ID")]
        public virtual User Admin { get; set; }

    }
}