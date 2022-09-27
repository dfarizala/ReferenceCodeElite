using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Spin.Connection.DAL.Common;
using Spin.Connection.Entity;
using Spin.Modules.API.Base.Primitive;

namespace MedicalClinic.Domain.Interfaces.Base
{
    /// <summary>
    /// Base Access Context
    /// </summary>
    /// <typeparam name="T">Entity base</typeparam>
    /// <typeparam name="Q">Data type primary key</typeparam>
    public interface IBaseCommonBL<T, Q> : IDisposable
        where T : BaseEntityCommon<Q>, new()
        where Q : IComparable
    {

        #region SelectAll
        /// <summary>
        /// Get all elements by table 
        /// </summary>
        /// <returns>List element s</returns>
        IQueryable<T> SelectAll();
        #endregion

        #region Select
        /// <summary>
        /// Get element by Id
        /// </summary>
        /// <param name="Id">Primary Key</param>
        /// <returns>Element found to database</returns>
        IQueryable<T> Select(Q Id);

        #endregion

        #region SelectBy
        /// <summary>
        /// Select elements by where
        /// </summary>
        /// <param name="Value">Parameter for filter information</param>
        /// <returns>List elements</returns>
        /// <example>this.SelectBy(a=> a.Id == 33);</example>
        IQueryable<T> SelectBy(Expression<Func<T, bool>> Value);
        #endregion

        #region CreateOrUpdate
        /// <summary>
        /// Insert or Update element
        /// </summary>
        /// <param name="Value">element by insert or update</param>
        /// <returns>return element database updated</returns>
        /// <remarks>If Id is 0, the system take a new register</remarks>
        T InsertOrUpdate(T Value);

        #endregion

        #region DeleteItems
        /// <summary>
        /// Delete information in cascade, comparer information database to object
        /// </summary>
        /// <param name="Value">inforamtion in memory</param>
        /// <param name="BaseItem">information to database</param>
        /// <returns>Element uploded</returns>
        T DeleteInternalObjectArray(T Value, T BaseItem);


        /// <summary>
        /// Delete Array comparer if element not exist local and exist remote
        /// </summary>
        /// <param name="Value">Element Memory</param>
        /// <param name="Base">Element database</param>
        void DeleteItemArray(BaseEntityCommon<Q> Value, BaseEntityCommon<Q> Base);
        #endregion


        #region Delete
        /// <summary>
        /// Delete Information and seve then 
        /// </summary>
        /// <param name="Value">element to delete</param>
        void DeleteAndSave(T Value);

        /// <summary>
        /// Delete Information and seve then with Id
        /// </summary>
        /// <param name="Id">promary key for delete</param>
        void DeleteAndSave(Q Id);

        /// <summary>
        /// Delete item but no send information to server
        /// </summary>
        /// <param name="Value">Element to delete item</param>
        void Delete(T Value);

        /// <summary>
        /// Delete item but no send information to server
        /// </summary>
        /// <param name="Id">Primary key to delete item</param>
        void Delete(Q Id);
        #endregion

        #region IncludeByDefault
        /// <summary>
        /// Include buy default inner join to other tables
        /// </summary>
        /// <param name="Value">Querable base</param>
        /// <returns>Querable modify</returns>
        IQueryable<T> IncludeByDefault(IQueryable<T> Value);
        #endregion

        #region TotalCount
        /// <summary>
        /// Total itmes in database
        /// </summary>
        /// <param name="Filter">parameter for filter result</param>
        /// <returns></returns>
        int TotalCount(List<SpinFilterItem> Filter);
        #endregion

        #region SelectAllPerPage
        /// <summary>
        /// Pagination all register 
        /// </summary>
        /// <param name="Value">Query by linq</param>
        /// <param name="Page">Number page</param>
        /// <param name="RegisterPerPage">number items per page</param>
        /// <param name="AddInclude">Include join to other tables</param>
        /// <returns>List items paged</returns>
        PaginatedListCommon<T, Q> SelectAllPerPage(IQueryable<T> Value, int Page, int RegisterPerPage, bool AddInclude = false);

        /// <summary>
        /// Pagination register filtered
        /// </summary>
        /// <param name="Filter">Parameters for query, intermal normaly use selectby</param>
        /// <param name="Page">Number page</param>
        /// <param name="RegisterPerPage">number items per page</param>
        /// <param name="AddInclude">Include join to other tables</param>
        /// <returns>List items paged</returns>
        PaginatedListCommon<T, Q> SelectAllPerPage(List<SpinFilterItem> Filter, int Page, int RegisterPerPage, bool AddInclude = false);

        /// <summary>
        /// Find information with parameters specifics
        /// </summary>
        /// <param name="Filter">List parameter for search</param>
        /// <returns>List elements filters</returns>
        List<T> Search(List<SpinFilterItem> Filter);

        /// <summary>
        /// Pagination register filtered
        /// </summary>
        /// <param name="Filter">Parameters for query, intermal normaly use selectby</param>
        /// <param name="Value">Query by linq</param>
        /// <param name="Page">Number page</param>
        /// <param name="RegisterPerPage">number items per page</param>
        /// <param name="AddInclude">Include join to other tables</param>
        /// <returns>List items paged</returns>
        PaginatedListCommon<T, Q> SelectAllPerPage(IQueryable<T> Value, List<SpinFilterItem> Filter, int Page, int RegisterPerPage, bool AddInclude = false);

        /// <summary>
        /// Find information with parameters specifics
        /// </summary>
        /// <param name="Value">Query by linq</param>
        /// <param name="Filter">List parameter for search</param>
        /// <returns>List elements filters</returns>
        List<T> Search(IQueryable<T> Value, List<SpinFilterItem> Filter);

        /// <summary>
        /// Build Exporesion filters
        /// </summary>
        /// <param name="Filters">List filters to add</param>
        /// <returns></returns>
        Expression<Func<T, bool>> AddFilter(List<SpinFilterItem> Filters);
        #endregion

        /// <summary>
        /// Detach all entities
        /// </summary>
        public void DetachAllEntities();
    }
}