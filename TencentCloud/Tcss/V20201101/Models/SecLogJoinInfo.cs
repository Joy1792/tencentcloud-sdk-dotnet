/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class SecLogJoinInfo : AbstractModel
    {
        
        /// <summary>
        /// 已接入普通主机数量
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 已接入超级节点数量
        /// </summary>
        [JsonProperty("SuperNodeCount")]
        public ulong? SuperNodeCount{ get; set; }

        /// <summary>
        /// 是否已接入(true:已接入 false:未接入)
        /// </summary>
        [JsonProperty("IsJoined")]
        public bool? IsJoined{ get; set; }

        /// <summary>
        /// 日志类型(
        /// 容器bash:  "container_bash"
        /// 容器启动: "container_launch"
        /// k8sApi: "k8s_api"
        /// )
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 已接入集群数量
        /// </summary>
        [JsonProperty("ClusterCount")]
        public ulong? ClusterCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "SuperNodeCount", this.SuperNodeCount);
            this.SetParamSimple(map, prefix + "IsJoined", this.IsJoined);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "ClusterCount", this.ClusterCount);
        }
    }
}

