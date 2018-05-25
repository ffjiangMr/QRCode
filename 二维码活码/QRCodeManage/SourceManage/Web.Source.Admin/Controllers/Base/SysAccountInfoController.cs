﻿using Source.Admin.Web.Models.ViewModel;
using System;
using System.Linq;
using System.Web.Mvc;
using Source.Admin.Web.Common;
using Source.Admin.Web.Filters;
using TomNet.Web.Mvc;
using TomNet.Web.Mvc.UI;
using Source.Core.Contracts.Base;
using Source.Model.DbModels.Base;

namespace Source.Admin.Web.Controllers.Account
{
    public class SysAccountInfoController : BaseController
    {
        public ISysAccountInfoContract SysAccountInfoContract { get; set; }

        LoginModel mLogin = CookiesManagement.GetLoginModel(CookiesManagement.GetTicket());

        #region 列表页面


        // GET: Dictionaries
        [GlobalAuthorization]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 查询数据列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>-
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult IndexAsync(int pageIndex, int pageSize, string search = "")
        {
            //获取数据集合
            var query = SysAccountInfoContract.Entities.Where(d => d.IsDeleted == false);



            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(m => m.SuName.Contains(search));
            }
            //数据总数
            var total = query.Count();

            //默认给一个排序的字段
            query = query.OrderBy(m => m.Id);

            //分页(假如total == 0，则取消分页查询，提高性能)
            query = total > 0 ? query.Skip((pageIndex - 1) * pageSize).Take(pageSize)
                : Enumerable.Empty<SysAccountInfo>().AsQueryable();// null;

            //此处可以采用匿名对象 GridData<object>
            GridData<object> gridData = new GridData<object>() { Total = total, Rows = query.ToList() };

            //此处采用重写后的jsonResult
            return JsonEx(gridData, JsonRequestBehavior.AllowGet, "yyyy-MM-dd HH:mm:ss");
        }

        #endregion

        #region 新增部分

        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult InsertAsync(SysAccountInfo entity)
        {

            entity.CreatorId = mLogin.Id.ToString();

            //所有AJAX的结果，返回统一数据格式
            var result = new AjaxResult();
            try
            {
                var queryLogin = SysAccountInfoContract.CheckExists(m => m.Login.Equals(entity.Login) && m.IsDeleted==false);
                var querySuName = SysAccountInfoContract.CheckExists(m => m.SuName.Equals(entity.SuName) && m.IsDeleted == false);
                if (queryLogin)
                {
                    result.Type = AjaxResultType.Error;
                    result.Content = "登录名已被使用";
                }
                else if (querySuName)
                {
                    result.Type = AjaxResultType.Error;
                    result.Content = "员工已经存在";
                }
                else
                {
                    var count = SysAccountInfoContract.Insert(entity);
                    if (count > 0)
                    {
                        result.Type = AjaxResultType.Success;
                        result.Content = "录入成功";
                    }
                    else
                    {
                        result.Type = AjaxResultType.Error;
                        result.Content = "录入失败";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Type = AjaxResultType.Error;
                result.Content = "异常操作";
            }
            return JsonEx(result);
        }



        #endregion

        #region 编辑部分



        /// <summary>
        /// 加载编辑页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id = 0)
        {
            if (id == 0) throw new Exception("参数错误");

            var entity = SysAccountInfoContract.GetByKey(id);
            //    //后台容错，有异常数据直接抛出。框架会自动跳转到错误页面。
            if (entity == null) throw new Exception("未找到该实体");


            ViewData["entity"] = entity;
            return View();

        }

        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ActionResult EditAsync(SysAccountInfo entity)
        {
            var result = new AjaxResult();
            try
            {
                var count = SysAccountInfoContract.UpdateDirect(d => d.Id == entity.Id, d =>
                  new SysAccountInfo
                  {
                      SuName = entity.SuName,
                      Position = entity.Position,
                      Role = entity.Role,
                      Phone = entity.Phone,
                      Identity = entity.Identity,
                      Email = entity.Email,
                      Explain = entity.Explain,
                      Login = entity.Login,
                      Password = entity.Password
                  });



                if (count > 0)
                {
                    result.Type = AjaxResultType.Success;
                    result.Content = "修改成功";
                }
                else
                {
                    result.Type = AjaxResultType.Error;
                    result.Content = "修改失败";
                }

            }
            catch
            {
                result.Type = AjaxResultType.Error;
                result.Content = "异常操作";
            }
            return JsonEx(result);
        }
        #endregion

        #region 删除部分

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAsync(string ids)
        {
            var result = new AjaxResult();
            try
            {
                string[] idsStr = ids.Split(new char[] { ',' });
                int[] idsInt = Array.ConvertAll(idsStr, id => Convert.ToInt32(id));
                SysAccountInfoContract.UpdateDirect(m => idsInt.Contains(m.Id), d => new SysAccountInfo { IsDeleted = true });

                result.Type = AjaxResultType.Success;
                result.Content = "删除成功";
            }
            catch
            {
                result.Type = AjaxResultType.Error;
                result.Content = "异常操作";
            }
            return JsonEx(result);
        }

        #endregion

    }
}