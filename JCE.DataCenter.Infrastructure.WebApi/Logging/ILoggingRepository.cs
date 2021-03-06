﻿/************************************************************************************
 * Copyright (c) 2017 All Rights Reserved. 
 * CLR版本：4.0.30319.42000
 * 机器名称：JIAN
 * 命名空间：JCE.DataCenter.Infrastructure.WebApi.Logging
 * 文件名：ILoggingRepository
 * 版本号：v1.0.0.0
 * 唯一标识：e4c7410b-8483-4329-bfbc-b18efbe77d73
 * 当前的用户域：JIAN
 * 创建人：简玄冰
 * 电子邮箱：jianxuanhuo1@126.com
 * 创建时间：2017/7/23 18:41:24
 * 描述：
 *
 * =====================================================================
 * 修改标记：
 * 修改时间：2017/7/23 18:41:24
 * 修改人：简玄冰
 * 版本号：v1.0.0.0
 * 描述：
 *
/************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCE.DataCenter.Infrastructure.WebApi.Logging
{
    /// <summary>
    /// 日志记录仓储
    /// </summary>
    public interface ILoggingRepository
    {
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="loggingInfo">Api日志信息</param>
        void Log(ApiLoggingInfo loggingInfo);
    }
}
