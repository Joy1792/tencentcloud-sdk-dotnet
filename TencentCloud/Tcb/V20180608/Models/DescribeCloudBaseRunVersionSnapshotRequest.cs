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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudBaseRunVersionSnapshotRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 版本名
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 版本历史名
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 偏移量。默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 限制大小。默认10，最大20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

