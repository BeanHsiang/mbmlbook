// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace UnclutteringYourInbox.Features
{
    using System;


    /// <summary>
    /// The message has attachments feature.
    /// </summary>
    [Serializable]
    public class HasAttachments : BinaryFeature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasAttachments"/> class. 
        /// </summary>
        public HasAttachments()
        {
            this.Description = "Whether the message has attachments";
        }

        /// <summary>
        /// Computes the feature.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>
        /// The <see cref="System.Boolean" />
        /// </returns>
        public override bool ComputeFeature(Message message)
        {
            return message.HasAttachments;
        }
    }
}
