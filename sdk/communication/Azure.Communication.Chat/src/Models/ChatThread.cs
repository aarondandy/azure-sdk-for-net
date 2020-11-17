// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Chat
{
    /// <summary>The ChatThread.</summary>
    public class ChatThread
    {
        internal ChatThread(ChatThreadInternal chatThreadInternal)
        {
            Id = chatThreadInternal.Id;
            Topic = chatThreadInternal.Topic;
            CreatedOn = chatThreadInternal.CreatedOn;
            CreatedBy = new CommunicationUser(chatThreadInternal.CreatedBy);
            Participants = chatThreadInternal.Participants.Select(x => x.ToChatParticipant()).ToList();
        }

        /// <summary> Chat thread id. </summary>
        public string Id { get; }
        /// <summary> Chat thread topic. </summary>
        public string Topic { get; }
        /// <summary> The timestamp when the chat thread was created. The timestamp is in ISO8601 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Id of the chat thread owner. </summary>
        public CommunicationUser CreatedBy { get; }
        /// <summary> Chat thread members. </summary>
        public IReadOnlyList<ChatParticipant> Participants { get; }
    }
}
