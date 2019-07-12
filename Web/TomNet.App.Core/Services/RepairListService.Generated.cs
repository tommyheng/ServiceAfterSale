﻿// <autogenerated>
//   This file was generated by T4 code generator ServiceCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

using SqlSugar;

using TomNet.SqlSugarCore.Entity;
using TomNet.App.Model.DB;
using TomNet.App.Core.Contracts;


namespace TomNet.App.Core.Services
{
    /// <summary>
    /// 服务类 RepairList
    /// </summary> 
	public partial class RepairListService : IRepairListContract
    {   		
		/// <summary>
        /// 服务提供者
        /// </summary>

	    private readonly IServiceProvider _serviceProvider;

		/// <summary>
        /// 仓储对象
        /// </summary>
		IRepository<RepairList, int> _repository;

		/// <summary>
        /// 构造函数
        /// </summary>
        public RepairListService(IServiceProvider provider)
        {
			_serviceProvider = provider;
			_repository = _serviceProvider.GetService<IRepository<RepairList, int>>();
            UnitOfWork = _repository.UnitOfWork;
            Entities = _repository.Entities;
        }

		/// <summary>
        /// 当前单元操作对象
        /// </summary>
        public IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 当前实体类型的查询数据集
        /// </summary>
        public ISugarQueryable<RepairList> Entities { get; }

         /// <summary>
        /// 新增
        /// </summary>
        /// <returns>操作影响的行数</returns>
        public int Insert(RepairList entity)
        {
            return _repository.Insert(entity);
        }

        public Task<int> InsertAsync(RepairList entity)
        {
            return _repository.InsertAsync(entity);
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <returns>操作影响的行数</returns>
        public int Insert(List<RepairList> entities)
        {
            return _repository.Insert(entities);
        }

        public Task<int> InsertAsync(List<RepairList> entities)
        {
            return _repository.InsertAsync(entities);
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <returns>操作影响的行数</returns>
        public int Insert(RepairList[] entities)
        {
            return _repository.Insert(entities);
        }

        public Task<int> InsertAsync(RepairList[] entities)
        {
            return _repository.InsertAsync(entities);
        }

        /// <summary>
        /// 新增并返回实体
        /// </summary>
        /// <returns>操作影响的行数</returns>
        public RepairList InsertReturnEntity(RepairList entity)
        {
            return _repository.InsertReturnEntity(entity);
        }

        public Task<RepairList> InsertReturnEntityAsync(RepairList entity)
        {
            return _repository.InsertReturnEntityAsync(entity);
        }

        /// <summary>
        /// 修改（主键是更新条件）
        /// </summary>
        /// <param name="entity"> 实体对象（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]）</param> 
        /// <param name="ignoreColumns">不更新的列</param>
        /// <returns>操作影响的行数</returns>
        public int Update(RepairList entity, string[] ignoreColumns = null)
        {
            return _repository.Update(entity, ignoreColumns);
        }

        public Task<int> UpdateAsync(RepairList entity, string[] ignoreColumns = null)
        {
            return _repository.UpdateAsync(entity, ignoreColumns);
        }

        /// <summary>
        /// 修改（主键是更新条件）
        /// </summary>
        /// <param name="entitys">实体对象集合（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]） </param> 
        /// <param name="ignoreColumns">不更新的列</param>
        /// <returns>操作影响的行数</returns>
        public int Update(List<RepairList> entitys, string[] ignoreColumns = null)
        {
            return _repository.Update(entitys, ignoreColumns);
        }

        public Task<int> UpdateAsync(List<RepairList> entitys, string[] ignoreColumns = null)
        {
            return _repository.UpdateAsync(entitys, ignoreColumns);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="update">实体对象</param> 
        /// <param name="predicate">条件</param>  
        /// <returns>操作影响的行数</returns>
        public int Update(Expression<Func<RepairList, RepairList>> update, Expression<Func<RepairList, bool>> predicate = null)
        {
            return _repository.Update(update, predicate);
        }

        public Task<int> UpdateAsync(Expression<Func<RepairList, RepairList>> update, Expression<Func<RepairList, bool>> predicate = null)
        {
            return _repository.UpdateAsync(update, predicate);
        }


        /// <summary>
        /// 根据实体删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(RepairList entity)
        {
            return _repository.Delete(entity);
        }

        public Task<int> DeleteAsync(RepairList entity)
        {
            return _repository.DeleteAsync(entity);
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Task<int> DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        /// <summary>
        /// 根据主键数组删除
        /// </summary>
        /// <param name="ids">主键数组</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(int[] ids)
        {
            return _repository.Delete(ids);
        }

        public Task<int> DeleteAsync(int[] ids)
        {
            return _repository.DeleteAsync(ids);
        }

        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="predicate">删除条件</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(Expression<Func<RepairList, bool>> predicate)
        {
            return _repository.Delete(predicate);
        }

        public Task<int> DeleteAsync(Expression<Func<RepairList, bool>> predicate)
        {
            return _repository.DeleteAsync(predicate);
        }

        /// <summary>
        /// 根据条件查询第一条符合条件的数据
        /// </summary>
        /// <param name="predicate">查询条件</param>
        public RepairList GetFirst(Expression<Func<RepairList, bool>> predicate)
        {
            return _repository.GetFirst(predicate);
        }

        public Task<RepairList> GetFirstAsync(Expression<Func<RepairList, bool>> predicate)
        {
            return _repository.GetFirstAsync(predicate);
        }		
	}
}
