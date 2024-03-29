﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Service : SaleUnit
    {
        #region Constructors
        public Service(string name, DateTime creationDate, decimal price, string description) : base(name, creationDate, price)
        {
            Description = description;
        }
        #endregion

        #region Fields
        protected string description; 
        #endregion

        #region Properties
        public string Description
        {
            get => description;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Beskrivelsen kan ikke være null");
                }
                description = value;
            }
        } 
        #endregion

        #region Methods
        public TimeSpan GetRunTime()
        {
            return DateTime.Now - CreationDate;
        } 
        #endregion
    }
}