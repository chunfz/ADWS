﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ADWS.Models
{
    [DataContract]
    public class UserPasswordRequest
    {
        [DataMember]
        public string SamAccountName { get; set; }

        [DataMember( IsRequired = true )]
        public string NewPassword { get; set; }

        [DataMember( IsRequired = true )]
        public string OldPassword { get; set; }

        [DataMember]
        public bool IsAutoGeneratedPassword { get; set; }

        [DataMember]
        public bool WithPasswordExpiration { get; set; }

        [DataMember]
        public bool IsOldPasswordProvided { get; set; }

        [DataMember]
        public DomainRequest DomainInfo { get; set; }

        [OnDeserializing]
        private void OnDeserializing( StreamingContext context )
        {
            IsOldPasswordProvided = false;
            IsAutoGeneratedPassword = true;
            WithPasswordExpiration = false;
        }

    }
}