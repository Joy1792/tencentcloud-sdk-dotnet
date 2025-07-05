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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApplicationTriggerPersonalRequest : AbstractModel
    {
        
        /// <summary>
        /// 触发器关联的镜像仓库，library/test格式
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 触发器名称
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// 触发方式，"all"全部触发，"taglist"指定tag触发，"regex"正则触发
        /// </summary>
        [JsonProperty("InvokeMethod")]
        public string InvokeMethod{ get; set; }

        /// <summary>
        /// 应用所在TKE集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 应用所在TKE集群命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 应用所在TKE集群工作负载类型,支持Deployment、StatefulSet、DaemonSet、CronJob、Job。
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

        /// <summary>
        /// 应用所在TKE集群工作负载名称
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }

        /// <summary>
        /// 应用所在TKE集群工作负载下容器名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 应用所在TKE集群地域
        /// </summary>
        [JsonProperty("ClusterRegion")]
        public long? ClusterRegion{ get; set; }

        /// <summary>
        /// 触发方式对应的表达式
        /// </summary>
        [JsonProperty("InvokeExpr")]
        public string InvokeExpr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "InvokeMethod", this.InvokeMethod);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ClusterRegion", this.ClusterRegion);
            this.SetParamSimple(map, prefix + "InvokeExpr", this.InvokeExpr);
        }
    }
}

