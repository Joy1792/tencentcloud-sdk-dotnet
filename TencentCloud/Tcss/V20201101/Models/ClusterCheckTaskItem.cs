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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterCheckTaskItem : AbstractModel
    {
        
        /// <summary>
        /// 指定要扫描的集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群所属地域
        /// </summary>
        [JsonProperty("ClusterRegion")]
        public string ClusterRegion{ get; set; }

        /// <summary>
        /// 指定要扫描的节点IP
        /// </summary>
        [JsonProperty("NodeIp")]
        public string NodeIp{ get; set; }

        /// <summary>
        /// 按照要扫描的workload名字
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterRegion", this.ClusterRegion);
            this.SetParamSimple(map, prefix + "NodeIp", this.NodeIp);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
        }
    }
}

