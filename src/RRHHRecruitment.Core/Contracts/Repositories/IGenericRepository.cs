﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RRHHRecruitment.Core.Contracts.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// Stores a given <see cref="T"/>
        /// </summary>
        /// <param name="entity">An instance of <see cref="T"/></param>
        /// <returns>An implementation of <see cref="IOperationResult{T}"/></returns>
        IOperationResult<T> Create(T entity);

        /// <summary>
        /// Gets an instance of <see cref="T"/> according with the given expression parameter.
        /// </summary>
        /// <param name="predicate">Contains the filter that will be used for the search in the database.</param>
        /// <returns>An instance of <see cref="T"/>.</returns>
        T Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets all the <see cref="T"/> existing.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>.</returns>
        IEnumerable<T> Get();

        /// <summary>
        /// Updates a given <see cref="T"/>.
        /// </summary>
        /// <param name="entity">An instance of <see cref="T"/>.</param>
        /// <returns>An implementation of <see cref="IOperationResult{T}"/>.</returns>
        IOperationResult<T> Update(T entity);

        /// <summary>
        /// Removes a given <see cref="T"/>.
        /// </summary>
        /// <param name="entity">An instance of <see cref="T"/>.</param>
        /// <returns>An implementation of <see cref="IOperationResult{T}"/>.</returns>
        IOperationResult<T> Remove(T entity);

        /// <summary>
        /// Gets a collection of <see cref="T"/> according with the given expression parameter.
        /// </summary>
        /// <param name="predicate">Contains the filter that will be used for the search in the database.</param>
        /// <returns>An <see cref="IEnumerable{T}"/>.</returns>
        IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Performs the saving of the changes that have been executed on <see cref="T"/>.
        /// </summary>
        void Save();

        /// <summary>
        /// Checks the existence of any <see cref="T"/> that match the filter parameter.
        /// </summary>
        /// <param name="predicate">Contains the filter that will be used for the search in the database.</param>
        /// <returns>A <see cref="bool"/> value representing if <see cref="T"/> exists</returns>
        bool Exists(Expression<Func<T, bool>> predicate);

    }
}
