// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that migrates on-prem SQL Server databases to Azure SQL Database for online migrations. </summary>
    public partial class MigrateSqlServerSqlDBSyncTaskInput : SqlMigrationTaskInput
    {
        /// <summary> Initializes a new instance of MigrateSqlServerSqlDBSyncTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public MigrateSqlServerSqlDBSyncTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IEnumerable<MigrateSqlServerSqlDBSyncDatabaseInput> selectedDatabases) : base(sourceConnectionInfo, targetConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));

            SelectedDatabases = selectedDatabases.ToList();
        }

        /// <summary> Initializes a new instance of MigrateSqlServerSqlDBSyncTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="validationOptions"> Validation options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> or <paramref name="targetConnectionInfo"/> is null. </exception>
        internal MigrateSqlServerSqlDBSyncTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IList<MigrateSqlServerSqlDBSyncDatabaseInput> selectedDatabases, MigrationValidationOptions validationOptions) : base(sourceConnectionInfo, targetConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));

            SelectedDatabases = selectedDatabases;
            ValidationOptions = validationOptions;
        }

        /// <summary> Databases to migrate. </summary>
        public IList<MigrateSqlServerSqlDBSyncDatabaseInput> SelectedDatabases { get; }
        /// <summary> Validation options. </summary>
        public MigrationValidationOptions ValidationOptions { get; set; }
    }
}
