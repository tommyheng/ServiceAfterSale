﻿// <autogenerated>
//   This file was generated by T4 code generator ContractCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using SqlSugar;

using TomNet.SqlSugarCore.Entity;
using TomNet.App.Model.DB;


namespace TomNet.App.Core.Contracts
{
    /// <summary>
    /// 契约接口 Goods
    /// </summary> 
	public partial interface IGoodsContract
    { 
		/// <summary>
        /// 获取 当前单元操作对象
        /// </summary>
        IUnitOfWork UnitOfWork { get; }

		/// <summary>
        /// 获取 当前实体类型的查询数据集
        /// </summary>
        ISugarQueryable<Goods> Entities { get; }

        //=============================== 实现方法 ===============================
        /// <summary>
        /// 新增
        /// </summary>
        /// <returns>操作影响的行数</returns>
        int Insert(Goods entity);

        Task<int> InsertAsync(Goods entity);


        /// <summary>
        /// 批量新增
        /// </summary>
        /// <returns>操作影响的行数</returns>
        int Insert(List<Goods> entities);

        Task<int> InsertAsync(List<Goods> entities);


        /// <summary>
        /// 批量新增
        /// </summary>
        /// <returns>操作影响的行数</returns>
        int Insert(Goods[] entities);

        Task<int> InsertAsync(Goods[] entities);


        /// <summary>
        /// 新增并返回实体
        /// </summary>
        /// <returns>操作影响的行数</returns>
        Goods InsertReturnEntity(Goods entity);

        Task<Goods> InsertReturnEntityAsync(Goods entity);


        /// <summary>
        /// 修改（主键是更新条件）
        /// </summary>
        /// <param name="entity"> 实体对象（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]）</param> 
        /// <param name="ignoreColumns">不更新的列</param>
        /// <returns>操作影响的行数</returns>
        int Update(Goods entity, string[] ignoreColumns = null);

        Task<int> UpdateAsync(Goods entity, string[] ignoreColumns = null);


        /// <summary>
        /// 修改（主键是更新条件）
        /// </summary>
        /// <param name="entitys">实体对象集合（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]） </param> 
        /// <param name="ignoreColumns">不更新的列</param>
        /// <returns>操作影响的行数</returns>
        int Update(List<Goods> entitys, string[] ignoreColumns = null);

        Task<int> UpdateAsync(List<Goods> entitys, string[] ignoreColumns = null);


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="update">实体对象</param> 
        /// <param name="predicate">条件</param>  
        /// <returns>操作影响的行数</returns>
        int Update(Expression<Func<Goods, Goods>> update, Expression<Func<Goods, bool>> predicate = null);

        Task<int> UpdateAsync(Expression<Func<Goods, Goods>> update, Expression<Func<Goods, bool>> predicate = null);


        /// <summary>
        /// 根据实体删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns>操作影响的行数</returns>
        int Delete(Goods entity);

        Task<int> DeleteAsync(Goods entity);


        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>操作影响的行数</returns>
        int Delete(int id);

        Task<int> DeleteAsync(int id);


        /// <summary>
        /// 根据主键数组删除
        /// </summary>
        /// <param name="ids">主键数组</param>
        /// <returns>操作影响的行数</returns>
        int Delete(int[] ids);

        Task<int> DeleteAsync(int[] ids);


        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="predicate">删除条件</param>
        /// <returns>操作影响的行数</returns>
        int Delete(Expression<Func<Goods, bool>> predicate);

        Task<int> DeleteAsync(Expression<Func<Goods, bool>> predicate);


        /// <summary>
        /// 根据条件查询第一条符合条件的数据
        /// </summary>
        /// <param name="predicate">查询条件</param>
        Goods GetFirst(Expression<Func<Goods, bool>> predicate);

        Task<Goods> GetFirstAsync(Expression<Func<Goods, bool>> predicate);

	}
}
