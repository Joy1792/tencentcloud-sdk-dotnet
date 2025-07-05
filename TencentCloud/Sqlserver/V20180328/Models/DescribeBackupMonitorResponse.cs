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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupMonitorResponse : AbstractModel
    {
        
        /// <summary>
        /// 备份趋势图时间轴
        /// </summary>
        [JsonProperty("TimeStamp")]
        public string[] TimeStamp{ get; set; }

        /// <summary>
        /// 免费备份空间
        /// </summary>
        [JsonProperty("FreeSpace")]
        public float?[] FreeSpace{ get; set; }

        /// <summary>
        /// 实际总备份空间
        /// </summary>
        [JsonProperty("ActualUsedSpace")]
        public float?[] ActualUsedSpace{ get; set; }

        /// <summary>
        /// 日志备份空间
        /// </summary>
        [JsonProperty("LogBackupSpace")]
        public float?[] LogBackupSpace{ get; set; }

        /// <summary>
        /// 数据备份空间
        /// </summary>
        [JsonProperty("DataBackupSpace")]
        public float?[] DataBackupSpace{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TimeStamp.", this.TimeStamp);
            this.SetParamArraySimple(map, prefix + "FreeSpace.", this.FreeSpace);
            this.SetParamArraySimple(map, prefix + "ActualUsedSpace.", this.ActualUsedSpace);
            this.SetParamArraySimple(map, prefix + "LogBackupSpace.", this.LogBackupSpace);
            this.SetParamArraySimple(map, prefix + "DataBackupSpace.", this.DataBackupSpace);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

