// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// 
// THIS FILE IS AUTOGENERATED, DO NOT MODIFY IT

using System.Runtime.Serialization;

namespace LSProtocol {
    /// <summary>
    /// Describes the content type that a client supports in various
    /// result literals like `Hover`, `ParameterInfo` or `CompletionItem`.
    /// 
    /// Please note that `MarkupKinds` must not start with a `$`. This kinds
    /// are reserved for internal usage.
    /// </summary>
    public enum MarkupKind 
    {
        /// <summary>
        /// Plain text is supported as a content format
        /// </summary>
        [EnumMember(Value = "plaintext")]PlainText,

        /// <summary>
        /// Markdown is supported as a content format
        /// </summary>
        [EnumMember(Value = "markdown")]Markdown,

    }
}