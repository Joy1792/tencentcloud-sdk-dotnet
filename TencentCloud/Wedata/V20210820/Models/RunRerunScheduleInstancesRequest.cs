/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunRerunScheduleInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例列表
        /// </summary>
        [JsonProperty("Instances")]
        public InstanceOpsDto[] Instances{ get; set; }

        /// <summary>
        /// 检查父任务类型, true: 检查父任务; false: 不检查父任务 
        /// </summary>
        [JsonProperty("CheckFather")]
        public bool? CheckFather{ get; set; }

        /// <summary>
        /// 重跑类型, 1: 自身; 3: 孩子; 2: 自身以及孩子 
        /// </summary>
        [JsonProperty("RerunType")]
        public string RerunType{ get; set; }

        /// <summary>
        /// 实例依赖方式, 1: 自依赖; 2: 任务依赖; 3: 自依赖及父子依赖 
        /// </summary>
        [JsonProperty("DependentWay")]
        public string DependentWay{ get; set; }

        /// <summary>
        /// 重跑忽略事件监听与否 
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// 下游实例范围 1: 所在工作流 2: 所在项目 3: 所有跨工作流依赖的项目
        /// </summary>
        [JsonProperty("SonInstanceType")]
        public string SonInstanceType{ get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonProperty("SearchCondition")]
        public InstanceApiOpsRequest SearchCondition{ get; set; }

        /// <summary>
        /// 访问类型
        /// </summary>
        [JsonProperty("OptType")]
        public string OptType{ get; set; }

        /// <summary>
        /// 操作者名称
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [JsonProperty("OperatorId")]
        public string OperatorId{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目标志
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 索引页码
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 基础请求信息
        /// </summary>
        [JsonProperty("RequestBaseInfo")]
        public ProjectBaseInfoOpsRequest RequestBaseInfo{ get; set; }

        /// <summary>
        /// 是否计算总数
        /// </summary>
        [JsonProperty("IsCount")]
        public bool? IsCount{ get; set; }

        /// <summary>
        /// 是否异步模式
        /// </summary>
        [JsonProperty("AsyncMode")]
        public bool? AsyncMode{ get; set; }

        /// <summary>
        /// 是否检查上游任务： ALL（全部）、 MAKE_SCOPE（选中）、NONE （全部不检查）
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// 任务原有自依赖配置 true（是）、false（否）
        /// </summary>
        [JsonProperty("SameSelfDependType")]
        public bool? SameSelfDependType{ get; set; }

        /// <summary>
        /// 实例运行并发度
        /// </summary>
        [JsonProperty("ParallelNum")]
        public long? ParallelNum{ get; set; }

        /// <summary>
        /// 任务原有自依赖配置 true（是）、false（否）
        /// </summary>
        [JsonProperty("SameSelfWorkflowDependType")]
        public bool? SameSelfWorkflowDependType{ get; set; }

        /// <summary>
        /// 代表重新指定 的  是 或者 否  yes、 no
        /// </summary>
        [JsonProperty("SelfWorkflowDependency")]
        public string SelfWorkflowDependency{ get; set; }

        /// <summary>
        /// 运行实例数据时间排序 0---正常  1--正序  2 – 逆序
        /// </summary>
        [JsonProperty("DataTimeOrder")]
        public long? DataTimeOrder{ get; set; }

        /// <summary>
        /// 重跑参数
        /// </summary>
        [JsonProperty("ReDoParams")]
        public string ReDoParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Instances.", this.Instances);
            this.SetParamSimple(map, prefix + "CheckFather", this.CheckFather);
            this.SetParamSimple(map, prefix + "RerunType", this.RerunType);
            this.SetParamSimple(map, prefix + "DependentWay", this.DependentWay);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "SonInstanceType", this.SonInstanceType);
            this.SetParamObj(map, prefix + "SearchCondition.", this.SearchCondition);
            this.SetParamSimple(map, prefix + "OptType", this.OptType);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "OperatorId", this.OperatorId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamObj(map, prefix + "RequestBaseInfo.", this.RequestBaseInfo);
            this.SetParamSimple(map, prefix + "IsCount", this.IsCount);
            this.SetParamSimple(map, prefix + "AsyncMode", this.AsyncMode);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "SameSelfDependType", this.SameSelfDependType);
            this.SetParamSimple(map, prefix + "ParallelNum", this.ParallelNum);
            this.SetParamSimple(map, prefix + "SameSelfWorkflowDependType", this.SameSelfWorkflowDependType);
            this.SetParamSimple(map, prefix + "SelfWorkflowDependency", this.SelfWorkflowDependency);
            this.SetParamSimple(map, prefix + "DataTimeOrder", this.DataTimeOrder);
            this.SetParamSimple(map, prefix + "ReDoParams", this.ReDoParams);
        }
    }
}

