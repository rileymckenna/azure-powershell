//------------------------------------------------------------------------------
// <copyright file="ContactInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The contact information of the peer.
    /// </summary>
    public class ContactInfo
    { 
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInfo"/> class.
        /// </summary>
        public ContactInfo()
        {
            this.Emails = new List<string>();
            this.Phone = new List<string>();
        }

        /// <summary>
        /// Gets or sets the list of emails.
        /// </summary>
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or sets the list of phones.
        /// </summary>
        public List<string> Phone { get; set; }

        /// <summary>
        /// Returns the string representation of the object.
        /// </summary>
        /// <returns>The string representation of the object</returns>
        public override string ToString()
        {
            return $"{string.Join(",", this.Emails)}|" + $"{string.Join(",", this.Phone)}";
        }

        /// <summary>
        /// Equal override
        /// </summary>
        /// <param name="other">Contact info</param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other is ContactInfo contactInfo)
            {
                if (contactInfo.Emails == null || contactInfo.Phone == null)
                {
                    return false;
                }

                if (contactInfo.Emails.Count != this.Emails.Count ||
                    contactInfo.Phone.Count != this.Phone.Count)
                {
                    return false;
                }

                foreach (var email in this.Emails)
                {
                    if (!contactInfo.Emails.Contains(email, StringComparer.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }

                foreach (var phone in this.Phone)
                {
                    if (!contactInfo.Phone.Contains(phone, StringComparer.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Get hash code method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // ReSharper disable NonReadonlyMemberInGetHashCode
            var hash = 17;

            foreach (var email in this.Emails)
            {
                hash = (hash * 31) + email.GetHashCode();
            }

            foreach (var phone in this.Phone)
            {
                hash = (hash * 31) + phone.GetHashCode();
            }

            // ReSharper enable NonReadonlyMemberInGetHashCode
            return hash;
        }

        /// <summary>
        /// Clone method
        /// </summary>
        /// <returns>Cloned object</returns>
        public ContactInfo Clone()
        {
            return new ContactInfo
            {
                Emails = this.Emails.ToList(),
                Phone = this.Phone.ToList()
            };
        }
    }
}