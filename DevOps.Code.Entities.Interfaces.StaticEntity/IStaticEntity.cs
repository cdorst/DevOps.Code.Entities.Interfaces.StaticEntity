// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using DevOps.Code.Entities.Interfaces.Entity;
using System;
using System.Linq.Expressions;

namespace DevOps.Code.Entities.Interfaces.StaticEntity
{
    /// <summary>Common interface for code-generated uneditable entity types</summary>
    public interface IStaticEntity<TEntity, TKey>
    {
        /// <summary>Returns an expression that EntityFrameworkCore uses to set a unique index on this entity type</summary>
        Expression<Func<TEntity, object>> GetUniqueIndex();
    }
}
