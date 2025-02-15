// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Git repository property payload for config server. </summary>
    public partial class GitPatternRepository
    {
        /// <summary> Initializes a new instance of GitPatternRepository. </summary>
        /// <param name="name"> Name of the repository. </param>
        /// <param name="uri"> URI of the repository. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="uri"/> is null. </exception>
        public GitPatternRepository(string name, Uri uri)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(uri, nameof(uri));

            Name = name;
            Pattern = new ChangeTrackingList<string>();
            Uri = uri;
            SearchPaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GitPatternRepository. </summary>
        /// <param name="name"> Name of the repository. </param>
        /// <param name="pattern"> Collection of pattern of the repository. </param>
        /// <param name="uri"> URI of the repository. </param>
        /// <param name="label"> Label of the repository. </param>
        /// <param name="searchPaths"> Searching path of the repository. </param>
        /// <param name="username"> Username of git repository basic auth. </param>
        /// <param name="password"> Password of git repository basic auth. </param>
        /// <param name="hostKey"> Public sshKey of git repository. </param>
        /// <param name="hostKeyAlgorithm"> SshKey algorithm of git repository. </param>
        /// <param name="privateKey"> Private sshKey algorithm of git repository. </param>
        /// <param name="strictHostKeyChecking"> Strict host key checking or not. </param>
        internal GitPatternRepository(string name, IList<string> pattern, Uri uri, string label, IList<string> searchPaths, string username, string password, string hostKey, string hostKeyAlgorithm, string privateKey, bool? strictHostKeyChecking)
        {
            Name = name;
            Pattern = pattern;
            Uri = uri;
            Label = label;
            SearchPaths = searchPaths;
            Username = username;
            Password = password;
            HostKey = hostKey;
            HostKeyAlgorithm = hostKeyAlgorithm;
            PrivateKey = privateKey;
            StrictHostKeyChecking = strictHostKeyChecking;
        }

        /// <summary> Name of the repository. </summary>
        public string Name { get; set; }
        /// <summary> Collection of pattern of the repository. </summary>
        public IList<string> Pattern { get; }
        /// <summary> URI of the repository. </summary>
        public Uri Uri { get; set; }
        /// <summary> Label of the repository. </summary>
        public string Label { get; set; }
        /// <summary> Searching path of the repository. </summary>
        public IList<string> SearchPaths { get; }
        /// <summary> Username of git repository basic auth. </summary>
        public string Username { get; set; }
        /// <summary> Password of git repository basic auth. </summary>
        public string Password { get; set; }
        /// <summary> Public sshKey of git repository. </summary>
        public string HostKey { get; set; }
        /// <summary> SshKey algorithm of git repository. </summary>
        public string HostKeyAlgorithm { get; set; }
        /// <summary> Private sshKey algorithm of git repository. </summary>
        public string PrivateKey { get; set; }
        /// <summary> Strict host key checking or not. </summary>
        public bool? StrictHostKeyChecking { get; set; }
    }
}
